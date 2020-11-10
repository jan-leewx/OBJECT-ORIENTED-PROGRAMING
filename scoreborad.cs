using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Snake
{
    public partial class scoreborad : Form
    {
        Boolean checkSubmit;
        Player player;
        string directory, fileName, filePath;

        public scoreborad(int score)
        {
            InitializeComponent();

            player = new Player();
            checkSubmit = false;
            directory = "G:\\NANYANG POLY\\OBJECT ORIENTED PROGRAMING\\Lab8-SnakeTaskComplete";
            fileName = "scoreList.txt";
            filePath = directory + "\\" + fileName;

            highscoreDGV.ColumnCount = 2;
            highscoreDGV.Columns[0].HeaderText = "Name";
            highscoreDGV.Columns[1].HeaderText = "Score";
            highscoreDGV.AllowUserToAddRows = false;
            highscoreDGV.AllowUserToDeleteRows = false;
            highscoreDGV.MultiSelect = false;
            highscoreDGV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            highscoreDGV.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            scoreLBL.Text = Convert.ToString(score);

        }

        private void scoreborad_Load(object sender, EventArgs e)
        {
            try
            { 
                StreamReader sr = new StreamReader(filePath);
                string txt = sr.ReadLine();
                while (txt != null)
                {
                    string[] input = txt.Split(',');
                    Indvscore stat = new Indvscore(input[0], Convert.ToInt32(input[1]));
                    player.Addplayer(stat);
                    txt = sr.ReadLine();
                }
                sr.Close();

                // Refresh Data List
                refreshDGV();
            }
            catch (DirectoryNotFoundException)
            {
                Directory.CreateDirectory(directory);
                StreamWriter sw = createFile();
                sw.Close();
            }
            catch (FileNotFoundException)
            {
                StreamWriter sw = createFile();
                sw.Close();
            }
        }

        private void submitBTN_Click(object sender, EventArgs e)
        {
            Boolean nameExist = false;

            // Check if the user fill in the name
            if (nameTB.Text == "")
            {
                MessageBox.Show("Please enter your name!", "Info");
            }
            else
            {
                // Check if the chosen name exist
                for (int i = 0; i < player.getSize(); i++)
                {
                    if (nameTB.Text == player.getscore(i).getName())
                    {
                        nameExist = true;
                    }
                }

                if (nameExist)
                {
                    MessageBox.Show("This name has been taken, please use another name!", "Info");
                }
                else
                {
                    checkSubmit = true;
                    StreamWriter sw = createFile();
                    Indvscore stat = new Indvscore(nameTB.Text, Convert.ToInt32(scoreLBL.Text));
                    player.Addplayer(stat);
                    // Display all the scores entered
                    for (int i = 0; i < player.getSize(); i++)
                    {
                        sw.WriteLine(player.getscore(i).getName() + "," + player.getscore(i).getScore());
                    }
                    sw.Close();
                    // Display the popup
                    MessageBox.Show("Your score has been submitted!", "Info");

                    // Refresh Data List
                    refreshDGV();

                    // Disable submit button
                    submitBTN.Enabled = false;
                }
            }
        }

        private void clearBTN_Click(object sender, EventArgs e)
        {
            if (checkSubmit)
            {
                this.Close();
            }
            else
            {
                // Prompt the user to close without submittingS
                DialogResult dialogResult = MessageBox.Show("Close without submitting your score?", "Info", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    this.Close();
                }
            }
        }
    

        private StreamWriter createFile()
        {
            return new StreamWriter(filePath, false);
        }

        private void refreshDGV()
        {
            highscoreDGV.Rows.Clear();
            for (int i = 0; i < player.getSize(); i++)
            {
                highscoreDGV.Rows.Add();
                highscoreDGV.Rows[i].Cells[0].Value = player.getscore(i).getName();
                highscoreDGV.Rows[i].Cells[1].Value = player.getscore(i).getScore();
            }
        }
    }
}
