using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Entree : Food
    {
        public string Country { get; set; }

        public Entree()
        {
            Country = "";
        }

        public Entree(string country) : base()
        {
            this.Country = country;
        }
        public override void Selection()
        {
            Console.WriteLine("\n your Entree is ");
        }
        public override void Welcome()
        {
            Console.WriteLine("\r\nWelcome To Unknown Restaurant");
        }
        public override string ToString()
        {
            return base.ToString();
        }
    }
}

