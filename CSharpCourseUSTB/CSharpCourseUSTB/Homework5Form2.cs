using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharpCourseUSTB
{

    public partial class Homework5Form2 : Form
    {
        public static int gameStaus = 0; //0:run 1:end

        public static int aiNum = 0;
        public static int playerNum = 0;

        public static int aiScore = 0;
        public static int playerScore = 0;

        public static Stack<Result> stepStack = new Stack<Result>();
        public Homework5Form2()
        {
            InitializeComponent();
            gameStaus = 0;
            aiNum = 0;
            playerNum = 0;
            aiScore = 0;
            playerScore = 0;
            stepStack.Clear();
        }

        public void RanNum()
        {
            Random random = new Random();
            aiNum = random.Next(1, 4);
            switch (aiNum)
            {
                case 1: pictureBox7.Image = (Properties.Resources.stone); break;
                case 2: pictureBox7.Image = (Properties.Resources.jian); break;
                case 3: pictureBox7.Image = (Properties.Resources.bu); break;
                default:
                    break;
            }
            switch (playerNum)
            {
                case 1: pictureBox8.Image = (Properties.Resources.stone); break;
                case 2: pictureBox8.Image = (Properties.Resources.jian); break;
                case 3: pictureBox8.Image = (Properties.Resources.bu); break;
                default:
                    break;
            }
        }
        public void Judge()
        {
            label3.Text = Convert.ToString(aiScore);
            label4.Text = Convert.ToString(playerScore);
            if (playerScore.Equals(2))
            {
                gameStaus = 1;
                label7.Text = "you win!";
                label7.Visible = true;
                return;
            }
            if (aiScore.Equals(2))
            {
                gameStaus = 1;
                label7.Text = "you lose!";
                label7.Visible = true;
                return;
            }
            gameStaus = 0;
            label7.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            //Application.ExitThread();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form form1 = new Homework5Form1();
            this.Hide();
            form1.ShowDialog();
            this.Close();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            Result result = new Result();
            if (gameStaus.Equals(0))
            {
                result.aiNum = aiNum;
                result.playerNum = playerNum;
                playerNum = 1;
                RanNum();
                switch (aiNum)
                {
                    case 1: break;
                    case 2: playerScore++; result.playerScore = 1; break;
                    case 3: aiScore++; result.aiScore = 1; break;
                }

                stepStack.Push(result);
                Judge();
            }

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Result result = new Result();
            if (gameStaus.Equals(0))
            {

                result.aiNum = aiNum;
                result.playerNum = playerNum;
                playerNum = 2;
                RanNum();
                switch (aiNum)
                {
                    case 1: aiScore++; result.aiScore = 1; break;
                    case 2: break;
                    case 3: playerScore++; result.playerScore = 1; break;
                }
                stepStack.Push(result);
                Judge();
            }
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Result result = new Result();
            if (gameStaus.Equals(0))
            {

                result.aiNum = aiNum;
                result.playerNum = playerNum;
                playerNum = 3;
                RanNum();
                switch (aiNum)
                {
                    case 1: playerScore++; result.playerScore = 1; break;
                    case 2: aiScore++; result.aiScore = 1; break;
                    case 3: break;
                }

                stepStack.Push(result);
                Judge();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (stepStack.Count != 0)
            {
                Result result = stepStack.Pop();
                aiScore -= result.aiScore;
                playerScore -= result.playerScore;
                aiNum = result.aiNum;
                playerNum = result.playerNum;

                switch (aiNum)
                {
                    case 1: pictureBox7.Image = (Properties.Resources.stone); break;
                    case 2: pictureBox7.Image = (Properties.Resources.jian); break;
                    case 3: pictureBox7.Image = (Properties.Resources.bu); break;
                    default:
                        pictureBox7.Image = (Properties.Resources.stone);
                        break;
                }
                switch (playerNum)
                {
                    case 1: pictureBox8.Image = (Properties.Resources.stone); break;
                    case 2: pictureBox8.Image = (Properties.Resources.jian); break;
                    case 3: pictureBox8.Image = (Properties.Resources.bu); break;
                    default:
                        pictureBox7.Image = (Properties.Resources.stone);
                        break;
                }
                Judge();
            }
        }
    }
    public class Result
    {
        public int aiNum = 0;
        public int playerNum = 0;

        public int aiScore = 0;
        public int playerScore = 0;

        public Result()
        {
            aiScore = 0;
            playerScore = 0;
        }

        Result(int aiN, int plN, int aiS, int plS)
        {
            aiNum = aiN;
            playerNum = plN;
            aiScore = aiS;
            playerScore = plS;
        }
    }
}
