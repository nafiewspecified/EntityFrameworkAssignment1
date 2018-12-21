namespace EntityFramworkAssignment1
{
    partial class CustomerUI
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
            this.CategoryCombobox = new System.Windows.Forms.ComboBox();
            this.categoryVMBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.AddressTextBox = new System.Windows.Forms.TextBox();
            this.ContactNoTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.maleRadioButton = new System.Windows.Forms.RadioButton();
            this.femaleRadioButton = new System.Windows.Forms.RadioButton();
            this.otherRadioButton = new System.Windows.Forms.RadioButton();
            this.computerCheckbox = new System.Windows.Forms.CheckBox();
            this.upsCheckBox = new System.Windows.Forms.CheckBox();
            this.airConditionCheckBox = new System.Windows.Forms.CheckBox();
            this.FreezeCheckBox = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.ReceiptButton = new System.Windows.Forms.Button();
            this.genderLabel = new System.Windows.Forms.Label();
            this.customerLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.categoryVMBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // CategoryCombobox
            // 
            this.CategoryCombobox.DataSource = this.categoryVMBindingSource;
            this.CategoryCombobox.DisplayMember = "Name";
            this.CategoryCombobox.FormattingEnabled = true;
            this.CategoryCombobox.Location = new System.Drawing.Point(200, 41);
            this.CategoryCombobox.Name = "CategoryCombobox";
            this.CategoryCombobox.Size = new System.Drawing.Size(313, 21);
            this.CategoryCombobox.TabIndex = 0;
            this.CategoryCombobox.ValueMember = "Id";
            // 
            // categoryVMBindingSource
            // 
            this.categoryVMBindingSource.DataSource = typeof(EF.Models.CategoryVM);
            // 
            // NameTextBox
            // 
            this.NameTextBox.Location = new System.Drawing.Point(200, 94);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(313, 20);
            this.NameTextBox.TabIndex = 1;
            // 
            // AddressTextBox
            // 
            this.AddressTextBox.Location = new System.Drawing.Point(200, 216);
            this.AddressTextBox.Multiline = true;
            this.AddressTextBox.Name = "AddressTextBox";
            this.AddressTextBox.Size = new System.Drawing.Size(313, 60);
            this.AddressTextBox.TabIndex = 1;
            // 
            // ContactNoTextBox
            // 
            this.ContactNoTextBox.Location = new System.Drawing.Point(200, 138);
            this.ContactNoTextBox.Name = "ContactNoTextBox";
            this.ContactNoTextBox.Size = new System.Drawing.Size(313, 20);
            this.ContactNoTextBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(104, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Category";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(118, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(108, 237);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Address";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(104, 141);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "ContactNo";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(111, 178);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Gender";
            // 
            // maleRadioButton
            // 
            this.maleRadioButton.AutoSize = true;
            this.maleRadioButton.Location = new System.Drawing.Point(212, 178);
            this.maleRadioButton.Name = "maleRadioButton";
            this.maleRadioButton.Size = new System.Drawing.Size(48, 17);
            this.maleRadioButton.TabIndex = 5;
            this.maleRadioButton.TabStop = true;
            this.maleRadioButton.Text = "Male";
            this.maleRadioButton.UseVisualStyleBackColor = true;
            // 
            // femaleRadioButton
            // 
            this.femaleRadioButton.AutoSize = true;
            this.femaleRadioButton.Location = new System.Drawing.Point(284, 178);
            this.femaleRadioButton.Name = "femaleRadioButton";
            this.femaleRadioButton.Size = new System.Drawing.Size(59, 17);
            this.femaleRadioButton.TabIndex = 5;
            this.femaleRadioButton.TabStop = true;
            this.femaleRadioButton.Text = "Female";
            this.femaleRadioButton.UseVisualStyleBackColor = true;
            // 
            // otherRadioButton
            // 
            this.otherRadioButton.AutoSize = true;
            this.otherRadioButton.Location = new System.Drawing.Point(379, 178);
            this.otherRadioButton.Name = "otherRadioButton";
            this.otherRadioButton.Size = new System.Drawing.Size(51, 17);
            this.otherRadioButton.TabIndex = 5;
            this.otherRadioButton.TabStop = true;
            this.otherRadioButton.Text = "Other";
            this.otherRadioButton.UseVisualStyleBackColor = true;
            // 
            // computerCheckbox
            // 
            this.computerCheckbox.AutoSize = true;
            this.computerCheckbox.Location = new System.Drawing.Point(200, 300);
            this.computerCheckbox.Name = "computerCheckbox";
            this.computerCheckbox.Size = new System.Drawing.Size(71, 17);
            this.computerCheckbox.TabIndex = 6;
            this.computerCheckbox.Text = "Computer";
            this.computerCheckbox.UseVisualStyleBackColor = true;
            // 
            // upsCheckBox
            // 
            this.upsCheckBox.AutoSize = true;
            this.upsCheckBox.Location = new System.Drawing.Point(277, 301);
            this.upsCheckBox.Name = "upsCheckBox";
            this.upsCheckBox.Size = new System.Drawing.Size(48, 17);
            this.upsCheckBox.TabIndex = 6;
            this.upsCheckBox.Text = "UPS";
            this.upsCheckBox.UseVisualStyleBackColor = true;
            // 
            // airConditionCheckBox
            // 
            this.airConditionCheckBox.AutoSize = true;
            this.airConditionCheckBox.Location = new System.Drawing.Point(345, 297);
            this.airConditionCheckBox.Name = "airConditionCheckBox";
            this.airConditionCheckBox.Size = new System.Drawing.Size(85, 17);
            this.airConditionCheckBox.TabIndex = 6;
            this.airConditionCheckBox.Text = "Air Condition";
            this.airConditionCheckBox.UseVisualStyleBackColor = true;
            // 
            // FreezeCheckBox
            // 
            this.FreezeCheckBox.AutoSize = true;
            this.FreezeCheckBox.Location = new System.Drawing.Point(469, 301);
            this.FreezeCheckBox.Name = "FreezeCheckBox";
            this.FreezeCheckBox.Size = new System.Drawing.Size(58, 17);
            this.FreezeCheckBox.TabIndex = 6;
            this.FreezeCheckBox.Text = "Freeze";
            this.FreezeCheckBox.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(108, 301);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Choice Subject";
            // 
            // ReceiptButton
            // 
            this.ReceiptButton.Location = new System.Drawing.Point(421, 361);
            this.ReceiptButton.Name = "ReceiptButton";
            this.ReceiptButton.Size = new System.Drawing.Size(75, 23);
            this.ReceiptButton.TabIndex = 7;
            this.ReceiptButton.Text = "Receipt";
            this.ReceiptButton.UseVisualStyleBackColor = true;
            this.ReceiptButton.Click += new System.EventHandler(this.ReceiptButton_Click);
            // 
            // genderLabel
            // 
            this.genderLabel.AutoSize = true;
            this.genderLabel.Location = new System.Drawing.Point(209, 198);
            this.genderLabel.Name = "genderLabel";
            this.genderLabel.Size = new System.Drawing.Size(0, 13);
            this.genderLabel.TabIndex = 8;
            // 
            // customerLabel
            // 
            this.customerLabel.AutoSize = true;
            this.customerLabel.Location = new System.Drawing.Point(197, 25);
            this.customerLabel.Name = "customerLabel";
            this.customerLabel.Size = new System.Drawing.Size(0, 13);
            this.customerLabel.TabIndex = 9;
            // 
            // CustomerUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(616, 429);
            this.Controls.Add(this.customerLabel);
            this.Controls.Add(this.genderLabel);
            this.Controls.Add(this.ReceiptButton);
            this.Controls.Add(this.FreezeCheckBox);
            this.Controls.Add(this.airConditionCheckBox);
            this.Controls.Add(this.upsCheckBox);
            this.Controls.Add(this.computerCheckbox);
            this.Controls.Add(this.otherRadioButton);
            this.Controls.Add(this.femaleRadioButton);
            this.Controls.Add(this.maleRadioButton);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ContactNoTextBox);
            this.Controls.Add(this.AddressTextBox);
            this.Controls.Add(this.NameTextBox);
            this.Controls.Add(this.CategoryCombobox);
            this.Name = "CustomerUI";
            this.Text = "CustomerUI";
            this.Load += new System.EventHandler(this.CustomerUI_Load);
            ((System.ComponentModel.ISupportInitialize)(this.categoryVMBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox CategoryCombobox;
        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.TextBox AddressTextBox;
        private System.Windows.Forms.TextBox ContactNoTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton maleRadioButton;
        private System.Windows.Forms.RadioButton femaleRadioButton;
        private System.Windows.Forms.RadioButton otherRadioButton;
        private System.Windows.Forms.CheckBox computerCheckbox;
        private System.Windows.Forms.CheckBox upsCheckBox;
        private System.Windows.Forms.CheckBox airConditionCheckBox;
        private System.Windows.Forms.CheckBox FreezeCheckBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button ReceiptButton;
        private System.Windows.Forms.BindingSource categoryVMBindingSource;
        private System.Windows.Forms.Label genderLabel;
        private System.Windows.Forms.Label customerLabel;
    }
}