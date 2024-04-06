using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_extension
{
    internal class Person
    {
        private static int _id;
        public int Id 
        { 
            get {  return _id; }
            set {  _id = value; }
            
        }
        public string FullName;
        private static sbyte _age;
        public sbyte Age
        {
            get { return _age; }
            set
            {
                if(_age>0||_age<=125)
                {
                    _age = value;
                }
            }
           
        }
        public Person(int _id,string fullname,sbyte age)
        {
            _id++;
            Id= _id;
            FullName= fullname;
            Age= age;
        }
        public double Cash { get; set; }
        public override string ToString()
        {
            return base.ToString();
        }
    }
}
