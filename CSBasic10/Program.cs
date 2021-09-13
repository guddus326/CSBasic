using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CSBasic10
{
    class Program
    {
        public static void TestMethod()
        {
            for(int i = 0; i < 1000; i++)
            {
                Console.Write("A");
            }
        }

        public delegate void SendString(string message);
        public static void Hello(string message)
        {
            Console.WriteLine("안녕하세요" + message + "씨!!");
        }
        public static void GoodBye(string message)
        {
            Console.WriteLine("안녕히계세요" + message + "씨!!");
        }

        class Product
        {
            public string Name { get; set; }
            public int Price { get; set; }

        }
        static void Main(string[] args)
        {
            Thread threadA = new Thread(TestMethod);
            Thread threadB = new Thread(delegate ()
              {
                  for (int i = 0; i < 1000; i++)
                  {
                      Console.Write("B");
                  }
              });

            Thread threadC = new Thread(delegate ()
            {
                for (int i = 0; i < 1000; i++)
                {
                    Console.Write("C");
                }
            });
            SendString sayHello, sayGoodbye, multiDelegate;
            sayHello = Hello;
            sayGoodbye = GoodBye;

            multiDelegate = sayHello + sayGoodbye;
            multiDelegate += sayHello;
            multiDelegate("함형연");
            Console.WriteLine();
            multiDelegate -= sayGoodbye;
            multiDelegate("함형연");



            List<Product> products = new List<Product>()
            {
                new Product(){Name="감자", Price=500},
                new Product(){Name="사과", Price=400},
                new Product(){Name="배추", Price=300},
                new Product(){Name="상추", Price=200},
                new Product(){Name="고구마", Price=600}
            };
            //정렬
            products.Sort((x,y)=> x.Price.CompareTo(y.Price));


            //출력
            foreach(var item in products)
            {
                Console.WriteLine(item.Name + " : " + item.Price);
            }
        }

        /*private static int SortWithPrice(Product x, Product y)
        {
            return x.Price.CompareTo(y.Price);
        }*/
    }
}
