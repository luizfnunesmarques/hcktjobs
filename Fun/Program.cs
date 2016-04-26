using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Fun
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Job> lista = new List<Job>();
            lista.Add(new Job() { nome = "google.com",   numero = 50001 });
            lista.Add(new Job() { nome = "yahoo.com",    numero = 50002 });
            lista.Add(new Job() { nome = "facebook.com", numero = 50003 });
            lista.Add(new Job() { nome = "google.com",   numero = 50004 });
            lista.Add(new Job() { nome = "google.com", numero = 50005 });
            lista.Add(new Job() { nome = "google.com", numero = 50006 });
            lista.Add(new Job() { nome = "google.com", numero = 50007 });
            lista.Add(new Job() { nome = "google.com", numero = 50008 });
            lista.Add(new Job() { nome = "google.com", numero = 50009 });
            lista.Add(new Job() { nome = "google.com", numero = 50010 });
            lista.Add(new Job() { nome = "google.com", numero = 50011 });
            lista.Add(new Job() { nome = "google.com", numero = 50012 });
            lista.Add(new Job() { nome = "google.com", numero = 50013 });
            lista.Add(new Job() { nome = "google.com", numero = 50014 });
            lista.Add(new Job() { nome = "google.com", numero = 50015 });


            Console.WriteLine("MainThread " + Thread.CurrentThread.IsThreadPoolThread + " " + Thread.CurrentThread.ManagedThreadId);
            Parallel.ForEach(lista, new ParallelOptions() { MaxDegreeOfParallelism = 4 } ,(a) => a.Executar());
            Console.ReadKey();               

        }

        
    }
}

