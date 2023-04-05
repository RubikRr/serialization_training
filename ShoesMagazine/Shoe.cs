using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoesMagazine
{
    internal class Shoe
    {
        public string Article { get; set; }     // Артикул
        public string Name { get; set; }        // Наименование
        public int Quantity { get; set; }       // Количество
        public int Price { get; set; }      // Стоимость одной пары

        public Shoe(string article, string name, int quantity, int price)
        {
            Article = article;
            Name = name;
            Quantity = quantity;
            Price = price;
        }

        public override string ToString()
        {
            return $"{Article} - {Name}, {Quantity} шт., {Price} руб.";
        }
    }
}
