using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Shoes kros1 = new Shoes("Д-0001", "Кросы найки", 6, 2114);
            Shoes kros2 = new Shoes("М-0002", "Кросы найку", 1, 1151);
            Shoes kros3 = new Shoes("Ж-0003", "Кросы рибук", 2, 1351);
            Shoes kros4 = new Shoes("Д-0004", "Кросы адидас", 3, 1341);
            Shoes kros5 = new Shoes("М-0001", "Кросы абибас", 7, 1344);
            string path = @"C:\Programming\C#\Учеба\Alina\shoes.txt";
            using (StreamWriter sw = new StreamWriter(path))
            {
                sw.WriteLine(kros1);
                sw.WriteLine(kros2);
                sw.WriteLine(kros3);
                sw.WriteLine(kros4);
                sw.WriteLine(kros5);

            }

            var lst1 = new List<Shoes>();
            lst1.AddRange( new Shoes[5]{kros1, kros2, kros3, kros4, kros5});
            BinaryFormatter formatter = new BinaryFormatter();
            using (FileStream fs = File.Create(@"C:\Programming\C#\Учеба\Alina\shoes.dat"))
            {
                formatter.Serialize(fs, lst1);
               
            }
            BinaryFormatter formatter2 = new BinaryFormatter();

            FileStream filestream = File.OpenRead(@"C:\Programming\C#\Учеба\Alina\shoes.dat");

            var lst = (List<Shoes>)formatter2.Deserialize(filestream);
            filestream.Close();
            foreach (var sh in lst)
            {
                Console.WriteLine(sh);
            }

            lst = new List<Shoes>();
            using (FileStream fs = File.Open(@"C:\Programming\C#\Учеба\Alina\shoes.dat", FileMode.Open))
            {
                var formatter1 = new BinaryFormatter();
                lst=(List<Shoes>)formatter1.Deserialize(fs);
            }

            foreach (var sh in lst)
            {
                Console.WriteLine(sh);
            }






        }
    }
}