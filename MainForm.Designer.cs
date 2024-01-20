namespace NewGame
{
    partial class MainForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.uiQuest1 = new NewGame.UI.UIQuest();
            this.progressData3 = new NewGame.UI.ProgressData();
            this.progressData2 = new NewGame.UI.ProgressData();
            this.progressData1 = new NewGame.UI.ProgressData();
            this.uiMap1 = new NewGame.UI.UIMap();
            this.uiMove1 = new NewGame.UI.UIMove();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.progressData3);
            this.panel1.Controls.Add(this.progressData2);
            this.panel1.Controls.Add(this.progressData1);
            this.panel1.Location = new System.Drawing.Point(119, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(318, 124);
            this.panel1.TabIndex = 4;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::NewGame.Properties.Resources.книга;
            this.pictureBox3.Location = new System.Drawing.Point(8, 232);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(49, 50);
            this.pictureBox3.TabIndex = 5;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::NewGame.Properties.Resources.сумка;
            this.pictureBox2.Location = new System.Drawing.Point(63, 232);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(49, 50);
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::NewGame.Properties.Resources.hero_logo;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 214);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // uiQuest1
            // 
            this.uiQuest1.BackColor = System.Drawing.Color.Transparent;
            this.uiQuest1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.uiQuest1.Location = new System.Drawing.Point(119, 143);
            this.uiQuest1.Name = "uiQuest1";
            this.uiQuest1.Size = new System.Drawing.Size(562, 365);
            this.uiQuest1.TabIndex = 6;
            // 
            // progressData3
            // 
            this.progressData3.Location = new System.Drawing.Point(3, 83);
            this.progressData3.Name = "progressData3";
            this.progressData3.Size = new System.Drawing.Size(319, 34);
            this.progressData3.TabIndex = 0;
            // 
            // progressData2
            // 
            this.progressData2.Location = new System.Drawing.Point(3, 43);
            this.progressData2.Name = "progressData2";
            this.progressData2.Size = new System.Drawing.Size(319, 34);
            this.progressData2.TabIndex = 0;
            // 
            // progressData1
            // 
            this.progressData1.Location = new System.Drawing.Point(3, 3);
            this.progressData1.Name = "progressData1";
            this.progressData1.Size = new System.Drawing.Size(319, 34);
            this.progressData1.TabIndex = 0;
            // 
            // uiMap1
            // 
            this.uiMap1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.uiMap1.Location = new System.Drawing.Point(696, 12);
            this.uiMap1.Name = "uiMap1";
            this.uiMap1.Size = new System.Drawing.Size(398, 398);
            this.uiMap1.TabIndex = 1;
            // 
            // uiMove1
            // 
            this.uiMove1.BackColor = System.Drawing.Color.Transparent;
            this.uiMove1.Fight = null;
            this.uiMove1.GetPredmet = null;
            this.uiMove1.Goto = null;
            this.uiMove1.Location = new System.Drawing.Point(771, 416);
            this.uiMove1.Name = "uiMove1";
            this.uiMove1.Size = new System.Drawing.Size(251, 174);
            this.uiMove1.TabIndex = 0;
            this.uiMove1.Talk = null;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1107, 671);
            this.Controls.Add(this.uiQuest1);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.uiMap1);
            this.Controls.Add(this.uiMove1);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private UI.UIMove uiMove1;
        private UI.UIMap uiMap1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private UI.ProgressData progressData1;
        private UI.ProgressData progressData3;
        private UI.ProgressData progressData2;
        private UI.UIQuest uiQuest1;
    }
}