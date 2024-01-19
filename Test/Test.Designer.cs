namespace NewGame.Test
{
    partial class Test
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
            this.button1 = new System.Windows.Forms.Button();
            this.uiMove1 = new NewGame.UI.UIMove();
            this.uiMap1 = new NewGame.UI.UIMap();
            this.uImap2 = new NewGame.UI.UIMap();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(503, 279);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // uiMove1
            // 
            this.uiMove1.Fight = null;
            this.uiMove1.GetPredmet = null;
            this.uiMove1.Goto = null;
            this.uiMove1.Location = new System.Drawing.Point(33, 264);
            this.uiMove1.Name = "uiMove1";
            this.uiMove1.Size = new System.Drawing.Size(251, 174);
            this.uiMove1.TabIndex = 4;
            this.uiMove1.Talk = null;
            // 
            // uiMap1
            // 
            this.uiMap1.Location = new System.Drawing.Point(12, 12);
            this.uiMap1.Name = "uiMap1";
            this.uiMap1.Size = new System.Drawing.Size(566, 246);
            this.uiMap1.TabIndex = 3;
            // 
            // uImap2
            // 
            this.uImap2.Location = new System.Drawing.Point(12, 12);
            this.uImap2.Name = "uImap2";
            this.uImap2.Size = new System.Drawing.Size(303, 218);
            this.uImap2.TabIndex = 2;
            // 
            // Test
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.uiMove1);
            this.Controls.Add(this.uiMap1);
            this.Controls.Add(this.uImap2);
            this.Name = "Test";
            this.Text = "Test";
            this.ResumeLayout(false);

        }

        #endregion

        private UI.UIMap uImap2;
        private UI.UIMap uiMap1;
        private UI.UIMove uiMove1;
        private System.Windows.Forms.Button button1;
    }
}