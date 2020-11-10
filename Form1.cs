using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using WMPLib;
using System.Media;
using System.Windows.Forms;


namespace Snake
{
    public partial class Form1 : Form
    {

        Snake mySnake;
        Board mainBoard;
        Rewards apples;
        Rewards enemy;

        WindowsMediaPlayer player = new WindowsMediaPlayer();
        SoundPlayer end;

        string mode;
        Timer clock;
        int duration; //How long the game has been running
        int speed = 500; //500ms
        int score;
        int level;


        public Form1()
        {
            InitializeComponent();

            player.URL = "Nyan Cat [original].wav";

            this.KeyPreview = true;

            //You don't have to worry about the auto-size
            this.AutoSize = true;       //The size of the Form will autoadjust.
            boardPanel.AutoSize = true; //The size of the panel grouping all the squares will auto-adjust

            //Set up the main board
            mainBoard = new Board(this);

            //Set up the game timer at the given speed
            clock = new Timer();
            clock.Interval = speed; //Set the clock to tick every 500ms
            clock.Tick += new EventHandler(refresh); //Call the refresh method at every tick to redraw the board and snake.

            duration = 0;
            score = 0;
            level = 1;
            modeLBL.Text = mode;

            gotoNextLevel(level);

        }

        private void gotoNextLevel(int nextLevel)
        {
            clock = new Timer();
            speed = speed - 25;

            if (speed <= 500 && speed >= 1)
            {
                clock.Interval = speed;
                clock.Tick += new EventHandler(refresh);
            }
            else
            {
                speed = 1;
                clock.Interval = speed;
                clock.Tick += new EventHandler(refresh);
            }
            mode = "REST";
            mySnake = new Snake(mainBoard); //Brand new snake with length 1
            apples = new Rewards(nextLevel, mainBoard); //<--- Generate 5 apples
        }

        private void upBTN_Click(object sender, EventArgs e)
        {
            mode = "UP";  //Just record the mode. The moving will be done in refresh method
        }

        private void downBTN_Click(object sender, EventArgs e)
        {
            mode = "DOWN";
        }

        private void leftBTN_Click(object sender, EventArgs e)
        {
            mode = "LEFT";
        }

        private void rightBTN_Click(object sender, EventArgs e)
        {
            mode = "RIGHT";
        }

        private void refresh(Object myObject, EventArgs myEventArgs)
        {
            mySnake.move(mode); //Move the snake based on mode
            modeLBL.Text = mode;

            mainBoard.draw();
            apples.draw();  //<----- draw apples
            mySnake.draw();

            //increment the duration by amount of time that has passed
            //this method is called every speed millisecond
            duration += speed;
            timerLBL.Text = Convert.ToString(duration / 1000); //Show time passed


            //Check if snke is biting itself. If so, call GameOver.
            if (mySnake.checkEatItself() == true)
            {
                GameOver();
            }
            else if (apples.checkIFSnakeHeadEatApple(mySnake.getHeadPosition()) == true)
            {
                score += apples.eatAppleAtPostion(mySnake.getHeadPosition());

                scoreLBL.Text = Convert.ToString(score);


                if (apples.noMoreApples() == true)
                {
                    clock.Stop();
                    level++;
                    levelLBL.Text = Convert.ToString(level);
                    gotoNextLevel(level);
                    MessageBox.Show("Press the start button to go to Level " + level, "Congrats");
                }
                else
                {
                    //Length the snake and continue with the Game
                    mySnake.extendBody();
                }
            }
        }

        private void startBTN_Click(object sender, EventArgs e)
        {
            clock.Start();
        }

        private void pauseBTN_Click(object sender, EventArgs e)
        {
            clock.Stop();
            end = new SoundPlayer(Properties.Resources.Nani_meme_sound_effect);
            end.LoadAsync();
            end.Play();
        }

        private void GameOver()
        {
            clock.Stop();
            DialogResult dialogResult = MessageBox.Show("Your final score is " + scoreLBL.Text + " and your time taken is " + duration/1000 + " seconds." + "\n" + "Would you like to submit your score?" , "Game over" , MessageBoxButtons.YesNo);
            if(dialogResult==DialogResult.Yes)
            {
                scoreborad scoreborad = new scoreborad(score);
                scoreborad.ShowDialog();
            }
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            mode = "UPRIGHT";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            mode = "DOWNRIGHT";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            mode = "DOWNLEFT";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            mode = "UPLEFT";
        }

        private void controlPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Exitbtn_Click(object sender, EventArgs e)
        {
            clock.Stop();
            end = new SoundPlayer(Properties.Resources.Nani_meme_sound_effect);
            end.LoadAsync();
            end.Play();
            GameOver();
        }

        private void w(object sender, KeyPressEventArgs e)
        {
            mode = "UP";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            player.controls.play();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode==Keys.NumPad8)
            {
                upBTN.PerformClick();
            }
            if (e.KeyCode == Keys.NumPad2)
            {
                downBTN.PerformClick();
            }
            if (e.KeyCode == Keys.NumPad4)
            {
                leftBTN.PerformClick();
            }
            if (e.KeyCode == Keys.NumPad6)
            {
                rightBTN.PerformClick();
            }
            if (e.KeyCode == Keys.NumPad9)
            {
                button1.PerformClick();
            }
            if (e.KeyCode == Keys.NumPad7)
            {
                button2.PerformClick();
            }
            if (e.KeyCode == Keys.NumPad3)
            {
                button4.PerformClick();
            }
            if (e.KeyCode == Keys.NumPad1)
            {
                button3.PerformClick();
            }
        }

        private void modeLBL_Click(object sender, EventArgs e)
        {

        }

        private void boardPanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
