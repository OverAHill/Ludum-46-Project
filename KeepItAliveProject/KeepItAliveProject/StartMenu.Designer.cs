namespace KeepItAliveProject
{
    partial class StartMenu
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
            this.startButton = new System.Windows.Forms.Button();
            this.pastelColourButton = new System.Windows.Forms.Button();
            this.gothColourButton = new System.Windows.Forms.Button();
            this.referenceColourButton = new System.Windows.Forms.Button();
            this.styleLabel = new System.Windows.Forms.Label();
            this.gameTitleLabel = new System.Windows.Forms.Label();
            this.warningLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // startButton
            // 
            this.startButton.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startButton.Location = new System.Drawing.Point(330, 324);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(135, 44);
            this.startButton.TabIndex = 1;
            this.startButton.Text = "Start";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // pastelColourButton
            // 
            this.pastelColourButton.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pastelColourButton.Location = new System.Drawing.Point(332, 223);
            this.pastelColourButton.Name = "pastelColourButton";
            this.pastelColourButton.Size = new System.Drawing.Size(135, 44);
            this.pastelColourButton.TabIndex = 2;
            this.pastelColourButton.Text = "Pastel";
            this.pastelColourButton.UseVisualStyleBackColor = true;
            this.pastelColourButton.Click += new System.EventHandler(this.pastelColourButton_Click);
            // 
            // gothColourButton
            // 
            this.gothColourButton.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gothColourButton.Location = new System.Drawing.Point(160, 223);
            this.gothColourButton.Name = "gothColourButton";
            this.gothColourButton.Size = new System.Drawing.Size(135, 44);
            this.gothColourButton.TabIndex = 3;
            this.gothColourButton.Text = "Goth";
            this.gothColourButton.UseVisualStyleBackColor = true;
            this.gothColourButton.Click += new System.EventHandler(this.gothColourButton_Click);
            // 
            // referenceColourButton
            // 
            this.referenceColourButton.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.referenceColourButton.Location = new System.Drawing.Point(521, 223);
            this.referenceColourButton.Name = "referenceColourButton";
            this.referenceColourButton.Size = new System.Drawing.Size(135, 44);
            this.referenceColourButton.TabIndex = 4;
            this.referenceColourButton.Text = "Reference";
            this.referenceColourButton.UseVisualStyleBackColor = true;
            this.referenceColourButton.Click += new System.EventHandler(this.referenceColourButton_Click);
            // 
            // styleLabel
            // 
            this.styleLabel.AutoSize = true;
            this.styleLabel.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.styleLabel.Location = new System.Drawing.Point(336, 164);
            this.styleLabel.Name = "styleLabel";
            this.styleLabel.Size = new System.Drawing.Size(142, 26);
            this.styleLabel.TabIndex = 5;
            this.styleLabel.Text = "Select A Style";
            // 
            // gameTitleLabel
            // 
            this.gameTitleLabel.AutoSize = true;
            this.gameTitleLabel.Font = new System.Drawing.Font("Microsoft YaHei UI", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gameTitleLabel.Location = new System.Drawing.Point(242, 70);
            this.gameTitleLabel.Name = "gameTitleLabel";
            this.gameTitleLabel.Size = new System.Drawing.Size(336, 46);
            this.gameTitleLabel.TabIndex = 6;
            this.gameTitleLabel.Text = "Title Of The Game";
            // 
            // warningLabel
            // 
            this.warningLabel.AutoSize = true;
            this.warningLabel.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.warningLabel.Location = new System.Drawing.Point(309, 383);
            this.warningLabel.Name = "warningLabel";
            this.warningLabel.Size = new System.Drawing.Size(193, 21);
            this.warningLabel.TabIndex = 7;
            this.warningLabel.Text = "Please select a style first";
            this.warningLabel.Visible = false;
            // 
            // StartMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.warningLabel);
            this.Controls.Add(this.gameTitleLabel);
            this.Controls.Add(this.styleLabel);
            this.Controls.Add(this.referenceColourButton);
            this.Controls.Add(this.gothColourButton);
            this.Controls.Add(this.pastelColourButton);
            this.Controls.Add(this.startButton);
            this.Name = "StartMenu";
            this.Text = "StartMenu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Button pastelColourButton;
        private System.Windows.Forms.Button gothColourButton;
        private System.Windows.Forms.Button referenceColourButton;
        private System.Windows.Forms.Label styleLabel;
        private System.Windows.Forms.Label gameTitleLabel;
        private System.Windows.Forms.Label warningLabel;
    }
}