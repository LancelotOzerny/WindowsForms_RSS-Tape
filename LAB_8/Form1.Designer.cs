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
            this.pictureDate = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.picture_WebSiteIcon = new System.Windows.Forms.PictureBox();
            this.panel_WebSiteInfo = new System.Windows.Forms.Panel();
            this.panel_dateInfo = new System.Windows.Forms.Panel();
            this.label_date = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.page_title = new System.Windows.Forms.Label();
            this.rightArrow = new LAB_8.PictureButton();
            this.pictureButton_link = new LAB_8.PictureButton();
            this.pictureButton_Date = new LAB_8.PictureButton();
            this.leftArrow = new LAB_8.PictureButton();
            this.page_image = new System.Windows.Forms.PictureBox();
            this.page_description = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureDate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture_WebSiteIcon)).BeginInit();
            this.panel_WebSiteInfo.SuspendLayout();
            this.panel_dateInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.page_image)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureDate
            // 
            this.pictureDate.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.pictureDate.Image = ((System.Drawing.Image)(resources.GetObject("pictureDate.Image")));
            this.pictureDate.Location = new System.Drawing.Point(1, 20);
            this.pictureDate.Name = "pictureDate";
            this.pictureDate.Size = new System.Drawing.Size(363, 100);
            this.pictureDate.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureDate.TabIndex = 3;
            this.pictureDate.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24.25F);
            this.label1.Location = new System.Drawing.Point(14, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(268, 38);
            this.label1.TabIndex = 4;
            this.label1.Text = "Перейти на сайт";
            // 
            // picture_WebSiteIcon
            // 
            this.picture_WebSiteIcon.Location = new System.Drawing.Point(288, 31);
            this.picture_WebSiteIcon.Name = "picture_WebSiteIcon";
            this.picture_WebSiteIcon.Size = new System.Drawing.Size(60, 60);
            this.picture_WebSiteIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picture_WebSiteIcon.TabIndex = 5;
            this.picture_WebSiteIcon.TabStop = false;
            // 
            // panel_WebSiteInfo
            // 
            this.panel_WebSiteInfo.Controls.Add(this.label1);
            this.panel_WebSiteInfo.Controls.Add(this.picture_WebSiteIcon);
            this.panel_WebSiteInfo.Controls.Add(this.pictureDate);
            this.panel_WebSiteInfo.Location = new System.Drawing.Point(150, 455);
            this.panel_WebSiteInfo.Name = "panel_WebSiteInfo";
            this.panel_WebSiteInfo.Size = new System.Drawing.Size(363, 120);
            this.panel_WebSiteInfo.TabIndex = 7;
            this.panel_WebSiteInfo.Visible = false;
            // 
            // panel_dateInfo
            // 
            this.panel_dateInfo.Controls.Add(this.label_date);
            this.panel_dateInfo.Controls.Add(this.pictureBox2);
            this.panel_dateInfo.Location = new System.Drawing.Point(56, 458);
            this.panel_dateInfo.Name = "panel_dateInfo";
            this.panel_dateInfo.Size = new System.Drawing.Size(363, 120);
            this.panel_dateInfo.TabIndex = 7;
            this.panel_dateInfo.Visible = false;
            // 
            // label_date
            // 
            this.label_date.AutoSize = true;
            this.label_date.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.label_date.Location = new System.Drawing.Point(15, 50);
            this.label_date.Name = "label_date";
            this.label_date.Size = new System.Drawing.Size(160, 24);
            this.label_date.TabIndex = 4;
            this.label_date.Text = "Перейти на сайт";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(0, 17);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(319, 100);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // page_title
            // 
            this.page_title.AutoSize = true;
            this.page_title.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.page_title.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.page_title.Location = new System.Drawing.Point(0, 50);
            this.page_title.Name = "page_title";
            this.page_title.Size = new System.Drawing.Size(101, 31);
            this.page_title.TabIndex = 8;
            this.page_title.Text = "label26";
            // 
            // rightArrow
            // 
            this.rightArrow.Image = ((System.Drawing.Image)(resources.GetObject("rightArrow.Image")));
            this.rightArrow.Location = new System.Drawing.Point(1165, 310);
            this.rightArrow.MinScale = 0.75F;
            this.rightArrow.Name = "rightArrow";
            this.rightArrow.Size = new System.Drawing.Size(100, 100);
            this.rightArrow.Speed = 4;
            this.rightArrow.TabIndex = 2;
            // 
            // pictureButton_link
            // 
            this.pictureButton_link.Image = ((System.Drawing.Image)(resources.GetObject("pictureButton_link.Image")));
            this.pictureButton_link.Location = new System.Drawing.Point(106, 581);
            this.pictureButton_link.MinScale = 0.75F;
            this.pictureButton_link.Name = "pictureButton_link";
            this.pictureButton_link.Size = new System.Drawing.Size(100, 100);
            this.pictureButton_link.Speed = 4;
            this.pictureButton_link.TabIndex = 2;
            // 
            // pictureButton_Date
            // 
            this.pictureButton_Date.Image = ((System.Drawing.Image)(resources.GetObject("pictureButton_Date.Image")));
            this.pictureButton_Date.Location = new System.Drawing.Point(0, 581);
            this.pictureButton_Date.MinScale = 0.75F;
            this.pictureButton_Date.Name = "pictureButton_Date";
            this.pictureButton_Date.Size = new System.Drawing.Size(100, 100);
            this.pictureButton_Date.Speed = 4;
            this.pictureButton_Date.TabIndex = 2;
            // 
            // leftArrow
            // 
            this.leftArrow.Image = ((System.Drawing.Image)(resources.GetObject("leftArrow.Image")));
            this.leftArrow.Location = new System.Drawing.Point(0, 310);
            this.leftArrow.MinScale = 0.75F;
            this.leftArrow.Name = "leftArrow";
            this.leftArrow.Size = new System.Drawing.Size(100, 100);
            this.leftArrow.Speed = 4;
            this.leftArrow.TabIndex = 2;
            // 
            // page_image
            // 
            this.page_image.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.page_image.Location = new System.Drawing.Point(749, 170);
            this.page_image.Name = "page_image";
            this.page_image.Size = new System.Drawing.Size(418, 426);
            this.page_image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.page_image.TabIndex = 9;
            this.page_image.TabStop = false;
            // 
            // page_description
            // 
            this.page_description.BackColor = System.Drawing.SystemColors.Control;
            this.page_description.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.page_description.Cursor = System.Windows.Forms.Cursors.Default;
            this.page_description.Enabled = false;
            this.page_description.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F);
            this.page_description.Location = new System.Drawing.Point(119, 170);
            this.page_description.Multiline = true;
            this.page_description.Name = "page_description";
            this.page_description.ReadOnly = true;
            this.page_description.Size = new System.Drawing.Size(571, 279);
            this.page_description.TabIndex = 0;
            this.page_description.Text = "dasdasd das das asd dasdasd das das asd dasdasd das das asd dasdasd das das asd d" +
    "asdasd das das asd dasdasd das das asd ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.page_description);
            this.Controls.Add(this.page_image);
            this.Controls.Add(this.page_title);
            this.Controls.Add(this.panel_dateInfo);
            this.Controls.Add(this.panel_WebSiteInfo);
            this.Controls.Add(this.rightArrow);
            this.Controls.Add(this.pictureButton_link);
            this.Controls.Add(this.pictureButton_Date);
            this.Controls.Add(this.leftArrow);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureDate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture_WebSiteIcon)).EndInit();
            this.panel_WebSiteInfo.ResumeLayout(false);
            this.panel_WebSiteInfo.PerformLayout();
            this.panel_dateInfo.ResumeLayout(false);
            this.panel_dateInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.page_image)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureButton leftArrow;
        private PictureButton rightArrow;
        private PictureButton pictureButton_Date;
        private PictureButton pictureButton_link;
        private System.Windows.Forms.PictureBox pictureDate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox picture_WebSiteIcon;
        private System.Windows.Forms.Panel panel_WebSiteInfo;
        private System.Windows.Forms.Panel panel_dateInfo;
        private System.Windows.Forms.Label label_date;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label page_title;
        private System.Windows.Forms.PictureBox page_image;
        private System.Windows.Forms.TextBox page_description;
    }
}

