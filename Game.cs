using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace Clicker_Game
{
    public partial class game_form : Form 
    {
        private Random random = new Random();              
        private difficulty_selection _difficultySelection;
        private gameForm_Size gameForm_Size = new gameForm_Size();

        int Image1BorderByWidth = 739 - 135;
        int Image1BorderByHeight = 554 - 106;

        int Image2BorderByWidth = 871 - 104;
        int Image2BorderByHeight = 649 - 128;

        int Image3BorderByWidth = 957 - 100;
        int Image3BorderByHeight = 666 - 100;

        int Image4BorderByWidth = 1186 - 88;
        int Image4BorderByHeight = 795 - 95;

        int Image5BorderByWidth = 1853 - 66;
        int Image5BorderByHeight = 1017 - 80;

        int Image6BorderByWidth = 1933 - 61;
        int Image6BorderByHeight = 1050 - 77;

        int Image7BorderByWidth = 1933 - 57;
        int Image7BorderByHeight = 1050 - 68;

        public game_form()
        {
            InitializeComponent();
            _difficultySelection = new difficulty_selection(ShowTimer_label, click_count_label,this, pictureBox1, pictureBox2,
                pictureBox3, pictureBox4, pictureBox5, pictureBox6, pictureBox7, Eazy_difficult_Button1, Medium_difficult_Button2,
                Hard_difficult_Button3, overallResult_label, Start_game_button, difficulty_groupBox);

            gameForm_Size.GameForm = this;

            int x1 = random.Next(117, Image1BorderByWidth); 
            int y1 = random.Next(0, Image1BorderByHeight); 
            pictureBox1.Location = new Point(x1, y1);

            int x2 = random.Next(117, Image2BorderByWidth);
            int y2 = random.Next(0, Image2BorderByHeight);
            pictureBox2.Location = new Point(x2, y2);

            int x3 = random.Next(117, Image3BorderByWidth);
            int y3 = random.Next(0, Image3BorderByHeight);
            pictureBox3.Location = new Point(x3, y3);

            int x4 = random.Next(117, Image4BorderByWidth);
            int y4 = random.Next(0, Image4BorderByHeight);
            pictureBox4.Location = new Point(x4, y4);

            int x5 = random.Next(117, Image5BorderByWidth);
            int y5 = random.Next(0, Image5BorderByHeight);
            pictureBox5.Location = new Point(x5, y5);

            int x6 = random.Next(117, Image6BorderByWidth);
            int y6 = random.Next(0, Image6BorderByHeight);
            pictureBox6.Location = new Point(x6, y6);

            int x7 = random.Next(117, Image7BorderByWidth);
            int y7 = random.Next(0, Image7BorderByHeight);
            pictureBox7.Location = new Point(x7, y7);
        }

        private  void Game_Load(object sender, EventArgs e)
        {
            NameOfPlayer_label.Text = Clicker_Game.Properties.Settings.Default.Name_player;        
        }

        private void Exit_button_2ndForm_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Start_game_button_Click(object sender, EventArgs e)
        {
            overallResult_label.Text = "Game Over Score: ";

            this.Size = new Size(739, 587);
            overallResult_label.Location = new Point(254, 231);

            if (!Eazy_difficult_Button1.Checked && !Medium_difficult_Button2.Checked && !Hard_difficult_Button3.Checked)
            {
                MessageBox.Show("Choose difficulty!");
            }
            else if (Eazy_difficult_Button1.Checked)
            {
                Start_game_button.Enabled = false;
                difficulty_groupBox.Enabled = false;
                overallResult_label.Visible = false;
                _difficultySelection.Eazy_difficult();
            }
            else if (Medium_difficult_Button2.Checked)
            {
                Start_game_button.Enabled = false;
                difficulty_groupBox.Enabled = false;
                overallResult_label.Visible = false;
                _difficultySelection.Meduim_difficult();
            }
            else if (Hard_difficult_Button3.Checked)
            {
                Start_game_button.Enabled = false;
                difficulty_groupBox.Enabled = false;
                overallResult_label.Visible = false;
                _difficultySelection.Hard_difficult();
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            int x = random.Next(117, Image1BorderByWidth); 
            int y = random.Next(0, Image1BorderByHeight); 
            pictureBox1.Location = new Point(x, y);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            int x = random.Next(117, Image2BorderByWidth); 
            int y = random.Next(0, Image2BorderByHeight); 
            pictureBox2.Location = new Point(x,y);
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            int x = random.Next(117, Image3BorderByWidth);
            int y = random.Next(0, Image3BorderByHeight); 
            pictureBox3.Location = new Point(x, y);
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            int x = random.Next(117, Image4BorderByWidth); 
            int y = random.Next(0, Image4BorderByHeight); 
            pictureBox4.Location = new Point(x,y);
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            int x = random.Next(117, Image5BorderByWidth);
            int y = random.Next(0, Image5BorderByHeight); 
            pictureBox5.Location = new Point(x, y);
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            int x = random.Next(117, Image6BorderByWidth);
            int y = random.Next(0, Image6BorderByHeight);
            pictureBox6.Location = new Point(x,y);
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            int x = random.Next(117, Image7BorderByWidth); 
            int y = random.Next(0, Image7BorderByHeight); 
            pictureBox7.Location = new Point(x, y);
        }

    }
}

