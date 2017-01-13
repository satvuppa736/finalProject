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
        int speedHero = 4;
        int xVillain;
        int yVillain;
        int inventory = 0;
        int screenCounter = 0;
        Boolean aKeyDown, sKeyDown, dKeyDown, wKeyDown;
        Boolean gameOn = false;
        public sunOnYee()
        {
            InitializeComponent();
        }

        private void startGame_Click(object sender, EventArgs e)
        {
            gameTimer.Start();
            gameOn = true;
            titleLabel.Visible = false;
            subtitleLabel.Visible = false;
            startGame.Visible = false;
            this.Focus();
        }
        private void sunOnYee_KeyUp(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.A:
                    aKeyDown = false;
                    break;
                case Keys.S:
                    sKeyDown = false;
                    break;
                case Keys.D:
                    dKeyDown = false;
                    break;
                case Keys.W:
                    wKeyDown = false;
                    break;
                default:
                    break;
            }
        }
        private void sunOnYee_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.A:
                    aKeyDown = true;
                    break;
                case Keys.S:
                    sKeyDown = true;
                    break;
                case Keys.D:
                    dKeyDown = true;
                    break;
                case Keys.W:
                     wKeyDown= true;
                    break;
                default:
                    break;
            }
        }

        private void gameTimer_Tick(object sender, EventArgs e)
        {
            if (aKeyDown == true)
            {
               xHero = xHero - speedHero;
            }

            if (sKeyDown == true)
            {
                yHero = yHero + speedHero;
            }

            if (dKeyDown == true)
            {
                xHero = xHero + speedHero;
            }

            if (wKeyDown == true)
            {
                yHero = yHero - speedHero;
            }

            //Draw the screen
            Refresh();
        }

        private void sunOnYee_Paint(object sender, PaintEventArgs e)
        {
            if (gameOn)
            {
                e.Graphics.Clear(Color.Black);
                e.Graphics.DrawImage(Properties.Resources.background1,0,0,);
                e.Graphics.DrawImage(Properties.Resources.playerCharacter, xHero, yHero, 25, 25);
                
            }
        }

    }
}
