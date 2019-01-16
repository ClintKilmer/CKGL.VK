using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace SharpVk
{
    /// <summary>
    /// 
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public struct ArrayProxy<T>
    {
        private T value;

        private ArraySegment<T> arrayValue;

        /// <summary>
        /// 
        /// </summary>
        public ProxyContents Contents
        {
            get;
            private set;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        public T this[int index]
        {
            get
            {
                if (index < 0 || index >= this.Length)
                {
                    throw new IndexOutOfRangeException();
                }
                else
                {
                    if(this.Contents == ProxyContents.Single)
                    {
                        return this.value;
                    }
                    else
                    {
                        return this.arrayValue.Array[this.arrayValue.Offset + index];
                    }
                }
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public int Length
        {
            get
            {
                // The underlying integer values for ProxyContents.Null & .Single
                // are 0 and 1 respectively and can be returned directly; otherwise
                // get the length of the array.
                int length = (int)this.Contents;

                if (length > 1)
                {
                    length = this.arrayValue.Count;
                }

                return length;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public T GetSingleValue()
        {
            return this.value;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public ArraySegment<T> GetArrayValue()
        {
            return this.arrayValue;
        }

        /// <summary>
        /// 
        /// </summary>
        public static ArrayProxy<T> Null
        {
            get
            {
                return new ArrayProxy<T>
                {
                    Contents = ProxyContents.Null
                };
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="value"></param>
        public static implicit operator ArrayProxy<T>(T[] value)
        {
            if (value == null)
            {
                return Null;
            }
            else if (value.Length == 1)
            {
                return new ArrayProxy<T>
                {
                    value = value[0],
                    Contents = ProxyContents.Single
                };
            }
            else
            {
                return new ArrayProxy<T>
                {
                    arrayValue = new ArraySegment<T>(value),
                    Contents = ProxyContents.Array
                };
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="value"></param>
        public static implicit operator ArrayProxy<T>(ArraySegment<T> value)
        {
            if (value.Count == 0)
            {
                return Null;
            }
            else if (value.Count == 1)
            {
                return new ArrayProxy<T>
                {
                    value = value.Array[0],
                    Contents = ProxyContents.Single
                };
            }
            else
            {
                return new ArrayProxy<T>
                {
                    arrayValue = value,
                    Contents = ProxyContents.Array
                };
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="value"></param>
        public static implicit operator ArrayProxy<T>(T value)
        {
            if (!typeof(T).GetTypeInfo().IsValueType && value.Equals(default(T)))
            {
                return Null;
            }
            else
            {
                return new ArrayProxy<T>
                {
                    value = value,
                    Contents = ProxyContents.Single
                };
            }
        }
    }

    /// <summary>
    /// 
    /// </summary>
    public enum ProxyContents
        : uint
    {
        /// <summary>
        /// 
        /// </summary>
        Null = 0,
        /// <summary>
        /// 
        /// </summary>
        Single = 1,
        /// <summary>
        /// 
        /// </summary>
        Array = 2
    }

    /// <summary>
    /// 
    /// </summary>
    public static class ArrayProxyExtensions
    {
        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="proxy"></param>
        /// <returns></returns>
        public static bool IsNull<T>(this ArrayProxy<T> proxy)
        {
            return proxy.Contents == ProxyContents.Null;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="proxy"></param>
        /// <returns></returns>
        public static bool IsNull<T>(this ArrayProxy<T>? proxy)
        {
            return proxy == null || proxy.Value.Contents == ProxyContents.Null;
        }
    }
}
