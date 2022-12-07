using System;
using System.Drawing;
using System.Windows.Forms;

namespace LAB_8
{
    public partial class PictureButton : UserControl
    {
        private Timer _timer = new Timer();

        private float _minScale = 0.75f;
        private Size _normalSize;
        private Point _startLocation;

        private bool _ToSmall = false;

        private bool _sizeAdded;


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
        }

        /// <summary>
        /// Метод, который вызывается при выходе курсора из картинки
        /// </summary>
        private void PictureBox_MouseLeave(object sender, EventArgs e)
        {
            _ToSmall = false;
        }

        /// <summary>
        /// Метод, еализующщий анимацию уменьшения и увеличения кнопки
        /// </summary>
        private void Update(Object sender, EventArgs e)
        {
            _sizeAdded = !_sizeAdded;
            if (_ToSmall)
            {
                if (Size.Width > _normalSize.Width * _minScale)
                {
                    Size = new Size(Size.Width - 1, Size.Height - 1);

                    if (_sizeAdded)
                    {
                        Location = new Point(++_startLocation.X, ++_startLocation.Y);
                    }
                }
            }

            if (!_ToSmall)
            {

                if (Size.Width < _normalSize.Width)
                {
                    Size = new Size(Size.Width + 1, Size.Height + 1);
                    if (_sizeAdded)
                    {
                        Location = new Point(--_startLocation.X, --_startLocation.Y);
                    }
                }
            }
        }


        /// <summary>
        /// Загрузка кнопки
        /// </summary>
        private void PictureButton_Load(object sender, EventArgs e)
        {
            _normalSize = Size;
            _startLocation = Location;
        }
    }
}
