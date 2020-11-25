using CodeDemo.DesignPattern._01AbstractFactory;
using System;
using System.Collections.Generic;
using System.Text;

namespace CodeDemo.DesignPattern._03FactoryMethod
{
    public class ApplePhoneFactory : PhoneFactory
    {
        protected override Phone CreatePhone(string type)
        {
            #region factory method
            //Phone phone = null;
            //switch (type)
            //{
            //    case "11":
            //        phone = new Apple11Phone();
            //        break;
            //    case "12":
            //        phone = new Apple12Phone();
            //        break;
            //    default:
            //        break;
            //}
            //return phone;
            #endregion
            #region abstract factory
            Phone phone = null;
            PhoneSeriesFactory phoneSeriesFactory = new ApplePhoneSeriesFactory();
            switch (type)
            {
                case "11":
                    phone = new Apple11Phone(phoneSeriesFactory);
                    break;
                case "12":
                    phone = new Apple12Phone(phoneSeriesFactory);
                    break;
                default:
                    break;
            }
            return phone;
            #endregion
        }
    }
}
