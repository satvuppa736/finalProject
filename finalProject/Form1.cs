using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Media;

namespace finalProject
{
    public partial class sunOnYee : Form
    {
        int xHero = 500;
        int yHero = 74;
        int speedHero = 15;
        int sizeHero = 30;
        int sizeNPC = 35;
        int screenCounter = 2;
        int dialogue;
        Random dialogueGen = new Random();
        Boolean aKeyDown, sKeyDown, dKeyDown, wKeyDown, spaceDown;
        Boolean gameOn = false;

        #region room 1 walls & doors
        Rectangle cellDoor = new Rectangle(616, 585, 43, 14);

        Rectangle bedRec = new Rectangle(420, 30, 45, 90);
        Rectangle cellRec1 = new Rectangle(405, 180, 206, 14);
        Rectangle cellRec2 = new Rectangle(539,180, 16, 419);
        Rectangle cellRec3 = new Rectangle(660, 180, 89, 14);
        Rectangle cellRec4 = new Rectangle(404, 0, 15, 196);
        Rectangle cellRec5 = new Rectangle(404, 0, 345, 25);
        Rectangle cellRec6 = new Rectangle(721,0,30,600);
        Rectangle cellRec7 = new Rectangle(660, 585, 110, 14);
        Rectangle cellRec8 = new Rectangle(555,585,60,15);
        #endregion

        #region room 2 doors and walls 
        Rectangle cafDoor = new Rectangle(584, 0, 91, 12);

        //room 2 walls
        Rectangle cafRec1 = new Rectangle(674, 0, 46, 12);
        Rectangle cafRec2 = new Rectangle(710, 0, 15, 629);
        Rectangle cafRec3 = new Rectangle(0, 578, 719, 15);
        Rectangle cafRec4 = new Rectangle(1, 312, 10, 299);
        Rectangle cafRec5 = new Rectangle(0, 0, 11, 83);
        Rectangle cafRec6 = new Rectangle(0, 0, 580, 14);

        Rectangle tableRec = new Rectangle(90, 104, 399, 145);
        Rectangle counterRec = new Rectangle(0, 372, 515, 28);

        Rectangle npcRec = new Rectangle(504, 118, 45, 45);
        #endregion

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
            instructionsLabel.Visible = false;
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
                case Keys.Space:
                    spaceDown = false;
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
                    wKeyDown = true;
                    break;
                case Keys.Space:
                    spaceDown = true;
                    break;
                default:
                    break;
            }
        }

        private void gameTimer_Tick(object sender, EventArgs e)
        {
            
            #region MOVEMENTS
            int xTemp = xHero;
            int yTemp = yHero;

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

            Rectangle heroRec = new Rectangle(xHero, yHero, 30, 30);
            #endregion

            #region COLLISION ROOM 1
            if (screenCounter == 1)
            {
                if (heroRec.IntersectsWith(bedRec) || heroRec.IntersectsWith(cellRec1) || heroRec.IntersectsWith(cellRec2) || heroRec.IntersectsWith(cellRec3) || heroRec.IntersectsWith(cellRec4) || heroRec.IntersectsWith(cellRec5) || heroRec.IntersectsWith(cellRec6) || heroRec.IntersectsWith(cellRec7))
                {
                    xHero = xTemp;
                    yHero = yTemp;
                }

                if (cellDoor.IntersectsWith(heroRec))
                {
                    screenCounter++;
                    yHero = 15;
                }
            }
            #endregion

            #region COLLISION ROOM 2
            else if (screenCounter == 2)
            {
                if (heroRec.IntersectsWith(cafRec1) || heroRec.IntersectsWith(cafRec2) || heroRec.IntersectsWith(cafRec3) || heroRec.IntersectsWith(cafRec4) || heroRec.IntersectsWith(cafRec5) || heroRec.IntersectsWith(cafRec6) || heroRec.IntersectsWith(tableRec) || heroRec.IntersectsWith(counterRec))
                {
                    xHero = xTemp;
                    yHero = yTemp;
                }

                if (cafDoor.IntersectsWith(heroRec))
                {
                    screenCounter--;
                    yHero = 544;
                    xHero = 617;
                }

                if (heroRec.IntersectsWith(npcRec) && spaceDown == true)
                {
                    dialogue = dialogueGen.Next(1, 6);
                }
            }

            #endregion

            //Draw the screen
            Refresh();
        }

        private void sunOnYee_Paint(object sender, PaintEventArgs e)
        {
            if (gameOn)
            {
                Font drawFont = new Font("Consolas", 14, FontStyle.Bold);
                SolidBrush drawBrush = new SolidBrush(Color.SteelBlue);

                #region Screen Counter
                switch (screenCounter)
                {
                    case 1:
                        e.Graphics.Clear(Color.Black);
                        e.Graphics.DrawImage(Properties.Resources.screen1, 0, 0, 750, 600);
                        e.Graphics.DrawImage(Properties.Resources.npcFlipped, 467, 246, sizeNPC, sizeNPC);
                        e.Graphics.DrawImage(Properties.Resources.npcCharacter, 500, 370, sizeNPC, sizeNPC);
                        e.Graphics.DrawImage(Properties.Resources.npcCharacter, 429, 500, sizeNPC, sizeNPC);
                        break;
                    case 2:
                        e.Graphics.Clear(Color.Black);
                        e.Graphics.DrawString("Walk to the man and press SPACE", drawFont, drawBrush, 12, 600);
                        e.Graphics.DrawImage(Properties.Resources.screen2, 0, 0, 720, 590);
                        e.Graphics.DrawImage(Properties.Resources.npcCharacter, 417, 115, sizeNPC, sizeNPC);
                        e.Graphics.DrawImage(Properties.Resources.npcFlipped, 504, 118, sizeNPC, sizeNPC);
                        break;
                    default:
                        break;
                }
                #endregion

                e.Graphics.DrawImage(Properties.Resources.playerCharacter, xHero, yHero, sizeHero, sizeHero);

                #region Dialogue
                switch (dialogue)
                {
                    case 1:
                        outputLabel.Text = "Dave the NPC: Hello there";
                        break;
                    case 2:
                        outputLabel.Text = "Dave the NPC: I have nothing to say, go away";
                        break;
                    case 3:
                        outputLabel.Text = "Dave the NPC: I solve practical problems";
                        break;
                    case 4:
                        outputLabel.Text = "Dave the NPC: JHVSDFBHSKLVBLGFVSHVF";
                        break;
                    case 5:
                        outputLabel.Text = "Dave the NPC: NO WAY IN, NO WAY OUT, NO WAY IN, NO WAY OUT";
                        break;
                    default:
                        outputLabel.Text = "";
                        break;
                }
                #endregion
            }
        }
    }
}
