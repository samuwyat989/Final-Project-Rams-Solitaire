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
            this.moveButton = new System.Windows.Forms.Button();
            this.line1 = new System.Windows.Forms.TextBox();
            this.line4 = new System.Windows.Forms.TextBox();
            this.line3 = new System.Windows.Forms.TextBox();
            this.line2 = new System.Windows.Forms.TextBox();
            this.line5 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // moveButton
            // 
            this.moveButton.Location = new System.Drawing.Point(276, 81);
            this.moveButton.Name = "moveButton";
            this.moveButton.Size = new System.Drawing.Size(75, 23);
            this.moveButton.TabIndex = 0;
            this.moveButton.Text = "MOVE";
            this.moveButton.UseVisualStyleBackColor = true;
            this.moveButton.Click += new System.EventHandler(this.moveButton_Click);
            // 
            // line1
            // 
            this.line1.Location = new System.Drawing.Point(48, 131);
            this.line1.Multiline = true;
            this.line1.Name = "line1";
            this.line1.Size = new System.Drawing.Size(100, 149);
            this.line1.TabIndex = 1;
            // 
            // line4
            // 
            this.line4.Location = new System.Drawing.Point(366, 131);
            this.line4.Multiline = true;
            this.line4.Name = "line4";
            this.line4.Size = new System.Drawing.Size(100, 149);
            this.line4.TabIndex = 2;
            // 
            // line3
            // 
            this.line3.Location = new System.Drawing.Point(260, 131);
            this.line3.Multiline = true;
            this.line3.Name = "line3";
            this.line3.Size = new System.Drawing.Size(100, 149);
            this.line3.TabIndex = 3;
            // 
            // line2
            // 
            this.line2.Location = new System.Drawing.Point(154, 131);
            this.line2.Multiline = true;
            this.line2.Name = "line2";
            this.line2.Size = new System.Drawing.Size(100, 149);
            this.line2.TabIndex = 4;
            // 
            // line5
            // 
            this.line5.Location = new System.Drawing.Point(472, 131);
            this.line5.Multiline = true;
            this.line5.Name = "line5";
            this.line5.Size = new System.Drawing.Size(100, 149);
            this.line5.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(656, 484);
            this.Controls.Add(this.line5);
            this.Controls.Add(this.line2);
            this.Controls.Add(this.line3);
            this.Controls.Add(this.line4);
            this.Controls.Add(this.line1);
            this.Controls.Add(this.moveButton);
            this.Name = "Form1";
            this.Text = "Rams Solitaire";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button moveButton;
        private System.Windows.Forms.TextBox line1;
        private System.Windows.Forms.TextBox line4;
        private System.Windows.Forms.TextBox line3;
        private System.Windows.Forms.TextBox line2;
        private System.Windows.Forms.TextBox line5;
    }
}

