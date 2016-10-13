using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace MyGitProject.Daten {
    class AsyncBeispiel {
        // see:
        // https://msdn.microsoft.com/en-us/library/hh191443(v=vs.110).aspx
        public async Task<int> ReadSite(string uri) {
            HttpClient client = new HttpClient();
            var result = client.GetStringAsync(uri);
            
            // do other stuff
            Console.WriteLine("Arbeit 1 start");
            await Task.Delay(1000);
            Console.WriteLine("Arbeit 1 ende");

            // wenn noch nicht fertig - control back to caller - promise to produce an integer result (promise task)
            string text = await result;

            return text.Length;
        }


        public async Task<int> ReadFile() {
            FileStream stream = File.OpenRead(@"c:\temp\sj-16-17.log");
            byte[] buffer = new byte[stream.Length];
            Task<int> gelesen = stream.ReadAsync(buffer, 0, (int) stream.Length);
            await Task.Delay(1000);
            return gelesen.Result;
            //return new Task<int>(()=> 1);
        }
    }
}
