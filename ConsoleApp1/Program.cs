﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Entree entree = new Entree();
            Appetizers appetizers = new Appetizers();
            appetizers.Name = "Tacos";
            appetizers.Cuisine = "Mexican";
            appetizers.ShareableAmount = 2;
            appetizers.Welcome();
            appetizers.Selection();
            Console.Write("Name :" + appetizers.Name + "\nCuisine: " + appetizers.Cuisine + "\nShareable By: " + appetizers.ShareableAmount.ToString());


            entree.Name = "Numb Chicken";
            entree.Cuisine = "Uyghur";
            entree.Country = "China";
            Console.WriteLine();
            entree.Selection();
            Console.WriteLine("Name :" + entree.Name.ToString() + "\nCuisine: " + entree.Cuisine + "\nCountry: " + entree.Country);

            Console.ReadLine();

            //need to finish on serializing and deserializing with json 
        }

    }
}
