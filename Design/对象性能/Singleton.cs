using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design.Singleton
{
    class Singleton
    { 
        private Singleton() 
        { 
        
        }

        private static Singleton instance = null;

        /// <summary>
        /// 线程非安全
        /// </summary>
        /// <returns></returns>
        public static Singleton GetInstance()
        {
            if(instance == null)
            {
                instance = new Singleton();
            }

            return instance;
        }

        static object mutex = new object();

        /// <summary>
        /// 线程安全版本，但锁的代价过高
        /// </summary>
        /// <returns></returns>
        public static Singleton GetInstance1()
        {
            lock(mutex)
            {
                if (instance == null)
                {
                    instance = new Singleton();
                }

                return instance;
            }
        }

        /// <summary>
        /// 双检查锁，锁前锁后都检查，锁前检查避免代价过高，锁后检查避免创建多个对象即保证正确性
        /// </summary>
        /// <returns></returns>
        public static Singleton GetInstance2()
        {
            if(instance == null)
            {
                lock(mutex)
                {
                    if (instance == null)
                    {
                        instance = new Singleton();
                    }
                }
            }

            return instance;
        }
    }
}
