using System;
using System.Drawing;
using System.Windows.Forms;

namespace LAB_8
{
    public partial class PictureButton : UserControl
    {
        private int _speed = 1;
        private Timer _timer = new Timer();

        private float _minScale = 0.75f;
        private Size _normalSize;

        private bool _ToSmall = false;

        public delegate void MouseEvent();
        public event MouseEvent mouseEnterEvent;
        public event MouseEvent mouseLeaveEvent;
        public event MouseEvent mouseClickEvent;

        /// <summary>
        /// Минимальный размер, который может иметь кнопка при наведении
        /// </summary>
        public float MinScale { 
            get 
            { 
                return _minScale;
            } 
            set 
            {
                if (value < 0)
                {
                    value = 0;
                }

                if (value > 1)
                {
                    value = 1;
                }

                _minScale = value; 
            } 
        }


        /// <summary>
        /// Изображение, которое будет носить в себе кнопка
        /// </summary>
        public Image Image { get => PictureBox.Image; set => PictureBox.Image = value; }

        /// <summary>
        /// Свойство, которое позволяет установить скорость анимации уменьшения и увеличения
        /// </summary>
        public int Speed
        {
            get => _speed;
            set
            {
                if (value < 1)
                {
                    value = 1;
                }

                _speed = value;
            }
        }



        /// <summary>
        /// Конструктор
        /// </summary>
        public PictureButton()
        {
            InitializeComponent();
            
            _timer.Interval = 10;
            _timer.Tick += Update;
            _timer.Start();
        }
        
        // <summary>
        /// Метод, который вызывается при входе курсора в картинку
        /// </summary>
        private void PictureBox_MouseEnter(object sender, EventArgs e)
        {
            _ToSmall = true;
            if (mouseEnterEvent != null)
            {
                mouseEnterEvent();
            }
        }

        /// <summary>
        /// Метод, который вызывается при выходе курсора из картинки
        /// </summary>
        private void PictureBox_MouseLeave(object sender, EventArgs e)
        {
            _ToSmall = false;
            if (mouseLeaveEvent != null)
            {
                mouseLeaveEvent();
            }
        }

        

        /// <summary>
        /// Метод, еализующщий анимацию уменьшения и увеличения кнопки
        /// </summary>
        private void Update(Object sender, EventArgs e)
        {
            if (_ToSmall)
            {
                if (PictureBox.Size.Width > _normalSize.Width * _minScale)
                {
                    PictureBox.Size = new Size(PictureBox.Size.Width - _speed, PictureBox.Size.Height - _speed);
                    PictureBox.Location = new Point((Width - PictureBox.Width) / 2, (Height - PictureBox.Height) / 2);
                }
            }

            if (!_ToSmall)
            {
                if (PictureBox.Size.Width < _normalSize.Width)
                {
                    PictureBox.Size = new Size(PictureBox.Size.Width + _speed, PictureBox.Size.Height + _speed);
                    PictureBox.Location = new Point((Width - PictureBox.Width) / 2, (Height - PictureBox.Height) / 2);
                }
            }
        }


        /// <summary>
        /// Загрузка кнопки
        /// </summary>
        private void PictureButton_Load(object sender, EventArgs e)
        {
            _normalSize = PictureBox.Size;
        }

        private void PictureBox_MouseClick(object sender, MouseEventArgs e)
        {
            if (mouseClickEvent != null)
            {
                mouseClickEvent();
            }
        }
    }
}
