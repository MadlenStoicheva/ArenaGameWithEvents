namespace ArenaGameWithEvents.WindowsForms
{
    partial class ShowGame
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
            this.labelHeroesFight = new System.Windows.Forms.Label();
            this.listBox_HeroesFight = new System.Windows.Forms.ListBox();
            this.buttonPlayAgain = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelHeroesFight
            // 
            this.labelHeroesFight.AutoSize = true;
            this.labelHeroesFight.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelHeroesFight.Location = new System.Drawing.Point(290, 29);
            this.labelHeroesFight.Name = "labelHeroesFight";
            this.labelHeroesFight.Size = new System.Drawing.Size(227, 39);
            this.labelHeroesFight.TabIndex = 0;
            this.labelHeroesFight.Text = "Heroes Fight";
            // 
            // listBox_HeroesFight
            // 
            this.listBox_HeroesFight.FormattingEnabled = true;
            this.listBox_HeroesFight.Location = new System.Drawing.Point(244, 83);
            this.listBox_HeroesFight.Name = "listBox_HeroesFight";
            this.listBox_HeroesFight.Size = new System.Drawing.Size(328, 251);
            this.listBox_HeroesFight.TabIndex = 1;
            // 
            // buttonPlayAgain
            // 
            this.buttonPlayAgain.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonPlayAgain.Location = new System.Drawing.Point(321, 375);
            this.buttonPlayAgain.Name = "buttonPlayAgain";
            this.buttonPlayAgain.Size = new System.Drawing.Size(171, 50);
            this.buttonPlayAgain.TabIndex = 2;
            this.buttonPlayAgain.Text = "Play Again";
            this.buttonPlayAgain.UseVisualStyleBackColor = true;
            this.buttonPlayAgain.Click += new System.EventHandler(this.buttonPlayAgain_Click);
            // 
            // ShowGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonPlayAgain);
            this.Controls.Add(this.listBox_HeroesFight);
            this.Controls.Add(this.labelHeroesFight);
            this.Name = "ShowGame";
            this.Text = "ShowGame";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelHeroesFight;
        private System.Windows.Forms.ListBox listBox_HeroesFight;
        private System.Windows.Forms.Button buttonPlayAgain;
    }
}