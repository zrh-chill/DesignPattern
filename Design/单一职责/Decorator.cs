using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// 组合优于继承--装饰模式
// 继承：静态特质
// 组合：动态特质

namespace Design.Decorator
{
    #region 基类
    /// <summary>
    /// 流
    /// </summary>
    abstract class Stream
    {
        public abstract char Read(int number);
        public abstract void Seek(int position);
        public abstract char Write(char data);
    }
    #endregion

    #region  业务实现
    /// <summary>
    /// 文件流
    /// </summary>
    class FileStream : Stream
    {
        public override char Read(int number)
        {
            return '0';
        }

        public override void Seek(int position)
        {
            
        }

        public override char Write(char data)
        {
            return '0';
        }
    }

    /// <summary>
    /// 网络流
    /// </summary>
    class NetWorkStream : Stream
    {
        public override char Read(int number)
        {
            return '0';
        }

        public override void Seek(int position)
        {

        }

        public override char Write(char data)
        {
            return '0';
        }
    }

    /// <summary>
    /// 内存流
    /// </summary>
    class MemoryStream : Stream
    {
        public override char Read(int number)
        {
            return '0';
        }

        public override void Seek(int position)
        {

        }

        public override char Write(char data)
        {
            return '0';
        }
    }
    #endregion

    #region 扩展操作-继承方式

    #region 加密操作
    /// <summary>
    /// 加密文件流
    /// </summary>
    class CryptoFileStream : FileStream
    {
        /// <summary>
        /// 加密
        /// </summary>
        void Crypto()
        {

        }

        public override char Read(int number)
        {
            Crypto();
            return base.Read(number); // 继承：静态特质
        }

        public override void Seek(int position)
        {
            Crypto();
            base.Seek(position);
        }

        public override char Write(char data)
        {
            Crypto();
            return base.Write(data);
        }
    }

    /// <summary>
    /// 加密网络流
    /// </summary>
    class CryptoNetWorkStream : FileStream
    {
        /// <summary>
        /// 加密
        /// </summary>
        void Crypto()
        {

        }

        public override char Read(int number)
        {
            Crypto();
            return base.Read(number);
        }

        public override void Seek(int position)
        {
            Crypto();
            base.Seek(position);
        }

        public override char Write(char data)
        {
            Crypto();
            return base.Write(data);
        }
    }

    /// <summary>
    /// 加密内存流
    /// </summary>
    class CryptoMemoryStream : FileStream
    {
        /// <summary>
        /// 加密
        /// </summary>
        void Crypto()
        {

        }

        public override char Read(int number)
        {
            Crypto();
            return base.Read(number);
        }

        public override void Seek(int position)
        {
            Crypto();
            base.Seek(position);
        }

        public override char Write(char data)
        {
            Crypto();
            return base.Write(data);
        }
    }
    #endregion

    #region 缓存操作
    /// <summary>
    /// 缓存文件流
    /// </summary>
    class BufferFileStream : FileStream
    {
        /// <summary>
        /// 缓存
        /// </summary>
        void Buffer()
        {

        }

        public override char Read(int number)
        {
            Buffer();
            return base.Read(number);
        }

        public override void Seek(int position)
        {
            Buffer();
            base.Seek(position);
        }

        public override char Write(char data)
        {
            Buffer();
            return base.Write(data);
        }
    }

    /// <summary>
    /// 缓存网络流
    /// </summary>
    class BufferNetWorkStream : FileStream
    {
        /// <summary>
        /// 缓存
        /// </summary>
        void Buffer()
        {

        }

        public override char Read(int number)
        {
            Buffer();
            return base.Read(number);
        }

        public override void Seek(int position)
        {
            Buffer();
            base.Seek(position);
        }

        public override char Write(char data)
        {
            Buffer();
            return base.Write(data);
        }
    }

    /// <summary>
    /// 缓存内存流
    /// </summary>
    class BufferMemoryStream : FileStream
    {
        /// <summary>
        /// 缓存
        /// </summary>
        void Buffer()
        {

        }

        public override char Read(int number)
        {
            Buffer();
            return base.Read(number);
        }

        public override void Seek(int position)
        {
            Buffer();
            base.Seek(position);
        }

