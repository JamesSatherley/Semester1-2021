namespace assignment3
{
    partial class Main
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
            this.groupBoxMain = new System.Windows.Forms.GroupBox();
            this.playersBox = new System.Windows.Forms.ListBox();
            this.teamsBox = new System.Windows.Forms.ListBox();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.buttonSign = new System.Windows.Forms.Button();
            this.buttonTeam = new System.Windows.Forms.Button();
            this.buttonPlayer = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonLoad = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.buttonChart = new System.Windows.Forms.Button();
            this.groupBoxMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxMain
            // 
            this.groupBoxMain.Controls.Add(this.buttonChart);
            this.groupBoxMain.Controls.Add(this.playersBox);
            this.groupBoxMain.Controls.Add(this.teamsBox);
            this.groupBoxMain.Controls.Add(this.radioButton2);
            this.groupBoxMain.Controls.Add(this.radioButton1);
            this.groupBoxMain.Controls.Add(this.richTextBox1);
            this.groupBoxMain.Controls.Add(this.buttonSearch);
            this.groupBoxMain.Controls.Add(this.buttonSign);
            this.groupBoxMain.Controls.Add(this.buttonTeam);
            this.groupBoxMain.Controls.Add(this.buttonPlayer);
            this.groupBoxMain.Controls.Add(this.buttonSave);
            this.groupBoxMain.Controls.Add(this.buttonLoad);
            this.groupBoxMain.Location = new System.Drawing.Point(8, 0);
            this.groupBoxMain.Margin = new System.Windows.Forms.Padding(2);
            this.groupBoxMain.Name = "groupBoxMain";
            this.groupBoxMain.Padding = new System.Windows.Forms.Padding(2);
            this.groupBoxMain.Size = new System.Drawing.Size(637, 478);
            this.groupBoxMain.TabIndex = 2;
            this.groupBoxMain.TabStop = false;
            this.groupBoxMain.Text = "Rudgy Union";
            // 
            // playersBox
            // 
            this.playersBox.FormattingEnabled = true;
            this.playersBox.Location = new System.Drawing.Point(0, 110);
            this.playersBox.Name = "playersBox";
            this.playersBox.Size = new System.Drawing.Size(313, 368);
            this.playersBox.TabIndex = 13;
            this.playersBox.SelectedIndexChanged += new System.EventHandler(this.playersBox_SelectedIndexChanged);
            // 
            // teamsBox
            // 
            this.teamsBox.FormattingEnabled = true;
            this.teamsBox.Location = new System.Drawing.Point(324, 110);
            this.teamsBox.Name = "teamsBox";
            this.teamsBox.Size = new System.Drawing.Size(313, 368);
            this.teamsBox.TabIndex = 12;
            this.teamsBox.SelectedIndexChanged += new System.EventHandler(this.teamsBox_SelectedIndexChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(4, 77);
            this.radioButton2.Margin = new System.Windows.Forms.Padding(2);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(139, 17);
            this.radioButton2.TabIndex = 10;
            this.radioButton2.Text = "Search by Place of Birth";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Location = new System.Drawing.Point(4, 55);
            this.radioButton1.Margin = new System.Windows.Forms.Padding(2);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(95, 17);
            this.radioButton1.TabIndex = 9;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Search by Age";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(143, 55);
            this.richTextBox1.Margin = new System.Windows.Forms.Padding(2);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(235, 38);
            this.richTextBox1.TabIndex = 4;
            this.richTextBox1.Text = "";
            // 
            // buttonSearch
            // 
            this.buttonSearch.Location = new System.Drawing.Point(382, 55);
            this.buttonSearch.Margin = new System.Windows.Forms.Padding(2);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(123, 37);
            this.buttonSearch.TabIndex = 8;
            this.buttonSearch.Text = "Search";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // buttonSign
            // 
            this.buttonSign.Location = new System.Drawing.Point(509, 14);
            this.buttonSign.Margin = new System.Windows.Forms.Padding(2);
            this.buttonSign.Name = "buttonSign";
            this.buttonSign.Size = new System.Drawing.Size(123, 37);
            this.buttonSign.TabIndex = 7;
            this.buttonSign.Text = "Sign Player";
            this.buttonSign.UseVisualStyleBackColor = true;
            this.buttonSign.Click += new System.EventHandler(this.buttonSign_Click);
            // 
            // buttonTeam
            // 
            this.buttonTeam.Location = new System.Drawing.Point(382, 14);
            this.buttonTeam.Margin = new System.Windows.Forms.Padding(2);
            this.buttonTeam.Name = "buttonTeam";
            this.buttonTeam.Size = new System.Drawing.Size(123, 37);
            this.buttonTeam.TabIndex = 6;
            this.buttonTeam.Text = "Add or Remove Team";
            this.buttonTeam.UseVisualStyleBackColor = true;
            this.buttonTeam.Click += new System.EventHandler(this.buttonTeam_Click);
            // 
            // buttonPlayer
            // 
            this.buttonPlayer.Location = new System.Drawing.Point(259, 14);
            this.buttonPlayer.Margin = new System.Windows.Forms.Padding(2);
            this.buttonPlayer.Name = "buttonPlayer";
            this.buttonPlayer.Size = new System.Drawing.Size(119, 37);
            this.buttonPlayer.TabIndex = 5;
            this.buttonPlayer.Text = "Add or Remove Player";
            this.buttonPlayer.UseVisualStyleBackColor = true;
            this.buttonPlayer.Click += new System.EventHandler(this.buttonPlayer_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(131, 14);
            this.buttonSave.Margin = new System.Windows.Forms.Padding(2);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(123, 37);
            this.buttonSave.TabIndex = 4;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonLoad
            // 
            this.buttonLoad.Location = new System.Drawing.Point(4, 14);
            this.buttonLoad.Margin = new System.Windows.Forms.Padding(2);
            this.buttonLoad.Name = "buttonLoad";
            this.buttonLoad.Size = new System.Drawing.Size(123, 37);
            this.buttonLoad.TabIndex = 3;
            this.buttonLoad.Text = "Load";
            this.buttonLoad.UseVisualStyleBackColor = true;
            this.buttonLoad.Click += new System.EventHandler(this.buttonLoad_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // buttonChart
            // 
            this.buttonChart.Location = new System.Drawing.Point(509, 55);
            this.buttonChart.Margin = new System.Windows.Forms.Padding(2);
            this.buttonChart.Name = "buttonChart";
            this.buttonChart.Size = new System.Drawing.Size(123, 37);
            this.buttonChart.TabIndex = 14;
            this.buttonChart.Text = "Open Charts";
            this.buttonChart.UseVisualStyleBackColor = true;
            this.buttonChart.Click += new System.EventHandler(this.buttonChart_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(653, 486);
            this.Controls.Add(this.groupBoxMain);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Main";
            this.Text = "Rudgy union";
            this.Load += new System.EventHandler(this.Main_Load);
            this.groupBoxMain.ResumeLayout(false);
            this.groupBoxMain.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBoxMain;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.Button buttonSign;
        private System.Windows.Forms.Button buttonTeam;
        private System.Windows.Forms.Button buttonPlayer;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonLoad;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ListBox playersBox;
        private System.Windows.Forms.ListBox teamsBox;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button buttonChart;
    }
}

