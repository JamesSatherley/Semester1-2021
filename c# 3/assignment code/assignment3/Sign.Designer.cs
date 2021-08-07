
namespace assignment3
{
    partial class Sign
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonClose = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.teambox = new System.Windows.Forms.ListBox();
            this.playerbox = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonClose);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.teambox);
            this.groupBox1.Controls.Add(this.playerbox);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(628, 461);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // buttonClose
            // 
            this.buttonClose.Location = new System.Drawing.Point(274, 294);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(75, 98);
            this.buttonClose.TabIndex = 6;
            this.buttonClose.Text = "Close and Save";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(274, 178);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 97);
            this.button2.TabIndex = 5;
            this.button2.Text = "Unsign";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // teambox
            // 
            this.teambox.FormattingEnabled = true;
            this.teambox.Location = new System.Drawing.Point(406, 19);
            this.teambox.Name = "teambox";
            this.teambox.Size = new System.Drawing.Size(216, 433);
            this.teambox.TabIndex = 4;
            this.teambox.SelectedIndexChanged += new System.EventHandler(this.teambox_SelectedIndexChanged);
            // 
            // playerbox
            // 
            this.playerbox.FormattingEnabled = true;
            this.playerbox.Location = new System.Drawing.Point(6, 19);
            this.playerbox.Name = "playerbox";
            this.playerbox.Size = new System.Drawing.Size(216, 433);
            this.playerbox.TabIndex = 3;
            this.playerbox.SelectedIndexChanged += new System.EventHandler(this.playerbox_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(274, 61);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 97);
            this.button1.TabIndex = 2;
            this.button1.Text = "Sign";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Sign
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(653, 486);
            this.Controls.Add(this.groupBox1);
            this.Name = "Sign";
            this.Text = "sign";
            this.Load += new System.EventHandler(this.Sign_Load);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox teambox;
        private System.Windows.Forms.ListBox playerbox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button buttonClose;
    }
}