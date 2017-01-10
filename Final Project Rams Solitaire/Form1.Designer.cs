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
            this.SuspendLayout();
            // 
            // moveButton
            // 
            this.moveButton.Location = new System.Drawing.Point(28, 41);
            this.moveButton.Name = "moveButton";
            this.moveButton.Size = new System.Drawing.Size(75, 23);
            this.moveButton.TabIndex = 0;
            this.moveButton.Text = "MOVE";
            this.moveButton.UseVisualStyleBackColor = true;
            this.moveButton.Click += new System.EventHandler(this.moveButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(656, 484);
            this.Controls.Add(this.moveButton);
            this.Name = "Form1";
            this.Text = "Rams Solitaire";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button moveButton;
    }
}

