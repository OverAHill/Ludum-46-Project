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
            this.nameTextLabel = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.RichTextBox();
            this.enterNameWarningLabel = new System.Windows.Forms.Label();
            this.enterNameWarningLabel2 = new System.Windows.Forms.Label();
            this.playerNameTextBox = new System.Windows.Forms.RichTextBox();
            this.playerNameLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // startButton
            // 
            this.startButton.BackColor = System.Drawing.Color.White;
            this.startButton.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startButton.Location = new System.Drawing.Point(330, 324);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(135, 44);
            this.startButton.TabIndex = 1;
            this.startButton.Text = "Start";
            this.startButton.UseVisualStyleBackColor = false;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // pastelColourButton
            // 
            this.pastelColourButton.BackColor = System.Drawing.Color.White;
            this.pastelColourButton.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pastelColourButton.Location = new System.Drawing.Point(331, 258);
            this.pastelColourButton.Name = "pastelColourButton";
            this.pastelColourButton.Size = new System.Drawing.Size(135, 44);
            this.pastelColourButton.TabIndex = 2;
            this.pastelColourButton.Text = "Pastel";
            this.pastelColourButton.UseVisualStyleBackColor = false;
            this.pastelColourButton.Click += new System.EventHandler(this.pastelColourButton_Click);
            // 
            // gothColourButton
            // 
            this.gothColourButton.BackColor = System.Drawing.Color.White;
            this.gothColourButton.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gothColourButton.Location = new System.Drawing.Point(159, 258);
            this.gothColourButton.Name = "gothColourButton";
            this.gothColourButton.Size = new System.Drawing.Size(135, 44);
            this.gothColourButton.TabIndex = 3;
            this.gothColourButton.Text = "Goth";
            this.gothColourButton.UseVisualStyleBackColor = false;
            this.gothColourButton.Click += new System.EventHandler(this.gothColourButton_Click);
            // 
            // referenceColourButton
            // 
            this.referenceColourButton.BackColor = System.Drawing.Color.White;
            this.referenceColourButton.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.referenceColourButton.Location = new System.Drawing.Point(520, 258);
            this.referenceColourButton.Name = "referenceColourButton";
            this.referenceColourButton.Size = new System.Drawing.Size(135, 44);
            this.referenceColourButton.TabIndex = 4;
            this.referenceColourButton.Text = "Strange";
            this.referenceColourButton.UseVisualStyleBackColor = false;
            this.referenceColourButton.Click += new System.EventHandler(this.referenceColourButton_Click);
            // 
            // styleLabel
            // 
            this.styleLabel.AutoSize = true;
            this.styleLabel.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.styleLabel.Location = new System.Drawing.Point(335, 220);
            this.styleLabel.Name = "styleLabel";
            this.styleLabel.Size = new System.Drawing.Size(142, 26);
            this.styleLabel.TabIndex = 5;
            this.styleLabel.Text = "Select A Style";
            // 
            // gameTitleLabel
            // 
            this.gameTitleLabel.AutoSize = true;
            this.gameTitleLabel.Font = new System.Drawing.Font("Microsoft YaHei UI", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gameTitleLabel.Location = new System.Drawing.Point(272, 37);
            this.gameTitleLabel.Name = "gameTitleLabel";
            this.gameTitleLabel.Size = new System.Drawing.Size(251, 64);
            this.gameTitleLabel.TabIndex = 6;
            this.gameTitleLabel.Text = "Feed Me!";
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
            // nameTextLabel
            // 
            this.nameTextLabel.AutoSize = true;
            this.nameTextLabel.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameTextLabel.Location = new System.Drawing.Point(468, 131);
            this.nameTextLabel.Name = "nameTextLabel";
            this.nameTextLabel.Size = new System.Drawing.Size(182, 26);
            this.nameTextLabel.TabIndex = 8;
            this.nameTextLabel.Text = "Enter A Pet Name";
            // 
            // nameTextBox
            // 
            this.nameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameTextBox.Location = new System.Drawing.Point(439, 160);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(258, 26);
            this.nameTextBox.TabIndex = 9;
            this.nameTextBox.Text = "";
            // 
            // enterNameWarningLabel
            // 
            this.enterNameWarningLabel.AutoSize = true;
            this.enterNameWarningLabel.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enterNameWarningLabel.Location = new System.Drawing.Point(455, 189);
            this.enterNameWarningLabel.Name = "enterNameWarningLabel";
            this.enterNameWarningLabel.Size = new System.Drawing.Size(202, 21);
            this.enterNameWarningLabel.TabIndex = 10;
            this.enterNameWarningLabel.Text = "Please select a name first";
            this.enterNameWarningLabel.Visible = false;
            // 
            // enterNameWarningLabel2
            // 
            this.enterNameWarningLabel2.AutoSize = true;
            this.enterNameWarningLabel2.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enterNameWarningLabel2.Location = new System.Drawing.Point(133, 189);
            this.enterNameWarningLabel2.Name = "enterNameWarningLabel2";
            this.enterNameWarningLabel2.Size = new System.Drawing.Size(202, 21);
            this.enterNameWarningLabel2.TabIndex = 13;
            this.enterNameWarningLabel2.Text = "Please select a name first";
            this.enterNameWarningLabel2.Visible = false;
            this.enterNameWarningLabel2.Click += new System.EventHandler(this.label1_Click);
            // 
            // playerNameTextBox
            // 
            this.playerNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playerNameTextBox.Location = new System.Drawing.Point(109, 160);
            this.playerNameTextBox.Name = "playerNameTextBox";
            this.playerNameTextBox.Size = new System.Drawing.Size(241, 26);
            this.playerNameTextBox.TabIndex = 12;
            this.playerNameTextBox.Text = "";
            this.playerNameTextBox.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // playerNameLabel
            // 
            this.playerNameLabel.AutoSize = true;
            this.playerNameLabel.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playerNameLabel.Location = new System.Drawing.Point(146, 131);
            this.playerNameLabel.Name = "playerNameLabel";
            this.playerNameLabel.Size = new System.Drawing.Size(175, 26);
            this.playerNameLabel.TabIndex = 11;
            this.playerNameLabel.Text = "Enter Your Name";
            this.playerNameLabel.Click += new System.EventHandler(this.label2_Click);
            // 
            // StartMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.enterNameWarningLabel2);
            this.Controls.Add(this.playerNameTextBox);
            this.Controls.Add(this.playerNameLabel);
            this.Controls.Add(this.enterNameWarningLabel);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.nameTextLabel);
            this.Controls.Add(this.warningLabel);
            this.Controls.Add(this.gameTitleLabel);
            this.Controls.Add(this.styleLabel);
            this.Controls.Add(this.referenceColourButton);
            this.Controls.Add(this.gothColourButton);
            this.Controls.Add(this.pastelColourButton);
            this.Controls.Add(this.startButton);
            this.Name = "StartMenu";
            this.Text = "StartMenu";
            this.Load += new System.EventHandler(this.StartMenu_Load);
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
        private System.Windows.Forms.Label nameTextLabel;
        private System.Windows.Forms.RichTextBox nameTextBox;
        private System.Windows.Forms.Label enterNameWarningLabel;
        private System.Windows.Forms.Label enterNameWarningLabel2;
        private System.Windows.Forms.RichTextBox playerNameTextBox;
        private System.Windows.Forms.Label playerNameLabel;
    }
}