using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public abstract class Food
    {
        public string Name { get; set; }
        public string Cuisine { get; set; }

        public Food()
        {
            this.Name = "";
            this.Cuisine = "";

        }
        public Food(string name, string cuisine)
        {
            this.Name = name;
            this.Cuisine = cuisine;
        }
        public abstract void Selection();
        public virtual void Welcome()
        {
            Console.WriteLine("Selected Food");
        }

    }


}
