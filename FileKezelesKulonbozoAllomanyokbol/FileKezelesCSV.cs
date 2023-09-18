using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace FileKezelesKulonbozoAllomanyokbol
{
    public class FileKezelesCSV
    {
        public static List<string[]> lista = new List<string[]>();
        
        public static List<string[]> FilebolOlvas(string fileNev)
        {
            string elsoSor = "";

            using (StreamReader sr = new StreamReader(fileNev, Encoding.UTF8))
            {
                elsoSor = sr.ReadLine();

                while (!sr.EndOfStream)
                {
                    string sor = sr.ReadLine();
                    string[] tomb = sor.Split(';');
                    lista.Add(tomb);
                }
            }

            return lista;
        }

        public static int ElemszamSzamolas()
        {
            int elemszam = lista.Count;

            return elemszam;
        }
    }
}
