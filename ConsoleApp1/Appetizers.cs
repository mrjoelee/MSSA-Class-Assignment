using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ConsoleApp1
{
    class Appetizers : Food
    {
        
        public int ShareableAmount { get; set; }

        public Appetizers()
        {
            ShareableAmount = 0;
        }

        public Appetizers(int shareableAmount) : base()
        {
            this.ShareableAmount = shareableAmount;
        }
        public override void Selection()
        {
            Console.WriteLine("Hello, your Appetizer is ");
        }
        public override void Welcome()
        {
            Console.WriteLine("Welcome To Unknown Restaurant");
        }
         public override string ToString()
        {
            return base.ToString();
        }
    }
}
