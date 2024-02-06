namespace PokeDex
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
            this.components = new System.ComponentModel.Container();
            this.NametextBox = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.TypetextBox = new System.Windows.Forms.TextBox();
            this.LevelnumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.HpnumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.ExpnumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.LegendarycheckBox = new System.Windows.Forms.CheckBox();
            this.ShinycheckBox = new System.Windows.Forms.CheckBox();
            this.GenerationnumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.DebugtextBox = new System.Windows.Forms.TextBox();
            this.Firstbutton = new System.Windows.Forms.Button();
            this.Previousbutton = new System.Windows.Forms.Button();
            this.Nextbutton = new System.Windows.Forms.Button();
            this.Lastbutton = new System.Windows.Forms.Button();
            this.Currentlabel = new System.Windows.Forms.Label();
            this.AttackTypecomboBox = new System.Windows.Forms.ComboBox();
            this.Newbutton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.LevelnumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HpnumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ExpnumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GenerationnumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // NametextBox
            // 
            this.NametextBox.Location = new System.Drawing.Point(181, 44);
            this.NametextBox.Name = "NametextBox";
            this.NametextBox.Size = new System.Drawing.Size(100, 22);
            this.NametextBox.TabIndex = 0;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // TypetextBox
            // 
            this.TypetextBox.Location = new System.Drawing.Point(181, 81);
            this.TypetextBox.Name = "TypetextBox";
            this.TypetextBox.Size = new System.Drawing.Size(100, 22);
            this.TypetextBox.TabIndex = 2;
            // 
            // LevelnumericUpDown
            // 
            this.LevelnumericUpDown.Location = new System.Drawing.Point(181, 127);
            this.LevelnumericUpDown.Name = "LevelnumericUpDown";
            this.LevelnumericUpDown.Size = new System.Drawing.Size(156, 22);
            this.LevelnumericUpDown.TabIndex = 3;
            // 
            // HpnumericUpDown
            // 
            this.HpnumericUpDown.Location = new System.Drawing.Point(181, 206);
            this.HpnumericUpDown.Name = "HpnumericUpDown";
            this.HpnumericUpDown.Size = new System.Drawing.Size(156, 22);
            this.HpnumericUpDown.TabIndex = 4;
            // 
            // ExpnumericUpDown
            // 
            this.ExpnumericUpDown.Location = new System.Drawing.Point(181, 249);
            this.ExpnumericUpDown.Name = "ExpnumericUpDown";
            this.ExpnumericUpDown.Size = new System.Drawing.Size(156, 22);
            this.ExpnumericUpDown.TabIndex = 5;
            // 
            // LegendarycheckBox
            // 
            this.LegendarycheckBox.AutoSize = true;
            this.LegendarycheckBox.Location = new System.Drawing.Point(181, 293);
            this.LegendarycheckBox.Name = "LegendarycheckBox";
            this.LegendarycheckBox.Size = new System.Drawing.Size(95, 20);
            this.LegendarycheckBox.TabIndex = 6;
            this.LegendarycheckBox.Text = "checkBox1";
            this.LegendarycheckBox.UseVisualStyleBackColor = true;
            // 
            // ShinycheckBox
            // 
            this.ShinycheckBox.AutoSize = true;
            this.ShinycheckBox.Location = new System.Drawing.Point(181, 326);
            this.ShinycheckBox.Name = "ShinycheckBox";
            this.ShinycheckBox.Size = new System.Drawing.Size(95, 20);
            this.ShinycheckBox.TabIndex = 7;
            this.ShinycheckBox.Text = "checkBox2";
            this.ShinycheckBox.UseVisualStyleBackColor = true;
            // 
            // GenerationnumericUpDown
            // 
            this.GenerationnumericUpDown.Location = new System.Drawing.Point(181, 359);
            this.GenerationnumericUpDown.Name = "GenerationnumericUpDown";
            this.GenerationnumericUpDown.Size = new System.Drawing.Size(156, 22);
            this.GenerationnumericUpDown.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(116, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 16);
            this.label1.TabIndex = 10;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(121, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 16);
            this.label2.TabIndex = 11;
            this.label2.Text = "Type";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(120, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 16);
            this.label3.TabIndex = 12;
            this.label3.Text = "Level";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(84, 165);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 16);
            this.label4.TabIndex = 13;
            this.label4.Text = "AttackType";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(134, 206);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(26, 16);
            this.label5.TabIndex = 14;
            this.label5.Text = "HP";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(127, 249);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(33, 16);
            this.label6.TabIndex = 15;
            this.label6.Text = "EXP";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(88, 293);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 16);
            this.label7.TabIndex = 16;
            this.label7.Text = "Legendary";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(120, 326);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(40, 16);
            this.label8.TabIndex = 17;
            this.label8.Text = "Shiny";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(87, 361);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(73, 16);
            this.label9.TabIndex = 18;
            this.label9.Text = "Generation";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(551, 121);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(89, 33);
            this.button1.TabIndex = 19;
            this.button1.Text = "Save";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // DebugtextBox
            // 
            this.DebugtextBox.Location = new System.Drawing.Point(551, 162);
            this.DebugtextBox.Multiline = true;
            this.DebugtextBox.Name = "DebugtextBox";
            this.DebugtextBox.Size = new System.Drawing.Size(237, 237);
            this.DebugtextBox.TabIndex = 20;
            // 
            // Firstbutton
            // 
            this.Firstbutton.Location = new System.Drawing.Point(456, 165);
            this.Firstbutton.Name = "Firstbutton";
            this.Firstbutton.Size = new System.Drawing.Size(89, 33);
            this.Firstbutton.TabIndex = 22;
            this.Firstbutton.Text = "First";
            this.Firstbutton.UseVisualStyleBackColor = true;
            this.Firstbutton.Click += new System.EventHandler(this.Firstbutton_Click);
            // 
            // Previousbutton
            // 
            this.Previousbutton.Location = new System.Drawing.Point(456, 220);
            this.Previousbutton.Name = "Previousbutton";
            this.Previousbutton.Size = new System.Drawing.Size(89, 33);
            this.Previousbutton.TabIndex = 23;
            this.Previousbutton.Text = "Previous";
            this.Previousbutton.UseVisualStyleBackColor = true;
            this.Previousbutton.Click += new System.EventHandler(this.Previousbutton_Click);
            // 
            // Nextbutton
            // 
            this.Nextbutton.Location = new System.Drawing.Point(456, 274);
            this.Nextbutton.Name = "Nextbutton";
            this.Nextbutton.Size = new System.Drawing.Size(89, 33);
            this.Nextbutton.TabIndex = 24;
            this.Nextbutton.Text = "Next";
            this.Nextbutton.UseVisualStyleBackColor = true;
            this.Nextbutton.Click += new System.EventHandler(this.Nextbutton_Click);
            // 
            // Lastbutton
            // 
            this.Lastbutton.Location = new System.Drawing.Point(456, 326);
            this.Lastbutton.Name = "Lastbutton";
            this.Lastbutton.Size = new System.Drawing.Size(89, 33);
            this.Lastbutton.TabIndex = 25;
            this.Lastbutton.Text = "Last";
            this.Lastbutton.UseVisualStyleBackColor = true;
            this.Lastbutton.Click += new System.EventHandler(this.Lastbutton_Click);
            // 
            // Currentlabel
            // 
            this.Currentlabel.AutoSize = true;
            this.Currentlabel.BackColor = System.Drawing.SystemColors.Control;
            this.Currentlabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Currentlabel.Location = new System.Drawing.Point(456, 64);
            this.Currentlabel.Name = "Currentlabel";
            this.Currentlabel.Size = new System.Drawing.Size(2, 18);
            this.Currentlabel.TabIndex = 26;
            // 
            // AttackTypecomboBox
            // 
            this.AttackTypecomboBox.FormattingEnabled = true;
            this.AttackTypecomboBox.Items.AddRange(new object[] {
            "Special_Attack",
            "Special_Defence",
            "Attack",
            "Defence"});
            this.AttackTypecomboBox.Location = new System.Drawing.Point(181, 162);
            this.AttackTypecomboBox.Name = "AttackTypecomboBox";
            this.AttackTypecomboBox.Size = new System.Drawing.Size(137, 24);
            this.AttackTypecomboBox.TabIndex = 27;
            // 
            // Newbutton
            // 
            this.Newbutton.Location = new System.Drawing.Point(699, 121);
            this.Newbutton.Name = "Newbutton";
            this.Newbutton.Size = new System.Drawing.Size(89, 33);
            this.Newbutton.TabIndex = 28;
            this.Newbutton.Text = "New";
            this.Newbutton.UseVisualStyleBackColor = true;
            this.Newbutton.Click += new System.EventHandler(this.Newbutton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Newbutton);
            this.Controls.Add(this.AttackTypecomboBox);
            this.Controls.Add(this.Currentlabel);
            this.Controls.Add(this.Lastbutton);
            this.Controls.Add(this.Nextbutton);
            this.Controls.Add(this.Previousbutton);
            this.Controls.Add(this.Firstbutton);
            this.Controls.Add(this.DebugtextBox);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.GenerationnumericUpDown);
            this.Controls.Add(this.ShinycheckBox);
            this.Controls.Add(this.LegendarycheckBox);
            this.Controls.Add(this.ExpnumericUpDown);
            this.Controls.Add(this.HpnumericUpDown);
            this.Controls.Add(this.LevelnumericUpDown);
            this.Controls.Add(this.TypetextBox);
            this.Controls.Add(this.NametextBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.LevelnumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HpnumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ExpnumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GenerationnumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox NametextBox;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox TypetextBox;
        private System.Windows.Forms.NumericUpDown LevelnumericUpDown;
        private System.Windows.Forms.NumericUpDown HpnumericUpDown;
        private System.Windows.Forms.NumericUpDown ExpnumericUpDown;
        private System.Windows.Forms.CheckBox LegendarycheckBox;
        private System.Windows.Forms.CheckBox ShinycheckBox;
        private System.Windows.Forms.NumericUpDown GenerationnumericUpDown;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox DebugtextBox;
        private System.Windows.Forms.Button Firstbutton;
        private System.Windows.Forms.Button Previousbutton;
        private System.Windows.Forms.Button Nextbutton;
        private System.Windows.Forms.Button Lastbutton;
        private System.Windows.Forms.Label Currentlabel;
        private System.Windows.Forms.ComboBox AttackTypecomboBox;
        private System.Windows.Forms.Button Newbutton;
    }
}

