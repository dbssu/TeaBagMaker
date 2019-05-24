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
        int CountOrgNum = 0; //초기 카운터
        string Choice = "";

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

        private void MakeTea_Click(object sender, EventArgs e)
        {
            Choice = TeaList.ToString();

            if (Choice == "홍차")
            {
                MessageBox.Show("홍차");
            }
        }
    }
}