        public override char Write(char data)
        {
            Buffer();
            return base.Write(data);
        }
    }
    #endregion

    #region 既加密又缓存操作
    /// <summary>
    /// 加密缓存文件流
    /// </summary>
    class CryptoBufferFileStream : FileStream
    {
        /// <summary>
        /// 加密
        /// </summary>
        void Crypto()
        {

        }

        /// <summary>
        /// 缓存
        /// </summary>
        void Buffer()
        {

        }

        public override char Read(int number)
        {
            Crypto();
            Buffer();
            return base.Read(number);
        }

        public override void Seek(int position)
        {
            Crypto();
            Buffer();
            base.Seek(position);
        }

        public override char Write(char data)
        {
            Crypto();
            Buffer();
            return base.Write(data);
        }
    }

    /// <summary>
    /// 加密缓存网络流
    /// </summary>
    class CryptoBufferNetWorkStream : FileStream
    {
        /// <summary>
        /// 加密
        /// </summary>
        void Crypto()
        {

        }

        /// <summary>
        /// 缓存
        /// </summary>
        void Buffer()
        {

        }

        public override char Read(int number)
        {
            Crypto();
            Buffer();
            return base.Read(number);
        }

        public override void Seek(int position)
        {
            Crypto();
            Buffer();
            base.Seek(position);
        }

        public override char Write(char data)
        {
            Crypto();
            Buffer();
            return base.Write(data);
        }
    }

    /// <summary>
    /// 加密缓存内存流
    /// </summary>
    class CryptoBufferMemoryStream : FileStream
    {
        /// <summary>
        /// 加密
        /// </summary>
        void Crypto()
        {

        }

        /// <summary>
        /// 缓存
        /// </summary>
        void Buffer()
        {

        }

        public override char Read(int number)
        {
            Crypto();
            Buffer();
            return base.Read(number);
        }

        public override void Seek(int position)
        {
            Crypto();
            Buffer();
            base.Seek(position);
        }

        public override char Write(char data)
        {
            Crypto();
            Buffer();
            return base.Write(data);
        }
    }

    #endregion

    #endregion

    #region 扩展操作-组合方式（装饰模式）

    #region 加密操作
    /// <summary>
    /// 加密流
    /// </summary>
    class CryptoStream : Stream
    {
        public CryptoStream(Stream stream)
        {
            _stream = stream;
        }

        private Stream _stream;

        /// <summary>
        /// 加密
        /// </summary>
        void Crypto()
        {

        }

        public override char Read(int number)
        {
            Crypto();
            return _stream.Read(number); // 组合：动态特质
        }

        public override void Seek(int position)
        {
            Crypto();
            _stream.Seek(position);
        }

        public override char Write(char data)
        {
            Crypto();
            return _stream.Write(data);
        }
    }
    #endregion

    #region 缓存操作
    /// <summary>
    /// 缓存流
    /// </summary>
    class BufferStream : Stream
    {
        public BufferStream(Stream stream)
        {
            _stream = stream;
        }

        private Stream _stream;

        /// <summary>
        /// 缓存
        /// </summary>
        void Buffer()
        {

        }

        public override char Read(int number)
        {
            Buffer();
            return _stream.Read(number);
        }

        public override void Seek(int position)
        {
            Buffer();
            _stream.Seek(position);
        }

        public override char Write(char data)
        {
            Buffer();
            return _stream.Write(data);
        }
    }
    #endregion

    class Test
    {
        public void Entrance()
        {
            // 文件流
            FileStream fileStream = new FileStream();
            //NetWorkStream netWorkStream = new NetWorkStream();
            //MemoryStream memorystream = new MemoryStream();

            // 加密文件流
            CryptoStream cryptoStream = new CryptoStream(fileStream); // 传netWorkStream变加密网络流

            // 缓存文件流
            BufferStream bufferStream = new BufferStream(fileStream); // 传memorystream变缓存内存流

            // 加密缓存流
            BufferStream cryptoBufferStream = new BufferStream(cryptoStream);

            // 缓存加密流
            CryptoStream bufferCryptoStream = new CryptoStream(bufferStream);
        }
    }

    #endregion
}
