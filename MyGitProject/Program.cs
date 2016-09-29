using MyGitProject.Daten;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyGitProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World");
            Schueler s = new Schueler("Hans Meier", new DateTime(2001, 12, 17));
            Console.WriteLine(s);
        }
    }
}
