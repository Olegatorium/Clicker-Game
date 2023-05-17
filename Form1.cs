using Clicker_Game.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clicker_Game
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void play_button1_Click(object sender, EventArgs e)
        {
            game_form game = new game_form();
           
            if (Name_textBox1.Text == "")
            {
                MessageBox.Show("You must write name", "Just write name)", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                Clicker_Game.Properties.Settings.Default.Name_player = Name_textBox1.Text;
                this.Hide();
                game.ShowDialog();
                this.Close();
            }
            
        }

        private void Exit_button_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
