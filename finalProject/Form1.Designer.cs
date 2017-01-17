namespace finalProject
{
    partial class sunOnYee
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(sunOnYee));
            this.titleLabel = new System.Windows.Forms.Label();
            this.subtitleLabel = new System.Windows.Forms.Label();
            this.startGame = new System.Windows.Forms.Button();
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.instructionsLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.BackColor = System.Drawing.Color.Transparent;
            this.titleLabel.Font = new System.Drawing.Font("Modern No. 20", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.ForeColor = System.Drawing.Color.Red;
            this.titleLabel.Location = new System.Drawing.Point(12, 9);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(207, 38);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "Sun On Yee";
            // 
            // subtitleLabel
            // 
            this.subtitleLabel.AutoSize = true;
            this.subtitleLabel.BackColor = System.Drawing.Color.Transparent;
            this.subtitleLabel.Font = new System.Drawing.Font("Modern No. 20", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subtitleLabel.ForeColor = System.Drawing.Color.White;
            this.subtitleLabel.Location = new System.Drawing.Point(225, 16);
            this.subtitleLabel.Name = "subtitleLabel";
            this.subtitleLabel.Size = new System.Drawing.Size(109, 29);
            this.subtitleLabel.TabIndex = 1;
            this.subtitleLabel.Text = "太陽在怡";
            // 
            // startGame
            // 
            this.startGame.BackColor = System.Drawing.Color.Red;
            this.startGame.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.startGame.FlatAppearance.BorderSize = 2;
            this.startGame.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Cyan;
            this.startGame.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.startGame.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F, System.Drawing.FontStyle.Bold);
            this.startGame.ForeColor = System.Drawing.Color.White;
            this.startGame.Location = new System.Drawing.Point(260, 334);
            this.startGame.Name = "startGame";
            this.startGame.Size = new System.Drawing.Size(233, 46);
            this.startGame.TabIndex = 2;
            this.startGame.Text = "Click To Start";
            this.startGame.UseVisualStyleBackColor = false;
            this.startGame.Click += new System.EventHandler(this.startGame_Click);
            // 
            // gameTimer
            // 
            this.gameTimer.Interval = 16;
            this.gameTimer.Tick += new System.EventHandler(this.gameTimer_Tick);
            // 
            // instructionsLabel
            // 
            this.instructionsLabel.AutoSize = true;
            this.instructionsLabel.BackColor = System.Drawing.Color.Transparent;
            this.instructionsLabel.Font = new System.Drawing.Font("Modern No. 20", 27.75F, System.Drawing.FontStyle.Bold);
            this.instructionsLabel.ForeColor = System.Drawing.Color.White;
            this.instructionsLabel.Location = new System.Drawing.Point(456, 558);
            this.instructionsLabel.Name = "instructionsLabel";
            this.instructionsLabel.Size = new System.Drawing.Size(263, 38);
            this.instructionsLabel.TabIndex = 3;
            this.instructionsLabel.Text = "WASD to move";
            // 
            // sunOnYee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::finalProject.Properties.Resources.background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(734, 606);
            this.Controls.Add(this.instructionsLabel);
            this.Controls.Add(this.startGame);
            this.Controls.Add(this.subtitleLabel);
            this.Controls.Add(this.titleLabel);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "sunOnYee";
            this.Text = "Sun On Yee";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.sunOnYee_Paint);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.sunOnYee_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.sunOnYee_KeyUp);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label subtitleLabel;
        private System.Windows.Forms.Button startGame;
        private System.Windows.Forms.Timer gameTimer;
        private System.Windows.Forms.Label instructionsLabel;
    }
}

