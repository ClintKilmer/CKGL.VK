using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using SharpVk;
using SharpVk.Khronos;
using SharpVk.Multivendor;
using static SDL2.SDL;
using Version = SharpVk.Version;
using CKGL;
using System.Runtime.CompilerServices;
using Buffer = SharpVk.Buffer;
using SharpVk.MoltenVk;

namespace VulkanTest
{
	public class Program
	{
		public static bool Running { get; private set; } = false;

		private static SDL_Event Event;

		private static IntPtr Window;
		private static uint WindowID;

		private Instance instance;
		private Surface surface;
		private PhysicalDevice physicalDevice;
		private Device device;
		private Queue graphicsQueue;
		private Queue presentQueue;
		private Queue transferQueue;

		private Swapchain swapChain;
		private Image[] swapChainImages;
		private ImageView[] swapChainImageViews;

		private RenderPass renderPass;
		private PipelineLayout pipelineLayout;
		private Pipeline pipeline;
		private ShaderModule fragShader;
		private ShaderModule vertShader;
		private Framebuffer[] frameBuffers;

		private CommandPool transientCommandPool;
		private CommandPool commandPool;
		private Buffer vertexBuffer;
		private DeviceMemory vertexBufferMemory;
		private Buffer indexBuffer;
		private DeviceMemory indexBufferMemory;
		private CommandBuffer[] commandBuffers;

		private Semaphore imageAvailableSemaphore;
		private Semaphore renderFinishedSemaphore;

		private Format swapChainFormat;
		private Extent2D swapChainExtent;

		private readonly Vertex[] vertices =
		{
			new Vertex(new Vector2(-1f, -1f), new Vector3(1.0f, 0.0f, 0.0f)),
			new Vertex(new Vector2(0.5f, -0.5f), new Vector3(0.0f, 1.0f, 0.0f)),
			new Vertex(new Vector2(1f, 1f), new Vector3(0.0f, 0.0f, 1.0f)),
			new Vertex(new Vector2(-0.5f, 0.5f), new Vector3(1.0f, 1.0f, 1.0f))
		};

		private readonly ushort[] indices = { 0, 1, 2, 2, 3, 0 };

		static void Main(string[] args)
		{
			new Program().Run();
		}

		public void Run()
		{
			// SDL Init
			if (SDL_Init(SDL_INIT_EVERYTHING) < 0)
			{
				Destroy();
				throw new Exception(SDL_GetError());
			}

			Running = true;

			// Create Window
			Window = SDL_CreateWindow(
				"Vukan Test",
				SDL_WINDOWPOS_CENTERED, SDL_WINDOWPOS_CENTERED, 1600, 900,
				SDL_WindowFlags.SDL_WINDOW_SHOWN |
				SDL_WindowFlags.SDL_WINDOW_VULKAN |
				SDL_WindowFlags.SDL_WINDOW_ALLOW_HIGHDPI |
				SDL_WindowFlags.SDL_WINDOW_RESIZABLE
			);
			WindowID = SDL_GetWindowID(Window);

			Version version = Instance.EnumerateVersion();
			Output.WriteLine($"Vulkan - Version: {version.Major}.{version.Minor}.{version.Patch}"); // Debug

			InitialiseVulkan();

			while (Running)
			{
				PollEvents();

				DrawFrame();
			}

			TearDown();
		}

		private void InitialiseVulkan()
		{
			CreateInstance();
			CreateSurface();
			PickPhysicalDevice();
			CreateLogicalDevice();
			CreateSwapChain();
			CreateImageViews();
			CreateRenderPass();
			CreateShaderModules();
			CreateGraphicsPipeline();
			CreateFrameBuffers();
			CreateCommandPools();
			CreateVertexBuffers();
			CreateIndexBuffer();
			CreateCommandBuffers();
			CreateSemaphores();
		}

		private void RecreateSwapChain()
		{
			device.WaitIdle();

			commandPool.FreeCommandBuffers(commandBuffers);

			foreach (var frameBuffer in frameBuffers)
			{
				frameBuffer.Dispose();
			}
			frameBuffers = null;

			pipeline.Dispose();
			pipeline = null;

			pipelineLayout.Dispose();
			pipelineLayout = null;

			foreach (var imageView in swapChainImageViews)
			{
				imageView.Dispose();
			}
			swapChainImageViews = null;

			renderPass.Dispose();
			renderPass = null;

			swapChain.Dispose();
			swapChain = null;

			CreateSwapChain();
			CreateImageViews();
			CreateRenderPass();
			CreateGraphicsPipeline();
			CreateFrameBuffers();
			CreateCommandBuffers();
		}

