namespace FongP3LogoStore
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
            this.orderNumLabel = new System.Windows.Forms.Label();
            this.orderNumtxtBox = new System.Windows.Forms.TextBox();
            this.numOfItemsLbl = new System.Windows.Forms.Label();
            this.numOfItemsTxtBx = new System.Windows.Forms.TextBox();
            this.radioGroupBox = new System.Windows.Forms.GroupBox();
            this.PenRadioButton = new System.Windows.Forms.RadioButton();
            this.mugRadioButton = new System.Windows.Forms.RadioButton();
            this.usbRadioButton = new System.Windows.Forms.RadioButton();
            this.textToLabelLbl = new System.Windows.Forms.Label();
            this.textToEngravetextBox = new System.Windows.Forms.TextBox();
            this.logoCheckBox = new System.Windows.Forms.CheckBox();
            this.numOfColorsLbl = new System.Windows.Forms.Label();
            this.numOfColorsTxtBox = new System.Windows.Forms.TextBox();
            this.submitButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.orderSummary = new System.Windows.Forms.TextBox();
            this.radioGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // orderNumLabel
            // 
            this.orderNumLabel.AutoEllipsis = true;
            this.orderNumLabel.AutoSize = true;
            this.orderNumLabel.Location = new System.Drawing.Point(42, 31);
            this.orderNumLabel.Name = "orderNumLabel";
            this.orderNumLabel.Size = new System.Drawing.Size(73, 13);
            this.orderNumLabel.TabIndex = 0;
            this.orderNumLabel.Text = "Order Number\r\n";
            // 
            // orderNumtxtBox
            // 
            this.orderNumtxtBox.Location = new System.Drawing.Point(162, 28);
            this.orderNumtxtBox.Name = "orderNumtxtBox";
            this.orderNumtxtBox.Size = new System.Drawing.Size(171, 20);
            this.orderNumtxtBox.TabIndex = 1;
            // 
            // numOfItemsLbl
            // 
            this.numOfItemsLbl.AutoSize = true;
            this.numOfItemsLbl.Location = new System.Drawing.Point(42, 66);
            this.numOfItemsLbl.Name = "numOfItemsLbl";
            this.numOfItemsLbl.Size = new System.Drawing.Size(84, 13);
            this.numOfItemsLbl.TabIndex = 2;
            this.numOfItemsLbl.Text = "Number of Items";
            // 
            // numOfItemsTxtBx
            // 
            this.numOfItemsTxtBx.Location = new System.Drawing.Point(162, 63);
            this.numOfItemsTxtBx.Name = "numOfItemsTxtBx";
            this.numOfItemsTxtBx.Size = new System.Drawing.Size(171, 20);
            this.numOfItemsTxtBx.TabIndex = 3;
            // 
            // radioGroupBox
            // 
            this.radioGroupBox.Controls.Add(this.PenRadioButton);
            this.radioGroupBox.Controls.Add(this.mugRadioButton);
            this.radioGroupBox.Controls.Add(this.usbRadioButton);
            this.radioGroupBox.Location = new System.Drawing.Point(162, 112);
            this.radioGroupBox.Name = "radioGroupBox";
            this.radioGroupBox.Size = new System.Drawing.Size(171, 100);
            this.radioGroupBox.TabIndex = 4;
            this.radioGroupBox.TabStop = false;
            this.radioGroupBox.Text = "Item Type";
            // 
            // PenRadioButton
            // 
            this.PenRadioButton.AutoSize = true;
            this.PenRadioButton.Location = new System.Drawing.Point(17, 71);
            this.PenRadioButton.Name = "PenRadioButton";
            this.PenRadioButton.Size = new System.Drawing.Size(44, 17);
            this.PenRadioButton.TabIndex = 2;
            this.PenRadioButton.Text = "Pen";
            this.PenRadioButton.UseVisualStyleBackColor = true;
            // 
            // mugRadioButton
            // 
            this.mugRadioButton.AutoSize = true;
            this.mugRadioButton.Checked = true;
            this.mugRadioButton.Location = new System.Drawing.Point(17, 47);
            this.mugRadioButton.Name = "mugRadioButton";
            this.mugRadioButton.Size = new System.Drawing.Size(46, 17);
            this.mugRadioButton.TabIndex = 1;
            this.mugRadioButton.TabStop = true;
            this.mugRadioButton.Text = "Mug";
            this.mugRadioButton.UseVisualStyleBackColor = true;
            // 
            // usbRadioButton
            // 
            this.usbRadioButton.AutoSize = true;
            this.usbRadioButton.Location = new System.Drawing.Point(17, 23);
            this.usbRadioButton.Name = "usbRadioButton";
            this.usbRadioButton.Size = new System.Drawing.Size(47, 17);
            this.usbRadioButton.TabIndex = 0;
            this.usbRadioButton.TabStop = true;
            this.usbRadioButton.Text = "USB";
            this.usbRadioButton.UseVisualStyleBackColor = true;
            // 
            // textToLabelLbl
            // 
            this.textToLabelLbl.AutoSize = true;
            this.textToLabelLbl.Location = new System.Drawing.Point(45, 237);
            this.textToLabelLbl.Name = "textToLabelLbl";
            this.textToLabelLbl.Size = new System.Drawing.Size(110, 13);
            this.textToLabelLbl.TabIndex = 5;
            this.textToLabelLbl.Text = "Text to engrave/print:";
            // 
            // textToEngravetextBox
            // 
            this.textToEngravetextBox.Location = new System.Drawing.Point(30, 237);
            this.textToEngravetextBox.Multiline = true;
            this.textToEngravetextBox.Name = "textToEngravetextBox";
            this.textToEngravetextBox.Size = new System.Drawing.Size(285, 56);
            this.textToEngravetextBox.TabIndex = 6;
            // 
            // logoCheckBox
            // 
            this.logoCheckBox.AutoSize = true;
            this.logoCheckBox.Location = new System.Drawing.Point(179, 322);
            this.logoCheckBox.Name = "logoCheckBox";
            this.logoCheckBox.Size = new System.Drawing.Size(56, 17);
            this.logoCheckBox.TabIndex = 7;
            this.logoCheckBox.Text = "Logo?";
            this.logoCheckBox.UseVisualStyleBackColor = true;
            this.logoCheckBox.CheckedChanged += new System.EventHandler(this.logoCheckBox_CheckedChanged);
            // 
            // numOfColorsLbl
            // 
            this.numOfColorsLbl.AutoSize = true;
            this.numOfColorsLbl.Location = new System.Drawing.Point(45, 348);
            this.numOfColorsLbl.Name = "numOfColorsLbl";
            this.numOfColorsLbl.Size = new System.Drawing.Size(91, 13);
            this.numOfColorsLbl.TabIndex = 8;
            this.numOfColorsLbl.Text = "Number of Colors:";
            this.numOfColorsLbl.Visible = false;
            // 
            // numOfColorsTxtBox
            // 
            this.numOfColorsTxtBox.Location = new System.Drawing.Point(179, 345);
            this.numOfColorsTxtBox.Name = "numOfColorsTxtBox";
            this.numOfColorsTxtBox.Size = new System.Drawing.Size(154, 20);
            this.numOfColorsTxtBox.TabIndex = 9;
            this.numOfColorsTxtBox.Visible = false;
            // 
            // submitButton
            // 
            this.submitButton.Location = new System.Drawing.Point(93, 386);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(75, 39);
            this.submitButton.TabIndex = 10;
            this.submitButton.Text = "Submit";
            this.submitButton.UseVisualStyleBackColor = true;
            this.submitButton.Click += new System.EventHandler(this.submitButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(198, 386);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(75, 39);
            this.clearButton.TabIndex = 11;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // orderSummary
            // 
            this.orderSummary.Location = new System.Drawing.Point(12, 439);
            this.orderSummary.Multiline = true;
            this.orderSummary.Name = "orderSummary";
            this.orderSummary.Size = new System.Drawing.Size(346, 96);
            this.orderSummary.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(370, 547);
            this.Controls.Add(this.orderSummary);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.submitButton);
            this.Controls.Add(this.numOfColorsTxtBox);
            this.Controls.Add(this.numOfColorsLbl);
            this.Controls.Add(this.logoCheckBox);
            this.Controls.Add(this.textToEngravetextBox);
            this.Controls.Add(this.textToLabelLbl);
            this.Controls.Add(this.radioGroupBox);
            this.Controls.Add(this.numOfItemsTxtBx);
            this.Controls.Add(this.numOfItemsLbl);
            this.Controls.Add(this.orderNumtxtBox);
            this.Controls.Add(this.orderNumLabel);
            this.Name = "Form1";
            this.Text = "Logo Items Order Form";
            this.radioGroupBox.ResumeLayout(false);
            this.radioGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label orderNumLabel;
        private System.Windows.Forms.TextBox orderNumtxtBox;
        private System.Windows.Forms.Label numOfItemsLbl;
        private System.Windows.Forms.TextBox numOfItemsTxtBx;
        private System.Windows.Forms.GroupBox radioGroupBox;
        private System.Windows.Forms.RadioButton PenRadioButton;
        private System.Windows.Forms.RadioButton mugRadioButton;
        private System.Windows.Forms.RadioButton usbRadioButton;
        private System.Windows.Forms.Label textToLabelLbl;
        private System.Windows.Forms.TextBox textToEngravetextBox;
        private System.Windows.Forms.CheckBox logoCheckBox;
        private System.Windows.Forms.Label numOfColorsLbl;
        private System.Windows.Forms.TextBox numOfColorsTxtBox;
        private System.Windows.Forms.Button submitButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.TextBox orderSummary;
    }
}

