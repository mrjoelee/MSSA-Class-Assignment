using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodLibrary
{
    //utilizing Abstract class
    abstract class Food
    {
        public string Name { get; set; }
        public string Cuisine { get; set; }

        public Food()
        {
            this.Name = "Tako Wasabi";
            this.Cuisine = "Japanese";

        }
        public Food(string name, string cuisine)
        {
            this.Name = name;
            this.Cuisine = cuisine;
        }
    }


}
