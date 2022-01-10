using System;
using System.Collections.Generic;
using System.IO;

namespace Week15_Frozen
{
    class Program
    {
        class SecretSanta
        {
            string name;
            string gift;

            public Wish(string _name, string _gift)
            {
                name = _name;
                gift = _gift;
            }

            public string Name
            {
                get { return name; }
            }
            public string Gift
            {
                get { return gift; }
            }
        }
        static void Main(string[] args)
        {
            List<SecretSanta> secretSantaWishes = new List<SecretSanta>();
            string[] wishesFromSanta = GetDataFromFile();

            foreach(string line in wishesFromSanta)
            {
                string[] tempArray = line.Split(new char[] { '/' }, StringSplitOptions.RemoveEmptyEntries);
                SecretSanta newWish = new SecretSanta(tempArray[0], tempArray[1]);
                secretSantaWishes.Add(newWish);
            }

            foreach(SecretSanta wishFromSanta in secretSantaWishes)
            {
                Console.WriteLine($"{wishFromSanta.Name} wants {wishFromSanta.Gift}");
            }
        }
        public static string[] GetDataFromFile()
        {
            string filePath = @"C:\Users\Public\samples\frozen.txt";
            string[] dataFromFile = File.ReadAllLines(filePath);

            return dataFromFile;
        }
    }
}
