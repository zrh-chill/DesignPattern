using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design.State
{
    enum NetworkState
    {
        Network_Open,
        Network_Close,
        Network_Connect,
    }

    class NetworkProcessor
    {
        public NetworkState State { get; set; }

        public void Operation1()
        {
            if(State == NetworkState.Network_Open)
            {
                // 其他行为1
                State = NetworkState.Network_Close;
            }
            else if(State == NetworkState.Network_Close)
            {
                // 其他行为2
                State = NetworkState.Network_Connect;
            }
            else if (State == NetworkState.Network_Connect)
            {
                // 其他行为3
                State = NetworkState.Network_Open;
            }
        }

        public void Operation2()
        {
            if (State == NetworkState.Network_Open)
            {

            }
            else if (State == NetworkState.Network_Close)
            {

            }
            else if (State == NetworkState.Network_Connect)
            {

            }
        }
    }

}
