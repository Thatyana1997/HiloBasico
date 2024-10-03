using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace HiloBasico
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Thread hilo1 = new Thread(FuncionHilo);
            Thread hilo2 = new Thread(FuncionHilo2);

            hilo1.Start();
            hilo2.Start(); 
        }

        public static void FuncionHilo() 
        {
            for(int i=0; i<10;i++)
            {
                Console.WriteLine("Hilo principal "+i);
                Thread.Sleep(500);
            }
        }
        public static void FuncionHilo2()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Hilo secundario " + i);
                Thread.Sleep(500);
            }
        }
    }
}
