namespace VideoGamesDex
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Newbutton = new System.Windows.Forms.Button();
            this.GenrecomboBox = new System.Windows.Forms.ComboBox();
            this.Currentlabel = new System.Windows.Forms.Label();
            this.Lastbutton = new System.Windows.Forms.Button();
            this.Nextbutton = new System.Windows.Forms.Button();
            this.Previousbutton = new System.Windows.Forms.Button();
            this.Firstbutton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Genrelabel = new System.Windows.Forms.Label();
            this.Namelabel = new System.Windows.Forms.Label();
            this.CriticScoresnumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.ReleasetextBox = new System.Windows.Forms.TextBox();
            this.NametextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.CharactertextBox = new System.Windows.Forms.TextBox();
            this.RevenuetextBox = new System.Windows.Forms.TextBox();
            this.RatingcomboBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.DevelopertextBox = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.CriticScoresnumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Newbutton
            // 
            this.Newbutton.Location = new System.Drawing.Point(420, 87);
            this.Newbutton.Name = "Newbutton";
            this.Newbutton.Size = new System.Drawing.Size(89, 33);
            this.Newbutton.TabIndex = 54;
            this.Newbutton.Text = "New";
            this.Newbutton.UseVisualStyleBackColor = true;
            this.Newbutton.Click += new System.EventHandler(this.Newbutton_Click_1);
            // 
            // GenrecomboBox
            // 
            this.GenrecomboBox.FormattingEnabled = true;
            this.GenrecomboBox.Items.AddRange(new object[] {
            "RPG",
            "Action_Adventure",
            "FPS",
            "Horror",
            "Platformer"});
            this.GenrecomboBox.Location = new System.Drawing.Point(115, 98);
            this.GenrecomboBox.Name = "GenrecomboBox";
            this.GenrecomboBox.Size = new System.Drawing.Size(170, 24);
            this.GenrecomboBox.TabIndex = 53;
            // 
            // Currentlabel
            // 
            this.Currentlabel.AutoSize = true;
            this.Currentlabel.BackColor = System.Drawing.SystemColors.Control;
            this.Currentlabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Currentlabel.Location = new System.Drawing.Point(446, 38);
            this.Currentlabel.Name = "Currentlabel";
            this.Currentlabel.Size = new System.Drawing.Size(2, 18);
            this.Currentlabel.TabIndex = 52;
            // 
            // Lastbutton
            // 
            this.Lastbutton.Location = new System.Drawing.Point(420, 330);
            this.Lastbutton.Name = "Lastbutton";
            this.Lastbutton.Size = new System.Drawing.Size(89, 33);
            this.Lastbutton.TabIndex = 51;
            this.Lastbutton.Text = "Last";
            this.Lastbutton.UseVisualStyleBackColor = true;
            this.Lastbutton.Click += new System.EventHandler(this.Lastbutton_Click_1);
            // 
            // Nextbutton
            // 
            this.Nextbutton.Location = new System.Drawing.Point(420, 278);
            this.Nextbutton.Name = "Nextbutton";
            this.Nextbutton.Size = new System.Drawing.Size(89, 33);
            this.Nextbutton.TabIndex = 50;
            this.Nextbutton.Text = "Next";
            this.Nextbutton.UseVisualStyleBackColor = true;
            this.Nextbutton.Click += new System.EventHandler(this.Nextbutton_Click_1);
            // 
            // Previousbutton
            // 
            this.Previousbutton.Location = new System.Drawing.Point(420, 224);
            this.Previousbutton.Name = "Previousbutton";
            this.Previousbutton.Size = new System.Drawing.Size(89, 33);
            this.Previousbutton.TabIndex = 49;
            this.Previousbutton.Text = "Previous";
            this.Previousbutton.UseVisualStyleBackColor = true;
            this.Previousbutton.Click += new System.EventHandler(this.Previousbutton_Click_1);
            // 
            // Firstbutton
            // 
            this.Firstbutton.Location = new System.Drawing.Point(420, 169);
            this.Firstbutton.Name = "Firstbutton";
            this.Firstbutton.Size = new System.Drawing.Size(89, 33);
            this.Firstbutton.TabIndex = 48;
            this.Firstbutton.Text = "First";
            this.Firstbutton.UseVisualStyleBackColor = true;
            this.Firstbutton.Click += new System.EventHandler(this.Firstbutton_Click_1);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(420, 126);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(89, 33);
            this.button1.TabIndex = 46;
            this.button1.Text = "Save";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(22, 67);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 16);
            this.label6.TabIndex = 42;
            this.label6.Text = "Character";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 256);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 16);
            this.label5.TabIndex = 41;
            this.label5.Text = "Revenue";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 177);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 16);
            this.label4.TabIndex = 40;
            this.label4.Text = "Release";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 16);
            this.label3.TabIndex = 39;
            this.label3.Text = "Rating";
            // 
            // Genrelabel
            // 
            this.Genrelabel.AutoSize = true;
            this.Genrelabel.Location = new System.Drawing.Point(22, 98);
            this.Genrelabel.Name = "Genrelabel";
            this.Genrelabel.Size = new System.Drawing.Size(44, 16);
            this.Genrelabel.TabIndex = 38;
            this.Genrelabel.Text = "Genre";
            // 
            // Namelabel
            // 
            this.Namelabel.AutoSize = true;
            this.Namelabel.Location = new System.Drawing.Point(22, 27);
            this.Namelabel.Name = "Namelabel";
            this.Namelabel.Size = new System.Drawing.Size(44, 16);
            this.Namelabel.TabIndex = 37;
            this.Namelabel.Text = "Name";
            // 
            // CriticScoresnumericUpDown
            // 
            this.CriticScoresnumericUpDown.Location = new System.Drawing.Point(115, 212);
            this.CriticScoresnumericUpDown.Name = "CriticScoresnumericUpDown";
            this.CriticScoresnumericUpDown.Size = new System.Drawing.Size(170, 22);
            this.CriticScoresnumericUpDown.TabIndex = 32;
            // 
            // ReleasetextBox
            // 
            this.ReleasetextBox.Location = new System.Drawing.Point(115, 174);
            this.ReleasetextBox.Name = "ReleasetextBox";
            this.ReleasetextBox.Size = new System.Drawing.Size(170, 22);
            this.ReleasetextBox.TabIndex = 30;
            // 
            // NametextBox
            // 
            this.NametextBox.Location = new System.Drawing.Point(115, 24);
            this.NametextBox.Name = "NametextBox";
            this.NametextBox.Size = new System.Drawing.Size(170, 22);
            this.NametextBox.TabIndex = 29;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 295);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 16);
            this.label1.TabIndex = 55;
            this.label1.Text = "Developer";
            // 
            // CharactertextBox
            // 
            this.CharactertextBox.Location = new System.Drawing.Point(115, 61);
            this.CharactertextBox.Name = "CharactertextBox";
            this.CharactertextBox.Size = new System.Drawing.Size(170, 22);
            this.CharactertextBox.TabIndex = 56;
            // 
            // RevenuetextBox
            // 
            this.RevenuetextBox.Location = new System.Drawing.Point(115, 253);
            this.RevenuetextBox.Name = "RevenuetextBox";
            this.RevenuetextBox.Size = new System.Drawing.Size(170, 22);
            this.RevenuetextBox.TabIndex = 57;
            // 
            // RatingcomboBox
            // 
            this.RatingcomboBox.FormattingEnabled = true;
            this.RatingcomboBox.Items.AddRange(new object[] {
            "everyone",
            "teen",
            "mature"});
            this.RatingcomboBox.Location = new System.Drawing.Point(115, 134);
            this.RatingcomboBox.Name = "RatingcomboBox";
            this.RatingcomboBox.Size = new System.Drawing.Size(170, 24);
            this.RatingcomboBox.TabIndex = 58;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 214);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 16);
            this.label2.TabIndex = 59;
            this.label2.Text = "Critic Scores";
            // 
            // DevelopertextBox
            // 
            this.DevelopertextBox.Location = new System.Drawing.Point(115, 289);
            this.DevelopertextBox.Name = "DevelopertextBox";
            this.DevelopertextBox.Size = new System.Drawing.Size(170, 22);
            this.DevelopertextBox.TabIndex = 60;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(531, 24);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(257, 387);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 61;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(443, 382);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 16);
            this.label7.TabIndex = 62;
            this.label7.Text = "Picture";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.DevelopertextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.RatingcomboBox);
            this.Controls.Add(this.RevenuetextBox);
            this.Controls.Add(this.CharactertextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Newbutton);
            this.Controls.Add(this.GenrecomboBox);
            this.Controls.Add(this.Currentlabel);
            this.Controls.Add(this.Lastbutton);
            this.Controls.Add(this.Nextbutton);
            this.Controls.Add(this.Previousbutton);
            this.Controls.Add(this.Firstbutton);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Genrelabel);
            this.Controls.Add(this.Namelabel);
            this.Controls.Add(this.CriticScoresnumericUpDown);
            this.Controls.Add(this.ReleasetextBox);
            this.Controls.Add(this.NametextBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.CriticScoresnumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Newbutton;
        private System.Windows.Forms.ComboBox GenrecomboBox;
        private System.Windows.Forms.Label Currentlabel;
        private System.Windows.Forms.Button Lastbutton;
        private System.Windows.Forms.Button Nextbutton;
        private System.Windows.Forms.Button Previousbutton;
        private System.Windows.Forms.Button Firstbutton;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label Genrelabel;
        private System.Windows.Forms.Label Namelabel;
        private System.Windows.Forms.NumericUpDown CriticScoresnumericUpDown;
        private System.Windows.Forms.TextBox ReleasetextBox;
        private System.Windows.Forms.TextBox NametextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox CharactertextBox;
        private System.Windows.Forms.TextBox RevenuetextBox;
        private System.Windows.Forms.ComboBox RatingcomboBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox DevelopertextBox;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}

