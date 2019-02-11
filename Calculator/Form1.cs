using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        char sign = (char)0;  //연산 기호
        decimal inputValue = 0m;       //입력받는 변수
        decimal value = 0m; //저장된 변수
        int length;
        public Form1()
        {
            InitializeComponent();
            inputBox.Text = inputValue.ToString();  //0으로 초기화
        }
        
        //자릿수 세팅
        private int position()
        {
            int temp = 1;
            for (int i = 0; i < length; i++)
            {
                temp *= 10;
            }
            return temp;
        }

        //데이터 세팅
        private void settingData(int n)
        {
            length = (int)(Math.Log10((double)inputValue) + 1);
            inputValue *= 10;
            inputValue += n;
            inputBox.Text = inputValue.ToString();
        }

        private void inputData_TextChanged(object sender, EventArgs e)
        {
            //inputData.Text = inputValue.ToString();
        }

        private void btn_1_Click(object sender, EventArgs e)
        {
            settingData(1);
        }

        private void btn_2_Click(object sender, EventArgs e)
        {
            settingData(2);
        }

        private void btn_3_Click(object sender, EventArgs e)
        {
            settingData(3);
        }

        private void btn_4_Click(object sender, EventArgs e)
        {
            settingData(4);
        }

        private void btn_5_Click(object sender, EventArgs e)
        {
            settingData(5);
        }

        private void btn_6_Click(object sender, EventArgs e)
        {
            settingData(6);
        }

        private void btn_7_Click(object sender, EventArgs e)
        {
            settingData(7);
        }

        private void btn_8_Click(object sender, EventArgs e)
        {
            settingData(8);
        }

        private void btn_9_Click(object sender, EventArgs e)
        {
            settingData(9);
        }

        private void btn_0_Click(object sender, EventArgs e)
        {
            if(inputValue != 0)
            {
                settingData(0);
            }
        }

        private void btn_plusminus_Click(object sender, EventArgs e)
        {
            inputValue *= -1;
            inputBox.Text = inputValue.ToString();
        }
        private void Calculate(char sign)
        {
            switch (sign)
            {
                case '+':
                    value += inputValue;
                    break;
                case '-':
                    value -= inputValue;
                    break;
                case '*':
                    value *= inputValue;
                    break;
                case '/':
                    value /= inputValue;
                    break;
                default:
                    value += inputValue;
                    break;
            }
            inputValue = 0;
            inputBox.Text = inputValue.ToString();
            valueBox.Text = value.ToString();
        }

        private void btn_plus_Click(object sender, EventArgs e)
        {
            if(inputValue == 0)
            {
                sign = '+';
                lastSign.Text = sign.ToString();
                return;
            }
            Calculate(sign);
            sign = '+';
            lastSign.Text = sign.ToString();
        }

        private void btn_minus_Click(object sender, EventArgs e)
        {
            if (inputValue == 0)
            {
                sign = '-';
                lastSign.Text = sign.ToString();
                return;
            }
            Calculate(sign);
            sign = '-';
            lastSign.Text = sign.ToString();
        }

        private void btn_multiple_Click(object sender, EventArgs e)
        {
            if (inputValue == 0)
            {
                sign = '*';
                lastSign.Text = sign.ToString();
                return;
            }
            Calculate(sign);
            sign = '*';
            lastSign.Text = sign.ToString();
        }

        private void btn_divide_Click(object sender, EventArgs e)
        {
            if (inputValue == 0)
            {
                sign = '/';
                lastSign.Text = sign.ToString();
                return;
            }
            Calculate(sign);
            sign = '/';
            lastSign.Text = sign.ToString();
        }

        private void btn_equal_Click(object sender, EventArgs e)
        {
            Calculate(sign);
            resultValue.Text = value.ToString();
            value = 0;
            valueBox.Text = value.ToString();
            sign = (char)0;
            lastSign.Text = sign.ToString();
        }
    }
}
