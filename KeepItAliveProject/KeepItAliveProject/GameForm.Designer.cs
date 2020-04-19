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
            this.components = new System.ComponentModel.Container();
            this.petButton = new System.Windows.Forms.Button();
            this.feedButton = new System.Windows.Forms.Button();
            this.tickleButton = new System.Windows.Forms.Button();
            this.creatureNameBox = new System.Windows.Forms.Label();
            this.hpLabel = new System.Windows.Forms.Label();
            this.hapinessLabel = new System.Windows.Forms.Label();
            this.graphicTimer = new System.Windows.Forms.Timer(this.components);
            this.hungerLabel = new System.Windows.Forms.Label();
            this.tutorialLabel = new System.Windows.Forms.Label();
            this.tutorialLabel2 = new System.Windows.Forms.Label();
            this.tutorialLabel3 = new System.Windows.Forms.Label();
            this.sacrifcesLabel = new System.Windows.Forms.Label();
            this.playerHealthLabel = new System.Windows.Forms.Label();
            this.youCantWinLabel = new System.Windows.Forms.Label();
            this.goodbyeLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // petButton
            // 
            this.petButton.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.petButton.Location = new System.Drawing.Point(641, 240);
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
            this.feedButton.Location = new System.Drawing.Point(641, 309);
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
            this.tickleButton.Location = new System.Drawing.Point(641, 378);
            this.tickleButton.Name = "tickleButton";
            this.tickleButton.Size = new System.Drawing.Size(135, 44);
            this.tickleButton.TabIndex = 2;
            this.tickleButton.Text = "Tickle";
            this.tickleButton.UseVisualStyleBackColor = true;
            this.tickleButton.Click += new System.EventHandler(this.tickleButton_Click);
            // 
            // creatureNameBox
            // 
            this.creatureNameBox.AutoSize = true;
            this.creatureNameBox.BackColor = System.Drawing.Color.Transparent;
            this.creatureNameBox.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.creatureNameBox.Location = new System.Drawing.Point(21, 34);
            this.creatureNameBox.Name = "creatureNameBox";
            this.creatureNameBox.Size = new System.Drawing.Size(183, 26);
            this.creatureNameBox.TabIndex = 3;
            this.creatureNameBox.Text = "Name of Creature";
            this.creatureNameBox.Click += new System.EventHandler(this.creatureNameBox_Click);
            // 
            // hpLabel
            // 
            this.hpLabel.AutoSize = true;
            this.hpLabel.BackColor = System.Drawing.Color.Transparent;
            this.hpLabel.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hpLabel.Location = new System.Drawing.Point(19, 83);
            this.hpLabel.Name = "hpLabel";
            this.hpLabel.Size = new System.Drawing.Size(49, 28);
            this.hpLabel.TabIndex = 4;
            this.hpLabel.Text = "HP:";
            // 
            // hapinessLabel
            // 
            this.hapinessLabel.AutoSize = true;
            this.hapinessLabel.BackColor = System.Drawing.Color.Transparent;
            this.hapinessLabel.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hapinessLabel.Location = new System.Drawing.Point(21, 131);
            this.hapinessLabel.Name = "hapinessLabel";
            this.hapinessLabel.Size = new System.Drawing.Size(127, 28);
            this.hapinessLabel.TabIndex = 5;
            this.hapinessLabel.Text = "Happiness:";
            // 
            // hungerLabel
            // 
            this.hungerLabel.AutoSize = true;
            this.hungerLabel.BackColor = System.Drawing.Color.Transparent;
            this.hungerLabel.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hungerLabel.Location = new System.Drawing.Point(21, 179);
            this.hungerLabel.Name = "hungerLabel";
            this.hungerLabel.Size = new System.Drawing.Size(98, 28);
            this.hungerLabel.TabIndex = 6;
            this.hungerLabel.Text = "Hunger:";
            // 
            // tutorialLabel
            // 
            this.tutorialLabel.AutoSize = true;
            this.tutorialLabel.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tutorialLabel.Location = new System.Drawing.Point(563, 221);
            this.tutorialLabel.Name = "tutorialLabel";
            this.tutorialLabel.Size = new System.Drawing.Size(100, 16);
            this.tutorialLabel.TabIndex = 7;
            this.tutorialLabel.Text = "Try Clicking Pet ";
            // 
            // tutorialLabel2
            // 
            this.tutorialLabel2.AutoSize = true;
            this.tutorialLabel2.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tutorialLabel2.Location = new System.Drawing.Point(563, 290);
            this.tutorialLabel2.Name = "tutorialLabel2";
            this.tutorialLabel2.Size = new System.Drawing.Size(89, 16);
            this.tutorialLabel2.TabIndex = 8;
            this.tutorialLabel2.Text = "Now Try Feed";
            this.tutorialLabel2.Visible = false;
            // 
            // tutorialLabel3
            // 
            this.tutorialLabel3.AutoSize = true;
            this.tutorialLabel3.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tutorialLabel3.Location = new System.Drawing.Point(563, 359);
            this.tutorialLabel3.Name = "tutorialLabel3";
            this.tutorialLabel3.Size = new System.Drawing.Size(104, 16);
            this.tutorialLabel3.TabIndex = 9;
            this.tutorialLabel3.Text = "And finally Tickle";
            this.tutorialLabel3.Visible = false;
            // 
            // sacrifcesLabel
            // 
            this.sacrifcesLabel.AutoSize = true;
            this.sacrifcesLabel.BackColor = System.Drawing.Color.Transparent;
            this.sacrifcesLabel.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sacrifcesLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.sacrifcesLabel.Location = new System.Drawing.Point(21, 342);
            this.sacrifcesLabel.Name = "sacrifcesLabel";
            this.sacrifcesLabel.Size = new System.Drawing.Size(117, 28);
            this.sacrifcesLabel.TabIndex = 10;
            this.sacrifcesLabel.Text = "Sacrifices:";
            this.sacrifcesLabel.Visible = false;
            // 
            // playerHealthLabel
            // 
            this.playerHealthLabel.AutoSize = true;
            this.playerHealthLabel.BackColor = System.Drawing.Color.Transparent;
            this.playerHealthLabel.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playerHealthLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.playerHealthLabel.Location = new System.Drawing.Point(21, 394);
            this.playerHealthLabel.Name = "playerHealthLabel";
            this.playerHealthLabel.Size = new System.Drawing.Size(106, 28);
            this.playerHealthLabel.TabIndex = 11;
            this.playerHealthLabel.Text = "Your HP:";
            this.playerHealthLabel.Visible = false;
            // 
            // youCantWinLabel
            // 
            this.youCantWinLabel.AutoSize = true;
            this.youCantWinLabel.BackColor = System.Drawing.Color.Transparent;
            this.youCantWinLabel.Font = new System.Drawing.Font("Microsoft YaHei UI", 48F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.youCantWinLabel.Location = new System.Drawing.Point(105, 73);
            this.youCantWinLabel.Name = "youCantWinLabel";
            this.youCantWinLabel.Size = new System.Drawing.Size(575, 86);
            this.youCantWinLabel.TabIndex = 12;
            this.youCantWinLabel.Text = "Y oU Ca n T Wi n";
            this.youCantWinLabel.Visible = false;
            // 
            // goodbyeLabel
            // 
            this.goodbyeLabel.AutoSize = true;
            this.goodbyeLabel.BackColor = System.Drawing.Color.Transparent;
            this.goodbyeLabel.Font = new System.Drawing.Font("Monotype Corsiva", 48F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.goodbyeLabel.Location = new System.Drawing.Point(274, 80);
            this.goodbyeLabel.Name = "goodbyeLabel";
            this.goodbyeLabel.Size = new System.Drawing.Size(236, 79);
            this.goodbyeLabel.TabIndex = 13;
            this.goodbyeLabel.Text = "Goodbye";
            this.goodbyeLabel.Visible = false;
            // 
            // GameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.goodbyeLabel);
            this.Controls.Add(this.youCantWinLabel);
            this.Controls.Add(this.playerHealthLabel);
            this.Controls.Add(this.sacrifcesLabel);
            this.Controls.Add(this.tutorialLabel3);
            this.Controls.Add(this.tutorialLabel2);
            this.Controls.Add(this.tutorialLabel);
            this.Controls.Add(this.hungerLabel);
            this.Controls.Add(this.hapinessLabel);
            this.Controls.Add(this.hpLabel);
            this.Controls.Add(this.creatureNameBox);
            this.Controls.Add(this.tickleButton);
            this.Controls.Add(this.feedButton);
            this.Controls.Add(this.petButton);
            this.Name = "GameForm";
            this.Text = "GameForm";
            this.Load += new System.EventHandler(this.GameForm_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.GameForm_Paint);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button petButton;
        private System.Windows.Forms.Button feedButton;
        private System.Windows.Forms.Button tickleButton;
        private System.Windows.Forms.Label creatureNameBox;
        private System.Windows.Forms.Label hpLabel;
        private System.Windows.Forms.Label hapinessLabel;
        private System.Windows.Forms.Timer graphicTimer;
        private System.Windows.Forms.Label hungerLabel;
        private System.Windows.Forms.Label tutorialLabel;
        private System.Windows.Forms.Label tutorialLabel2;
        private System.Windows.Forms.Label tutorialLabel3;
        private System.Windows.Forms.Label sacrifcesLabel;
        private System.Windows.Forms.Label playerHealthLabel;
        private System.Windows.Forms.Label youCantWinLabel;
        private System.Windows.Forms.Label goodbyeLabel;
    }


}