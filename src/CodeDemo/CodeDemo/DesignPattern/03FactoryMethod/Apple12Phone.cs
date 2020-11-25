using CodeDemo.DesignPattern._01AbstractFactory;
using System;
using System.Collections.Generic;
using System.Text;

namespace CodeDemo.DesignPattern._03FactoryMethod
{
    public class Apple12Phone : Phone
    {
        #region abstract factory
        private PhoneSeriesFactory phoneSeriesFactory;

        public Apple12Phone(PhoneSeriesFactory phoneSeriesFactory)
        {
            this.phoneSeriesFactory = phoneSeriesFactory;
        }
        
        public override void Prepare()
        {
            cpu = phoneSeriesFactory.CreateCpu();
            camera = phoneSeriesFactory.CreateCamera();
            ram = phoneSeriesFactory.CreateRAM();
            operatingSystem = phoneSeriesFactory.CreateOperatingSystem();
        }
        #endregion
    }
}
