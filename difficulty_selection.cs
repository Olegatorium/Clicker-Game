using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace Clicker_Game
{
    class difficulty_selection
    {
        private gameForm_Size gameForm_Size = new gameForm_Size();       
        private int _countdown;
        private Timer _timer = new Timer();
        private Label _timerLabel;
        private int _clickCount = 0;
        private Label _click_count_label;
        private PictureBox _pictureBox1;
        private PictureBox _pictureBox2;
        private PictureBox _pictureBox3;
        private PictureBox _pictureBox4;
        private PictureBox _pictureBox5;
        private PictureBox _pictureBox6;
        private PictureBox _pictureBox7;
        private RadioButton _Eazy_difficult_Button1;
        private RadioButton _Medium_difficult_Button2;
        private RadioButton _Hard_difficult_Button3;
        private Label _overallResult;
        private Button _Start_game_button;
        private GroupBox _difficulty_groupBox;

        public difficulty_selection(Label timerLabel, Label click_count_label, Form gameForm, PictureBox pictureBox1, 
            PictureBox pictureBox2, PictureBox pictureBox3, PictureBox pictureBox4, PictureBox pictureBox5, PictureBox pictureBox6,
            PictureBox pictureBox7, RadioButton eazy_difficult_Button1, RadioButton medium_difficult_Button2, RadioButton hard_difficult_Button3,
            Label overallResult, Button start_game_button,
            GroupBox difficulty_groupBox )
        {
           
            _timerLabel = timerLabel;
            _timer.Interval = 1000;
            _timer.Tick += Timer_Tick;

            _click_count_label = click_count_label;
            
            _pictureBox1 = pictureBox1;
            _pictureBox1.MouseClick += pictureBox1_MouseClick;

            _pictureBox2 = pictureBox2;
            _pictureBox2.MouseClick += pictureBox2_MouseClick;

            _pictureBox3 = pictureBox3;
            _pictureBox3.MouseClick += pictureBox3_MouseClick;

            _pictureBox4 = pictureBox4;
            _pictureBox4.MouseClick += pictureBox4_MouseClick;

            _pictureBox5 = pictureBox5;
            _pictureBox5.MouseClick += pictureBox5_MouseClick;

            _pictureBox6 = pictureBox6;
            _pictureBox6.MouseClick += pictureBox6_MouseClick;

            _pictureBox7 = pictureBox7;
            _pictureBox7.MouseClick += pictureBox7_MouseClick;

            _Eazy_difficult_Button1 = eazy_difficult_Button1;
            _Medium_difficult_Button2 = medium_difficult_Button2;
            _Hard_difficult_Button3 = hard_difficult_Button3;
            _overallResult = overallResult;
            _Start_game_button = start_game_button;
            _difficulty_groupBox = difficulty_groupBox;           
            gameForm_Size.GameForm = gameForm;

        }

        public void Eazy_difficult()
        {
            if (_Eazy_difficult_Button1.Checked)
            {
                _pictureBox1.Enabled = true;
                _pictureBox1.Visible = true;

                _countdown = 20;
                _timerLabel.Text = _countdown.ToString();
            }

            _timer.Start();

        }
        public void Meduim_difficult()
        {
            if (_Medium_difficult_Button2.Checked)
            {
                _pictureBox1.Enabled = true;
                _pictureBox1.Visible = true;

                _countdown = 15;
                _timerLabel.Text = _countdown.ToString();
            }

            _timer.Start();

        }
        public void Hard_difficult()
        {
            if (_Hard_difficult_Button3.Checked)
            {
                _pictureBox1.Enabled = true;
                _pictureBox1.Visible = true;

                _countdown = 10;
                _timerLabel.Text = _countdown.ToString();
            }

            _timer.Start();

        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            _countdown--;
            _timerLabel.Text = _countdown.ToString();

            if (_countdown == 0)
            {
                _timer.Stop();
                
                _pictureBox1.Visible = false;
                _pictureBox2.Visible = false;
                _pictureBox3.Visible = false;
                _pictureBox4.Visible = false;
                _pictureBox5.Visible = false;
                _pictureBox6.Visible = false;
                _pictureBox7.Visible = false;
                _overallResult.Visible = true;                
                _Start_game_button.Enabled = true;
                _difficulty_groupBox.Enabled = true;
                
                _overallResult.Text = _overallResult.Text + _clickCount.ToString();
            }

            if (_countdown == 0)
            {
                _clickCount = 0;
                _click_count_label.Text = "0";
                
            }

        }
        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            _clickCount++;
            _click_count_label.Text = _clickCount.ToString();

            if (_clickCount == 10)
            {
                
                gameForm_Size.Size_1Level_gameForm();
                _overallResult.Location = new Point(319, 239); 

                _pictureBox1.Visible = false;
                _pictureBox2.Visible = true;


            }

            if (_clickCount == 10)
            {
                _countdown += 10;
            }

        }

        private void pictureBox2_MouseClick(object sender, MouseEventArgs e)
        {
            _clickCount++;
            _click_count_label.Text = _clickCount.ToString();

            if (_clickCount == 20)
            {

                gameForm_Size.Size_2Level_gameForm();
                _overallResult.Location = new Point(362, 253);

                _pictureBox2.Visible = false;
                _pictureBox3.Visible = true;



            }
           
            if (_clickCount == 20)
            {
                _countdown += 10;
            }
        }
        private void pictureBox3_MouseClick(object sender, MouseEventArgs e) 
        {
            _clickCount++;
            _click_count_label.Text = _clickCount.ToString();

            if (_clickCount == 30)
            {

                gameForm_Size.Size_3Level_gameForm();
                _overallResult.Location = new Point(467, 308);

                _pictureBox3.Visible = false;
                _pictureBox4.Visible = true;


            }

            if (_clickCount == 30)
            {
                _countdown += 10;
            }

        }
        private void pictureBox4_MouseClick(object sender, MouseEventArgs e)
        {
            _clickCount++;
            _click_count_label.Text = _clickCount.ToString();

            if (_clickCount == 40)
            {

                gameForm_Size.Size_4Level_gameForm();
                _overallResult.Location = new Point(735, 387);

                _pictureBox4.Visible = false;
                _pictureBox5.Visible = true;


            }

            if (_clickCount == 40)
            {
                _countdown += 10;
            }

        }
        private void pictureBox5_MouseClick(object sender, MouseEventArgs e)
        {

            _clickCount++;
            _click_count_label.Text = _clickCount.ToString();

            if (_clickCount == 50)
            {

                gameForm_Size.Size_5Level_gameForm();

                _overallResult.Location = new Point(782, 471);
                _pictureBox5.Visible = false;
                _pictureBox6.Visible = true;


            }

            if (_clickCount == 50)
            {
                _countdown += 10;
            }

        }
        private void pictureBox6_MouseClick(object sender, MouseEventArgs e)
        {

            _clickCount++;
            _click_count_label.Text = _clickCount.ToString();

            if (_clickCount == 60)
            {

                gameForm_Size.Size_5Level_gameForm();
                _pictureBox6.Visible = false;
                _pictureBox7.Visible = true;


            }

            if (_clickCount == 60)
            {
                _countdown += 10;
            }

        }

        private void pictureBox7_MouseClick(object sender, MouseEventArgs e)
        {

            _clickCount++;
            _click_count_label.Text = _clickCount.ToString();


            if (_clickCount == 70)
            {
                _countdown += 10;
            }

        }

    }
}




