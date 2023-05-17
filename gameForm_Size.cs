using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clicker_Game
{
    class gameForm_Size
    {
        private Form _gameForm;

        public Form GameForm
        {
            get { return _gameForm; }
            set { _gameForm = value; }
        }



        public void Size_1Level_gameForm()
        {
            _gameForm.Size = new Size(871, 649); 
        }

        public void Size_2Level_gameForm()
        {
            _gameForm.Size = new Size(957, 666); 
        }

        public void Size_3Level_gameForm()
        {
            _gameForm.Size = new Size(1186, 795); 
        }

        public void Size_4Level_gameForm()
        {
            _gameForm.Size = new Size(1853, 1017); 
        }

        public void Size_5Level_gameForm()
        {
            _gameForm.Size = new Size(1933, 1050); 
        }
    }
}
