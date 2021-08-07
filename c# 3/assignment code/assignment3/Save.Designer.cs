
namespace assignment3
{
    partial class Save
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
            this.buttonSaveCustom = new System.Windows.Forms.Button();
            this.buttonSaveDefault = new System.Windows.Forms.Button();
            this.appendorreplace = new System.Windows.Forms.GroupBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButtonRemove = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.radioButtonPlayerTeam = new System.Windows.Forms.RadioButton();
            this.radioButtonPlayersSigned = new System.Windows.Forms.RadioButton();
            this.radioButtonTeamsSigned = new System.Windows.Forms.RadioButton();
            this.appendorreplace.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonSaveCustom
            // 
            this.buttonSaveCustom.Location = new System.Drawing.Point(328, 119);
            this.buttonSaveCustom.Name = "buttonSaveCustom";
            this.buttonSaveCustom.Size = new System.Drawing.Size(181, 51);
            this.buttonSaveCustom.TabIndex = 5;
            this.buttonSaveCustom.Text = "Save to Custom Location";
            this.buttonSaveCustom.UseVisualStyleBackColor = true;
            this.buttonSaveCustom.Click += new System.EventHandler(this.buttonSaveCustom_Click);
            // 
            // buttonSaveDefault
            // 
            this.buttonSaveDefault.Location = new System.Drawing.Point(132, 119);
            this.buttonSaveDefault.Name = "buttonSaveDefault";
            this.buttonSaveDefault.Size = new System.Drawing.Size(181, 51);
            this.buttonSaveDefault.TabIndex = 4;
            this.buttonSaveDefault.Text = "Save to Default Location";
            this.buttonSaveDefault.UseVisualStyleBackColor = true;
            this.buttonSaveDefault.Click += new System.EventHandler(this.buttonSaveDefault_Click);
            // 
            // appendorreplace
            // 
            this.appendorreplace.Controls.Add(this.radioButton1);
            this.appendorreplace.Controls.Add(this.radioButtonRemove);
            this.appendorreplace.Location = new System.Drawing.Point(319, 193);
            this.appendorreplace.Name = "appendorreplace";
            this.appendorreplace.Size = new System.Drawing.Size(190, 129);
            this.appendorreplace.TabIndex = 6;
            this.appendorreplace.TabStop = false;
            this.appendorreplace.Text = "Empty data from program?";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(47, 59);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(93, 17);
            this.radioButton1.TabIndex = 1;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Don\'t Remove";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButtonRemove
            // 
            this.radioButtonRemove.AutoSize = true;
            this.radioButtonRemove.Checked = true;
            this.radioButtonRemove.Location = new System.Drawing.Point(47, 36);
            this.radioButtonRemove.Name = "radioButtonRemove";
            this.radioButtonRemove.Size = new System.Drawing.Size(65, 17);
            this.radioButtonRemove.TabIndex = 0;
            this.radioButtonRemove.TabStop = true;
            this.radioButtonRemove.Text = "Remove";
            this.radioButtonRemove.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButtonTeamsSigned);
            this.groupBox1.Controls.Add(this.radioButtonPlayersSigned);
            this.groupBox1.Controls.Add(this.radioButtonPlayerTeam);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(132, 193);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(181, 129);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "What would you like to save?";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "be read by this program";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Only players.txt and teams.txt can ";
            // 
            // radioButtonPlayerTeam
            // 
            this.radioButtonPlayerTeam.AutoSize = true;
            this.radioButtonPlayerTeam.Checked = true;
            this.radioButtonPlayerTeam.Location = new System.Drawing.Point(8, 68);
            this.radioButtonPlayerTeam.Name = "radioButtonPlayerTeam";
            this.radioButtonPlayerTeam.Size = new System.Drawing.Size(138, 17);
            this.radioButtonPlayerTeam.TabIndex = 8;
            this.radioButtonPlayerTeam.TabStop = true;
            this.radioButtonPlayerTeam.Text = "players.txt and teams.txt";
            this.radioButtonPlayerTeam.UseVisualStyleBackColor = true;
            // 
            // radioButtonPlayersSigned
            // 
            this.radioButtonPlayersSigned.AutoSize = true;
            this.radioButtonPlayersSigned.Location = new System.Drawing.Point(8, 85);
            this.radioButtonPlayersSigned.Name = "radioButtonPlayersSigned";
            this.radioButtonPlayersSigned.Size = new System.Drawing.Size(159, 17);
            this.radioButtonPlayersSigned.TabIndex = 9;
            this.radioButtonPlayersSigned.Text = "players.txt with teams signed";
            this.radioButtonPlayersSigned.UseVisualStyleBackColor = true;
            // 
            // radioButtonTeamsSigned
            // 
            this.radioButtonTeamsSigned.AutoSize = true;
            this.radioButtonTeamsSigned.Location = new System.Drawing.Point(8, 102);
            this.radioButtonTeamsSigned.Name = "radioButtonTeamsSigned";
            this.radioButtonTeamsSigned.Size = new System.Drawing.Size(159, 17);
            this.radioButtonTeamsSigned.TabIndex = 11;
            this.radioButtonTeamsSigned.Text = "teams.txt with players signed";
            this.radioButtonTeamsSigned.UseVisualStyleBackColor = true;
            // 
            // Save
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(653, 486);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.appendorreplace);
            this.Controls.Add(this.buttonSaveCustom);
            this.Controls.Add(this.buttonSaveDefault);
            this.Name = "Save";
            this.Text = "save";
            this.appendorreplace.ResumeLayout(false);
            this.appendorreplace.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonSaveCustom;
        private System.Windows.Forms.Button buttonSaveDefault;
        private System.Windows.Forms.GroupBox appendorreplace;
        private System.Windows.Forms.RadioButton radioButtonRemove;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton radioButtonTeamsSigned;
        private System.Windows.Forms.RadioButton radioButtonPlayersSigned;
        private System.Windows.Forms.RadioButton radioButtonPlayerTeam;
    }
}