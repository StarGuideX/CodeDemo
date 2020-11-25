using System;
using System.Collections.Generic;
using System.Text;

namespace CodeDemo.DesignPattern._04Prototype
{
    /// <summary>
    /// 实现ICloneable
    /// </summary>
    public class Student : ICloneable
    {
        private int Id;
        private string Name;
        private int Score;

        public object Clone()
        {
            return new Student() { 
                Id = this.Id, 
                Name = this.Name,
                Score = this.Score
            };
        }
    }
}
