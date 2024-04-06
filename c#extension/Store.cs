using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_extension
{
    internal class Store
    {
        private static int _id;
        public int Id 
        {
            get {  return _id; }
            set {  _id = value; }
        }
        public Store()
        {
            _id++;
            Id = _id;
        }
        public Product[] Products;
        public void AddProduct(Product product)
        {
            Array.Resize(ref Products,Products.Length+1);
            Products[Products.Length-1] = product;
        } 
        public void  RemoveProductByNo(int No)
        {
            int index = -1;
            
            for(int i = 0; i < Products.Length; i++)
            {
               if( Products[i].No == No)
               {
                    index=i; 
                    break;
               }
            }
            if (index != -1)
            {

                for (int i = index; i < Products.Length - 1; i++)
                {
                    Products[i] = Products[i + 1];
                }

                Array.Resize(ref Products, Products.Length - 1);
            }
        }
        public Product GetProduct(int No)
        {
            for (int i = 0; i < Products.Length; i++)
            {
                if(Products[i].No ==No)
                {
                    return Products[i];
                }
            }
            return null;
        }
        public Product[] FilterProductByType(string Type)
        {
            
            for(int i=0; i < Products.Length;i++)
            {
                if (Products[i].Type == Type)
                {
                    Array.Resize(ref Products, Products.Length - 1);
                    Products[Products.Length+1] = Products[i];
                    return Products;
                }
            }
            return null;
        }
        public Product[]FilterProductByName(string Name)
        {
            for(int i = 0; i < Products.Length; i++)
            {
                if (Products[i].Name == Name)
                {
                    Array.Resize(ref Products, Products.Length - 1);
                    Products[Products.Length + 1] = Products[i];
                    return Products;
                }
            }
            return null;
        }
        public void Sale(Person person,int No)
        {
            for(int i=0; i < Products.Length; ++i)
            {
                

            }
            
        }

    }
}
