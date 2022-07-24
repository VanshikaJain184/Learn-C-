using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    internal class Program
    {
        //initiatlizing method with no parameter
        public void Mymethod()
        {
            Console.WriteLine("I am method without any arguments/parameters");
        }
        //Initializing method with one argument
        public int Mymethod(int firstVar)
        {
            Console.WriteLine("I am method with 1 argument/parameter");
            return firstVar;
        }
        //Initializing method with two arguments
        public string Mymethod(string firstVar, string secondVar)
        {
            Console.WriteLine("I am method with 2 arguments/parameters");
            return firstVar +" "+ secondVar;
        }
        static void Main(string[] args)
        {
            Program pObj = new Program();
            
            pObj.Mymethod();
            Console.WriteLine(pObj.Mymethod(9));
            Console.WriteLine(pObj.Mymethod("Vanshika", "Jain"));

        }
    }
}
