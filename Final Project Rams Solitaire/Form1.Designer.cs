namespace Final_Project_Rams_Solitaire
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
            this.loadButton = new System.Windows.Forms.Button();
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.minLabel = new System.Windows.Forms.Label();
            this.secLabel = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.listBox3 = new System.Windows.Forms.ListBox();
            this.listBox4 = new System.Windows.Forms.ListBox();
            this.listBox5 = new System.Windows.Forms.ListBox();
            this.listBox6 = new System.Windows.Forms.ListBox();
            this.listBox7 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // loadButton
            // 
            this.loadButton.Location = new System.Drawing.Point(28, 41);
            this.loadButton.Name = "loadButton";
            this.loadButton.Size = new System.Drawing.Size(75, 23);
            this.loadButton.TabIndex = 0;
            this.loadButton.Text = "DEAL";
            this.loadButton.UseVisualStyleBackColor = true;
            this.loadButton.Click += new System.EventHandler(this.loadButton_Click);
            // 
            // gameTimer
            // 
            this.gameTimer.Interval = 1000;
            this.gameTimer.Tick += new System.EventHandler(this.gameTimer_Tick);
            // 
            // minLabel
            // 
            this.minLabel.AutoSize = true;
            this.minLabel.BackColor = System.Drawing.Color.Transparent;
            this.minLabel.ForeColor = System.Drawing.Color.White;
            this.minLabel.Location = new System.Drawing.Point(206, 411);
            this.minLabel.Name = "minLabel";
            this.minLabel.Size = new System.Drawing.Size(0, 13);
            this.minLabel.TabIndex = 8;
            // 
            // secLabel
            // 
            this.secLabel.AutoSize = true;
            this.secLabel.BackColor = System.Drawing.Color.Transparent;
            this.secLabel.ForeColor = System.Drawing.Color.White;
            this.secLabel.Location = new System.Drawing.Point(223, 411);
            this.secLabel.Name = "secLabel";
            this.secLabel.Size = new System.Drawing.Size(0, 13);
            this.secLabel.TabIndex = 9;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(28, 105);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(100, 186);
            this.listBox1.TabIndex = 10;
            this.listBox1.Click += new System.EventHandler(this.listBox1_Click);
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.Location = new System.Drawing.Point(134, 105);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(100, 186);
            this.listBox2.TabIndex = 11;
            // 
            // listBox3
            // 
            this.listBox3.FormattingEnabled = true;
            this.listBox3.Location = new System.Drawing.Point(240, 105);
            this.listBox3.Name = "listBox3";
            this.listBox3.Size = new System.Drawing.Size(100, 186);
            this.listBox3.TabIndex = 12;
            // 
            // listBox4
            // 
            this.listBox4.FormattingEnabled = true;
            this.listBox4.Location = new System.Drawing.Point(346, 105);
            this.listBox4.Name = "listBox4";
            this.listBox4.Size = new System.Drawing.Size(100, 186);
            this.listBox4.TabIndex = 13;
            // 
            // listBox5
            // 
            this.listBox5.FormattingEnabled = true;
            this.listBox5.Location = new System.Drawing.Point(452, 105);
            this.listBox5.Name = "listBox5";
            this.listBox5.Size = new System.Drawing.Size(100, 186);
            this.listBox5.TabIndex = 14;
            // 
            // listBox6
            // 
            this.listBox6.FormattingEnabled = true;
            this.listBox6.Location = new System.Drawing.Point(558, 105);
            this.listBox6.Name = "listBox6";
            this.listBox6.Size = new System.Drawing.Size(100, 186);
            this.listBox6.TabIndex = 15;
            // 
            // listBox7
            // 
            this.listBox7.FormattingEnabled = true;
            this.listBox7.Location = new System.Drawing.Point(664, 105);
            this.listBox7.Name = "listBox7";
            this.listBox7.Size = new System.Drawing.Size(100, 186);
            this.listBox7.TabIndex = 16;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Final_Project_Rams_Solitaire.Properties.Resources.poker_table;
            this.ClientSize = new System.Drawing.Size(780, 484);
            this.Controls.Add(this.listBox7);
            this.Controls.Add(this.listBox6);
            this.Controls.Add(this.listBox5);
            this.Controls.Add(this.listBox4);
            this.Controls.Add(this.listBox3);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.secLabel);
            this.Controls.Add(this.minLabel);
            this.Controls.Add(this.loadButton);
            this.Name = "Form1";
            this.Text = "Rams Solitaire";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button loadButton;
        private System.Windows.Forms.Timer gameTimer;
        private System.Windows.Forms.Label minLabel;
        private System.Windows.Forms.Label secLabel;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.ListBox listBox3;
        private System.Windows.Forms.ListBox listBox4;
        private System.Windows.Forms.ListBox listBox5;
        private System.Windows.Forms.ListBox listBox6;
        private System.Windows.Forms.ListBox listBox7;
    }
}

