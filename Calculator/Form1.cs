using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace Calculator
{
    public partial class Form1 : Form
    {
        char sign = (char)0;  //연산 기호
        //decimal inputValue = 0m;       //입력받는 변수
        string inputValue = "0";
        decimal value = 0m; //저장된 변수
        int length;
        public Form1()
        {
            InitializeComponent();
            inputBox.Text = inputValue.ToString();  //0으로 초기화
        }

        public void UpdateInputValue() //입력받아져있는 데이터 업데이트
        {
            inputBox.Text = inputValue.ToString();
        }
        public void UpdateValue()
        {
            valueBox.Text = value.ToString();
        }
        public void setInputValue(decimal Value)
        {
            this.inputValue = Value.ToString();
        }

        private void inputData_TextChanged(object sender, EventArgs e)
        {
            //inputData.Text = inputValue.ToString();
        }

        private void btn_1_Click(object sender, EventArgs e)
        {
            DataSetting.settingData(this, inputValue, 1);
        }

        private void btn_2_Click(object sender, EventArgs e)
        {
            DataSetting.settingData(this, inputValue, 2);
        }

        private void btn_3_Click(object sender, EventArgs e)
        {
            DataSetting.settingData(this, inputValue, 3);
        }

        private void btn_4_Click(object sender, EventArgs e)
        {
            DataSetting.settingData(this, inputValue, 4);
        }

        private void btn_5_Click(object sender, EventArgs e)
        {
            DataSetting.settingData(this, inputValue, 5);
        }

        private void btn_6_Click(object sender, EventArgs e)
        {
            DataSetting.settingData(this, inputValue, 6);
        }

        private void btn_7_Click(object sender, EventArgs e)
        {
            DataSetting.settingData(this, inputValue, 7);
        }

        private void btn_8_Click(object sender, EventArgs e)
        {
            DataSetting.settingData(this, inputValue, 8);
        }

        private void btn_9_Click(object sender, EventArgs e)
        {
            DataSetting.settingData(this, inputValue, 9);
        }

        private void btn_0_Click(object sender, EventArgs e)
        {
            if(decimal.Parse(inputValue) != 0)
            {
                DataSetting.settingData(this, inputValue, 0);
            }
        }

        private void btn_plusminus_Click(object sender, EventArgs e)
        {
            //decimal.Parse(inputValue) *= -1;
            if(inputValue.IndexOf("-") == -1)
            {
                inputValue = inputValue.Insert(0, "-");
            }
            else
            {
                inputValue = inputValue.Remove(0, 1);
            }
            UpdateInputValue();
        }

        private void Calculate(char sign)
        {
            switch (sign)
            {
                case '+':
                    value += decimal.Parse(inputValue);
                    break;
                case '-':
                    value -= decimal.Parse(inputValue);
                    break;
                case '*':
                    value *= decimal.Parse(inputValue);
                    break;
                case '/':
                    value /= decimal.Parse(inputValue);
                    break;
                default:
                    value += decimal.Parse(inputValue);
                    break;
            }
            inputValue = "0";
            inputBox.Text = inputValue.ToString();
            valueBox.Text = value.ToString();
        }

        private void btn_plus_Click(object sender, EventArgs e)
        {
            if(inputValue == "0")
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
            if (inputValue == "0")
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
            if (inputValue == "0")
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
            if (inputValue == "0")
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

        private void btn_sqrt_Click(object sender, EventArgs e)
        {
            //0이 아닌 경우 입력되어있는 데이터부터 루트
            if(inputValue != "0")
            {
                inputValue = (Math.Sqrt(double.Parse(inputValue))).ToString();
                UpdateInputValue();
            }
            //0인 경우 입력받아져있는 것부터 루트
            else
            {
                value = (decimal)Math.Sqrt((double)value);
                UpdateValue();
            }
        }

        //제곱 버튼
        private void btn_pow_Click(object sender, EventArgs e)
        {
            if (decimal.Parse(inputValue) != 0)
            {
                inputValue = Math.Pow(double.Parse(inputValue),2).ToString();
                UpdateInputValue();
            }
            //0인 경우 입력받아져있는 것부터 루트
            else
            {
                value = (decimal)Math.Pow((double)value,2);
                UpdateValue();
            }
        }

        //세제곱 버튼
        private void btn_cube_Click(object sender, EventArgs e)
        {
            if (decimal.Parse(inputValue) != 0)
            {
                inputValue = Math.Pow(double.Parse(inputValue), 3).ToString();
                UpdateInputValue();
            }
            //0인 경우 입력받아져있는 것부터 루트
            else
            {
                value = (decimal)Math.Pow((double)value, 3);
                UpdateValue();
            }
        }

        //삭제 버튼
        private void btn_delete_Click(object sender, EventArgs e)
        {
            if(decimal.Parse(inputValue) != 0)
            {
                //정수만 일단
                inputValue = inputValue.Remove(inputValue.Length-1);
                UpdateInputValue();
            }
        }

        private void btn_dot_Click(object sender, EventArgs e)
        {
            Debug.WriteLine(inputValue.IndexOf("."));
            if (inputValue.IndexOf(".") == -1)
            {
                inputValue += ".";
                UpdateInputValue();
            }
            else
            {
                inputValue = inputValue.Remove(inputValue.IndexOf("."));
                UpdateInputValue();
            }
        }

        //정수 실수 확인
        private Boolean isNumberic(string str)
        {
            int i;
            try
            {
                i = Convert.ToInt32(str);
            }
            catch
            {
                return false;
            }
            return true;
        }
    }
}
