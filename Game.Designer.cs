namespace Clicker_Game
{
    partial class game_form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(game_form));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.NameOfPlayer_label = new System.Windows.Forms.Label();
            this.Start_game_button = new System.Windows.Forms.Button();
            this.difficulty_groupBox = new System.Windows.Forms.GroupBox();
            this.Eazy_difficult_Button1 = new System.Windows.Forms.RadioButton();
            this.Hard_difficult_Button3 = new System.Windows.Forms.RadioButton();
            this.Medium_difficult_Button2 = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.ShowTimer_label = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.click_count_label = new System.Windows.Forms.Label();
            this.Exit_button_2ndForm = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.overallResult_label = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.difficulty_groupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.label1.Location = new System.Drawing.Point(-1, -3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 1136);
            this.label1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(8, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Welcome";
            // 
            // NameOfPlayer_label
            // 
            this.NameOfPlayer_label.AutoSize = true;
            this.NameOfPlayer_label.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.NameOfPlayer_label.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NameOfPlayer_label.Location = new System.Drawing.Point(-2, 37);
            this.NameOfPlayer_label.Name = "NameOfPlayer_label";
            this.NameOfPlayer_label.Size = new System.Drawing.Size(0, 19);
            this.NameOfPlayer_label.TabIndex = 2;
            // 
            // Start_game_button
            // 
            this.Start_game_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Start_game_button.Location = new System.Drawing.Point(16, 68);
            this.Start_game_button.Name = "Start_game_button";
            this.Start_game_button.Size = new System.Drawing.Size(68, 25);
            this.Start_game_button.TabIndex = 3;
            this.Start_game_button.Text = "Start";
            this.Start_game_button.UseVisualStyleBackColor = true;
            this.Start_game_button.Click += new System.EventHandler(this.Start_game_button_Click);
            // 
            // difficulty_groupBox
            // 
            this.difficulty_groupBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.difficulty_groupBox.Controls.Add(this.Eazy_difficult_Button1);
            this.difficulty_groupBox.Controls.Add(this.Hard_difficult_Button3);
            this.difficulty_groupBox.Controls.Add(this.Medium_difficult_Button2);
            this.difficulty_groupBox.Location = new System.Drawing.Point(12, 119);
            this.difficulty_groupBox.Name = "difficulty_groupBox";
            this.difficulty_groupBox.Size = new System.Drawing.Size(86, 105);
            this.difficulty_groupBox.TabIndex = 4;
            this.difficulty_groupBox.TabStop = false;
            this.difficulty_groupBox.Text = "Difficulty:";
            // 
            // Eazy_difficult_Button1
            // 
            this.Eazy_difficult_Button1.AutoSize = true;
            this.Eazy_difficult_Button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Eazy_difficult_Button1.Location = new System.Drawing.Point(9, 19);
            this.Eazy_difficult_Button1.Name = "Eazy_difficult_Button1";
            this.Eazy_difficult_Button1.Size = new System.Drawing.Size(60, 20);
            this.Eazy_difficult_Button1.TabIndex = 10;
            this.Eazy_difficult_Button1.TabStop = true;
            this.Eazy_difficult_Button1.Text = "Easy";
            this.Eazy_difficult_Button1.UseVisualStyleBackColor = true;
            // 
            // Hard_difficult_Button3
            // 
            this.Hard_difficult_Button3.AutoSize = true;
            this.Hard_difficult_Button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Hard_difficult_Button3.Location = new System.Drawing.Point(6, 71);
            this.Hard_difficult_Button3.Name = "Hard_difficult_Button3";
            this.Hard_difficult_Button3.Size = new System.Drawing.Size(59, 20);
            this.Hard_difficult_Button3.TabIndex = 12;
            this.Hard_difficult_Button3.TabStop = true;
            this.Hard_difficult_Button3.Text = "Hard";
            this.Hard_difficult_Button3.UseVisualStyleBackColor = true;
            // 
            // Medium_difficult_Button2
            // 
            this.Medium_difficult_Button2.AutoSize = true;
            this.Medium_difficult_Button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Medium_difficult_Button2.Location = new System.Drawing.Point(6, 45);
            this.Medium_difficult_Button2.Name = "Medium_difficult_Button2";
            this.Medium_difficult_Button2.Size = new System.Drawing.Size(79, 20);
            this.Medium_difficult_Button2.TabIndex = 11;
            this.Medium_difficult_Button2.TabStop = true;
            this.Medium_difficult_Button2.Text = "Medium";
            this.Medium_difficult_Button2.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei", 12.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(25, 279);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 24);
            this.label4.TabIndex = 5;
            this.label4.Text = "Time";
            // 
            // ShowTimer_label
            // 
            this.ShowTimer_label.AutoSize = true;
            this.ShowTimer_label.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ShowTimer_label.Font = new System.Drawing.Font("Microsoft YaHei", 12.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ShowTimer_label.Location = new System.Drawing.Point(31, 303);
            this.ShowTimer_label.Name = "ShowTimer_label";
            this.ShowTimer_label.Size = new System.Drawing.Size(0, 24);
            this.ShowTimer_label.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei", 12.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(25, 344);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 24);
            this.label6.TabIndex = 7;
            this.label6.Text = "Score";
            // 
            // click_count_label
            // 
            this.click_count_label.AutoSize = true;
            this.click_count_label.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.click_count_label.Font = new System.Drawing.Font("Microsoft YaHei", 12.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.click_count_label.Location = new System.Drawing.Point(46, 368);
            this.click_count_label.Name = "click_count_label";
            this.click_count_label.Size = new System.Drawing.Size(0, 24);
            this.click_count_label.TabIndex = 8;
            // 
            // Exit_button_2ndForm
            // 
            this.Exit_button_2ndForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Exit_button_2ndForm.Location = new System.Drawing.Point(21, 414);
            this.Exit_button_2ndForm.Name = "Exit_button_2ndForm";
            this.Exit_button_2ndForm.Size = new System.Drawing.Size(68, 25);
            this.Exit_button_2ndForm.TabIndex = 9;
            this.Exit_button_2ndForm.Text = "Exit";
            this.Exit_button_2ndForm.UseVisualStyleBackColor = true;
            this.Exit_button_2ndForm.Click += new System.EventHandler(this.Exit_button_2ndForm_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(435, 33);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(88, 88);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 10;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Visible = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Enabled = false;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(180, 33);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(115, 106);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Visible = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(339, 37);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(81, 62);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 12;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Visible = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            // 
            // overallResult_label
            // 
            this.overallResult_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.overallResult_label.ForeColor = System.Drawing.Color.Red;
            this.overallResult_label.Location = new System.Drawing.Point(254, 231);
            this.overallResult_label.Name = "overallResult_label";
            this.overallResult_label.Size = new System.Drawing.Size(293, 115);
            this.overallResult_label.TabIndex = 14;
            this.overallResult_label.Text = "Game Over Score: ";
            this.overallResult_label.Visible = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(227, 414);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(68, 54);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 15;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Visible = false;
            this.pictureBox4.Click += new System.EventHandler(this.pictureBox4_Click);
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(169, 473);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(50, 40);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 16;
            this.pictureBox5.TabStop = false;
            this.pictureBox5.Visible = false;
            this.pictureBox5.Click += new System.EventHandler(this.pictureBox5_Click);
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox6.Image")));
            this.pictureBox6.Location = new System.Drawing.Point(158, 390);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(40, 33);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox6.TabIndex = 17;
            this.pictureBox6.TabStop = false;
            this.pictureBox6.Visible = false;
            this.pictureBox6.Click += new System.EventHandler(this.pictureBox6_Click);
            // 
            // pictureBox7
            // 
            this.pictureBox7.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox7.Image")));
            this.pictureBox7.Location = new System.Drawing.Point(158, 429);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(34, 29);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox7.TabIndex = 18;
            this.pictureBox7.TabStop = false;
            this.pictureBox7.Visible = false;
            this.pictureBox7.Click += new System.EventHandler(this.pictureBox7_Click);
            // 
            // game_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(723, 548);
            this.Controls.Add(this.pictureBox7);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.overallResult_label);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.Exit_button_2ndForm);
            this.Controls.Add(this.click_count_label);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.ShowTimer_label);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.difficulty_groupBox);
            this.Controls.Add(this.Start_game_button);
            this.Controls.Add(this.NameOfPlayer_label);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "game_form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Game";
            this.Load += new System.EventHandler(this.Game_Load);
            this.difficulty_groupBox.ResumeLayout(false);
            this.difficulty_groupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label NameOfPlayer_label;
        private System.Windows.Forms.Button Start_game_button;
        private System.Windows.Forms.GroupBox difficulty_groupBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label ShowTimer_label;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label click_count_label;
        private System.Windows.Forms.Button Exit_button_2ndForm;
        private System.Windows.Forms.RadioButton Eazy_difficult_Button1;
        private System.Windows.Forms.RadioButton Hard_difficult_Button3;
        private System.Windows.Forms.RadioButton Medium_difficult_Button2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label overallResult_label;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox pictureBox7;
    }
}