using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Day04
{
    enum Superpower
    {
        Speed, Strength, Money, XrayVision, Flight, Swimming, FreezeBreath
    }
    class Superhero
    {
        //properties
        public string Name { get; set; }
        public string Secret { get; set; }
        public Superpower Power { get; set; }
    }
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

            List<Superhero> JLA = new List<Superhero>();
            JLA.Add(new Superhero() { Name = "Batman", Secret = "Bruce Wayne", Power = Superpower.Money });
            JLA.Add(new Superhero() { Name = "Superman", Secret = "Clark Kent", Power = Superpower.Flight });
            JLA.Add(new Superhero() { Name = "Wonder Woman", Secret = "Diana Prince", Power = Superpower.Strength });
            JLA.Add(new Superhero() { Name = "Flash", Secret = "Barry Allen", Power = Superpower.Speed });
            JLA.Add(new Superhero() { Name = "Aquaman", Secret = "Arthur Curry", Power = Superpower.Swimming });

            //change the extension to .json
            fileName = Path.ChangeExtension(fileName, ".json");
            Serialize(JLA, fileName);
        }

        private static void Serialize(List<Superhero> jLA, string fileName)
        {
            using (StreamWriter sw = new StreamWriter(fileName))
            {
                //use Json.NET to write out in JSON format
                using (JsonTextWriter jtw = new JsonTextWriter(sw))
                {
                    JsonSerializer jsonSerializer = new JsonSerializer();
                    jsonSerializer.Formatting = Formatting.Indented;
                    jsonSerializer.Serialize(jtw, jLA);
                }
            }
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

                //OR...use the File.ReadAllText method
                {
                    string fileText = File.ReadAllText(fileName);//open, read, close the file
                    string[] data = fileText.Split(delimiter);
                    string name = data[0];
                    int fave = int.Parse(data[1]);
                    double age = double.Parse(data[2]);
                    bool isGood = bool.Parse(data[3]);
                    Console.WriteLine(name);
                }

            }
        }
    }
}
