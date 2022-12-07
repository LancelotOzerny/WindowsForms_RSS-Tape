namespace LAB_8
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureButton1 = new LAB_8.PictureButton();
            this.pictureButton2 = new LAB_8.PictureButton();
            this.SuspendLayout();
            // 
            // pictureButton1
            // 
            this.pictureButton1.Image = ((System.Drawing.Image)(resources.GetObject("pictureButton1.Image")));
            this.pictureButton1.Location = new System.Drawing.Point(0, 310);
            this.pictureButton1.MinScale = 0.75F;
            this.pictureButton1.Name = "pictureButton1";
            this.pictureButton1.Size = new System.Drawing.Size(100, 100);
            this.pictureButton1.TabIndex = 2;
            // 
            // pictureButton2
            // 
            this.pictureButton2.Image = ((System.Drawing.Image)(resources.GetObject("pictureButton2.Image")));
            this.pictureButton2.Location = new System.Drawing.Point(1165, 310);
            this.pictureButton2.MinScale = 0.75F;
            this.pictureButton2.Name = "pictureButton2";
            this.pictureButton2.Size = new System.Drawing.Size(100, 100);
            this.pictureButton2.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.pictureButton2);
            this.Controls.Add(this.pictureButton1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion
        private PictureButton pictureButton1;
        private PictureButton pictureButton2;
    }
}

