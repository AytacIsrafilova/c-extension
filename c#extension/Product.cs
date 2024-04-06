using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_extension
{
    internal class Product
    {
        private static int _no;
        public int No 
        { 
            get { return _no; }
            set {  _no = value; }
        }
        public string Name;
        private static int _price;
        public int Price 
        {
            get { return _price; }
            set
            {
                if(_price>0)
                {
                    _price=value;
                }
            }
        }
        public string Type;
        public int Count;
        public Product(int _no,string name,int price,string type,int count)
        {
            _no++;
            No = _no;
            Name = name;
            Price = price;
            Type = type;
            Count = count;

        }
        public override string ToString()
        {
            return base.ToString();
        }
    }
}
