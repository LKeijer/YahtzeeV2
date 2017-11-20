namespace YahtzeeV2
{
    partial class Form1
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
            this.dice1 = new System.Windows.Forms.PictureBox();
            this.dice2 = new System.Windows.Forms.PictureBox();
            this.dice3 = new System.Windows.Forms.PictureBox();
            this.dice4 = new System.Windows.Forms.PictureBox();
            this.dice5 = new System.Windows.Forms.PictureBox();
            this.rollDiceBtn = new System.Windows.Forms.Button();
            this.displayResultsLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dice1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dice2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dice3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dice4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dice5)).BeginInit();
            this.SuspendLayout();
            // 
            // dice1
            // 
            this.dice1.Image = global::YahtzeeV2.Properties.Resources.dice1_6;
            this.dice1.InitialImage = global::YahtzeeV2.Properties.Resources.dice1_6;
            this.dice1.Location = new System.Drawing.Point(89, 12);
            this.dice1.Name = "dice1";
            this.dice1.Size = new System.Drawing.Size(75, 75);
            this.dice1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.dice1.TabIndex = 0;
            this.dice1.TabStop = false;
            // 
            // dice2
            // 
            this.dice2.Image = global::YahtzeeV2.Properties.Resources.dice1_6;
            this.dice2.InitialImage = global::YahtzeeV2.Properties.Resources.dice1_6;
            this.dice2.Location = new System.Drawing.Point(170, 12);
            this.dice2.Name = "dice2";
            this.dice2.Size = new System.Drawing.Size(75, 75);
            this.dice2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.dice2.TabIndex = 1;
            this.dice2.TabStop = false;
            // 
            // dice3
            // 
            this.dice3.Image = global::YahtzeeV2.Properties.Resources.dice1_6;
            this.dice3.InitialImage = global::YahtzeeV2.Properties.Resources.dice1_6;
            this.dice3.Location = new System.Drawing.Point(251, 12);
            this.dice3.Name = "dice3";
            this.dice3.Size = new System.Drawing.Size(75, 75);
            this.dice3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.dice3.TabIndex = 2;
            this.dice3.TabStop = false;
            // 
            // dice4
            // 
            this.dice4.Image = global::YahtzeeV2.Properties.Resources.dice1_6;
            this.dice4.InitialImage = global::YahtzeeV2.Properties.Resources.dice1_6;
            this.dice4.Location = new System.Drawing.Point(332, 12);
            this.dice4.Name = "dice4";
            this.dice4.Size = new System.Drawing.Size(75, 75);
            this.dice4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.dice4.TabIndex = 3;
            this.dice4.TabStop = false;
            // 
            // dice5
            // 
            this.dice5.Image = global::YahtzeeV2.Properties.Resources.dice1_6;
            this.dice5.InitialImage = global::YahtzeeV2.Properties.Resources.dice1_6;
            this.dice5.Location = new System.Drawing.Point(413, 12);
            this.dice5.Name = "dice5";
            this.dice5.Size = new System.Drawing.Size(75, 75);
            this.dice5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.dice5.TabIndex = 4;
            this.dice5.TabStop = false;
            // 
            // rollDiceBtn
            // 
            this.rollDiceBtn.Location = new System.Drawing.Point(190, 128);
            this.rollDiceBtn.Name = "rollDiceBtn";
            this.rollDiceBtn.Size = new System.Drawing.Size(200, 75);
            this.rollDiceBtn.TabIndex = 5;
            this.rollDiceBtn.Text = "Roll this shiet";
            this.rollDiceBtn.UseVisualStyleBackColor = true;
            this.rollDiceBtn.Click += new System.EventHandler(this.rollDiceBtn_Click);
            // 
            // displayResultsLabel
            // 
            this.displayResultsLabel.AutoSize = true;
            this.displayResultsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.displayResultsLabel.Location = new System.Drawing.Point(185, 225);
            this.displayResultsLabel.Name = "displayResultsLabel";
            this.displayResultsLabel.Size = new System.Drawing.Size(169, 29);
            this.displayResultsLabel.TabIndex = 6;
            this.displayResultsLabel.Text = "displayResults";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 461);
            this.Controls.Add(this.displayResultsLabel);
            this.Controls.Add(this.rollDiceBtn);
            this.Controls.Add(this.dice5);
            this.Controls.Add(this.dice4);
            this.Controls.Add(this.dice3);
            this.Controls.Add(this.dice2);
            this.Controls.Add(this.dice1);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Yahtzee";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dice1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dice2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dice3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dice4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dice5)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox dice1;
        private System.Windows.Forms.PictureBox dice2;
        private System.Windows.Forms.PictureBox dice3;
        private System.Windows.Forms.PictureBox dice4;
        private System.Windows.Forms.PictureBox dice5;
        private System.Windows.Forms.Button rollDiceBtn;
        private System.Windows.Forms.Label displayResultsLabel;
    }
}

