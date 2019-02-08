using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.IO;
using System.Text;

using Newtonsoft.Json;
using System.Runtime.Serialization.Formatters.Binary;

// XML
using System.Xml.Serialization;

namespace Csharp.Day4.Example5
{
    class Program
    {
        static void Main1(string[] args)
        {
            // gestion I/O File

            // DIR
            DirectoryInfo currDir = new DirectoryInfo(".");

            // absolut path
            DirectoryInfo currDirAb = new DirectoryInfo(@"C:\Users\youssef\DATA");

            Console.WriteLine(currDirAb.FullName);
            Console.WriteLine(currDirAb.Name);
            Console.WriteLine(currDirAb.Parent);
            Console.WriteLine(currDirAb.Attributes);
            Console.WriteLine(currDirAb.CreationTime);

            // create directoy
            DirectoryInfo newCurrDirAb = new DirectoryInfo(@"C:\Users\youssef\DATA2");

            newCurrDirAb.Create();

            //DirectoryInfo delCurrDirAb = new DirectoryInfo(@"C:\Users\youssef\DATA3");

            // Directory.Delete(@"C:\Users\youssef\DATA3");


            // File

            string[] students =
                {
                "baddi youssef",
                "Karim Baina",
                "salah baina"
            };

            string textFilePath = @"C:\Users\youssef\DATA2/testFile.txt";
            ;
            File.WriteAllLines(textFilePath, students);

            foreach(string line in File.ReadLines(textFilePath))
            {
                Console.WriteLine($"student : {line}");
            }


            // get all files
            DirectoryInfo dir2 = new DirectoryInfo(@"C:\Users\youssef\DATA2");

            FileInfo[] textFiles = dir2.GetFiles("*.txt",
                SearchOption.AllDirectories);

            foreach (FileInfo line in textFiles)
            {
                Console.WriteLine($"fiel full name : {line.Name}");
                Console.WriteLine($"file size : {line.Length}");
            }

            // file stream 

            // to save a byte of data or array of baytes
            string streamFilePath = @"C:\Users\youssef\DATA2/streamFile.txt";

            //create stream file
            FileStream fileStream = File.Open(streamFilePath, FileMode.Create);
            string str = "this is a stream string";

            string str1 = " this is an other \n stream string";

            // convert it to a byte array
            byte[] strbyte = Encoding.Default.GetBytes(str);

            byte[] strbyte2 = Encoding.Default.GetBytes(str1);

            fileStream.Write(strbyte, 0, strbyte.Length);
            fileStream.Position = 0;
            fileStream.Write(strbyte2, 0, strbyte2.Length);
            

          
            fileStream.Close();

            // save a serialisable object 
            Owner o = new Owner("ahmeD", 1 );

            string json = JsonConvert.SerializeObject(o);
            File.WriteAllText(@"C:\Users\youssef\DATA2/streamFile.txt", json);
            //File.WriteAllLines(@"C:\Users\youssef\DATA2/streamFile.txt", json);

            using (StreamWriter file = File.CreateText(@"C:\Users\youssef\DATA2/streamFile2.txt"))
            {
                JsonSerializer js = new JsonSerializer();
                js.Serialize(file, o);
            }


            // quick test serialisable 
            Owner o1 = new Owner("name1", 1);

            Stream file1 = File.Open(@"C:\Users\youssef\DATA2/streamFile2.txt", 
                FileMode.Create);
            BinaryFormatter bf = new BinaryFormatter();

            bf.Serialize(file1, o1);
            file1.Close();

            // Quick Deserialisable to read from a stored file
            file1 = File.Open(@"C:\Users\youssef\DATA2/streamFile2.txt", 
                FileMode.Open);
            bf = new BinaryFormatter();

            Owner o2 = (Owner)bf.Deserialize(file1);
            Console.WriteLine("the name is {0}",o2.Name);
            file1.Close();


            // change file to show change state where made
            o1.ID = 2;


            // list of owners

            List<Owner> lOwners = new List<Owner>
            {
                new Owner("name 1", 1),
                new Owner("name 2", 2),
                new Owner("name 3", 3),
                new Owner("name 4", 4),
            };

            // sate the object as an XML file XML
            
            using(Stream file2 = new FileStream(@"C:\Users\youssef\DATA2/streamFile2.xml",
                FileMode.Create))
            {
                XmlSerializer xMLSerializer = new XmlSerializer(typeof(List<Owner>));
                xMLSerializer.Serialize(file2, lOwners);
            }

            // deserialiser
            List<Owner> owners = null;
            XmlSerializer xMLSerializer1 = new XmlSerializer(typeof(List<Owner>));
            using (Stream file3 = File.OpenRead(@"C:\Users\youssef\DATA2/streamFile2.xml"))
            {
                owners = (List<Owner>)xMLSerializer1.Deserialize(file3);

                
            }

            foreach(Owner owner1 in owners)
            {
                Console.WriteLine("owner {0} with id {1}", owner1.Name, owner1.ID);
            }

            Console.ReadLine();
        }
    }
}