		private void TearDown()
		{
			device.WaitIdle();

			renderFinishedSemaphore.Dispose();
			renderFinishedSemaphore = null;

			imageAvailableSemaphore.Dispose();
			imageAvailableSemaphore = null;

			vertexBufferMemory.Free();
			vertexBufferMemory = null;

			vertexBuffer.Dispose();
			vertexBuffer = null;

			commandPool.Dispose();
			commandPool = null;

			foreach (var frameBuffer in frameBuffers)
			{
				frameBuffer.Dispose();
			}
			frameBuffers = null;

			fragShader.Dispose();
			fragShader = null;

			vertShader.Dispose();
			vertShader = null;

			pipeline.Dispose();
			pipeline = null;

			pipelineLayout.Dispose();
			pipelineLayout = null;

			foreach (var imageView in swapChainImageViews)
			{
				imageView.Dispose();
			}
			swapChainImageViews = null;

			renderPass.Dispose();
			renderPass = null;

			swapChain.Dispose();
			swapChain = null;

			device.Dispose();
			device = null;

			surface.Dispose();
			surface = null;

			instance.Dispose();
			instance = null;
		}

		private void DrawFrame()
		{
			uint nextImage = swapChain.AcquireNextImage(uint.MaxValue, imageAvailableSemaphore, null);

			graphicsQueue.Submit(
				new SubmitInfo
				{
					CommandBuffers = new[] { commandBuffers[nextImage] },
					SignalSemaphores = new[] { renderFinishedSemaphore },
					WaitDestinationStageMask = new[] { PipelineStageFlags.ColorAttachmentOutput },
					WaitSemaphores = new[] { imageAvailableSemaphore }
				},
				null
			);

			presentQueue.Present(renderFinishedSemaphore, swapChain, nextImage, new Result[1]);
		}

		private void CreateInstance()
		{
			var enabledLayers = new List<string>();

			//VK_LAYER_LUNARG_api_dump
			//VK_LAYER_LUNARG_standard_validation

			void AddAvailableLayer(string layerName)
			{
				if (Instance.EnumerateLayerProperties().Any(x => x.LayerName == layerName))
				{
					enabledLayers.Add(layerName);
					Output.WriteLine($"Added Validation Layer: {layerName}"); // Debug
				}
				else
				{
					Output.WriteLine($"Failed to add Validation Layer: {layerName}"); // Debug
				}
			}

			//AddAvailableLayer("VK_LAYER_LUNARG_api_dump");
			//AddAvailableLayer("VK_LAYER_LUNARG_standard_validation");

			var enabledExtentions = new List<string>();
			enabledExtentions.Add(KhrExtensions.Surface);
			if (SDL_GetPlatform() == "Windows")
			{
				enabledExtentions.Add(KhrExtensions.Win32Surface);
			}
			else if (SDL_GetPlatform() == "Linux")
			{
				enabledExtentions.Add(KhrExtensions.XlibSurface);
				//enabledExtentions.Add(KhrExtensions.WaylandSurface);
			}
			else if (SDL_GetPlatform() == "Android")
			{
				enabledExtentions.Add(KhrExtensions.AndroidSurface);
			}
			else if (SDL_GetPlatform() == "Mac OS X")
			{
				enabledExtentions.Add(MvkExtensions.MacosSurface);
			}
			else if (SDL_GetPlatform() == "iOS")
			{
				enabledExtentions.Add(MvkExtensions.IosSurface);
			}
			enabledExtentions.Add(ExtExtensions.DebugReport);

			instance = Instance.Create(
				enabledLayers.ToArray(),
				enabledExtentions.ToArray(),
				applicationInfo: new ApplicationInfo
				{
					ApplicationName = "VulkanTest",
					ApplicationVersion = new Version(1, 0, 0),
					EngineName = "VulkanTest",
					EngineVersion = new Version(1, 0, 0),
					ApiVersion = new Version(1, 0, 0)
				}
			);

			instance.CreateDebugReportCallback(DebugReportDelegate, DebugReportFlags.Error | DebugReportFlags.Warning);
		}

		private static readonly DebugReportCallbackDelegate DebugReportDelegate = DebugReport;

		private static Bool32 DebugReport(DebugReportFlags flags, DebugReportObjectType objectType, ulong @object, HostSize location, int messageCode, string layerPrefix, string message, IntPtr userData)
		{
			Output.WriteLine(message);

			return false;
		}

