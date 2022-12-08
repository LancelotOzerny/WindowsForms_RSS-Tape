using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.Xml.Linq;

namespace LAB_8
{
    public partial class Form1 : Form
    {
        /// <summary>
        /// Список, который содержит в себе все новости
        /// </summary>
        private List<Item> _items = new List<Item>();

        private int currentPageIndex;

        /// <summary>
        /// Инициализация формы
        /// </summary>
        public Form1()
        {
            InitializeComponent();
            
            try
            {
                XElement tape = XElement.Load("https://www.f1-world.ru/news/rssexp6.xml");
                ReadXMLTape(tape);
            }
            catch(Exception)
            {
                MessageBox.Show("Проверьте подлючение к интернету!");
                Close();
            }

            SetPage();
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
                if (element.Name == "image")
                {
                    SetIcon(element);
                    continue;
                }
                if (element.Name == "item")
                {
                    SetItem(element);
                    continue;
                }

                ReadXMLTape(element);
            }
        }

        private void SetIcon(XElement element)
        {
            foreach (var itemElement in element.Elements())
            {
                if (itemElement.Name == "title")
                {
                    this.Text = itemElement.Value;
                }

                if (itemElement.Name == "url")
                {
                    picture_WebSiteIcon.ImageLocation = itemElement.Value;
                }
            }
        }

        private void SetPreviousPage()
        {
            if (--currentPageIndex < 0)
            {
                currentPageIndex = _items.Count - 1;
            }
            SetPage();
        }

        private void SetNextPage()
        {
            if (++currentPageIndex > _items.Count - 1)
            {
                currentPageIndex = 0;
            }
            SetPage();
        }

        private void SetPage()
        {
            label_date.Text = _items[currentPageIndex].publication;
            page_title.Text = _items[currentPageIndex].title;

            page_title.Location = new Point(Width / 2 - page_title.Width / 2, page_title.Location.Y);
            page_image.ImageLocation = _items[currentPageIndex].imageUrl;
            page_description.Text = _items[currentPageIndex].description;
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
                if (itemElement.Name == "title")
                {
                    item.title = itemElement.Value;
                }

                if (itemElement.Name == "description")
                {
                    item.description = itemElement.Value;
                }

                if (itemElement.Name == "guid")
                {
                    item.guid = itemElement.Value;
                }

                if (itemElement.Name == "pubDate")
                {
                    item.publication = itemElement.Value;
                }

                if (itemElement.Name == "enclosure")
                {
                    item.imageUrl = (string)itemElement.Attribute("url");
                }
            }

            _items.Add(item);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pictureDate.BackColor = Color.FromArgb(0, 0, 0, 0);
            pictureBox2.BackColor = Color.FromArgb(0, 0, 0, 0);

            pictureDate.Invalidate();

            pictureButton_link.mouseEnterEvent += () => { panel_WebSiteInfo.Visible = true; };
            pictureButton_Date.mouseEnterEvent += () => { panel_dateInfo.Visible = true; };

            pictureButton_link.mouseLeaveEvent += () => { panel_WebSiteInfo.Visible = false; };
            pictureButton_Date.mouseLeaveEvent += () => { panel_dateInfo.Visible = false; };

            leftArrow.mouseClickEvent += () => { SetPreviousPage(); };
            rightArrow.mouseClickEvent += () => { SetNextPage(); };
            pictureButton_link.mouseClickEvent += () => { System.Diagnostics.Process.Start(_items[currentPageIndex].guid); };
        }
    }

    /// <summary>
    /// Класс который содержит в себе элементы новости
    /// </summary>
    public class Item
    {
        public string title { get; set; }
        public string description { get; set; }
        public string publication { get; set; }
        public string guid { get; set; }
        public string imageUrl { get; set; }
    }
}
