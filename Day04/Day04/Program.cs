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
        }
    }
}