		private unsafe void CreateSurface()
		{
			if (SDL_Vulkan_CreateSurface(Window, (IntPtr)instance.handle.handle.ToPointer(), out IntPtr surfaceIntPtr) != SDL_bool.SDL_TRUE)
				throw new Exception($"Error creating Vulkan surface: {SDL_GetError()}");

			surface = Surface.CreateFromHandle(instance, (ulong)surfaceIntPtr);

			//SDL_SysWMinfo info = new SDL_SysWMinfo();
			//SDL_GetWindowWMInfo(Window, ref info);

			//if (SDL_GetPlatform() == "Windows")
			//{
			//	surface = instance.CreateWin32Surface(Window, info.info.win.window);
			//}
			//else if (SDL_GetPlatform() == "Linux")
			//{
			//	//surface = instance.CreateXlibSurface(info.info.x11.display, info.info.x11.window);
			//	surface = instance.CreateWaylandSurface(info.info.wl.display, info.info.wl.surface);
			//}
			//else if (SDL_GetPlatform() == "Android")
			//{
			//}
			//else if (SDL_GetPlatform() == "Mac OS X")
			//{
			//}
			//else if (SDL_GetPlatform() == "iOS")
			//{
			//}
		}

		private void PickPhysicalDevice()
		{
			var availableDevices = instance.EnumeratePhysicalDevices();

			Output.WriteLine("Vulkan - Physical Devices:");
			foreach (var device in availableDevices)
			{
				Output.WriteLine($"    {device.GetProperties().DeviceID} - {device.GetProperties().DeviceName}, Vk v{device.GetProperties().ApiVersion}, Driver v{device.GetProperties().DriverVersion}, Vendor {device.GetProperties().VendorID}, {device.GetProperties().DeviceType}");
			}

			physicalDevice = availableDevices.First(IsSuitableDevice);
			Output.WriteLine($"Vulkan - Selected Physical Device: {physicalDevice.GetProperties().DeviceID} - {physicalDevice.GetProperties().DeviceName}");
		}

		private void CreateLogicalDevice()
		{
			QueueFamilyIndices queueFamilies = FindQueueFamilies(physicalDevice);

			device = physicalDevice.CreateDevice(
				queueFamilies.Indices.Select(index => new DeviceQueueCreateInfo
				{
					QueueFamilyIndex = index,
					QueuePriorities = new[] { 1f }
				}).ToArray(),
				null,
				KhrExtensions.Swapchain
			);

			graphicsQueue = device.GetQueue(queueFamilies.GraphicsFamily.Value, 0);
			presentQueue = device.GetQueue(queueFamilies.PresentFamily.Value, 0);
			transferQueue = device.GetQueue(queueFamilies.TransferFamily.Value, 0);
		}

		private void CreateSwapChain()
		{
			SwapChainSupportDetails swapChainSupport = QuerySwapChainSupport(physicalDevice);

			uint imageCount = swapChainSupport.Capabilities.MinImageCount + 1;
			if (swapChainSupport.Capabilities.MaxImageCount > 0 && imageCount > swapChainSupport.Capabilities.MaxImageCount)
			{
				imageCount = swapChainSupport.Capabilities.MaxImageCount;
			}

			SurfaceFormat surfaceFormat = ChooseSwapSurfaceFormat(swapChainSupport.Formats);

			QueueFamilyIndices queueFamilies = FindQueueFamilies(physicalDevice);

			var indices = queueFamilies.Indices.ToArray();

			Extent2D extent = ChooseSwapExtent(swapChainSupport.Capabilities);

			swapChain = device.CreateSwapchain(
				surface,
				imageCount,
				surfaceFormat.Format,
				surfaceFormat.ColorSpace,
				extent,
				1,
				ImageUsageFlags.ColorAttachment | ImageUsageFlags.TransferSource,
				indices.Length == 1 ? SharingMode.Exclusive : SharingMode.Concurrent,
				indices,
				swapChainSupport.Capabilities.CurrentTransform,
				CompositeAlphaFlags.Opaque,
				ChooseSwapPresentMode(swapChainSupport.PresentModes),
				true,
				swapChain
			);

			swapChainImages = swapChain.GetImages();
			swapChainFormat = surfaceFormat.Format;
			swapChainExtent = extent;
		}

		private void CreateImageViews()
		{
			swapChainImageViews = swapChainImages.Select(image => device.CreateImageView(
				image,
				ImageViewType.ImageView2d,
				swapChainFormat,
				ComponentMapping.Identity,
				new ImageSubresourceRange
				{
					AspectMask = ImageAspectFlags.Color,
					BaseMipLevel = 0,
					LevelCount = 1,
					BaseArrayLayer = 0,
					LayerCount = 1
				}
			)).ToArray();
		}

