using MyGitProject.Daten;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace MyGitProject
{
    class Program
    {
        [DllImport("User32.dll", CharSet = CharSet.Unicode)]
        public static extern int MessageBox(IntPtr h, string m, string c, int type);

        static void Main(string[] args) {
            Console.WriteLine("Hello World:" + Task.CurrentId);
            Schueler s = new Schueler("Hans Meier", new DateTime(2001, 12, 17));
            Console.WriteLine(s);

            StartReading();
        }

        private static void StartReading() {
            Start();
            Console.WriteLine("Nach start weiter ...");
            MessageBox((IntPtr)0, "Hallo", "Nach start weiter ...", 0);
            Console.ReadKey();
        }

        static async void Start() {
            AsyncBeispiel ab = new AsyncBeispiel();
            int l = await ab.ReadSite("http://msdn.microsoft.com");
            Console.WriteLine("gelesen: " + l);

        }
    }
}
