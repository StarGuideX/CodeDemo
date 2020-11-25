using System;
using System.Collections.Generic;
using System.Text;

namespace CodeDemo.DesignPattern._04Prototype
{
    /// <summary>
    /// 自定义方法来实现原型拷贝
    /// </summary>
    public class Teacher
    {
        private int Id;
        private string Name;

        public Teacher Copy()
        {
            return new Teacher()
            {
                Id = this.Id,
                Name = this.Name
            };
        }
    }
}