		private void CreateRenderPass()
		{
			renderPass = device.CreateRenderPass(
				new AttachmentDescription
				{
					Format = swapChainFormat,
					Samples = SampleCountFlags.SampleCount1,
					LoadOp = AttachmentLoadOp.Clear,
					StoreOp = AttachmentStoreOp.Store,
					StencilLoadOp = AttachmentLoadOp.DontCare,
					StencilStoreOp = AttachmentStoreOp.DontCare,
					InitialLayout = ImageLayout.Undefined,
					FinalLayout = ImageLayout.PresentSource
				},
				new SubpassDescription
				{
					DepthStencilAttachment = new AttachmentReference(Constants.AttachmentUnused, ImageLayout.Undefined),
					PipelineBindPoint = PipelineBindPoint.Graphics,
					ColorAttachments = new[]
					{
						new AttachmentReference(0, ImageLayout.ColorAttachmentOptimal)
					}
				},
				new[]
				{
					new SubpassDependency
					{
						SourceSubpass = Constants.SubpassExternal,
						DestinationSubpass = 0,
						SourceStageMask = PipelineStageFlags.BottomOfPipe,
						SourceAccessMask = AccessFlags.MemoryRead,
						DestinationStageMask = PipelineStageFlags.ColorAttachmentOutput,
						DestinationAccessMask = AccessFlags.ColorAttachmentRead | AccessFlags.ColorAttachmentWrite
					},
					new SubpassDependency
					{
						SourceSubpass = 0,
						DestinationSubpass = Constants.SubpassExternal,
						SourceStageMask = PipelineStageFlags.ColorAttachmentOutput,
						SourceAccessMask = AccessFlags.ColorAttachmentRead | AccessFlags.ColorAttachmentWrite,
						DestinationStageMask = PipelineStageFlags.BottomOfPipe,
						DestinationAccessMask = AccessFlags.MemoryRead
					}
				}
			);
		}

		private void CreateShaderModules()
		{
			// Shanq

			//vertShader = ShanqShader.CreateVertexModule(
			//	device,
			//	VectorTypeLibrary.Instance,
			//	shanq => from input in shanq.GetInput<Vertex>()
			//			 select new VertexOutput
			//			 {
			//				 Colour = input.Colour,
			//				 Position = new Vector4(input.Position, 0, 1)
			//			 }
			//);

			//fragShader = ShanqShader.CreateFragmentModule(
			//	device,
			//	VectorTypeLibrary.Instance,
			//	shanq => from input in shanq.GetInput<FragmentInput>()
			//			 select new FragmentOutput
			//			 {
			//				 Colour = new Vector4(input.Colour, 1)
			//			 }
			//);

			ShaderModule CreateShader(string path)
			{
				var shaderData = LoadShaderData(path, out int codeSize);

				return device.CreateShaderModule(codeSize, shaderData);
			}

			uint[] LoadShaderData(string filePath, out int codeSize)
			{
				var fileBytes = File.ReadAllBytes(filePath);
				var shaderData = new uint[(int)System.Math.Ceiling(fileBytes.Length / 4f)];

				System.Buffer.BlockCopy(fileBytes, 0, shaderData, 0, fileBytes.Length);

				codeSize = fileBytes.Length;

				return shaderData;
			}

			vertShader = CreateShader(@".\Shaders\shader.vert.spv");

			fragShader = CreateShader(@".\Shaders\shader.frag.spv");
		}

		//private void CreateGraphicsPipeline()
		//{
		//	var bindingDescription = Vertex.GetBindingDescription();
		//	var attributeDescriptions = Vertex.GetAttributeDescriptions();

		//	pipelineLayout = device.CreatePipelineLayout(null, null);

		//	pipeline = device.CreateGraphicsPipeline(
		//		null,
		//		new[]
		//		{
		//			new PipelineShaderStageCreateInfo
		//			{
		//				Stage = ShaderStageFlags.Vertex,
		//				Module = vertShader,
		//				Name = "main"
		//			},
		//			new PipelineShaderStageCreateInfo
		//			{
		//				Stage = ShaderStageFlags.Fragment,
		//				Module = fragShader,
		//				Name = "main"
		//			}
		//		},
		//		new PipelineRasterizationStateCreateInfo
		//		{
		//			DepthClampEnable = false,
		//			RasterizerDiscardEnable = false,
		//			PolygonMode = PolygonMode.Fill,
		//			LineWidth = 1,
		//			CullMode = CullModeFlags.Back,
		//			FrontFace = FrontFace.Clockwise,
		//			DepthBiasEnable = false
		//		},
		//		pipelineLayout,
		//		renderPass,
		//		0,
		//		null,
		//		-1,
		//		vertexInputState: new PipelineVertexInputStateCreateInfo(),
		//		inputAssemblyState: new PipelineInputAssemblyStateCreateInfo
		//		{
		//			PrimitiveRestartEnable = false,
		//			Topology = PrimitiveTopology.TriangleList
		//		},
		//		viewportState: new PipelineViewportStateCreateInfo
		//		{
		//			Viewports = new[]
		//			{
		//				new Viewport(0f, 0f, swapChainExtent.Width, swapChainExtent.Height, 0, 1)
		//			},
		//			Scissors = new[]
		//			{
		//				new Rect2D(swapChainExtent)
		//			}
		//		},
		//		colorBlendState: new PipelineColorBlendStateCreateInfo
		//		{
		//			Attachments = new[]
		//			{
		//				new PipelineColorBlendAttachmentState
		//				{
		//					ColorWriteMask = ColorComponentFlags.R | ColorComponentFlags.G | ColorComponentFlags.B | ColorComponentFlags.A,
		//					BlendEnable = false
		//				}
		//			},
		//			LogicOpEnable = false
		//		},
		//		multisampleState: new PipelineMultisampleStateCreateInfo
		//		{
		//			SampleShadingEnable = false,
		//			RasterizationSamples = SampleCountFlags.SampleCount1,
		//			MinSampleShading = 1
		//		}
		//	);
		//}

