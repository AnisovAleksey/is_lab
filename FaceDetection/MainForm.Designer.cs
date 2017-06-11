namespace FaceDetection
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.PickImageButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.PickCascadeButton = new System.Windows.Forms.Button();
            this.SelectedCascadeLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // PickImageButton
            // 
            this.PickImageButton.Enabled = false;
            this.PickImageButton.Location = new System.Drawing.Point(327, 273);
            this.PickImageButton.Name = "PickImageButton";
            this.PickImageButton.Size = new System.Drawing.Size(140, 23);
            this.PickImageButton.TabIndex = 0;
            this.PickImageButton.Text = "Выбрать изображение";
            this.PickImageButton.UseVisualStyleBackColor = true;
            this.PickImageButton.Click += new System.EventHandler(this.OnButtonClick);
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(458, 258);
            this.panel1.TabIndex = 1;
            this.panel1.DoubleClick += new System.EventHandler(this.OnPanelDoubleClick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(455, 255);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.DoubleClick += new System.EventHandler(this.OnPictureBoxDoubleClick);
            // 
            // PickCascadeButton
            // 
            this.PickCascadeButton.Location = new System.Drawing.Point(12, 273);
            this.PickCascadeButton.Name = "PickCascadeButton";
            this.PickCascadeButton.Size = new System.Drawing.Size(115, 23);
            this.PickCascadeButton.TabIndex = 2;
            this.PickCascadeButton.Text = "Выбрать каскад";
            this.PickCascadeButton.UseVisualStyleBackColor = true;
            this.PickCascadeButton.Click += new System.EventHandler(this.OnPickCascadeButtonClick);
            // 
            // SelectedCascadeLabel
            // 
            this.SelectedCascadeLabel.AutoSize = true;
            this.SelectedCascadeLabel.Location = new System.Drawing.Point(133, 278);
            this.SelectedCascadeLabel.MaximumSize = new System.Drawing.Size(180, 15);
            this.SelectedCascadeLabel.Name = "SelectedCascadeLabel";
            this.SelectedCascadeLabel.Size = new System.Drawing.Size(100, 13);
            this.SelectedCascadeLabel.TabIndex = 3;
            this.SelectedCascadeLabel.Text = "Каскад не выбран";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(479, 308);
            this.Controls.Add(this.SelectedCascadeLabel);
            this.Controls.Add(this.PickCascadeButton);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.PickImageButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(495, 347);
            this.Name = "MainForm";
            this.Text = "FaceDetector 2.0";
            this.Resize += new System.EventHandler(this.OnFormResized);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button PickImageButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button PickCascadeButton;
        private System.Windows.Forms.Label SelectedCascadeLabel;
    }
}

