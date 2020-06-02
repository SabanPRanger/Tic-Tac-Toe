using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tic_Tac_Toe
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public int player = 2;
        public int turns = 0;
        public int s1 = 0;
        public int s2 = 0;
        public int sd = 0;


        private void buttonClick(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            if(button.Text == "")
            if(player%2==0)
            {
                button.Text = "X";
                player++;
                turns++;
            }
            else
            {
                button.Text = "O";
                player++;
                turns++;
            }
            if(CheckDraw()==true)
            {
                MessageBox.Show("Tie Game!");
                sd++;
                NewGame();
            }

            if(CheckWinner()==true)
            {
                if(button.Text=="X")
                {
                    MessageBox.Show("X Won!");
                    s1++;
                    NewGame();
                }
                else
                {
                    MessageBox.Show("O Won!");
                    s2++;
                    NewGame();
                }
            }
        }

        private void EButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            XWin.Text = "X= " + s1;
            OWin.Text = "O= " + s2;
            Draw.Text = "Draw= " + sd;
        }
        void NewGame()
        {
            player = 2;
            turns = 0;
            A1.Text = A2.Text = A3.Text = B1.Text = B2.Text = B3.Text = C1.Text = C2.Text = C3.Text = "";
            XWin.Text = "X: " + s1;
            OWin.Text = "O: " + s2;
            Draw.Text = "Draw: " + sd;

        }

        private void NGButton_Click(object sender, EventArgs e)
        {
            NewGame();
        }

        bool CheckDraw()
        {
            if ((turns == 9)&&CheckWinner()==false)
                return true;
            else
                return false;

        }

        bool CheckWinner()
        {
            if ((A1.Text == B1.Text) && (B1.Text == C1.Text) && A1.Text != "")
                return true;
            else if ((A2.Text == B2.Text) && (B2.Text == C2.Text) && A2.Text != "")
                return true;
            else if ((A3.Text == B3.Text) && (B3.Text == C3.Text) && A3.Text != "")
                return true;

            if ((A1.Text == A2.Text) && (A2.Text == A3.Text) && A1.Text != "")
                return true;
            else if ((B1.Text == B2.Text) && (B2.Text == B3.Text) && B1.Text != "")
                return true;
            else if ((C1.Text == C2.Text) && (C2.Text == C3.Text) && C1.Text != "")
                return true;

            if ((A1.Text == B2.Text) && (B2.Text == C3.Text) && A1.Text != "")
                return true;
            else if ((C1.Text == B2.Text) && (B2.Text == A3.Text) && C1.Text != "")
                return true;
            else
                return false;
        }

        private void RButton_Click(object sender, EventArgs e)
        {
            s1 = s2 = sd = 0;
            NewGame();
        }
    }
}