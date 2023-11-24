using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Design.State.NetworkProcessor;

namespace Design.State
{
    #region 一般写法
    class NetworkProcessor
    {
        public enum NetworkState
        {
            Network_Open,
            Network_Connect,
            Network_Close,
            //Network_Wait
        }

        public NetworkState State { get; set; }

        public void Operation1()
        {
            if(State == NetworkState.Network_Open)
            {
                // ********
                State = NetworkState.Network_Close;
            }
            else if (State == NetworkState.Network_Connect)
            {
                // $$$$$$$$
                State = NetworkState.Network_Open;
            }
            else if (State == NetworkState.Network_Close)
            {
                // --------
                State = NetworkState.Network_Connect;
            }
        }

        public void Operation2()
        {
            if (State == NetworkState.Network_Open)
            {
                // ********
                State = NetworkState.Network_Connect;
            }
            else if (State == NetworkState.Network_Connect)
            {
                // $$$$$$$$
                State = NetworkState.Network_Close;
            }
            else if (State == NetworkState.Network_Close)
            {
                // --------
                State = NetworkState.Network_Open;
            }
        }

        public void Operation3()
        {

        }
    }
    #endregion

    #region 状态模式
    abstract class NetWorkState
    {
        public NetWorkState Next { get; set; }
        public abstract void Operation1();
        public abstract void Operation2();
    }

    class OpenState : NetWorkState
    {
        private static NetWorkState _instance;

        public static NetWorkState Instance
        {
            get
            {
                if(_instance == null)
                {
                    _instance = new OpenState();
                }

                return _instance;
            }
        }

        public override void Operation1()
        {
            // ********
            Next = CloseState.Instance;
        }

        public override void Operation2()
        {
            // ********
            Next = ConnectState.Instance;
        }
    }

    class ConnectState : NetWorkState
    {
        private static NetWorkState _instance;

        public static NetWorkState Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new ConnectState();
                }

                return _instance;
            }
        }

        public override void Operation1()
        {
            // $$$$$$$$
            Next = CloseState.Instance;
        }

        public override void Operation2()
        {
            // $$$$$$$$
            Next = CloseState.Instance;
        }
    }

    class CloseState : NetWorkState
    {
        private static NetWorkState _instance;

        public static NetWorkState Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new CloseState();
                }

                return _instance;
            }
        }

        public override void Operation1()
        {
            // --------
            Next = OpenState.Instance;
        }

        public override void Operation2()
        {
            // --------
            Next = ConnectState.Instance;
        }
    }

    class NetworkProcessorStatePattern
    {
        private NetWorkState pState;

        public NetworkProcessorStatePattern(NetWorkState state)
        {
            pState = state;
        }

        void Operation1()
        {
            //...
            pState.Operation1();
            pState = pState.Next;
            //...
        }

        void Operation2()
        {
            //...
            pState.Operation2();
            pState = pState.Next;
            //...
        }
    }

    #endregion

}
