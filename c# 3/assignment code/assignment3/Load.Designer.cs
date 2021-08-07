
namespace assignment3
{
    partial class Load
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
            this.buttonLoadDefault = new System.Windows.Forms.Button();
            this.buttonLoadCustom = new System.Windows.Forms.Button();
            this.appendorreplace = new System.Windows.Forms.GroupBox();
            this.radioButtonReplace = new System.Windows.Forms.RadioButton();
            this.radioButtonAppend = new System.Windows.Forms.RadioButton();
            this.openFile = new System.Windows.Forms.OpenFileDialog();
            this.appendorreplace.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonLoadDefault
            // 
            this.buttonLoadDefault.Location = new System.Drawing.Point(212, 70);
            this.buttonLoadDefault.Name = "buttonLoadDefault";
            this.buttonLoadDefault.Size = new System.Drawing.Size(190, 51);
            this.buttonLoadDefault.TabIndex = 0;
            this.buttonLoadDefault.Text = "Load from default location";
            this.buttonLoadDefault.UseVisualStyleBackColor = true;
            this.buttonLoadDefault.Click += new System.EventHandler(this.buttonLoadDefault_Click);
            // 
            // buttonLoadCustom
            // 
            this.buttonLoadCustom.Location = new System.Drawing.Point(212, 138);
            this.buttonLoadCustom.Name = "buttonLoadCustom";
            this.buttonLoadCustom.Size = new System.Drawing.Size(190, 51);
            this.buttonLoadCustom.TabIndex = 1;
            this.buttonLoadCustom.Text = "Load from custom location";
            this.buttonLoadCustom.UseVisualStyleBackColor = true;
            this.buttonLoadCustom.Click += new System.EventHandler(this.buttonLoadCustom_Click);
            // 
            // appendorreplace
            // 
            this.appendorreplace.Controls.Add(this.radioButtonReplace);
            this.appendorreplace.Controls.Add(this.radioButtonAppend);
            this.appendorreplace.Location = new System.Drawing.Point(212, 242);
            this.appendorreplace.Name = "appendorreplace";
            this.appendorreplace.Size = new System.Drawing.Size(190, 100);
            this.appendorreplace.TabIndex = 3;
            this.appendorreplace.TabStop = false;
            this.appendorreplace.Text = "Append Or Replace?";
            // 
            // radioButtonReplace
            // 
            this.radioButtonReplace.AutoSize = true;
            this.radioButtonReplace.Location = new System.Drawing.Point(65, 52);
            this.radioButtonReplace.Name = "radioButtonReplace";
            this.radioButtonReplace.Size = new System.Drawing.Size(65, 17);
            this.radioButtonReplace.TabIndex = 1;
            this.radioButtonReplace.TabStop = true;
            this.radioButtonReplace.Text = "Replace";
            this.radioButtonReplace.UseVisualStyleBackColor = true;
            // 
            // radioButtonAppend
            // 
            this.radioButtonAppend.AutoSize = true;
            this.radioButtonAppend.Checked = true;
            this.radioButtonAppend.Location = new System.Drawing.Point(65, 28);
            this.radioButtonAppend.Name = "radioButtonAppend";
            this.radioButtonAppend.Size = new System.Drawing.Size(62, 17);
            this.radioButtonAppend.TabIndex = 0;
            this.radioButtonAppend.TabStop = true;
            this.radioButtonAppend.Text = "Append";
            this.radioButtonAppend.UseVisualStyleBackColor = true;
            // 
            // load
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(653, 486);
            this.Controls.Add(this.appendorreplace);
            this.Controls.Add(this.buttonLoadCustom);
            this.Controls.Add(this.buttonLoadDefault);
            this.Name = "load";
            this.Text = "load";
            this.appendorreplace.ResumeLayout(false);
            this.appendorreplace.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonLoadDefault;
        private System.Windows.Forms.Button buttonLoadCustom;
        private System.Windows.Forms.GroupBox appendorreplace;
        private System.Windows.Forms.RadioButton radioButtonReplace;
        private System.Windows.Forms.RadioButton radioButtonAppend;
        private System.Windows.Forms.OpenFileDialog openFile;
    }
}