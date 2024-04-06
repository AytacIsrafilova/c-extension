using System.Security.Cryptography;

namespace c_extension
{
    internal class Program
    {
      
        static void Main(string[] args)
        {
            Store store =new  Store();
            
            do
            {
                Console.WriteLine($"1.Mehsul elave et" +
                                  $"\n2.Mehsul sil" +
                                  $"\n3. Mehsula bax" +
                                  $"\n4. Type'a gore mehsullara bax" +
                                  $"\n5. Ada gore mehsullara bax" +
                                  $"\n0. Proqramdan cix");
                Console.WriteLine($"Secim edin:");
                string choice=Console.ReadLine();

                switch ( choice )
                {
                    case "1":
                        
                        string _nostr ;
                        int _no;
                        do
                        {
                            Console.WriteLine($"product no daxil et");
                            _nostr = Console.ReadLine();

                        } while (!int.TryParse(_nostr,out  _no));
                        Console.WriteLine($"product name daxil et");
                        string name=Console.ReadLine();

                        string pricestr;
                        int price;
                        do
                        {
                            Console.WriteLine($"product price daxil et");
                            pricestr = Console.ReadLine();

                        } while (!int.TryParse(pricestr, out price));
                        Console.WriteLine($"product type daxil et");
                        string type=Console.ReadLine();

                        string countstr;
                        int count;
                        do
                        {
                            Console.WriteLine($"product count daxil et");
                            countstr=Console.ReadLine();
                        } while( !int.TryParse(countstr,out count));
                        Product product=new Product(_no,name,price,type,count);
                        store.AddProduct(product);
                        break;
                    case "2":
                   
                        string removeNoStr;
                        int removeNo;
                        do
                        {
                            Console.WriteLine($"Enter the product number to remove:");
                             removeNoStr = Console.ReadLine();
                        } while (!int.TryParse(removeNoStr, out removeNo));
                        

                        store.RemoveProductByNo(removeNo);
                        break;
                    case "3":
                        int getNo;
                        string getNoStr;
                        do
                        {
                            Console.WriteLine($"Enter the product number to view:");
                             getNoStr = Console.ReadLine();
                        } while (!int.TryParse(getNoStr, out getNo));
                        store.GetProduct(getNo);
                        break;
                    case "4":

                        Console.WriteLine($"Enter the product type to filter:");
                        string filterType = Console.ReadLine();
                        store.FilterProductByType(filterType);
                        break;
                    case "5":
                        Console.WriteLine($"Enter the product name to filter:");
                        string filterName = Console.ReadLine();
                        store.FilterProductByName(filterName);
                        break;
                    case "0":
                        Console.WriteLine($"Proqramdan cixildi");
                        break;
                }
            }while(false);
        }
    }
}
