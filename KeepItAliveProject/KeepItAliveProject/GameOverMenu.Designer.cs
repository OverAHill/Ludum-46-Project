﻿namespace KeepItAliveProject
{
    partial class GameOverMenu
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
            this.gameOverLable = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // gameOverLable
            // 
            this.gameOverLable.AutoSize = true;
            this.gameOverLable.Font = new System.Drawing.Font("Microsoft YaHei UI", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gameOverLable.Location = new System.Drawing.Point(216, 174);
            this.gameOverLable.Name = "gameOverLable";
            this.gameOverLable.Size = new System.Drawing.Size(325, 64);
            this.gameOverLable.TabIndex = 0;
            this.gameOverLable.Text = "GAME OVER";
            this.gameOverLable.Click += new System.EventHandler(this.label1_Click);
            // 
            // GameOverMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Maroon;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gameOverLable);
            this.Name = "GameOverMenu";
            this.Text = "GameOverMenu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label gameOverLable;
    }
}