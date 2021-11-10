using Newtonsoft.Json;
using Newtonsoft;
using System;
using System.Collections.Generic;
using System.IO;
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
            Console.WriteLine("Name : " + entree.Name.ToString() + "\nCuisine: " + entree.Cuisine + "\nCountry: " + entree.Country);

            //Console.WriteLine("Serialization");
            //string result = JsonConvert.SerializeObject(entree, Formatting.Indented);

            //Console.WriteLine(result);

            //Console.WriteLine("\nDeserilization");
            //Entree newEntree = JsonConvert.DeserializeObject<Entree>(result);
            //Console.WriteLine("Name: " + newEntree.Name);
            //Console.WriteLine("Cuisine: " + newEntree.Cuisine);
            //Console.WriteLine("Country: " + newEntree.Country);

            var entreeAsJson = JsonConvert.SerializeObject(entree);
            Console.Write(entreeAsJson);
            string filePathEntree = @"C:\My Projects\ClassAssignment\ConsoleApp1\temEntreeFile.txt";
            File.WriteAllText(filePathEntree, entreeAsJson);
            string sentreeAsJson = File.ReadAllText(filePathEntree);

            //Entree newEntree1 = JsonConvert.DeserializeObject<Entree>(File.ReadAllText(@"C:\My Projects\ClassAssignment\ConsoleApp1\temEntreeFile.txt"));

            //using (StreamReader file = File.OpenText(@"C:\My Projects\ClassAssignment\ConsoleApp1\temEntreeFile.txt")) 
            //{
            //    JsonSerializer serializer = new JsonSerializer();
            //    Entree newEntree2 = (Entree)serializer.Deserialize(File, typeof(Entree));
            //}

            Console.ReadLine();
        }

    }
}
