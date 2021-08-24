using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{ 
    class Product
    {
        string name;
        int price, stock;
        static List<string> product_name = new List<string>();
        static List<int> prices = new List<int>();
        static List<int> stocks = new List<int>();
        public void addProduct()
        {
            Console.WriteLine("Masukkan jumlah yang mau ditambah : \t");
            int count = Convert.ToInt32( Console.ReadLine());

            for(int i=0; i<count; i++)
            {
                Console.WriteLine("Nama produk : \t");
                name = Console.ReadLine();
                product_name.Add(name);

                Console.WriteLine("Harga: \t");
                price = Convert.ToInt32( Console.ReadLine());
                prices.Add(price);

                Console.WriteLine("Jumlah : \t");
                stock = Convert.ToInt32( Console.ReadLine());
                stocks.Add(stock);
            }
        }
 
        public void showProduct()
        {
            int index = 1;
            if (product_name.Count != 0)
            {
                for (int i = 0; i < product_name.Count; i++)
                {
                    Console.WriteLine("\n=========== PRODUCT " + index + " =============");
                    Console.WriteLine(
                            "Nama Produk :\t " + product_name[i]+
                            "\nHarga      :\t" + prices[i]+
                            "\nJumlah     :\t" + stocks[i]
                            );
                    Console.WriteLine("================================");

                    index++;
                }
            }
            else
            {
                Console.WriteLine("Produk belum ada");
            }
            
        }

        public void DeleteProduct()
        {
            showProduct();
            if (product_name is null)
            {
                Console.WriteLine("Produk Belum ada !!!");
            }
            else
            {
                Console.WriteLine("----------- HAPUS PRODUCT -------------");
                Console.WriteLine("Produk yang mau dihapus");
                int choice = Convert.ToInt32(Console.ReadLine());
                    product_name.RemoveAt(choice - 1);
                    prices.RemoveAt(choice - 1);
                    stocks.RemoveAt(choice - 1);
                
            }
            

        }

        public void Update()
        {
            
            int j = Convert.ToInt32(Console.ReadLine());
            int i = stocks.IndexOf(j-1);

            Console.WriteLine("Masukkan Nama :");
            string new_name = Console.ReadLine();

            product_name[i] = product_name[i].Replace(product_name[i],new_name);

            showProduct();

        }


    }
}

    

