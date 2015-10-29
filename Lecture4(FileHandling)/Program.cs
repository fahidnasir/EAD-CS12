using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace Lecture4
{
    class Program
    {
        static void Main(string[] args)
        {
            //Always use Using block when ever opening the file.
            //So that at the end of the using block File automatically close.

            //Creating the File in which you want to save data.
            using (FileStream writer = File.Create("Data.txt"))
            {
                //Creating the list of Object you want to save in file.
                List<Person> persons = new List<Person>();

                //Whenever you create an object save add it in above list.
                persons.Add(new Person() { Name = "First", Email = "First@b.com", Age = 20, Gender = "Male" });
                persons.Add(new Person() { Name = "Second", Email = "Second@b.com", Age = 20, Gender = "FeMale" });
                persons.Add(new Person() { Name = "Third", Email = "Third@b.com", Age = 20, Gender = "FeMale" });
                persons.Add(new Person() { Name = "Forth", Email = "Forth@b.com", Age = 20, Gender = "Male" });
                persons.Add(new Person() { Name = "Fifth", Email = "Fifth@b.com", Age = 20, Gender = "FeMale" });

                //This piece of code saves the file in filesystem.
                //So use this code at the Save button Click or before closing the Application.
                BinaryFormatter bformatter = new BinaryFormatter();
                bformatter.Serialize(writer, persons);

            }

            //Always use Using block when ever opening the file.
            //So that at the end of the using block File automatically close.

            //Read the file from the FileSystem with Open mode.
            //Through error if file not there.
            //You can change the value of FileMode.OpenOrCreate so that if file not exist then create an empty file.
            using (Stream reader = File.Open("Data.txt", FileMode.Open))
            {
                //Above reader read the file.
                //And BinaryFormatter knows the Format in which the Object saved.
                BinaryFormatter bformatter = new BinaryFormatter();
                //BinaryFormatter Convert the Format to one which you saved.
                List<Person> p = (List<Person>)bformatter.Deserialize(reader);

                foreach (var item in p)
                {
                    Console.WriteLine(item);
                }

                Console.Read();
            }
        }
    }

    [Serializable]
    public class Person
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string Gender { get; set; }
        public int Age { get; set; }
        public override string ToString()
        {
            return Name + "," + Email + "," + Gender + "," + Age;
        }
    }
}
