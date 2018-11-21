using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieApp

{
    class Program
    {
        static void Main(string[] args)
        {
            Movie test = new Movie("Chidori", "Sasuke", 100, "Action", "The fuckin coolest attack",
                new DateTime(2018, 3, 1), 10.0);

            Console.WriteLine(test.getTitle());
            Console.Read();

     
           
        }
    }
}
