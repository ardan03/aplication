namespace aplication
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.iconButton2 = new FontAwesome.Sharp.IconButton();
            this.what = new FontAwesome.Sharp.IconButton();
            this.price = new FontAwesome.Sharp.IconButton();
            this.info = new FontAwesome.Sharp.IconButton();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.iconButton5 = new FontAwesome.Sharp.IconButton();
            this.iconButton4 = new FontAwesome.Sharp.IconButton();
            this.iconButton3 = new FontAwesome.Sharp.IconButton();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Brown;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.iconButton1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(194, 433);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.iconButton2);
            this.panel2.Controls.Add(this.what);
            this.panel2.Controls.Add(this.price);
            this.panel2.Controls.Add(this.info);
            this.panel2.Location = new System.Drawing.Point(-9, 116);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(209, 334);
            this.panel2.TabIndex = 2;
            // 
            // iconButton2
            // 
            this.iconButton2.BackColor = System.Drawing.Color.Brown;
            this.iconButton2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.iconButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton2.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.iconButton2.ForeColor = System.Drawing.Color.SeaShell;
            this.iconButton2.IconChar = FontAwesome.Sharp.IconChar.SignOutAlt;
            this.iconButton2.IconColor = System.Drawing.Color.Black;
            this.iconButton2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton2.IconSize = 30;
            this.iconButton2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton2.Location = new System.Drawing.Point(0, 286);
            this.iconButton2.Name = "iconButton2";
            this.iconButton2.Padding = new System.Windows.Forms.Padding(10, 0, 0, 15);
            this.iconButton2.Size = new System.Drawing.Size(209, 48);
            this.iconButton2.TabIndex = 6;
            this.iconButton2.Tag = "Выход";
            this.iconButton2.Text = "Выход";
            this.iconButton2.UseVisualStyleBackColor = false;
            this.iconButton2.Click += new System.EventHandler(this.iconButton3_Click);
            // 
            // what
            // 
            this.what.BackColor = System.Drawing.Color.Brown;
            this.what.Dock = System.Windows.Forms.DockStyle.Top;
            this.what.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.what.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.what.ForeColor = System.Drawing.Color.SeaShell;
            this.what.IconChar = FontAwesome.Sharp.IconChar.Grav;
            this.what.IconColor = System.Drawing.Color.Black;
            this.what.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.what.IconSize = 30;
            this.what.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.what.Location = new System.Drawing.Point(0, 102);
            this.what.Name = "what";
            this.what.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.what.Size = new System.Drawing.Size(209, 51);
            this.what.TabIndex = 5;
            this.what.Tag = "Что то с чем то";
            this.what.Text = "Что то с чем то";
            this.what.UseVisualStyleBackColor = false;
            this.what.Click += new System.EventHandler(this.what_Click);
            // 
            // price
            // 
            this.price.BackColor = System.Drawing.Color.Brown;
            this.price.Dock = System.Windows.Forms.DockStyle.Top;
            this.price.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.price.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.price.ForeColor = System.Drawing.Color.SeaShell;
            this.price.IconChar = FontAwesome.Sharp.IconChar.StackOverflow;
            this.price.IconColor = System.Drawing.Color.Black;
            this.price.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.price.IconSize = 30;
            this.price.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.price.Location = new System.Drawing.Point(0, 51);
            this.price.Name = "price";
            this.price.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.price.Size = new System.Drawing.Size(209, 51);
            this.price.TabIndex = 4;
            this.price.Tag = "Услуги";
            this.price.Text = "Услуги";
            this.price.UseVisualStyleBackColor = false;
            this.price.Click += new System.EventHandler(this.price_Click);
            // 
            // info
            // 
            this.info.BackColor = System.Drawing.Color.Brown;
            this.info.Dock = System.Windows.Forms.DockStyle.Top;
            this.info.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.info.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.info.ForeColor = System.Drawing.Color.SeaShell;
            this.info.IconChar = FontAwesome.Sharp.IconChar.Alipay;
            this.info.IconColor = System.Drawing.Color.Black;
            this.info.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.info.IconSize = 30;
            this.info.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.info.Location = new System.Drawing.Point(0, 0);
            this.info.Name = "info";
            this.info.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.info.Size = new System.Drawing.Size(209, 51);
            this.info.TabIndex = 3;
            this.info.Tag = "Информация";
            this.info.Text = "Информация";
            this.info.UseVisualStyleBackColor = false;
            this.info.Click += new System.EventHandler(this.info_Click);
            // 
            // iconButton1
            // 
            this.iconButton1.BackColor = System.Drawing.Color.Brown;
            this.iconButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.iconButton1.FlatAppearance.BorderSize = 0;
            this.iconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton1.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.AlignJustify;
            this.iconButton1.IconColor = System.Drawing.Color.Black;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.Location = new System.Drawing.Point(0, 84);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(50, 35);
            this.iconButton1.TabIndex = 1;
            this.iconButton1.UseVisualStyleBackColor = false;
            this.iconButton1.Click += new System.EventHandler(this.iconButton1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::aplication.Properties.Resources.ODBmR0sCu40;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(52, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(150, 119);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.iconButton5);
            this.panel3.Controls.Add(this.iconButton4);
            this.panel3.Controls.Add(this.iconButton3);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(194, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(774, 24);
            this.panel3.TabIndex = 1;
            this.panel3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel3_MouseDown);
            // 
            // iconButton5
            // 
            this.iconButton5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iconButton5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.iconButton5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconButton5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton5.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.iconButton5.ForeColor = System.Drawing.Color.SeaShell;
            this.iconButton5.IconChar = FontAwesome.Sharp.IconChar.Minus;
            this.iconButton5.IconColor = System.Drawing.Color.Black;
            this.iconButton5.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton5.IconSize = 25;
            this.iconButton5.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.iconButton5.Location = new System.Drawing.Point(650, 0);
            this.iconButton5.Name = "iconButton5";
            this.iconButton5.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.iconButton5.Size = new System.Drawing.Size(45, 25);
            this.iconButton5.TabIndex = 6;
            this.iconButton5.UseVisualStyleBackColor = false;
            this.iconButton5.Click += new System.EventHandler(this.iconButton5_Click);
            // 
            // iconButton4
            // 
            this.iconButton4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iconButton4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.iconButton4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconButton4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton4.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.iconButton4.ForeColor = System.Drawing.Color.SeaShell;
            this.iconButton4.IconChar = FontAwesome.Sharp.IconChar.Clone;
            this.iconButton4.IconColor = System.Drawing.Color.Black;
            this.iconButton4.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton4.IconSize = 25;
            this.iconButton4.Location = new System.Drawing.Point(689, 0);
            this.iconButton4.Name = "iconButton4";
            this.iconButton4.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.iconButton4.Size = new System.Drawing.Size(41, 25);
            this.iconButton4.TabIndex = 5;
            this.iconButton4.UseVisualStyleBackColor = false;
            this.iconButton4.Click += new System.EventHandler(this.iconButton4_Click);
            // 
            // iconButton3
            // 
            this.iconButton3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iconButton3.BackColor = System.Drawing.Color.Red;
            this.iconButton3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconButton3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton3.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.iconButton3.ForeColor = System.Drawing.Color.SeaShell;
            this.iconButton3.IconChar = FontAwesome.Sharp.IconChar.Xmark;
            this.iconButton3.IconColor = System.Drawing.Color.Black;
            this.iconButton3.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton3.IconSize = 25;
            this.iconButton3.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.iconButton3.Location = new System.Drawing.Point(729, 0);
            this.iconButton3.Name = "iconButton3";
            this.iconButton3.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.iconButton3.Size = new System.Drawing.Size(45, 25);
            this.iconButton3.TabIndex = 4;
            this.iconButton3.UseVisualStyleBackColor = false;
            this.iconButton3.Click += new System.EventHandler(this.iconButton3_Click);
            // 
            // panel4
            // 
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(194, 24);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(774, 409);
            this.panel4.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(968, 433);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private FontAwesome.Sharp.IconButton iconButton2;
        private FontAwesome.Sharp.IconButton what;
        private FontAwesome.Sharp.IconButton price;
        private FontAwesome.Sharp.IconButton info;
        private FontAwesome.Sharp.IconButton iconButton1;
        private PictureBox pictureBox1;
        private Panel panel3;
        private FontAwesome.Sharp.IconButton iconButton5;
        private FontAwesome.Sharp.IconButton iconButton4;
        private FontAwesome.Sharp.IconButton iconButton3;
        private Panel panel4;
    }
}