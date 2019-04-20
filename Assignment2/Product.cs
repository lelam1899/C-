using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment2
{
    class Product
    {
        public int id;
        public string name;
        public float price;
        public int qty;
        public string image;
        public string desc;
        List<string> gallary = new List<string>();

        public Product(int id, string name, float price, int qty, string image, string desc, List<string> gallary
            )
        {
            this.id = id;
            this.name = name;
            this.price = price;
            this.qty = qty;
            this.image = image;
            this.desc = desc;
            this.gallary = gallary;

        }

        public void getinfor()
        {
            Console.WriteLine("id:" + id);
            Console.WriteLine("name:" + name);
            Console.WriteLine("price:" + price);
            Console.WriteLine("qty:" + qty);
            Console.WriteLine("image:" + image);
            Console.WriteLine("desc:" + desc);
          

        }
        public void kiemtra()
        {
            if (qty > 0)
            {
                Console.WriteLine("Con hang!");
                return;
            }
            Console.WriteLine("Het hang!");


        }
        public void add_image(string img)
        {
            if(gallary.Count < 10)
            {
                gallary.Add(img);
            }
            else
            {
                Console.WriteLine("gallary Day!");
            }

        }
        public void Remove()
        {
            Console.WriteLine("Remove at!");
            int i = Int16.Parse(Console.ReadLine());
            gallary.RemoveAt(i);

        }


    }
    class ClassMain
    {
        public static void Main(String[] args)
        {

        }
    }
}
