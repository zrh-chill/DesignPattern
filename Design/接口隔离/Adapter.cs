using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design.Adapter
{
    // 目标接口（新接口）
    abstract class ITarget
    {
        public abstract void process();
    }

    // 遗留接口（老接口）
    abstract class IAdaptee
    {
        public abstract void foo(int data);

        public abstract int bar();
    }

    // 遗留类
    class OldAdaptee : IAdaptee
    {
        public override int bar()
        {
            return 0;
        }

        public override void foo(int data)
        {
            
        }
    }

    // 适配器类，新实现
    class Adapter : ITarget
    {
        protected IAdaptee adaptee; // OldAdaptee

        public override void process()
        {
            int data = adaptee.bar();
            adaptee.foo(data);
        }
    }
}
