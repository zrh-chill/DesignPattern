using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//组合优于继承、多个维度的变化--桥模式

namespace Design.Bridge.Sample
{
    abstract class Messager
    {
        public abstract void Login(string username, string password);
        public abstract void SendMessage(string message);
        public abstract void SendPicture(string message);

        public abstract void PlaySound();
        public abstract void DrawShape();
        public abstract void WriteText();
        public abstract void Connect();
    }

    #region 平台实现

    abstract class PCMessagerBase : Messager
    {
        public override void PlaySound()
        {
            //*************
        }

        public override void DrawShape()
        {
            //*************
        }

        public override void WriteText()
        {
            //*************
        }

        public override void Connect()
        {
            //*************
        }
    }

    abstract class MobileMessagerBase : Messager
    {
        public override void PlaySound()
        {
            //==============
        }

        public override void DrawShape()
        {
            //==============
        }

        public override void WriteText()
        {
            //==============
        }

        public override void Connect()
        {
            //==============
        }
    }

    #endregion

    #region 业务抽象

    class PCMessagerLite : PCMessagerBase
    {
        public override void Login(string username, string password)
        {
            base.Connect();
            //.......
        }

        public override void SendMessage(string message)
        {
            base.WriteText();
            //.......
        }

        public override void SendPicture(string message)
        {
            base.DrawShape();
            //.......
        }
    }

    class PCMessagerPerfect : PCMessagerBase
    {
        public override void Login(string username, string password)
        {
            base.Connect();
            //.......
            base.PlaySound();
            //*******
        }

        public override void SendMessage(string message)
        {
            base.WriteText();
            //.......
            base.PlaySound();
            //*******
        }

        public override void SendPicture(string message)
        {
            base.DrawShape();
            //.......
            base.PlaySound();
            //*******
        }
    }

    class MobileMessagerLite : MobileMessagerBase
    {
        public override void Login(string username, string password)
        {
            base.Connect();
            //.......
        }

        public override void SendMessage(string message)
        {
            base.WriteText();
            //.......
        }

        public override void SendPicture(string message)
        {
            base.DrawShape();
            //.......
        }
    }

    class MobileMessagerPerfect : MobileMessagerBase
    {
        public override void Login(string username, string password)
        {
            base.Connect();
            //.......
            base.PlaySound();
            //*******
        }

        public override void SendMessage(string message)
        {
            base.WriteText();
            //.......
            base.PlaySound();
            //*******
        }

        public override void SendPicture(string message)
        {
            base.DrawShape();
            //.......
            base.PlaySound();
            //*******
        }
    }

    #endregion
}

namespace Design.Bridge 
{
    // 主方向 -> 业务实现：经典版和完美版及其他版本
    abstract class Messager
    {
        // 子类有相同字段的时候，往上提
        //protected MessagerImpl _impl;

        public abstract void Login(string username, string password);
        public abstract void SendMessage(string message);
        public abstract void SendPicture(string message);
    }

    // 副方向 -> 平台实现：桌面端的经典版和完美版，移动端的经典版和完美版，及其他平台
    abstract class MessagerImpl
    {
        public abstract void PlaySound();
        public abstract void DrawShape();
        public abstract void WriteText();
        public abstract void Connect();
    }

    #region 平台实现：桌面端和移动端的实现

    abstract class PCMessager : MessagerImpl
    {
        public override void PlaySound()
        {
            //*************
        }

        public override void DrawShape()
        {
            //*************
        }

        public override void WriteText()
        {
            //*************
        }

        public override void Connect()
        {
            //*************
        }
    }

    abstract class MobileMessager : MessagerImpl
    {
        public override void PlaySound()
        {
            //==============
        }

        public override void DrawShape()
        {
            //==============
        }

        public override void WriteText()
        {
            //==============
        }

        public override void Connect()
        {
            //==============
        }
    }

    #endregion

    #region 业务抽象：经典版和完美版的实现

    class MessagerLite : Messager
    {
        public MessagerLite(MessagerImpl messager_impl)
        {
            _messager_impl = messager_impl;
        }

        private MessagerImpl _messager_impl;

        public override void Login(string username, string password)
        {
            _messager_impl.Connect();
            //.......
        }

        public override void SendMessage(string message)
        {
            _messager_impl.WriteText();
            //.......
        }

        public override void SendPicture(string message)
        {
            _messager_impl.DrawShape();
            //.......
        }
    }

    class MessagerPerfect : Messager
    {
        public MessagerPerfect(MessagerImpl messager_impl)
        {
            MessagerImpl _messager_impl = messager_impl;
        }

        private MessagerImpl _messager_impl;

        public override void Login(string username, string password)
        {
            _messager_impl.Connect();
            //.......
            _messager_impl.PlaySound();
            //*******
        }

        public override void SendMessage(string message)
        {
            _messager_impl.WriteText();
            //.......
            _messager_impl.PlaySound();
            //*******
        }

        public override void SendPicture(string message)
        {
            _messager_impl.DrawShape();
            //.......
            _messager_impl.PlaySound();
            //*******
        }
    }

    #endregion
}
