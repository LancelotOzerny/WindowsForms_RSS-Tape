using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Xml.Linq;

namespace LAB_8
{
    /// <summary>
    /// Класс который содержит в себе элементы новости
    /// </summary>
    public class Item
    {
        public string title { get; set; }
        public string description {get; set;}
        public string link { get; set;}
        public string publication { get; set;}
        public string guid {get; set;}
        public string imageUrl { get; set;}
    }

    public partial class Form1 : Form
    {
        /// <summary>
        /// Список, который содержит в себе все новости
        /// </summary>
        private List<Item> _items = new List<Item>();

        /// <summary>
        /// Инициализация формы
        /// </summary>
        public Form1()
        {
            InitializeComponent();

            XElement tape = XElement.Load("https://www.f1-world.ru/news/rssexp6.xml");
            ReadXMLTape(tape);
        }

        /// <summary>
        /// Метод, который позволяет считать все дочерние элементы из XElement экземпляра
        /// </summary>
        /// <param name="tape"></param>
        private void ReadXMLTape(XElement tape)
        {
            // Дочерние элементы
            var elements = tape.Elements();

            // Если элементов больше нет, то значит мы дошли до одного из последнх
            if (elements.Count() <= 0)
            {
                return;
            }

            // Перебор всех элементов
            foreach (var element in elements)
            {
                if (element.Name == "item")
                {
                    SetItem(element);
                    continue;
                }

                ReadXMLTape(element);
            }
        }

        /// <summary>
        /// Метод, который позволяет установить добавить в список item-ов новостей еще одну новость, преображенную в Item элемент через XElement
        /// </summary>
        /// <param name="element"></param>
        private void SetItem(XElement element)
        {
            Item item = new Item();

            foreach (var itemElement in element.Elements())
            {
                if (element.Name == "title")
                {
                    item.title = itemElement.Value;
                }

                if (element.Name == "description")
                {
                    item.description = itemElement.Value;
                }

                if (element.Name == "guid")
                {
                    item.guid = itemElement.Value;
                }

                if (element.Name == "pubDate")
                {
                    item.publication = itemElement.Value;
                }

                if (element.Name == "enclosure")
                {
                    item.imageUrl = (string)itemElement.Attribute("url");
                }
            }

            _items.Add(item);
        }
    }
}
