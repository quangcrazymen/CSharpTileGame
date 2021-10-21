
namespace colorGame
{
    partial class Game
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Game));
            this.puzzle = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.StartBtn = new System.Windows.Forms.Button();
            this.Tile1 = new System.Windows.Forms.Button();
            this.Tile2 = new System.Windows.Forms.Button();
            this.Tile3 = new System.Windows.Forms.Button();
            this.Tile4 = new System.Windows.Forms.Button();
            this.Tile5 = new System.Windows.Forms.Button();
            this.Tile6 = new System.Windows.Forms.Button();
            this.Tile7 = new System.Windows.Forms.Button();
            this.Tile8 = new System.Windows.Forms.Button();
            this.Tile9 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Test = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.puzzle)).BeginInit();
            this.SuspendLayout();
            // 
            // puzzle
            // 
            this.puzzle.Image = global::colorGame.Properties.Resources.M20;
            this.puzzle.Location = new System.Drawing.Point(493, 63);
            this.puzzle.Name = "puzzle";
            this.puzzle.Size = new System.Drawing.Size(418, 360);
            this.puzzle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.puzzle.TabIndex = 0;
            this.puzzle.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(459, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(17, 450);
            this.label1.TabIndex = 1;
            this.label1.Text = "|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n\r\n";
            // 
            // StartBtn
            // 
            this.StartBtn.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.StartBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.StartBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.StartBtn.Image = global::colorGame.Properties.Resources._25263_here_orange_start_icon;
            this.StartBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.StartBtn.Location = new System.Drawing.Point(383, 452);
            this.StartBtn.Name = "StartBtn";
            this.StartBtn.Size = new System.Drawing.Size(153, 77);
            this.StartBtn.TabIndex = 2;
            this.StartBtn.Text = "Start";
            this.StartBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.StartBtn.UseVisualStyleBackColor = false;
            this.StartBtn.Click += new System.EventHandler(this.StartBtn_Click);
            // 
            // Tile1
            // 
            this.Tile1.Location = new System.Drawing.Point(28, 63);
            this.Tile1.Name = "Tile1";
            this.Tile1.Size = new System.Drawing.Size(132, 117);
            this.Tile1.TabIndex = 3;
            this.Tile1.Text = "button1";
            this.Tile1.UseVisualStyleBackColor = true;
            this.Tile1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Tile1_KeyDown);
            // 
            // Tile2
            // 
            this.Tile2.Location = new System.Drawing.Point(166, 63);
            this.Tile2.Name = "Tile2";
            this.Tile2.Size = new System.Drawing.Size(132, 117);
            this.Tile2.TabIndex = 4;
            this.Tile2.Text = "button2";
            this.Tile2.UseVisualStyleBackColor = true;
            this.Tile2.ChangeUICues += new System.Windows.Forms.UICuesEventHandler(this.Tile2_ChangeUICues);
            // 
            // Tile3
            // 
            this.Tile3.Location = new System.Drawing.Point(304, 63);
            this.Tile3.Name = "Tile3";
            this.Tile3.Size = new System.Drawing.Size(132, 117);
            this.Tile3.TabIndex = 5;
            this.Tile3.Text = "button3";
            this.Tile3.UseVisualStyleBackColor = true;
            // 
            // Tile4
            // 
            this.Tile4.Location = new System.Drawing.Point(28, 186);
            this.Tile4.Name = "Tile4";
            this.Tile4.Size = new System.Drawing.Size(132, 117);
            this.Tile4.TabIndex = 6;
            this.Tile4.Text = "button4";
            this.Tile4.UseVisualStyleBackColor = true;
            this.Tile4.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Tile4_KeyDown);
            // 
            // Tile5
            // 
            this.Tile5.Location = new System.Drawing.Point(166, 186);
            this.Tile5.Name = "Tile5";
            this.Tile5.Size = new System.Drawing.Size(132, 117);
            this.Tile5.TabIndex = 7;
            this.Tile5.Text = "button5";
            this.Tile5.UseVisualStyleBackColor = true;
            // 
            // Tile6
            // 
            this.Tile6.Location = new System.Drawing.Point(304, 186);
            this.Tile6.Name = "Tile6";
            this.Tile6.Size = new System.Drawing.Size(132, 117);
            this.Tile6.TabIndex = 8;
            this.Tile6.Text = "button6";
            this.Tile6.UseVisualStyleBackColor = true;
            // 
            // Tile7
            // 
            this.Tile7.Location = new System.Drawing.Point(28, 309);
            this.Tile7.Name = "Tile7";
            this.Tile7.Size = new System.Drawing.Size(132, 117);
            this.Tile7.TabIndex = 9;
            this.Tile7.Text = "button7";
            this.Tile7.UseVisualStyleBackColor = true;
            // 
            // Tile8
            // 
            this.Tile8.Location = new System.Drawing.Point(166, 309);
            this.Tile8.Name = "Tile8";
            this.Tile8.Size = new System.Drawing.Size(132, 117);
            this.Tile8.TabIndex = 10;
            this.Tile8.Text = "button8";
            this.Tile8.UseVisualStyleBackColor = true;
            // 
            // Tile9
            // 
            this.Tile9.Location = new System.Drawing.Point(304, 309);
            this.Tile9.Name = "Tile9";
            this.Tile9.Size = new System.Drawing.Size(132, 117);
            this.Tile9.TabIndex = 11;
            this.Tile9.Text = "button9";
            this.Tile9.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(71, 468);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 36);
            this.label2.TabIndex = 12;
            this.label2.Text = "Steps: 0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(498, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(136, 36);
            this.label3.TabIndex = 13;
            this.label3.Text = "Example";
            // 
            // Test
            // 
            this.Test.AutoSize = true;
            this.Test.Location = new System.Drawing.Point(318, 16);
            this.Test.Name = "Test";
            this.Test.Size = new System.Drawing.Size(46, 17);
            this.Test.TabIndex = 14;
            this.Test.Text = "label4";
            // 
            // Game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.ClientSize = new System.Drawing.Size(935, 567);
            this.Controls.Add(this.Test);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Tile9);
            this.Controls.Add(this.Tile8);
            this.Controls.Add(this.Tile7);
            this.Controls.Add(this.Tile6);
            this.Controls.Add(this.Tile5);
            this.Controls.Add(this.Tile4);
            this.Controls.Add(this.Tile3);
            this.Controls.Add(this.Tile2);
            this.Controls.Add(this.Tile1);
            this.Controls.Add(this.StartBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.puzzle);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "Game";
            this.Text = "Game";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Game_KeyDown);
            this.ChangeUICues += new System.Windows.Forms.UICuesEventHandler(this.Game_ChangeUICues);
            ((System.ComponentModel.ISupportInitialize)(this.puzzle)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox puzzle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button StartBtn;
        private System.Windows.Forms.Button Tile1;
        private System.Windows.Forms.Button Tile2;
        private System.Windows.Forms.Button Tile3;
        private System.Windows.Forms.Button Tile4;
        private System.Windows.Forms.Button Tile5;
        private System.Windows.Forms.Button Tile6;
        private System.Windows.Forms.Button Tile7;
        private System.Windows.Forms.Button Tile8;
        private System.Windows.Forms.Button Tile9;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label Test;
    }
}