		private void CreateGraphicsPipeline()
		{
			var bindingDescription = Vertex.GetBindingDescription();
			var attributeDescriptions = Vertex.GetAttributeDescriptions();

			pipelineLayout = device.CreatePipelineLayout(null, null);

			pipeline = device.CreateGraphicsPipelines(
				null,
				new[]
				{
					new GraphicsPipelineCreateInfo
					{
						Layout = pipelineLayout,
						RenderPass = renderPass,
						Subpass = 0,
						VertexInputState = new PipelineVertexInputStateCreateInfo()
						{
							VertexBindingDescriptions = new [] { bindingDescription },
							VertexAttributeDescriptions = attributeDescriptions
						},
						InputAssemblyState = new PipelineInputAssemblyStateCreateInfo
						{
							PrimitiveRestartEnable = false,
							Topology = PrimitiveTopology.TriangleList
						},
						ViewportState = new PipelineViewportStateCreateInfo
						{
							Viewports = new[]
							{
								new Viewport(0f, 0f, swapChainExtent.Width, swapChainExtent.Height, 0f, 1f)
							},
							Scissors = new[]
							{
								new Rect2D(new Offset2D(), swapChainExtent)
							}
						},
						RasterizationState = new PipelineRasterizationStateCreateInfo
						{
							DepthClampEnable = false,
							RasterizerDiscardEnable = false,
							PolygonMode = PolygonMode.Fill,
							LineWidth = 1,
							CullMode = CullModeFlags.Back,
							FrontFace = FrontFace.Clockwise,
							DepthBiasEnable = false
						},
						MultisampleState = new PipelineMultisampleStateCreateInfo
						{
							SampleShadingEnable = false,
							RasterizationSamples = SampleCountFlags.SampleCount1,
							MinSampleShading = 1
						},
						ColorBlendState = new PipelineColorBlendStateCreateInfo
						{
							Attachments = new[]
							{
								new PipelineColorBlendAttachmentState
								{
									ColorWriteMask = ColorComponentFlags.R
														| ColorComponentFlags.G
														| ColorComponentFlags.B
														| ColorComponentFlags.A,
									BlendEnable = false,
									SourceColorBlendFactor = BlendFactor.One,
									DestinationColorBlendFactor = BlendFactor.Zero,
									ColorBlendOp = BlendOp.Add,
									SourceAlphaBlendFactor = BlendFactor.One,
									DestinationAlphaBlendFactor = BlendFactor.Zero,
									AlphaBlendOp = BlendOp.Add
								}
							},
							LogicOpEnable = false,
							LogicOp = LogicOp.Copy,
							BlendConstants = ( 0, 0, 0, 0 )
						},
						Stages = new[]
						{
							new PipelineShaderStageCreateInfo
							{
								Stage = ShaderStageFlags.Vertex,
								Module = vertShader,
								Name = "main"
							},
							new PipelineShaderStageCreateInfo
							{
								Stage = ShaderStageFlags.Fragment,
								Module = fragShader,
								Name = "main"
							}
						}
					}
				}
			).Single();
		}

		private void CreateFrameBuffers()
		{
			Framebuffer Create(ImageView imageView) => device.CreateFramebuffer(
				renderPass,
				imageView,
				swapChainExtent.Width,
				swapChainExtent.Height,
				1
			);

			frameBuffers = swapChainImageViews.Select(Create).ToArray();
		}

		private void CreateCommandPools()
		{
			QueueFamilyIndices queueFamilies = FindQueueFamilies(physicalDevice);

			transientCommandPool = device.CreateCommandPool(queueFamilies.TransferFamily.Value, CommandPoolCreateFlags.Transient);

			commandPool = device.CreateCommandPool(queueFamilies.GraphicsFamily.Value);
		}

