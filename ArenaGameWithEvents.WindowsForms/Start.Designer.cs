namespace ArenaGameWithEvents.WindowsForms
{
    partial class Start
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
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxHeroTwo = new System.Windows.Forms.ComboBox();
            this.comboBoxHeroOne = new System.Windows.Forms.ComboBox();
            this.lbHeroOne = new System.Windows.Forms.Label();
            this.lbHeroTwo = new System.Windows.Forms.Label();
            this.btnPlay = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(302, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(241, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Play Arena Game";
            // 
            // comboBoxHeroTwo
            // 
            this.comboBoxHeroTwo.FormattingEnabled = true;
            this.comboBoxHeroTwo.Location = new System.Drawing.Point(499, 140);
            this.comboBoxHeroTwo.Name = "comboBoxHeroTwo";
            this.comboBoxHeroTwo.Size = new System.Drawing.Size(156, 21);
            this.comboBoxHeroTwo.TabIndex = 3;
            // 
            // comboBoxHeroOne
            // 
            this.comboBoxHeroOne.FormattingEnabled = true;
            this.comboBoxHeroOne.Location = new System.Drawing.Point(134, 140);
            this.comboBoxHeroOne.Name = "comboBoxHeroOne";
            this.comboBoxHeroOne.Size = new System.Drawing.Size(156, 21);
            this.comboBoxHeroOne.TabIndex = 4;
            // 
            // lbHeroOne
            // 
            this.lbHeroOne.AutoSize = true;
            this.lbHeroOne.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbHeroOne.Location = new System.Drawing.Point(155, 109);
            this.lbHeroOne.Name = "lbHeroOne";
            this.lbHeroOne.Size = new System.Drawing.Size(108, 25);
            this.lbHeroOne.TabIndex = 5;
            this.lbHeroOne.Text = "Hero one";
            // 
            // lbHeroTwo
            // 
            this.lbHeroTwo.AutoSize = true;
            this.lbHeroTwo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbHeroTwo.Location = new System.Drawing.Point(528, 109);
            this.lbHeroTwo.Name = "lbHeroTwo";
            this.lbHeroTwo.Size = new System.Drawing.Size(105, 25);
            this.lbHeroTwo.TabIndex = 6;
            this.lbHeroTwo.Text = "Hero two";
            // 
            // btnPlay
            // 
            this.btnPlay.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnPlay.Location = new System.Drawing.Point(330, 249);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(126, 48);
            this.btnPlay.TabIndex = 7;
            this.btnPlay.Text = "Play";
            this.btnPlay.UseVisualStyleBackColor = true;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // Start
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnPlay);
            this.Controls.Add(this.lbHeroTwo);
            this.Controls.Add(this.lbHeroOne);
            this.Controls.Add(this.comboBoxHeroOne);
            this.Controls.Add(this.comboBoxHeroTwo);
            this.Controls.Add(this.label1);
            this.Name = "Start";
            this.Text = "Start";
            this.Load += new System.EventHandler(this.Start_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxHeroTwo;
        private System.Windows.Forms.ComboBox comboBoxHeroOne;
        private System.Windows.Forms.Label lbHeroOne;
        private System.Windows.Forms.Label lbHeroTwo;
        private System.Windows.Forms.Button btnPlay;
    }
}

