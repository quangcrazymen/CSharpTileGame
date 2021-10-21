using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace colorGame
{
    public partial class Game : Form
    {
        public Game()
        {
            InitializeComponent();
            InitialPosition();
        }

        void InitialPosition()
        {
            Tile1.BackColor = Color.White;
            Tile2.BackColor = Color.Red;
            Tile3.BackColor = Color.Green;
            Tile4.BackColor = Color.Blue;
            Tile5.BackColor = Color.Green;
            Tile6.BackColor = Color.Blue;
            Tile7.BackColor = Color.Green;
            Tile8.BackColor = Color.Blue;
            Tile9.BackColor = Color.Red;
        }
        private void StartBtn_Click(object sender, EventArgs e)
        {
            //create random number from 12-20
            Random r = new Random();
            int rInt = r.Next(11, 21);
            if (rInt == 11)
            {
                puzzle.Image = colorGame.Properties.Resources.M11;
            }
            if (rInt == 12)
            {
                puzzle.Image = colorGame.Properties.Resources.M12;
            }
            if (rInt == 13)
            {
                puzzle.Image = colorGame.Properties.Resources.M13;
            }
            if (rInt == 14)
            {
                puzzle.Image = colorGame.Properties.Resources.M14;
            }
            if (rInt == 15)
            {
                puzzle.Image = colorGame.Properties.Resources.M15;
            }
            if (rInt == 16)
            {
                puzzle.Image = colorGame.Properties.Resources.M16;
            }
            if (rInt == 17)
            {
                puzzle.Image = colorGame.Properties.Resources.M17;
            }
            if (rInt == 18)
            {
                puzzle.Image = colorGame.Properties.Resources.M18;
            }
            if (rInt == 19)
            {
                puzzle.Image = colorGame.Properties.Resources.M19;
            }
            if (rInt == 20)
            {
                puzzle.Image = colorGame.Properties.Resources.M20;
            }
            // Return play tile to Original Position:
            InitialPosition();
        }

        private void Tile1_KeyDown(object sender, KeyEventArgs e)
        {
            //Test.Text += e.KeyCode.ToString();
            if (e.KeyData == Keys.S)
            {
                Color temp = Tile1.BackColor;
                Tile1.BackColor = Tile4.BackColor;
                Tile4.BackColor = temp;
                Tile4.Select();
            }
        }

        private void Tile4_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.S)
            {
                Color temp = Tile7.BackColor;
                Tile7.BackColor = Tile4.BackColor;
                Tile4.BackColor = temp;
                Tile7.Select();
            }
        }

        private void Game_KeyDown(object sender, KeyEventArgs e)
        {
            Test.Text = "Quang";
            if(e.KeyData == Keys.S)
            {
                //Tile1.BackColor = Tile4.BackColor;
                //Tile4.BackColor = Tile1.BackColor;
                Tile1.Focus();
            }
        }

        private void Tile2_ChangeUICues(object sender, UICuesEventArgs e)
        {
            Tile2.BackColor = Color.Black;
        }

        private void Game_ChangeUICues(object sender, UICuesEventArgs e)
        {
            
        }

       
    }
}