		private void CreateVertexBuffers()
		{
			int vertexSize = Unsafe.SizeOf<Vertex>();

			uint bufferSize = (uint)(vertexSize * vertices.Length);

			CreateBuffer(bufferSize, BufferUsageFlags.TransferSource, MemoryPropertyFlags.HostVisible | MemoryPropertyFlags.HostCoherent, out var stagingBuffer, out var stagingBufferMemory);

			IntPtr memoryBuffer = stagingBufferMemory.Map(0, bufferSize, MemoryMapFlags.None);

			for (int index = 0; index < vertices.Length; index++)
			{
				Marshal.StructureToPtr(vertices[index], memoryBuffer + (vertexSize * index), false);
			}

			stagingBufferMemory.Unmap();

			CreateBuffer(bufferSize, BufferUsageFlags.TransferDestination | BufferUsageFlags.VertexBuffer, MemoryPropertyFlags.DeviceLocal, out vertexBuffer, out vertexBufferMemory);

			CopyBuffer(stagingBuffer, vertexBuffer, bufferSize);

			stagingBuffer.Dispose();
			stagingBufferMemory.Free();
		}

		private void CreateIndexBuffer()
		{
			int indexSize = Unsafe.SizeOf<ushort>();

			ulong bufferSize = (uint)(indexSize * indices.Length);

			CreateBuffer(bufferSize, BufferUsageFlags.TransferSource, MemoryPropertyFlags.HostVisible | MemoryPropertyFlags.HostCoherent, out var stagingBuffer, out var stagingBufferMemory);

			IntPtr memoryBuffer = stagingBufferMemory.Map(0, bufferSize, MemoryMapFlags.None);

			for (int index = 0; index < indices.Length; index++)
			{
				Marshal.StructureToPtr(indices[index], memoryBuffer + (indexSize * index), false);
			}

			stagingBufferMemory.Unmap();

			CreateBuffer(bufferSize, BufferUsageFlags.TransferDestination | BufferUsageFlags.IndexBuffer, MemoryPropertyFlags.DeviceLocal, out indexBuffer, out indexBufferMemory);

			CopyBuffer(stagingBuffer, indexBuffer, bufferSize);

			stagingBuffer.Dispose();
			stagingBufferMemory.Free();
		}

		private void CreateCommandBuffers()
		{
			commandBuffers = device.AllocateCommandBuffers(commandPool, CommandBufferLevel.Primary, (uint)frameBuffers.Length);

			for (int index = 0; index < frameBuffers.Length; index++)
			{
				var commandBuffer = commandBuffers[index];

				commandBuffer.Begin(CommandBufferUsageFlags.SimultaneousUse);

				commandBuffer.BeginRenderPass(
					renderPass,
					frameBuffers[index],
					new Rect2D(swapChainExtent),
					new ClearValue(),
					SubpassContents.Inline
				);

				commandBuffer.BindPipeline(PipelineBindPoint.Graphics, pipeline);

				commandBuffer.BindVertexBuffers(0, vertexBuffer, (DeviceSize)0);

				commandBuffer.BindIndexBuffer(indexBuffer, 0, IndexType.Uint16);

				commandBuffer.DrawIndexed((uint)indices.Length, 1, 0, 0, 0);

				commandBuffer.EndRenderPass();

				commandBuffer.End();
			}
		}

		private void CreateSemaphores()
		{
			imageAvailableSemaphore = device.CreateSemaphore();
			renderFinishedSemaphore = device.CreateSemaphore();
		}

		private uint FindMemoryType(uint typeFilter, MemoryPropertyFlags flags)
		{
			var memoryProperties = physicalDevice.GetMemoryProperties();

			for (int i = 0; i < memoryProperties.MemoryTypes.Length; i++)
			{
				if ((typeFilter & (1u << i)) > 0
						&& memoryProperties.MemoryTypes[i].PropertyFlags.HasFlag(flags))
				{
					return (uint)i;
				}
			}

			throw new Exception("No compatible memory type.");
		}

		private SurfaceFormat ChooseSwapSurfaceFormat(SurfaceFormat[] availableFormats)
		{
			if (availableFormats.Length == 1 && availableFormats[0].Format == Format.Undefined)
			{
				return new SurfaceFormat
				{
					Format = Format.B8G8R8A8UNorm,
					ColorSpace = ColorSpace.SrgbNonlinear
				};
			}

			foreach (var format in availableFormats)
			{
				if (format.Format == Format.B8G8R8A8UNorm && format.ColorSpace == ColorSpace.SrgbNonlinear)
				{
					return format;
				}
			}

			return availableFormats[0];
		}

		private PresentMode ChooseSwapPresentMode(PresentMode[] availablePresentModes)
		{
			return availablePresentModes.Contains(PresentMode.Mailbox)
					? PresentMode.Mailbox
					: PresentMode.Fifo;
		}

