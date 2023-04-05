using System.Diagnostics;
using System.Xml.Linq;

namespace ShoesMagazine
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string textFilePath = "shoes.txt";
            string binaryFilePath = "shoes.dat";

            // Читаем данные из текстового файла
            List<Shoe> shoes = new List<Shoe>();
            using (StreamReader sr = new StreamReader(textFilePath))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    string[] parts = line.Split(';');
                    string article = parts[0];
                    string name = parts[1];
                    int quantity = int.Parse(parts[2]);
                    int price = int.Parse(parts[3]);        

                    Shoe shoe = new Shoe(article, name, quantity, price);
                    shoes.Add(shoe);
                }
            }

            // Сортируем данные в алфавитном порядке наименований
            shoes.Sort((s1, s2) => s1.Name.CompareTo(s2.Name));

            // Записываем данные в двоичный файл
            using (FileStream fs = new FileStream(binaryFilePath, FileMode.Create))
            {
                foreach (Shoe shoe in shoes)
                {
                    byte[] buffer = System.Text.Encoding.UTF8.GetBytes(shoe.ToString() + Environment.NewLine);
                    fs.Write(buffer, 0, buffer.Length);
                }
            }

            int priceA = 100; // нижняя граница диапазона
            int priceB = 200; // верхняя граница диапазона

            for (int i = 0; i < shoes.Count; i++)
            {
                var shoe = shoes[i];
                if (shoe.Price >= priceA && shoe.Price <= priceB)
                {
                    Console.WriteLine($"Art: {shoe.Article} Name: {shoe.Name} Quantity: {shoe.Quantity} Price: {shoe.Price:C}");
                }
            }

            // Открываем бинарный файл с данными об обуви
         

            

        }
    }
}