
namespace assignment1
{
    partial class MainGroup
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.fromGroup = new System.Windows.Forms.GroupBox();
            this.fromYEN = new System.Windows.Forms.RadioButton();
            this.fromRMB = new System.Windows.Forms.RadioButton();
            this.fromINR = new System.Windows.Forms.RadioButton();
            this.fromAED = new System.Windows.Forms.RadioButton();
            this.fromEUR = new System.Windows.Forms.RadioButton();
            this.fromCAD = new System.Windows.Forms.RadioButton();
            this.fromNZD = new System.Windows.Forms.RadioButton();
            this.fromAUD = new System.Windows.Forms.RadioButton();
            this.fromUSD = new System.Windows.Forms.RadioButton();
            this.toGroup = new System.Windows.Forms.GroupBox();
            this.toYEN = new System.Windows.Forms.RadioButton();
            this.toRMB = new System.Windows.Forms.RadioButton();
            this.toINR = new System.Windows.Forms.RadioButton();
            this.toAED = new System.Windows.Forms.RadioButton();
            this.toEUR = new System.Windows.Forms.RadioButton();
            this.toCAD = new System.Windows.Forms.RadioButton();
            this.toNZD = new System.Windows.Forms.RadioButton();
            this.toAUD = new System.Windows.Forms.RadioButton();
            this.toUSD = new System.Windows.Forms.RadioButton();
            this.nameLabel = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.dateLabel = new System.Windows.Forms.Label();
            this.SeePhotoCheckBox = new System.Windows.Forms.CheckBox();
            this.helloNameLabel = new System.Windows.Forms.Label();
            this.conversionOutputLabel = new System.Windows.Forms.Label();
            this.amountInput = new System.Windows.Forms.NumericUpDown();
            this.infoLabel = new System.Windows.Forms.Label();
            this.fromLabel = new System.Windows.Forms.Label();
            this.toLabel = new System.Windows.Forms.Label();
            this.additionalInfoLabel = new System.Windows.Forms.Label();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.Convert = new System.Windows.Forms.Button();
            this.Timer = new System.Windows.Forms.Timer(this.components);
            this.fromGroup.SuspendLayout();
            this.toGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.amountInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // fromGroup
            // 
            this.fromGroup.Controls.Add(this.fromYEN);
            this.fromGroup.Controls.Add(this.fromRMB);
            this.fromGroup.Controls.Add(this.fromINR);
            this.fromGroup.Controls.Add(this.fromAED);
            this.fromGroup.Controls.Add(this.fromEUR);
            this.fromGroup.Controls.Add(this.fromCAD);
            this.fromGroup.Controls.Add(this.fromNZD);
            this.fromGroup.Controls.Add(this.fromAUD);
            this.fromGroup.Controls.Add(this.fromUSD);
            this.fromGroup.Location = new System.Drawing.Point(89, 255);
            this.fromGroup.Name = "fromGroup";
            this.fromGroup.Size = new System.Drawing.Size(266, 122);
            this.fromGroup.TabIndex = 0;
            this.fromGroup.TabStop = false;
            this.fromGroup.Text = "Please select money you want to convert from";
            // 
            // fromYEN
            // 
            this.fromYEN.AutoSize = true;
            this.fromYEN.Location = new System.Drawing.Point(193, 84);
            this.fromYEN.Name = "fromYEN";
            this.fromYEN.Size = new System.Drawing.Size(47, 19);
            this.fromYEN.TabIndex = 8;
            this.fromYEN.Text = "YEN";
            this.fromYEN.UseVisualStyleBackColor = true;
            // 
            // fromRMB
            // 
            this.fromRMB.AutoSize = true;
            this.fromRMB.Location = new System.Drawing.Point(193, 59);
            this.fromRMB.Name = "fromRMB";
            this.fromRMB.Size = new System.Drawing.Size(50, 19);
            this.fromRMB.TabIndex = 7;
            this.fromRMB.Text = "RMB";
            this.fromRMB.UseVisualStyleBackColor = true;
            // 
            // fromINR
            // 
            this.fromINR.AutoSize = true;
            this.fromINR.Location = new System.Drawing.Point(193, 33);
            this.fromINR.Name = "fromINR";
            this.fromINR.Size = new System.Drawing.Size(44, 19);
            this.fromINR.TabIndex = 6;
            this.fromINR.Text = "INR";
            this.fromINR.UseVisualStyleBackColor = true;
            // 
            // fromAED
            // 
            this.fromAED.AutoSize = true;
            this.fromAED.Location = new System.Drawing.Point(111, 85);
            this.fromAED.Name = "fromAED";
            this.fromAED.Size = new System.Drawing.Size(47, 19);
            this.fromAED.TabIndex = 5;
            this.fromAED.Text = "AED";
            this.fromAED.UseVisualStyleBackColor = true;
            // 
            // fromEUR
            // 
            this.fromEUR.AutoSize = true;
            this.fromEUR.Location = new System.Drawing.Point(111, 59);
            this.fromEUR.Name = "fromEUR";
            this.fromEUR.Size = new System.Drawing.Size(46, 19);
            this.fromEUR.TabIndex = 4;
            this.fromEUR.Text = "EUR";
            this.fromEUR.UseVisualStyleBackColor = true;
            // 
            // fromCAD
            // 
            this.fromCAD.AutoSize = true;
            this.fromCAD.Location = new System.Drawing.Point(111, 33);
            this.fromCAD.Name = "fromCAD";
            this.fromCAD.Size = new System.Drawing.Size(49, 19);
            this.fromCAD.TabIndex = 3;
            this.fromCAD.Text = "CAD";
            this.fromCAD.UseVisualStyleBackColor = true;
            // 
            // fromNZD
            // 
            this.fromNZD.AutoSize = true;
            this.fromNZD.Location = new System.Drawing.Point(30, 85);
            this.fromNZD.Name = "fromNZD";
            this.fromNZD.Size = new System.Drawing.Size(49, 19);
            this.fromNZD.TabIndex = 2;
            this.fromNZD.Text = "NZD";
            this.fromNZD.UseVisualStyleBackColor = true;
            // 
            // fromAUD
            // 
            this.fromAUD.AutoSize = true;
            this.fromAUD.Location = new System.Drawing.Point(30, 59);
            this.fromAUD.Name = "fromAUD";
            this.fromAUD.Size = new System.Drawing.Size(49, 19);
            this.fromAUD.TabIndex = 1;
            this.fromAUD.Text = "AUD";
            this.fromAUD.UseVisualStyleBackColor = true;
            // 
            // fromUSD
            // 
            this.fromUSD.AutoSize = true;
            this.fromUSD.Checked = true;
            this.fromUSD.Location = new System.Drawing.Point(30, 33);
            this.fromUSD.Name = "fromUSD";
            this.fromUSD.Size = new System.Drawing.Size(47, 19);
            this.fromUSD.TabIndex = 0;
            this.fromUSD.TabStop = true;
            this.fromUSD.Text = "USD";
            this.fromUSD.UseVisualStyleBackColor = true;
            // 
            // toGroup
            // 
            this.toGroup.Controls.Add(this.toYEN);
            this.toGroup.Controls.Add(this.toRMB);
            this.toGroup.Controls.Add(this.toINR);
            this.toGroup.Controls.Add(this.toAED);
            this.toGroup.Controls.Add(this.toEUR);
            this.toGroup.Controls.Add(this.toCAD);
            this.toGroup.Controls.Add(this.toNZD);
            this.toGroup.Controls.Add(this.toAUD);
            this.toGroup.Controls.Add(this.toUSD);
            this.toGroup.Location = new System.Drawing.Point(439, 255);
            this.toGroup.Name = "toGroup";
            this.toGroup.Size = new System.Drawing.Size(266, 122);
            this.toGroup.TabIndex = 1;
            this.toGroup.TabStop = false;
            this.toGroup.Text = "Please select money you want to convert to";
            // 
            // toYEN
            // 
            this.toYEN.AutoSize = true;
            this.toYEN.Location = new System.Drawing.Point(193, 84);
            this.toYEN.Name = "toYEN";
            this.toYEN.Size = new System.Drawing.Size(47, 19);
            this.toYEN.TabIndex = 8;
            this.toYEN.Text = "YEN";
            this.toYEN.UseVisualStyleBackColor = true;
            // 
            // toRMB
            // 
            this.toRMB.AutoSize = true;
            this.toRMB.Location = new System.Drawing.Point(193, 59);
            this.toRMB.Name = "toRMB";
            this.toRMB.Size = new System.Drawing.Size(50, 19);
            this.toRMB.TabIndex = 7;
            this.toRMB.Text = "RMB";
            this.toRMB.UseVisualStyleBackColor = true;
            // 
            // toINR
            // 
            this.toINR.AutoSize = true;
            this.toINR.Location = new System.Drawing.Point(193, 33);
            this.toINR.Name = "toINR";
            this.toINR.Size = new System.Drawing.Size(44, 19);
            this.toINR.TabIndex = 6;
            this.toINR.Text = "INR";
            this.toINR.UseVisualStyleBackColor = true;
            // 
            // toAED
            // 
            this.toAED.AutoSize = true;
            this.toAED.Location = new System.Drawing.Point(111, 85);
            this.toAED.Name = "toAED";
            this.toAED.Size = new System.Drawing.Size(47, 19);
            this.toAED.TabIndex = 5;
            this.toAED.Text = "AED";
            this.toAED.UseVisualStyleBackColor = true;
            // 
            // toEUR
            // 
            this.toEUR.AutoSize = true;
            this.toEUR.Location = new System.Drawing.Point(111, 59);
            this.toEUR.Name = "toEUR";
            this.toEUR.Size = new System.Drawing.Size(46, 19);
            this.toEUR.TabIndex = 4;
            this.toEUR.Text = "EUR";
            this.toEUR.UseVisualStyleBackColor = true;
            // 
            // toCAD
            // 
            this.toCAD.AutoSize = true;
            this.toCAD.Location = new System.Drawing.Point(111, 33);
            this.toCAD.Name = "toCAD";
            this.toCAD.Size = new System.Drawing.Size(49, 19);
            this.toCAD.TabIndex = 3;
            this.toCAD.Text = "CAD";
            this.toCAD.UseVisualStyleBackColor = true;
            // 
            // toNZD
            // 
            this.toNZD.AutoSize = true;
            this.toNZD.Location = new System.Drawing.Point(30, 85);
            this.toNZD.Name = "toNZD";
            this.toNZD.Size = new System.Drawing.Size(49, 19);
            this.toNZD.TabIndex = 2;
            this.toNZD.Text = "NZD";
            this.toNZD.UseVisualStyleBackColor = true;
            // 
            // toAUD
            // 
            this.toAUD.AutoSize = true;
            this.toAUD.Location = new System.Drawing.Point(30, 59);
            this.toAUD.Name = "toAUD";
            this.toAUD.Size = new System.Drawing.Size(49, 19);
            this.toAUD.TabIndex = 1;
            this.toAUD.Text = "AUD";
            this.toAUD.UseVisualStyleBackColor = true;
            // 
            // toUSD
            // 
            this.toUSD.AutoSize = true;
            this.toUSD.Checked = true;
            this.toUSD.Location = new System.Drawing.Point(30, 33);
            this.toUSD.Name = "toUSD";
            this.toUSD.Size = new System.Drawing.Size(47, 19);
            this.toUSD.TabIndex = 0;
            this.toUSD.TabStop = true;
            this.toUSD.Text = "USD";
            this.toUSD.UseVisualStyleBackColor = true;
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(48, 46);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(71, 15);
            this.nameLabel.TabIndex = 2;
            this.nameLabel.Text = "My name is:";
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(124, 46);
            this.nameTextBox.MaxLength = 20;
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(100, 23);
            this.nameTextBox.TabIndex = 3;
            this.nameTextBox.Text = "James Satherley";
            // 
            // dateLabel
            // 
            this.dateLabel.AutoSize = true;
            this.dateLabel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.dateLabel.Location = new System.Drawing.Point(331, 24);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(0, 19);
            this.dateLabel.TabIndex = 4;
            // 
            // SeePhotoCheckBox
            // 
            this.SeePhotoCheckBox.AutoSize = true;
            this.SeePhotoCheckBox.Location = new System.Drawing.Point(675, 20);
            this.SeePhotoCheckBox.Name = "SeePhotoCheckBox";
            this.SeePhotoCheckBox.Size = new System.Drawing.Size(99, 19);
            this.SeePhotoCheckBox.TabIndex = 5;
            this.SeePhotoCheckBox.Text = "See My Photo";
            this.SeePhotoCheckBox.UseVisualStyleBackColor = true;
            this.SeePhotoCheckBox.CheckedChanged += new System.EventHandler(this.SeePhotoCheckBox_CheckedChanged);
            // 
            // helloNameLabel
            // 
            this.helloNameLabel.AutoSize = true;
            this.helloNameLabel.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.helloNameLabel.Location = new System.Drawing.Point(48, 84);
            this.helloNameLabel.Name = "helloNameLabel";
            this.helloNameLabel.Size = new System.Drawing.Size(0, 20);
            this.helloNameLabel.TabIndex = 7;
            // 
            // conversionOutputLabel
            // 
            this.conversionOutputLabel.AutoSize = true;
            this.conversionOutputLabel.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.conversionOutputLabel.Location = new System.Drawing.Point(48, 114);
            this.conversionOutputLabel.Name = "conversionOutputLabel";
            this.conversionOutputLabel.Size = new System.Drawing.Size(0, 20);
            this.conversionOutputLabel.TabIndex = 8;
            // 
            // amountInput
            // 
            this.amountInput.DecimalPlaces = 2;
            this.amountInput.Location = new System.Drawing.Point(335, 215);
            this.amountInput.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.amountInput.Name = "amountInput";
            this.amountInput.Size = new System.Drawing.Size(120, 23);
            this.amountInput.TabIndex = 9;
            // 
            // infoLabel
            // 
            this.infoLabel.AutoSize = true;
            this.infoLabel.Location = new System.Drawing.Point(214, 217);
            this.infoLabel.Name = "infoLabel";
            this.infoLabel.Size = new System.Drawing.Size(99, 15);
            this.infoLabel.TabIndex = 10;
            this.infoLabel.Text = "I want to convert:";
            // 
            // fromLabel
            // 
            this.fromLabel.AutoSize = true;
            this.fromLabel.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.fromLabel.Location = new System.Drawing.Point(37, 305);
            this.fromLabel.Name = "fromLabel";
            this.fromLabel.Size = new System.Drawing.Size(50, 20);
            this.fromLabel.TabIndex = 12;
            this.fromLabel.Text = "From:";
            // 
            // toLabel
            // 
            this.toLabel.AutoSize = true;
            this.toLabel.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.toLabel.Location = new System.Drawing.Point(406, 305);
            this.toLabel.Name = "toLabel";
            this.toLabel.Size = new System.Drawing.Size(30, 20);
            this.toLabel.TabIndex = 13;
            this.toLabel.Text = "To:";
            // 
            // additionalInfoLabel
            // 
            this.additionalInfoLabel.AutoSize = true;
            this.additionalInfoLabel.Font = new System.Drawing.Font("Segoe UI", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.additionalInfoLabel.Location = new System.Drawing.Point(478, 217);
            this.additionalInfoLabel.Name = "additionalInfoLabel";
            this.additionalInfoLabel.Size = new System.Drawing.Size(185, 12);
            this.additionalInfoLabel.TabIndex = 14;
            this.additionalInfoLabel.Text = "(Amount of money you want to convert)";
            // 
            // pictureBox
            // 
            this.pictureBox.Image = global::assignment1.Properties.Resources._55837897_760005321051181_6570805272841814016_o;
            this.pictureBox.Location = new System.Drawing.Point(655, 46);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(120, 119);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox.TabIndex = 15;
            this.pictureBox.TabStop = false;
            this.pictureBox.Visible = false;
            // 
            // Convert
            // 
            this.Convert.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Convert.Location = new System.Drawing.Point(335, 398);
            this.Convert.Name = "Convert";
            this.Convert.Size = new System.Drawing.Size(120, 40);
            this.Convert.TabIndex = 17;
            this.Convert.Text = "Convert";
            this.Convert.UseVisualStyleBackColor = true;
            this.Convert.Click += new System.EventHandler(this.ConvertClick);
            // 
            // Timer
            // 
            this.Timer.Enabled = true;
            this.Timer.Interval = 1000;
            this.Timer.Tick += new System.EventHandler(this.Timer_Tick);
            // 
            // MainGroup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Convert);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.additionalInfoLabel);
            this.Controls.Add(this.toLabel);
            this.Controls.Add(this.fromLabel);
            this.Controls.Add(this.infoLabel);
            this.Controls.Add(this.amountInput);
            this.Controls.Add(this.conversionOutputLabel);
            this.Controls.Add(this.helloNameLabel);
            this.Controls.Add(this.SeePhotoCheckBox);
            this.Controls.Add(this.dateLabel);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.toGroup);
            this.Controls.Add(this.fromGroup);
            this.Name = "MainGroup";
            this.Text = "19040618 James Satherley";
            this.fromGroup.ResumeLayout(false);
            this.fromGroup.PerformLayout();
            this.toGroup.ResumeLayout(false);
            this.toGroup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.amountInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox fromGroup;
        private System.Windows.Forms.RadioButton fromNZD;
        private System.Windows.Forms.RadioButton fromAUD;
        private System.Windows.Forms.RadioButton fromUSD;
        private System.Windows.Forms.RadioButton fromYEN;
        private System.Windows.Forms.RadioButton fromRMB;
        private System.Windows.Forms.RadioButton fromINR;
        private System.Windows.Forms.RadioButton fromAED;
        private System.Windows.Forms.RadioButton fromEUR;
        private System.Windows.Forms.RadioButton fromCAD;
        private System.Windows.Forms.GroupBox toGroup;
        private System.Windows.Forms.RadioButton toYEN;
        private System.Windows.Forms.RadioButton toRMB;
        private System.Windows.Forms.RadioButton toINR;
        private System.Windows.Forms.RadioButton toAED;
        private System.Windows.Forms.RadioButton toEUR;
        private System.Windows.Forms.RadioButton toCAD;
        private System.Windows.Forms.RadioButton toNZD;
        private System.Windows.Forms.RadioButton toAUD;
        private System.Windows.Forms.RadioButton toUSD;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Label dateLabel;
        private System.Windows.Forms.CheckBox SeePhotoCheckBox;
        private System.Windows.Forms.Label helloNameLabel;
        private System.Windows.Forms.Label conversionOutputLabel;
        private System.Windows.Forms.NumericUpDown amountInput;
        private System.Windows.Forms.Label infoLabel;
        private System.Windows.Forms.Label fromLabel;
        private System.Windows.Forms.Label toLabel;
        private System.Windows.Forms.Label additionalInfoLabel;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Button Convert;
        private System.Windows.Forms.Timer Timer;
    }
}

