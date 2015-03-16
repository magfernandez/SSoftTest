namespace WindowsFormsApplication1
{
    partial class theMainForm
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
            this.theButtonOne = new System.Windows.Forms.Button();
            this.theButtonTwo = new System.Windows.Forms.Button();
            this.theTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // theButtonOne
            // 
            this.theButtonOne.Location = new System.Drawing.Point(12, 12);
            this.theButtonOne.Name = "theButtonOne";
            this.theButtonOne.Size = new System.Drawing.Size(110, 23);
            this.theButtonOne.TabIndex = 0;
            this.theButtonOne.Text = "B1";
            this.theButtonOne.UseVisualStyleBackColor = true;
            this.theButtonOne.Click += new System.EventHandler(this.on_theButtonOne_clicked);
            // 
            // theButtonTwo
            // 
            this.theButtonTwo.Location = new System.Drawing.Point(128, 12);
            this.theButtonTwo.Name = "theButtonTwo";
            this.theButtonTwo.Size = new System.Drawing.Size(109, 23);
            this.theButtonTwo.TabIndex = 1;
            this.theButtonTwo.Text = "B2";
            this.theButtonTwo.UseVisualStyleBackColor = true;
            this.theButtonTwo.Click += new System.EventHandler(this.on_theButtonTwo_clicked);
            // 
            // theTextBox
            // 
            this.theTextBox.Location = new System.Drawing.Point(84, 41);
            this.theTextBox.Name = "theTextBox";
            this.theTextBox.Size = new System.Drawing.Size(82, 20);
            this.theTextBox.TabIndex = 2;
            this.theTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // theMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(249, 76);
            this.Controls.Add(this.theTextBox);
            this.Controls.Add(this.theButtonTwo);
            this.Controls.Add(this.theButtonOne);
            this.Name = "theMainForm";
            this.Text = "Window";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button theButtonOne;
        private System.Windows.Forms.Button theButtonTwo;
        private System.Windows.Forms.TextBox theTextBox;
    }
}

