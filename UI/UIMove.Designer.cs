namespace NewGame.UI
{
    partial class UIMove
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

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UIMove));
            this.btnTalk = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.btnFight = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnTalk
            // 
            this.btnTalk.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnTalk.BackgroundImage")));
            this.btnTalk.Enabled = false;
            this.btnTalk.ForeColor = System.Drawing.Color.White;
            this.btnTalk.Location = new System.Drawing.Point(5, 141);
            this.btnTalk.Name = "btnTalk";
            this.btnTalk.Size = new System.Drawing.Size(89, 40);
            this.btnTalk.TabIndex = 6;
            this.btnTalk.Text = "Говорить";
            this.btnTalk.UseVisualStyleBackColor = true;
            this.btnTalk.Click += new System.EventHandler(this.btnTalk_Click);
            // 
            // button6
            // 
            this.button6.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button6.BackgroundImage")));
            this.button6.Enabled = false;
            this.button6.ForeColor = System.Drawing.Color.White;
            this.button6.Location = new System.Drawing.Point(98, 141);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(89, 40);
            this.button6.TabIndex = 6;
            this.button6.Text = "Подобрать";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // btnFight
            // 
            this.btnFight.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnFight.BackgroundImage")));
            this.btnFight.Enabled = false;
            this.btnFight.ForeColor = System.Drawing.Color.White;
            this.btnFight.Location = new System.Drawing.Point(193, 141);
            this.btnFight.Name = "btnFight";
            this.btnFight.Size = new System.Drawing.Size(89, 40);
            this.btnFight.TabIndex = 6;
            this.btnFight.Text = "Бой";
            this.btnFight.UseVisualStyleBackColor = true;
            this.btnFight.Click += new System.EventHandler(this.btnFight_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Transparent;
            this.button4.BackgroundImage = global::NewGame.Properties.Resources.стрелка_вниз_psd;
            this.button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.button4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.button4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Location = new System.Drawing.Point(112, 75);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(60, 60);
            this.button4.TabIndex = 2;
            this.button4.Tag = "Down";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.StepHero);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Transparent;
            this.button3.BackgroundImage = global::NewGame.Properties.Resources.стрелка_вправо_psd;
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.button3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Location = new System.Drawing.Point(211, 37);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(60, 60);
            this.button3.TabIndex = 3;
            this.button3.Tag = "Right";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.StepHero);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.BackgroundImage = global::NewGame.Properties.Resources.стрелка_влево_psd;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(22, 37);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(60, 60);
            this.button2.TabIndex = 4;
            this.button2.Tag = "Left";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.StepHero);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImage = global::NewGame.Properties.Resources.стрелочка_вверх_psd;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(115, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(60, 60);
            this.button1.TabIndex = 5;
            this.button1.Tag = "Up";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.StepHero);
            // 
            // UIMove
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnFight);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.btnTalk);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "UIMove";
            this.Size = new System.Drawing.Size(302, 190);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnTalk;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button btnFight;
    }
}
