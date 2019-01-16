namespace SharpVk
{
    public partial struct Extent2D
    {
        /// <summary>
        /// 
        /// </summary>
        public float AspectRatio => (float)this.Width / (float)this.Height;
    }
}
