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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.panel1 = new System.Windows.Forms.Panel();
			this.panel4 = new System.Windows.Forms.Panel();
			this.panel3 = new System.Windows.Forms.Panel();
			this.panel2 = new System.Windows.Forms.Panel();
			this.pictureBox6 = new System.Windows.Forms.PictureBox();
			this.pictureBox7 = new System.Windows.Forms.PictureBox();
			this.pictureBox5 = new System.Windows.Forms.PictureBox();
			this.pictureBox4 = new System.Windows.Forms.PictureBox();
			this.pictureBox3 = new System.Windows.Forms.PictureBox();
			this.pictureBox2 = new System.Windows.Forms.PictureBox();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.panel5 = new System.Windows.Forms.Panel();
			this.uiMove1 = new NewGame.UI.UIMove();
			this.uiMap1 = new NewGame.UI.UIMap();
			this.uiQuest1 = new NewGame.UI.UIQuest();
			this.progressData3 = new NewGame.UI.ProgressData();
			this.progressData2 = new NewGame.UI.ProgressData();
			this.progressData1 = new NewGame.UI.ProgressData();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.Transparent;
			this.panel1.Controls.Add(this.progressData3);
			this.panel1.Controls.Add(this.progressData2);
			this.panel1.Controls.Add(this.progressData1);
			this.panel1.Location = new System.Drawing.Point(189, 62);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(360, 124);
			this.panel1.TabIndex = 4;
			// 
			// panel4
			// 
			this.panel4.BackColor = System.Drawing.Color.Transparent;
			this.panel4.BackgroundImage = global::NewGame.Properties.Resources.рамка_нижняя;
			this.panel4.Location = new System.Drawing.Point(118, 648);
			this.panel4.Name = "panel4";
			this.panel4.Size = new System.Drawing.Size(876, 29);
			this.panel4.TabIndex = 13;
			// 
			// panel3
			// 
			this.panel3.BackColor = System.Drawing.Color.Transparent;
			this.panel3.BackgroundImage = global::NewGame.Properties.Resources.правая_рамка_psd;
			this.panel3.Location = new System.Drawing.Point(1067, 136);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(41, 412);
			this.panel3.TabIndex = 12;
			// 
			// panel2
			// 
			this.panel2.BackColor = System.Drawing.Color.Transparent;
			this.panel2.BackgroundImage = global::NewGame.Properties.Resources.рамка_левая_psd;
			this.panel2.Location = new System.Drawing.Point(-1, 138);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(41, 410);
			this.panel2.TabIndex = 11;
			// 
			// pictureBox6
			// 
			this.pictureBox6.BackColor = System.Drawing.Color.Transparent;
			this.pictureBox6.Image = global::NewGame.Properties.Resources.рамка_правый_нижний_угол_psd;
			this.pictureBox6.Location = new System.Drawing.Point(988, 545);
			this.pictureBox6.Name = "pictureBox6";
			this.pictureBox6.Size = new System.Drawing.Size(135, 143);
			this.pictureBox6.TabIndex = 10;
			this.pictureBox6.TabStop = false;
			// 
			// pictureBox7
			// 
			this.pictureBox7.BackColor = System.Drawing.Color.Transparent;
			this.pictureBox7.Image = global::NewGame.Properties.Resources.рамка_левый_нижний_угол_psd;
			this.pictureBox7.Location = new System.Drawing.Point(-5, 548);
			this.pictureBox7.Name = "pictureBox7";
			this.pictureBox7.Size = new System.Drawing.Size(135, 143);
			this.pictureBox7.TabIndex = 9;
			this.pictureBox7.TabStop = false;
			// 
			// pictureBox5
			// 
			this.pictureBox5.BackColor = System.Drawing.Color.Transparent;
			this.pictureBox5.Image = global::NewGame.Properties.Resources.рамка_правый_верхний_угол_psd;
			this.pictureBox5.Location = new System.Drawing.Point(979, -6);
			this.pictureBox5.Name = "pictureBox5";
			this.pictureBox5.Size = new System.Drawing.Size(135, 143);
			this.pictureBox5.TabIndex = 8;
			this.pictureBox5.TabStop = false;
			// 
			// pictureBox4
			// 
			this.pictureBox4.BackColor = System.Drawing.Color.Transparent;
			this.pictureBox4.Image = global::NewGame.Properties.Resources.рамка__левый_верхний_угол_psd;
			this.pictureBox4.Location = new System.Drawing.Point(-4, -2);
			this.pictureBox4.Name = "pictureBox4";
			this.pictureBox4.Size = new System.Drawing.Size(135, 143);
			this.pictureBox4.TabIndex = 7;
			this.pictureBox4.TabStop = false;
			// 
			// pictureBox3
			// 
			this.pictureBox3.Image = global::NewGame.Properties.Resources.книга;
			this.pictureBox3.Location = new System.Drawing.Point(69, 282);
			this.pictureBox3.Name = "pictureBox3";
			this.pictureBox3.Size = new System.Drawing.Size(49, 50);
			this.pictureBox3.TabIndex = 5;
			this.pictureBox3.TabStop = false;
			// 
			// pictureBox2
			// 
			this.pictureBox2.Image = global::NewGame.Properties.Resources.сумка;
			this.pictureBox2.Location = new System.Drawing.Point(124, 282);
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.Size = new System.Drawing.Size(49, 50);
			this.pictureBox2.TabIndex = 5;
			this.pictureBox2.TabStop = false;
			this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
			// 
			// pictureBox1
			// 
			this.pictureBox1.BackColor = System.Drawing.SystemColors.Control;
			this.pictureBox1.Image = global::NewGame.Properties.Resources.hero_logo;
			this.pictureBox1.Location = new System.Drawing.Point(67, 62);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(104, 214);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox1.TabIndex = 3;
			this.pictureBox1.TabStop = false;
			// 
			// panel5
			// 
			this.panel5.BackColor = System.Drawing.Color.Transparent;
			this.panel5.BackgroundImage = global::NewGame.Properties.Resources.рамка_верхняя_psd;
			this.panel5.Location = new System.Drawing.Point(124, 4);
			this.panel5.Name = "panel5";
			this.panel5.Size = new System.Drawing.Size(876, 29);
			this.panel5.TabIndex = 14;
			// 
			// uiMove1
			// 
			this.uiMove1.BackColor = System.Drawing.Color.Transparent;
			this.uiMove1.GotoFight = null;
			this.uiMove1.GetPredmet = null;
			this.uiMove1.Goto = null;
			this.uiMove1.Location = new System.Drawing.Point(719, 443);
			this.uiMove1.Name = "uiMove1";
			this.uiMove1.Size = new System.Drawing.Size(295, 199);
			this.uiMove1.TabIndex = 0;
			this.uiMove1.Talk = null;
			// 
			// uiMap1
			// 
			this.uiMap1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.uiMap1.Location = new System.Drawing.Point(663, 39);
			this.uiMap1.Name = "uiMap1";
			this.uiMap1.Size = new System.Drawing.Size(398, 398);
			this.uiMap1.TabIndex = 1;
			// 
			// uiQuest1
			// 
			this.uiQuest1.BackColor = System.Drawing.Color.Transparent;
			this.uiQuest1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.uiQuest1.Location = new System.Drawing.Point(189, 192);
			this.uiQuest1.Name = "uiQuest1";
			this.uiQuest1.Size = new System.Drawing.Size(459, 360);
			this.uiQuest1.TabIndex = 6;
			// 
			// progressData3
			// 
			this.progressData3.Location = new System.Drawing.Point(3, 82);
			this.progressData3.MinimumSize = new System.Drawing.Size(354, 38);
			this.progressData3.Name = "progressData3";
			this.progressData3.Size = new System.Drawing.Size(354, 38);
			this.progressData3.TabIndex = 0;
			// 
			// progressData2
			// 
			this.progressData2.Location = new System.Drawing.Point(3, 43);
			this.progressData2.MinimumSize = new System.Drawing.Size(354, 38);
			this.progressData2.Name = "progressData2";
			this.progressData2.Size = new System.Drawing.Size(354, 38);
			this.progressData2.TabIndex = 0;
			// 
			// progressData1
			// 
			this.progressData1.Location = new System.Drawing.Point(3, 3);
			this.progressData1.MinimumSize = new System.Drawing.Size(354, 38);
			this.progressData1.Name = "progressData1";
			this.progressData1.Size = new System.Drawing.Size(388, 38);
			this.progressData1.TabIndex = 0;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = global::NewGame.Properties.Resources.фон3;
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ClientSize = new System.Drawing.Size(1107, 671);
			this.Controls.Add(this.uiMove1);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.uiMap1);
			this.Controls.Add(this.panel4);
			this.Controls.Add(this.panel3);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.pictureBox6);
			this.Controls.Add(this.pictureBox7);
			this.Controls.Add(this.pictureBox5);
			this.Controls.Add(this.pictureBox4);
			this.Controls.Add(this.uiQuest1);
			this.Controls.Add(this.pictureBox3);
			this.Controls.Add(this.pictureBox2);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.panel5);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "MainForm";
			this.Text = "Главное окно игры";
			this.Load += new System.EventHandler(this.MainForm_Load);
			this.panel1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
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
        private UI.UIQuest uiQuest1;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
		private UI.ProgressData progressData3;
		private UI.ProgressData progressData2;
		private UI.ProgressData progressData1;
	}
}