		public Extent2D ChooseSwapExtent(SurfaceCapabilities capabilities)
		{
			if (capabilities.CurrentExtent.Width != uint.MaxValue)
			{
				return capabilities.CurrentExtent;
			}
			else
			{
				SDL_GetWindowSize(Window, out int width, out int height);
				return new Extent2D
				{
					Width = System.Math.Max(capabilities.MinImageExtent.Width, System.Math.Min(capabilities.MaxImageExtent.Width, (uint)width)),
					Height = System.Math.Max(capabilities.MinImageExtent.Height, System.Math.Min(capabilities.MaxImageExtent.Height, (uint)height))
				};
			}
		}

		SwapChainSupportDetails QuerySwapChainSupport(PhysicalDevice device)
		{
			return new SwapChainSupportDetails
			{
				Capabilities = device.GetSurfaceCapabilities(surface),
				Formats = device.GetSurfaceFormats(surface),
				PresentModes = device.GetSurfacePresentModes(surface)
			};
		}

		private bool IsSuitableDevice(PhysicalDevice device)
		{
			return device.EnumerateDeviceExtensionProperties(null).Any(extension => extension.ExtensionName == KhrExtensions.Swapchain)
					&& FindQueueFamilies(device).IsComplete;
		}

		private void CreateBuffer(ulong size, BufferUsageFlags usage, MemoryPropertyFlags properties, out Buffer buffer, out DeviceMemory bufferMemory)
		{
			buffer = device.CreateBuffer(size, usage, SharingMode.Exclusive, null);

			var memRequirements = buffer.GetMemoryRequirements();

			bufferMemory = device.AllocateMemory(memRequirements.Size, FindMemoryType(memRequirements.MemoryTypeBits, properties));

			buffer.BindMemory(bufferMemory, 0);
		}

		private void CopyBuffer(Buffer sourceBuffer, Buffer destinationBuffer, ulong size)
		{
			var transferBuffers = device.AllocateCommandBuffers(transientCommandPool, CommandBufferLevel.Primary, 1);

			transferBuffers[0].Begin(CommandBufferUsageFlags.OneTimeSubmit);

			transferBuffers[0].CopyBuffer(sourceBuffer, destinationBuffer, new BufferCopy { Size = size });

			transferBuffers[0].End();

			transferQueue.Submit(new SubmitInfo { CommandBuffers = transferBuffers }, null);
			transferQueue.WaitIdle();

			transientCommandPool.FreeCommandBuffers(transferBuffers);
		}

		private QueueFamilyIndices FindQueueFamilies(PhysicalDevice device)
		{
			QueueFamilyIndices indices = new QueueFamilyIndices();

			var queueFamilies = device.GetQueueFamilyProperties();

			for (uint index = 0; index < queueFamilies.Length && !indices.IsComplete; index++)
			{
				if (queueFamilies[index].QueueFlags.HasFlag(QueueFlags.Graphics))
				{
					indices.GraphicsFamily = index;
				}

				if (device.GetSurfaceSupport(index, surface))
				{
					indices.PresentFamily = index;
				}

				if (queueFamilies[index].QueueFlags.HasFlag(QueueFlags.Transfer) && !queueFamilies[index].QueueFlags.HasFlag(QueueFlags.Graphics))
				{
					indices.TransferFamily = index;
				}
			}

			if (!indices.TransferFamily.HasValue)
			{
				indices.TransferFamily = indices.GraphicsFamily;
			}

			return indices;
		}

		private struct QueueFamilyIndices
		{
			public uint? GraphicsFamily;
			public uint? PresentFamily;
			public uint? TransferFamily;

			public IEnumerable<uint> Indices
			{
				get
				{
					if (GraphicsFamily.HasValue)
					{
						yield return GraphicsFamily.Value;
					}

					if (PresentFamily.HasValue && PresentFamily != GraphicsFamily)
					{
						yield return PresentFamily.Value;
					}

					if (TransferFamily.HasValue && TransferFamily != PresentFamily && TransferFamily != GraphicsFamily)
					{
						yield return TransferFamily.Value;
					}
				}
			}

			public bool IsComplete { get => GraphicsFamily.HasValue && PresentFamily.HasValue && TransferFamily.HasValue; }
		}

		private struct SwapChainSupportDetails
		{
			public SurfaceCapabilities Capabilities;
			public SurfaceFormat[] Formats;
			public PresentMode[] PresentModes;
		}

		private struct Vertex
		{
			public Vertex(Vector2 position, Vector3 colour)
			{
				Position = position;
				Colour = colour;
			}

			//[Location(0)]
			public Vector2 Position;

