using CodeDemo.DesignPattern._01AbstractFactory;
using System;
using System.Collections.Generic;
using System.Text;
using OperatingSystem = CodeDemo.DesignPattern._01AbstractFactory.OperatingSystem;

namespace CodeDemo.DesignPattern._03FactoryMethod
{
    public abstract class Phone
    {
        #region abstract factory
        protected Cpu cpu;
        protected RAM ram;
        protected Camera camera;
        protected OperatingSystem operatingSystem;

        public abstract void Prepare();

        public void Make() 
        {
            Console.WriteLine("make......");
        }

        public virtual void AddNetworkAccessLicense()
        {
            Console.WriteLine("AddNetworkAccessLicense......");
        }

        public void Box()
        {
            Console.WriteLine("Box......");
        }
        
        #endregion
    }
}
