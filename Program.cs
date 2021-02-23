using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.IO;

namespace Survey
{
    class Program
    {
        static void Main(string[] args)
        {
            // Indsamle 5 sæt kundedata
            string data = "";

            string[] spørgsmål = File.ReadAllLines(@"C:\datafil\survey\questions.txt",Encoding.Unicode);
            string[] svar = new string[spørgsmål.Length];

            for (int index = 0; index < svar.Length; index++)
            {
                Console.Write(spørgsmål[index]);
                svar[index] = Console.ReadLine();
            }

            // 7 svar til 1 text som skal gemmes i filen

            for (int index = 0; index < svar.Length - 1; index++)
                data = data + svar[index] + ";";

            data = data + svar[svar.Length-1] + Environment.NewLine;
                          
            File.AppendAllText(@"C:\datafil\survey\svar.txt",data, Encoding.Unicode);




            Console.WriteLine("c u"); Console.ReadKey();
        }
    }
}