			//[Location(1)]
			public Vector3 Colour;

			public static VertexInputBindingDescription GetBindingDescription()
			{
				return new VertexInputBindingDescription()
				{
					Binding = 0,
					Stride = (uint)Marshal.SizeOf<Vertex>(),
					InputRate = VertexInputRate.Vertex
				};
			}

			public static VertexInputAttributeDescription[] GetAttributeDescriptions()
			{
				return new VertexInputAttributeDescription[]
				{
					new VertexInputAttributeDescription
					{
						Binding = 0,
						Location = 0,
						Format = Format.R32G32SFloat,
						Offset = (uint)Marshal.OffsetOf<Vertex>("Position")
					},
					new VertexInputAttributeDescription
					{
						Binding = 0,
						Location = 1,
						Format = Format.R32G32B32SFloat,
						Offset = (uint)Marshal.OffsetOf<Vertex>("Colour")
					}
				};
			}
		}

		public void Destroy()
		{
			SDL_Quit();
		}

		public void PollEvents()
		{
			while (SDL_PollEvent(out Event) != 0)
			{
				//Output.WriteLine(Event.type.ToString());
				switch (Event.type)
				{
					case SDL_EventType.SDL_QUIT:
						Quit();
						break;
					case SDL_EventType.SDL_KEYDOWN:
						if (Event.key.keysym.sym == SDL_Keycode.SDLK_BACKSPACE)
							Quit();
						break;
					case SDL_EventType.SDL_KEYUP:
						break;
					case SDL_EventType.SDL_MOUSEMOTION:
						break;
					case SDL_EventType.SDL_MOUSEBUTTONDOWN:
						break;
					case SDL_EventType.SDL_MOUSEBUTTONUP:
						break;
					case SDL_EventType.SDL_MOUSEWHEEL:
						break;
					case SDL_EventType.SDL_CONTROLLERDEVICEADDED:
						break;
					case SDL_EventType.SDL_CONTROLLERDEVICEREMOVED:
						break;
					case SDL_EventType.SDL_CONTROLLERDEVICEREMAPPED:
						break;
					case SDL_EventType.SDL_CONTROLLERBUTTONDOWN:
						break;
					case SDL_EventType.SDL_CONTROLLERBUTTONUP:
						break;
					case SDL_EventType.SDL_CONTROLLERAXISMOTION:
						break;
					case SDL_EventType.SDL_WINDOWEVENT:
						if (Event.window.windowID == WindowID)
						{
							//Output.WriteLine(Event.window.windowEvent.ToString()); // Debug
							switch (Event.window.windowEvent)
							{
								case SDL_WindowEventID.SDL_WINDOWEVENT_CLOSE:
									Quit();
									break;
								case SDL_WindowEventID.SDL_WINDOWEVENT_SHOWN:
									//Events.OnWinShown?.Invoke();
									break;
								case SDL_WindowEventID.SDL_WINDOWEVENT_HIDDEN:
									//Events.OnWinHidden?.Invoke();
									break;
								case SDL_WindowEventID.SDL_WINDOWEVENT_EXPOSED:
									//Events.OnWinExposed?.Invoke();
									break;
								case SDL_WindowEventID.SDL_WINDOWEVENT_MOVED:
									//Events.OnWinMoved?.Invoke();
									break;
								case SDL_WindowEventID.SDL_WINDOWEVENT_RESIZED:
									//Events.OnWinResized?.Invoke();
									RecreateSwapChain();
									break;
								case SDL_WindowEventID.SDL_WINDOWEVENT_MINIMIZED:
									//Events.OnWinMinimized?.Invoke();
									break;
								case SDL_WindowEventID.SDL_WINDOWEVENT_MAXIMIZED:
									//Events.OnWinMaximized?.Invoke();
									break;
								case SDL_WindowEventID.SDL_WINDOWEVENT_RESTORED:
									//Events.OnWinRestored?.Invoke();
									break;
								case SDL_WindowEventID.SDL_WINDOWEVENT_ENTER:
									//Events.OnWinEnter?.Invoke();
									break;
								case SDL_WindowEventID.SDL_WINDOWEVENT_LEAVE:
									//Events.OnWinLeave?.Invoke();
									break;
								case SDL_WindowEventID.SDL_WINDOWEVENT_FOCUS_GAINED:
									//Events.OnWinFocusGained?.Invoke();
									break;
								case SDL_WindowEventID.SDL_WINDOWEVENT_FOCUS_LOST:
									//Events.OnWinFocusLost?.Invoke();
									break;
								default:
									//Events.OnWinOtherEvent?.Invoke((int)Event.window.windowEvent);
									break;
							}
						}
						break;
				}
			}
		}

		public void Quit()
		{
			Running = false;
		}
	}
}