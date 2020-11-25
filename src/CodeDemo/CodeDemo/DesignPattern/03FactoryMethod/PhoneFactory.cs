using System;
using System.Collections.Generic;
using System.Text;

namespace CodeDemo.DesignPattern._03FactoryMethod
{
    public abstract class PhoneFactory
    {
        #region abstract factory
        public Phone OrderPhone(string type)
        {
            Phone phone;

            phone = CreatePhone(type);

            phone.Make();
            phone.AddNetworkAccessLicense();
            phone.Box();
            return phone;
        }
        #endregion
        #region factory method
        protected abstract Phone CreatePhone(string type);
        #endregion
    }
}
