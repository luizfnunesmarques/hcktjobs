using System;
using System.Collections.Generic;
using System.Net;
using System.Threading;
using System.Threading.Tasks;

namespace Fun
{
    class Job
    {
        public Job()
        {

        }

        public string nome { get; internal set; }
        public int numero { get; set; }

        public void Executar()
        {
            Console.WriteLine("Running prime numbero of: " + numero + " PT: "+Thread.CurrentThread.IsThreadPoolThread + " ID: " + Thread.CurrentThread.ManagedThreadId);
          
            Fatorial();
        }


        private void Fatorial()
        {            
            Console.WriteLine("First prime number" + numero + " " + FindPrimeNumber(numero));
        }

        public long FindPrimeNumber(int n)
        {
            int count = 0;
            long a = 2;
            while (count < n)
            {
                long b = 2;
                int prime = 1;// to check if found a prime
                while (b * b <= a)
                {
                    if (a % b == 0)
                    {
                        prime = 0;
                        break;
                    }
                    b++;
                }
                if (prime > 0)
                    count++;
                a++;
            }
            return (--a);
        }

        private async Task<string> RunHttpJob()
        {
            WebClient webClient = new WebClient();
            var tasklist = new List<Task<string>>();
            return await webClient.DownloadStringTaskAsync("http://" + nome);              
        }
    }
}
