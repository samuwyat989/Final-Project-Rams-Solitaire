﻿namespace Final_Project_Rams_Solitaire
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.loadButton = new System.Windows.Forms.Button();
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.minLabel = new System.Windows.Forms.Label();
            this.secLabel = new System.Windows.Forms.Label();
            this.lineBox1 = new System.Windows.Forms.ListBox();
            this.lineBox2 = new System.Windows.Forms.ListBox();
            this.lineBox3 = new System.Windows.Forms.ListBox();
            this.lineBox4 = new System.Windows.Forms.ListBox();
            this.lineBox5 = new System.Windows.Forms.ListBox();
            this.lineBox6 = new System.Windows.Forms.ListBox();
            this.lineBox7 = new System.Windows.Forms.ListBox();
            this.movesNumber = new System.Windows.Forms.Label();
            this.heartsBox = new System.Windows.Forms.ListBox();
            this.clubsBox = new System.Windows.Forms.ListBox();
            this.diamondsBox = new System.Windows.Forms.ListBox();
            this.spadesBox = new System.Windows.Forms.ListBox();
            this.heartsLabel = new System.Windows.Forms.Label();
            this.clubsLabel = new System.Windows.Forms.Label();
            this.diamondsLabel = new System.Windows.Forms.Label();
            this.spadesLabel = new System.Windows.Forms.Label();
            this.drawCardButton = new System.Windows.Forms.Button();
            this.playCardBox = new System.Windows.Forms.ListBox();
            this.displayTimeLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // loadButton
            // 
            this.loadButton.Location = new System.Drawing.Point(30, 23);
            this.loadButton.Name = "loadButton";
            this.loadButton.Size = new System.Drawing.Size(181, 83);
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
            this.minLabel.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minLabel.ForeColor = System.Drawing.Color.White;
            this.minLabel.Location = new System.Drawing.Point(529, 68);
            this.minLabel.Name = "minLabel";
            this.minLabel.Size = new System.Drawing.Size(30, 32);
            this.minLabel.TabIndex = 8;
            this.minLabel.Text = "0";
            // 
            // secLabel
            // 
            this.secLabel.AutoSize = true;
            this.secLabel.BackColor = System.Drawing.Color.Transparent;
            this.secLabel.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.secLabel.ForeColor = System.Drawing.Color.White;
            this.secLabel.Location = new System.Drawing.Point(554, 68);
            this.secLabel.Name = "secLabel";
            this.secLabel.Size = new System.Drawing.Size(61, 32);
            this.secLabel.TabIndex = 9;
            this.secLabel.Text = ": 00";
            // 
            // lineBox1
            // 
            this.lineBox1.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lineBox1.FormattingEnabled = true;
            this.lineBox1.ItemHeight = 20;
            this.lineBox1.Location = new System.Drawing.Point(30, 140);
            this.lineBox1.Name = "lineBox1";
            this.lineBox1.Size = new System.Drawing.Size(100, 324);
            this.lineBox1.TabIndex = 10;
            this.lineBox1.Click += new System.EventHandler(this.listBox1_Click);
            // 
            // lineBox2
            // 
            this.lineBox2.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lineBox2.FormattingEnabled = true;
            this.lineBox2.ItemHeight = 20;
            this.lineBox2.Location = new System.Drawing.Point(136, 140);
            this.lineBox2.Name = "lineBox2";
            this.lineBox2.Size = new System.Drawing.Size(100, 324);
            this.lineBox2.TabIndex = 11;
            this.lineBox2.Click += new System.EventHandler(this.listBox2_Click);
            // 
            // lineBox3
            // 
            this.lineBox3.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lineBox3.FormattingEnabled = true;
            this.lineBox3.ItemHeight = 20;
            this.lineBox3.Location = new System.Drawing.Point(242, 140);
            this.lineBox3.Name = "lineBox3";
            this.lineBox3.Size = new System.Drawing.Size(100, 324);
            this.lineBox3.TabIndex = 12;
            this.lineBox3.Click += new System.EventHandler(this.listBox3_Click);
            // 
            // lineBox4
            // 
            this.lineBox4.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lineBox4.FormattingEnabled = true;
            this.lineBox4.ItemHeight = 20;
            this.lineBox4.Location = new System.Drawing.Point(348, 140);
            this.lineBox4.Name = "lineBox4";
            this.lineBox4.Size = new System.Drawing.Size(100, 324);
            this.lineBox4.TabIndex = 13;
            this.lineBox4.Click += new System.EventHandler(this.listBox4_Click);
            // 
            // lineBox5
            // 
            this.lineBox5.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lineBox5.FormattingEnabled = true;
            this.lineBox5.ItemHeight = 20;
            this.lineBox5.Location = new System.Drawing.Point(454, 140);
            this.lineBox5.Name = "lineBox5";
            this.lineBox5.Size = new System.Drawing.Size(100, 324);
            this.lineBox5.TabIndex = 14;
            this.lineBox5.Click += new System.EventHandler(this.listBox5_Click);
            // 
            // lineBox6
            // 
            this.lineBox6.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lineBox6.FormattingEnabled = true;
            this.lineBox6.ItemHeight = 20;
            this.lineBox6.Location = new System.Drawing.Point(560, 140);
            this.lineBox6.Name = "lineBox6";
            this.lineBox6.Size = new System.Drawing.Size(100, 324);
            this.lineBox6.TabIndex = 15;
            this.lineBox6.Click += new System.EventHandler(this.listBox6_Click);
            // 
            // lineBox7
            // 
            this.lineBox7.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lineBox7.FormattingEnabled = true;
            this.lineBox7.ItemHeight = 20;
            this.lineBox7.Location = new System.Drawing.Point(666, 140);
            this.lineBox7.Name = "lineBox7";
            this.lineBox7.Size = new System.Drawing.Size(100, 324);
            this.lineBox7.TabIndex = 16;
            this.lineBox7.Click += new System.EventHandler(this.listBox7_Click);
            // 
            // movesNumber
            // 
            this.movesNumber.AutoSize = true;
            this.movesNumber.BackColor = System.Drawing.Color.Transparent;
            this.movesNumber.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.movesNumber.ForeColor = System.Drawing.Color.White;
            this.movesNumber.Location = new System.Drawing.Point(416, 23);
            this.movesNumber.Name = "movesNumber";
            this.movesNumber.Size = new System.Drawing.Size(143, 32);
            this.movesNumber.TabIndex = 17;
            this.movesNumber.Text = "MOVES: 0";
            // 
            // heartsBox
            // 
            this.heartsBox.FormattingEnabled = true;
            this.heartsBox.Location = new System.Drawing.Point(789, 237);
            this.heartsBox.Name = "heartsBox";
            this.heartsBox.Size = new System.Drawing.Size(100, 17);
            this.heartsBox.TabIndex = 18;
            // 
            // clubsBox
            // 
            this.clubsBox.FormattingEnabled = true;
            this.clubsBox.Location = new System.Drawing.Point(789, 293);
            this.clubsBox.Name = "clubsBox";
            this.clubsBox.Size = new System.Drawing.Size(100, 17);
            this.clubsBox.TabIndex = 19;
            // 
            // diamondsBox
            // 
            this.diamondsBox.FormattingEnabled = true;
            this.diamondsBox.Location = new System.Drawing.Point(789, 352);
            this.diamondsBox.Name = "diamondsBox";
            this.diamondsBox.Size = new System.Drawing.Size(100, 17);
            this.diamondsBox.TabIndex = 20;
            // 
            // spadesBox
            // 
            this.spadesBox.FormattingEnabled = true;
            this.spadesBox.Location = new System.Drawing.Point(789, 404);
            this.spadesBox.Name = "spadesBox";
            this.spadesBox.Size = new System.Drawing.Size(100, 17);
            this.spadesBox.TabIndex = 21;
            // 
            // heartsLabel
            // 
            this.heartsLabel.AutoSize = true;
            this.heartsLabel.BackColor = System.Drawing.Color.Transparent;
            this.heartsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.heartsLabel.ForeColor = System.Drawing.Color.White;
            this.heartsLabel.Location = new System.Drawing.Point(786, 221);
            this.heartsLabel.Name = "heartsLabel";
            this.heartsLabel.Size = new System.Drawing.Size(57, 13);
            this.heartsLabel.TabIndex = 22;
            this.heartsLabel.Text = "HEARTS";
            // 
            // clubsLabel
            // 
            this.clubsLabel.AutoSize = true;
            this.clubsLabel.BackColor = System.Drawing.Color.Transparent;
            this.clubsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clubsLabel.ForeColor = System.Drawing.Color.White;
            this.clubsLabel.Location = new System.Drawing.Point(786, 277);
            this.clubsLabel.Name = "clubsLabel";
            this.clubsLabel.Size = new System.Drawing.Size(47, 13);
            this.clubsLabel.TabIndex = 23;
            this.clubsLabel.Text = "CLUBS";
            // 
            // diamondsLabel
            // 
            this.diamondsLabel.AutoSize = true;
            this.diamondsLabel.BackColor = System.Drawing.Color.Transparent;
            this.diamondsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.diamondsLabel.ForeColor = System.Drawing.Color.White;
            this.diamondsLabel.Location = new System.Drawing.Point(786, 336);
            this.diamondsLabel.Name = "diamondsLabel";
            this.diamondsLabel.Size = new System.Drawing.Size(73, 13);
            this.diamondsLabel.TabIndex = 24;
            this.diamondsLabel.Text = "DIAMONDS";
            // 
            // spadesLabel
            // 
            this.spadesLabel.AutoSize = true;
            this.spadesLabel.BackColor = System.Drawing.Color.Transparent;
            this.spadesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.spadesLabel.ForeColor = System.Drawing.Color.White;
            this.spadesLabel.Location = new System.Drawing.Point(786, 388);
            this.spadesLabel.Name = "spadesLabel";
            this.spadesLabel.Size = new System.Drawing.Size(56, 13);
            this.spadesLabel.TabIndex = 25;
            this.spadesLabel.Text = "SPADES";
            // 
            // drawCardButton
            // 
            this.drawCardButton.Location = new System.Drawing.Point(217, 23);
            this.drawCardButton.Name = "drawCardButton";
            this.drawCardButton.Size = new System.Drawing.Size(181, 58);
            this.drawCardButton.TabIndex = 26;
            this.drawCardButton.Text = "DRAW CARD";
            this.drawCardButton.UseVisualStyleBackColor = true;
            this.drawCardButton.Click += new System.EventHandler(this.drawCardButton_Click);
            // 
            // playCardBox
            // 
            this.playCardBox.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playCardBox.FormattingEnabled = true;
            this.playCardBox.ItemHeight = 15;
            this.playCardBox.Location = new System.Drawing.Point(217, 87);
            this.playCardBox.Name = "playCardBox";
            this.playCardBox.Size = new System.Drawing.Size(181, 19);
            this.playCardBox.TabIndex = 27;
            this.playCardBox.Click += new System.EventHandler(this.playCardBox_Click);
            // 
            // displayTimeLabel
            // 
            this.displayTimeLabel.AutoSize = true;
            this.displayTimeLabel.BackColor = System.Drawing.Color.Transparent;
            this.displayTimeLabel.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.displayTimeLabel.ForeColor = System.Drawing.Color.White;
            this.displayTimeLabel.Location = new System.Drawing.Point(416, 68);
            this.displayTimeLabel.Name = "displayTimeLabel";
            this.displayTimeLabel.Size = new System.Drawing.Size(120, 32);
            this.displayTimeLabel.TabIndex = 28;
            this.displayTimeLabel.Text = "TIME    :";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Final_Project_Rams_Solitaire.Properties.Resources.poker_table;
            this.ClientSize = new System.Drawing.Size(928, 484);
            this.Controls.Add(this.displayTimeLabel);
            this.Controls.Add(this.playCardBox);
            this.Controls.Add(this.drawCardButton);
            this.Controls.Add(this.spadesLabel);
            this.Controls.Add(this.diamondsLabel);
            this.Controls.Add(this.clubsLabel);
            this.Controls.Add(this.heartsLabel);
            this.Controls.Add(this.spadesBox);
            this.Controls.Add(this.diamondsBox);
            this.Controls.Add(this.clubsBox);
            this.Controls.Add(this.heartsBox);
            this.Controls.Add(this.movesNumber);
            this.Controls.Add(this.lineBox7);
            this.Controls.Add(this.lineBox6);
            this.Controls.Add(this.lineBox5);
            this.Controls.Add(this.lineBox4);
            this.Controls.Add(this.lineBox3);
            this.Controls.Add(this.lineBox2);
            this.Controls.Add(this.lineBox1);
            this.Controls.Add(this.secLabel);
            this.Controls.Add(this.minLabel);
            this.Controls.Add(this.loadButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Rams Solitaire";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button loadButton;
        private System.Windows.Forms.Timer gameTimer;
        private System.Windows.Forms.Label minLabel;
        private System.Windows.Forms.Label secLabel;
        private System.Windows.Forms.ListBox lineBox1;
        private System.Windows.Forms.ListBox lineBox2;
        private System.Windows.Forms.ListBox lineBox3;
        private System.Windows.Forms.ListBox lineBox4;
        private System.Windows.Forms.ListBox lineBox5;
        private System.Windows.Forms.ListBox lineBox6;
        private System.Windows.Forms.ListBox lineBox7;
        private System.Windows.Forms.Label movesNumber;
        private System.Windows.Forms.ListBox heartsBox;
        private System.Windows.Forms.ListBox clubsBox;
        private System.Windows.Forms.ListBox diamondsBox;
        private System.Windows.Forms.ListBox spadesBox;
        private System.Windows.Forms.Label heartsLabel;
        private System.Windows.Forms.Label clubsLabel;
        private System.Windows.Forms.Label diamondsLabel;
        private System.Windows.Forms.Label spadesLabel;
        private System.Windows.Forms.Button drawCardButton;
        private System.Windows.Forms.ListBox playCardBox;
        private System.Windows.Forms.Label displayTimeLabel;
    }
}

