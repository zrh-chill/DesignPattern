using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// 这个模式在C#里面有点过时，用序列化的方式实现会更好
namespace Design.MementoPattern
{
    // ... 动机
    // 在软件构建过程中，某些对象的状态在转换过程中，可能由于某种需要，要求
    // 程序能够回溯到对象之前处于某个点时的状态。
    // 如果使用一些公有接口来让其他对象得到对象的状态，便会暴露对象的细节实现

    // ... 定义
    // 在不破坏封装性(Originator的)的前提下，捕获一个对象的内部状态(41行)，并在该对象之外保存这个状态(51行)。
    // 这样以后就可以将该对象恢复到原先保存的状态

    /// <summary>
    /// 照片模板（本例只存储State这个字段）
    /// </summary>
    internal class Memento
    {
        public Memento(string s)
        {
            State = s;
        }

        public string State { get; set; }
        // ...
    }

    class Originator
    {
        private string state;
        // ... 只摘取部分需要的快照（状态，也就是属性值）

        /// <summary>
        /// 拍照，创建备忘录
        /// </summary>
        /// <returns></returns>
        public Memento CreateMemento()
        {
            // 这里在实际应用中一般比较复杂
            return new Memento(state);
        }

        /// <summary>
        /// 从快照恢复
        /// </summary>
        /// <param name="memento">快照</param>
        public void SetMemento(Memento memento)
        {
            // 这里在实际应用中一般比较复杂
            state = memento.State;
        }
    }

    class Main
    {
        public Main()
        {
            Originator originator = new Originator();

            // 创建备忘录
            Memento memento = originator.CreateMemento();

            // 存储快照
            // ...

            // 干别的事情改变状态(比如改变originator的state值)
            // ...

            // 恢复
            originator.SetMemento(memento);
        }
    }
}
