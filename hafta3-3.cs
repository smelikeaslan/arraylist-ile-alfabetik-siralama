using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace hafta3
{
    internal class Program
    {
     
        static void Main(string[] args)
        {
            
            ArrayList isimler = new ArrayList();

            
            Console.WriteLine("Lütfen 5 adet isim giriniz:");
            for (int i = 0; i < 5; i++)
            {
                Console.Write($"İsim {i + 1}: ");
                string isim = Console.ReadLine();
                isimler.Add(isim);
            }

            isimler.Sort();

            
            Console.WriteLine("\nİsimlerin alfabetik sıralaması için tuşa basın ");
            foreach (string isim in isimler)
            {
                Console.WriteLine(isim);
                Console.ReadKey();
            }
        }
    }



}



