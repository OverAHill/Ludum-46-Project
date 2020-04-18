namespace KeepItAliveProject
{
    partial class GameForm
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
            this.petButton = new System.Windows.Forms.Button();
            this.feedButton = new System.Windows.Forms.Button();
            this.tickleButton = new System.Windows.Forms.Button();
            this.creatureName = new System.Windows.Forms.Label();
            this.hpLabel = new System.Windows.Forms.Label();
            this.hapinessLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // petButton
            // 
            this.petButton.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.petButton.Location = new System.Drawing.Point(639, 34);
            this.petButton.Name = "petButton";
            this.petButton.Size = new System.Drawing.Size(135, 44);
            this.petButton.TabIndex = 0;
            this.petButton.Text = "Pet";
            this.petButton.UseVisualStyleBackColor = true;
            this.petButton.Click += new System.EventHandler(this.petButton_Click);
            // 
            // feedButton
            // 
            this.feedButton.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.feedButton.Location = new System.Drawing.Point(639, 103);
            this.feedButton.Name = "feedButton";
            this.feedButton.Size = new System.Drawing.Size(135, 44);
            this.feedButton.TabIndex = 1;
            this.feedButton.Text = "Feed";
            this.feedButton.UseVisualStyleBackColor = true;
            this.feedButton.Click += new System.EventHandler(this.feedButton_Click);
            // 
            // tickleButton
            // 
            this.tickleButton.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tickleButton.Location = new System.Drawing.Point(639, 172);
            this.tickleButton.Name = "tickleButton";
            this.tickleButton.Size = new System.Drawing.Size(135, 44);
            this.tickleButton.TabIndex = 2;
            this.tickleButton.Text = "Tickle";
            this.tickleButton.UseVisualStyleBackColor = true;
            this.tickleButton.Click += new System.EventHandler(this.tickleButton_Click);
            // 
            // creatureName
            // 
            this.creatureName.AutoSize = true;
            this.creatureName.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.creatureName.Location = new System.Drawing.Point(40, 34);
            this.creatureName.Name = "creatureName";
            this.creatureName.Size = new System.Drawing.Size(183, 26);
            this.creatureName.TabIndex = 3;
            this.creatureName.Text = "Name of Creature";
            // 
            // hpLabel
            // 
            this.hpLabel.AutoSize = true;
            this.hpLabel.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hpLabel.Location = new System.Drawing.Point(38, 83);
            this.hpLabel.Name = "hpLabel";
            this.hpLabel.Size = new System.Drawing.Size(49, 28);
            this.hpLabel.TabIndex = 4;
            this.hpLabel.Text = "HP:";
            // 
            // hapinessLabel
            // 
            this.hapinessLabel.AutoSize = true;
            this.hapinessLabel.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hapinessLabel.Location = new System.Drawing.Point(40, 131);
            this.hapinessLabel.Name = "hapinessLabel";
            this.hapinessLabel.Size = new System.Drawing.Size(127, 28);
            this.hapinessLabel.TabIndex = 5;
            this.hapinessLabel.Text = "Happiness:";
            // 
            // GameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.hapinessLabel);
            this.Controls.Add(this.hpLabel);
            this.Controls.Add(this.creatureName);
            this.Controls.Add(this.tickleButton);
            this.Controls.Add(this.feedButton);
            this.Controls.Add(this.petButton);
            this.Name = "GameForm";
            this.Text = "GameForm";
            this.Load += new System.EventHandler(this.GameForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button petButton;
        private System.Windows.Forms.Button feedButton;
        private System.Windows.Forms.Button tickleButton;
        private System.Windows.Forms.Label creatureName;
        private System.Windows.Forms.Label hpLabel;
        private System.Windows.Forms.Label hapinessLabel;
    }
}