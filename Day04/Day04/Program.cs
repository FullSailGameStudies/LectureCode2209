using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Day04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string fileName = @"C:\temp\2209\heroes.txt";
            char delimiter = '*';

            #region Writing CSV
            //
            //1. open the file
            using (StreamWriter sw = new StreamWriter(fileName))
            {
                //2. write to the file
                sw.Write("Batman");
                sw.Write(delimiter);
                sw.Write(5);
                sw.Write(delimiter);
                sw.Write(13.7);
                sw.Write(delimiter);
                sw.Write(true);
            }//3. Close the file!  sw.Close(); 
            #endregion

            #region Reading CSV
            ReadCSV(fileName, delimiter);
            #endregion
        }

        private static void ReadCSV(string fileName, char delimiter)
        {
            if (File.Exists(fileName))
            {
                //1. open the file to read it
                using (StreamReader sr = new StreamReader(fileName))
                {
                    //2. READ the file
                    string line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        string[] data = line.Split(delimiter);
                        string name = data[0];
                        int fave = int.Parse(data[1]);
                        double age = double.Parse(data[2]);
                        bool isGood = bool.Parse(data[3]);

                        Console.WriteLine(name);
                    }
                }//3. CLOSE THE FILE!
            }
        }
    }
}
