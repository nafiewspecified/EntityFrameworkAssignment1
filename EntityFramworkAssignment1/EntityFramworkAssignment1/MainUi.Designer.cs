namespace EntityFramworkAssignment1
{
    partial class MainUi
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
            this.CategoryButton = new System.Windows.Forms.Button();
            this.SalesButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CategoryButton
            // 
            this.CategoryButton.Location = new System.Drawing.Point(158, 31);
            this.CategoryButton.Name = "CategoryButton";
            this.CategoryButton.Size = new System.Drawing.Size(116, 42);
            this.CategoryButton.TabIndex = 0;
            this.CategoryButton.Text = "Category";
            this.CategoryButton.UseVisualStyleBackColor = true;
            this.CategoryButton.Click += new System.EventHandler(this.CategoryButton_Click);
            // 
            // SalesButton
            // 
            this.SalesButton.Location = new System.Drawing.Point(295, 31);
            this.SalesButton.Name = "SalesButton";
            this.SalesButton.Size = new System.Drawing.Size(115, 42);
            this.SalesButton.TabIndex = 1;
            this.SalesButton.Text = "Sales";
            this.SalesButton.UseVisualStyleBackColor = true;
            this.SalesButton.Click += new System.EventHandler(this.SalesButton_Click);
            // 
            // MainUi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1189, 531);
            this.Controls.Add(this.SalesButton);
            this.Controls.Add(this.CategoryButton);
            this.Name = "MainUi";
            this.Text = "Customer Entry UI";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button CategoryButton;
        private System.Windows.Forms.Button SalesButton;
    }
}

