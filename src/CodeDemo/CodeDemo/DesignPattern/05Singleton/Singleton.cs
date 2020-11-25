using System;
using System.Collections.Generic;
using System.Text;

namespace CodeDemo.DesignPattern._05Singleton
{
    // sealed 阻止发生派生
    public sealed class Singleton
    {
        #region simple
        //private static Singleton uniqueInstance;
        //private Singleton() { }

        //public static Singleton GetInstance()
        //{
        //    if (uniqueInstance == null)
        //        uniqueInstance = new Singleton();

        //    return uniqueInstance;
        //}
        #endregion

        #region use lock
        private static volatile Singleton uniqueInstance;
        // volatile 用于控制同步，其意义是针对程序中一些敏感数据，不允许多线程同时访问，保证数据在任何访问时刻，最多有一个线程访问，以保证数据的完整性，volatile是修饰变量的修饰符。
        private static readonly object Singleton_Lock = new object();
        private Singleton() { }

        public static Singleton GetInstance()
        {
            if (uniqueInstance == null)
            {
                lock (Singleton_Lock)
                {
                    if (uniqueInstance == null)
                        uniqueInstance = new Singleton();
                }
            }
            return uniqueInstance;
        }
        #endregion
    }
}
