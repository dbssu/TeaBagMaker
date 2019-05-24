using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using Microsoft.VisualBasic;

namespace TeaBagMaker
{
    public partial class Form1 : Form
    {
        //콤보박스 데이터 설정
        string[] TeaList = new string[] { "홍차", "녹차", "루이보스차", "국화차" };
        int[] List = new int[] { 10 * 60 * 2, 10 * 60 * 3, 10 * 60 * 5, 10 * 60 * 2 };
        string Choice = "";
        int CountNum = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < this.TeaList.Length; i++)
            {
                this.ChoiceTea.Items.Add(TeaList[i]);
            }
            
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            if (CountNum < 1)
            {
                this.TeaTimer.Enabled = false;
                MessageBox.Show("티백을 건지세요!", "알림",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                CountNum--;
                if (CountNum / 10 / 60 == 0)
                    this.TCountDown.Text = Convert.ToString((CountNum / 10) % 60 + "초" + " 남았습니다!");
                else
                    this.TCountDown.Text = Convert.ToString(CountNum / 10 / 60 + "분 " + (CountNum / 10) % 60 + "초" + " 남았습니다!");
            }

        }

        private void MakeTea_Click(object sender, EventArgs e)
        {
          
        }
    }
}
