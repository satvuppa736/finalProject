using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace finalProject
{
    public partial class sunOnYee : Form
    {
        int xHero = 100;
        int yHero = 100;
        int speedHero = 2;
        int xVillain;
        int yVillain;
        int inventory = 0;
        int screenCounter = 0;
        Boolean leftArrowDown, downArrowDown, rightArrowDown, upArrowDown;
        public sunOnYee()
        {
            InitializeComponent();
        }

        private void startGame_Click(object sender, EventArgs e)
        {
            gameTimer.Start();
            titleLabel.Visible = false;
            subtitleLabel.Visible = false;
            startGame.Visible = false;
        }

        private void sunOnYee_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Left:
                    leftArrowDown = true;
                    break;
                case Keys.Down:
                    downArrowDown = true;
                    break;
                case Keys.Right:
                    rightArrowDown = true;
                    break;
                case Keys.Up:
                    upArrowDown = true;
                    break;
                default:
                    break;
            }
        }
        private void sunOnYee_KeyUp(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Left:
                    leftArrowDown = false;
                    break;
                case Keys.Down:
                    downArrowDown = false;
                    break;
                case Keys.Right:
                    rightArrowDown = false;
                    break;
                case Keys.Up:
                    upArrowDown = false;
                    break;
                default:
                    break;
            }
        }

        private void gameTimer_Tick(object sender, EventArgs e)
        {
            if (leftArrowDown == true)
            {
               xHero = xHero - speedHero;
            }

            if (downArrowDown == true)
            {
                yHero = yHero + speedHero;
            }

            if (rightArrowDown == true)
            {
                xHero = xHero + speedHero;
            }

            if (upArrowDown == true)
            {
                yHero = yHero - speedHero;
            }

            //Draw the screen
            Refresh();
        }

        private void sunOnYee_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.Clear(Color.Black);
            e.Graphics.DrawImage(Properties.Resources.playerCharacter, xHero, yHero, 25, 25);
        }

    }
}
