using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NasaAPIProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Nasa nasa = new Nasa();
            Console.WriteLine(nasa.GetTest());
            Console.ReadKey();
        }
    }
}
