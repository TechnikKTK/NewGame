namespace NewGame.UI
{
    partial class UIMap
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
            this.pictMap = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictMap)).BeginInit();
            this.SuspendLayout();
            // 
            // pictMap
            // 
            this.pictMap.BackColor = System.Drawing.Color.Gray;
            this.pictMap.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictMap.Location = new System.Drawing.Point(0, 0);
            this.pictMap.MaximumSize = new System.Drawing.Size(400, 400);
            this.pictMap.MinimumSize = new System.Drawing.Size(400, 400);
            this.pictMap.Name = "pictMap";
            this.pictMap.Size = new System.Drawing.Size(400, 400);
            this.pictMap.TabIndex = 0;
            this.pictMap.TabStop = false;
            // 
            // UIMap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.pictMap);
            this.Name = "UIMap";
            this.Size = new System.Drawing.Size(398, 398);
            ((System.ComponentModel.ISupportInitialize)(this.pictMap)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictMap;
    }
}
