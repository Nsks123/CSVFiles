using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSVFILE
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = "Sheets.csv";
            StreamReader sr = new StreamReader(name);
            string[] str = File.ReadAllLines(name);

            string name1 = "sheets.txt";
            using(StreamWriter sw = new StreamWriter(name1))
            {
                while(!sr.EndOfStream)
                {
                    sw.WriteLine(sr.ReadLine());
                }

            }
            sr.Close();
           
            
           
            


        }
    }
}

           
           /* string filename = "Sheets.csv";
            string[] str = File.ReadAllLines(filename);
            foreach (string str2 in str)
            {
                Console.WriteLine(str2);
            }
            using (StreamWriter writer = File.AppendText(filename))
            {
                writer.WriteLine("Arun,Kishore,22,Pune,Maharashtra");
                writer.WriteLine("Tillu,Radhika,26,Lakdikapul,Hyderabad");
            }
*/
            /*string filename1 = "Sheets.txt";
            StreamReader sr = new StreamReader(filename1);
            string[] str = File.ReadAllLines(filename1);
            filename1 = "Sheets.csv";
            using (StreamWriter sw = File.CreateText(filename1))
            {
                while (!sr.EndOfStream)
                {
                    sw.WriteLine(sr.ReadLine());
                }
            }
            Console.WriteLine("Executed");
            sr.Close();*/