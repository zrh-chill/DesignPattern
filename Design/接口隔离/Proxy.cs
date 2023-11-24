using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design.Proxy1
{
    abstract class ISubject
    {
        public abstract void Process();
    }

    class RealSubject : ISubject
    {
        public override void Process()
        {

        }
    }

    class ClientApp
    {
        ISubject subject;

        public ClientApp(ISubject subject)
        {
            this.subject = subject;
        }

        public void DoWork()
        {
            subject.Process();
        }
    }
}


namespace Design.Proxy
{
    abstract class ISubject
    {
        public abstract void Process();
    }

    class RealSubject : ISubject
    {
        public override void Process()
        {

        }
    }

    class SubjectProxy : ISubject
    {
        public override void Process()
        {
            // 对RealSubject的一种间接访问
        }
    }

    class ClientApp
    {
        ISubject subject;

        public ClientApp(ISubject subject)
        {
            this.subject = subject; // SubjectProxy
        }

        public void DoWork()
        {
            subject.Process();
        }
    }
}
