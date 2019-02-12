using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class DataSetting
    {
        //데이터 세팅
        public static void settingData(Form1 myForm,string inputValue, int n)
        {
            //length = (int)(Math.Log10((double)inputValue) + 1);
            //decimal tempValue = decimal.Parse(inputValue);
            //tempValue *= 10;
            //tempValue += n.ToString();
            //myForm.setInputValue(tempValue);
            inputValue += n.ToString();
            myForm.setInputValue(decimal.Parse(inputValue));
            myForm.UpdateInputValue();
        }
        //자릿수 세팅
        private int position(int length)
        {
            int temp = 1;
            for (int i = 0; i < length; i++)
            {
                temp *= 10;
            }
            return temp;
        }
    }
}
