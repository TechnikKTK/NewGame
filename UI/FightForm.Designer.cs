namespace NewGame
{
    partial class FightForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FightForm));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.btnFight = new System.Windows.Forms.Button();
            this.btnProtect = new System.Windows.Forms.Button();
            this.btnGiveUp = new System.Windows.Forms.Button();
            this.enemyDamage = new NewGame.UI.ProgressData();
            this.enemyProtect = new NewGame.UI.ProgressData();
            this.enemyHealth = new NewGame.UI.ProgressData();
            this.heroDamage = new NewGame.UI.ProgressData();
            this.heroProtect = new NewGame.UI.ProgressData();
            this.heroHealth = new NewGame.UI.ProgressData();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Image = global::NewGame.Properties.Resources.hero_logo;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(163, 229);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox2.Image = global::NewGame.Properties.Resources.Снимок_экрана_2024_01_20_131304;
            this.pictureBox2.Location = new System.Drawing.Point(951, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(163, 166);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(181, 247);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(764, 392);
            this.richTextBox1.TabIndex = 14;
            this.richTextBox1.Text = "";
            // 
            // btnFight
            // 
            this.btnFight.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnFight.BackgroundImage")));
            this.btnFight.ForeColor = System.Drawing.Color.White;
            this.btnFight.Location = new System.Drawing.Point(12, 247);
            this.btnFight.Name = "btnFight";
            this.btnFight.Size = new System.Drawing.Size(163, 110);
            this.btnFight.TabIndex = 15;
            this.btnFight.Text = "Ударить";
            this.btnFight.UseVisualStyleBackColor = true;
            this.btnFight.Click += new System.EventHandler(this.btnFight_Click);
            // 
            // btnProtect
            // 
            this.btnProtect.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnProtect.BackgroundImage")));
            this.btnProtect.ForeColor = System.Drawing.Color.White;
            this.btnProtect.Location = new System.Drawing.Point(12, 363);
            this.btnProtect.Name = "btnProtect";
            this.btnProtect.Size = new System.Drawing.Size(163, 110);
            this.btnProtect.TabIndex = 16;
            this.btnProtect.Text = "Защититься";
            this.btnProtect.UseVisualStyleBackColor = true;
            this.btnProtect.Click += new System.EventHandler(this.btnProtect_Click);
            // 
            // btnGiveUp
            // 
            this.btnGiveUp.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnGiveUp.BackgroundImage")));
            this.btnGiveUp.ForeColor = System.Drawing.Color.White;
            this.btnGiveUp.Location = new System.Drawing.Point(951, 559);
            this.btnGiveUp.Name = "btnGiveUp";
            this.btnGiveUp.Size = new System.Drawing.Size(163, 80);
            this.btnGiveUp.TabIndex = 17;
            this.btnGiveUp.Text = "Сдаться :(";
            this.btnGiveUp.UseVisualStyleBackColor = true;
            this.btnGiveUp.Click += new System.EventHandler(this.btnGiveUp_Click);
            // 
            // enemyDamage
            // 
            this.enemyDamage.BackColor = System.Drawing.Color.Transparent;
            this.enemyDamage.Location = new System.Drawing.Point(591, 56);
            this.enemyDamage.MinimumSize = new System.Drawing.Size(354, 38);
            this.enemyDamage.Name = "enemyDamage";
            this.enemyDamage.Size = new System.Drawing.Size(354, 38);
            this.enemyDamage.TabIndex = 23;
            // 
            // enemyProtect
            // 
            this.enemyProtect.BackColor = System.Drawing.Color.Transparent;
            this.enemyProtect.Location = new System.Drawing.Point(591, 100);
            this.enemyProtect.MinimumSize = new System.Drawing.Size(354, 38);
            this.enemyProtect.Name = "enemyProtect";
            this.enemyProtect.Size = new System.Drawing.Size(354, 38);
            this.enemyProtect.TabIndex = 22;
            // 
            // enemyHealth
            // 
            this.enemyHealth.BackColor = System.Drawing.Color.Transparent;
            this.enemyHealth.Location = new System.Drawing.Point(591, 12);
            this.enemyHealth.MinimumSize = new System.Drawing.Size(354, 38);
            this.enemyHealth.Name = "enemyHealth";
            this.enemyHealth.Size = new System.Drawing.Size(354, 38);
            this.enemyHealth.TabIndex = 21;
            // 
            // heroDamage
            // 
            this.heroDamage.BackColor = System.Drawing.Color.Transparent;
            this.heroDamage.Location = new System.Drawing.Point(181, 56);
            this.heroDamage.MinimumSize = new System.Drawing.Size(354, 38);
            this.heroDamage.Name = "heroDamage";
            this.heroDamage.Size = new System.Drawing.Size(354, 38);
            this.heroDamage.TabIndex = 20;
            // 
            // heroProtect
            // 
            this.heroProtect.BackColor = System.Drawing.Color.Transparent;
            this.heroProtect.Location = new System.Drawing.Point(181, 100);
            this.heroProtect.MinimumSize = new System.Drawing.Size(354, 38);
            this.heroProtect.Name = "heroProtect";
            this.heroProtect.Size = new System.Drawing.Size(354, 38);
            this.heroProtect.TabIndex = 19;
            // 
            // heroHealth
            // 
            this.heroHealth.BackColor = System.Drawing.Color.Transparent;
            this.heroHealth.Location = new System.Drawing.Point(181, 12);
            this.heroHealth.MinimumSize = new System.Drawing.Size(354, 38);
            this.heroHealth.Name = "heroHealth";
            this.heroHealth.Size = new System.Drawing.Size(354, 38);
            this.heroHealth.TabIndex = 18;
            // 
            // FightForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::NewGame.Properties.Resources.фон3;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1126, 651);
            this.Controls.Add(this.enemyDamage);
            this.Controls.Add(this.enemyProtect);
            this.Controls.Add(this.enemyHealth);
            this.Controls.Add(this.heroDamage);
            this.Controls.Add(this.heroProtect);
            this.Controls.Add(this.heroHealth);
            this.Controls.Add(this.btnGiveUp);
            this.Controls.Add(this.btnProtect);
            this.Controls.Add(this.btnFight);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Name = "FightForm";
            this.Text = "Бой";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button btnFight;
        private System.Windows.Forms.Button btnProtect;
        private System.Windows.Forms.Button btnGiveUp;
        private NewGame.UI.ProgressData heroHealth;
        private NewGame.UI.ProgressData heroProtect;
        private NewGame.UI.ProgressData heroDamage;
        private NewGame.UI.ProgressData enemyDamage;
        private NewGame.UI.ProgressData enemyProtect;
        private NewGame.UI.ProgressData enemyHealth;
    }
}

