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
        public static void settingData(Form1 myForm,decimal inputValue, int n)
        {
            //length = (int)(Math.Log10((double)inputValue) + 1);
            inputValue *= 10;
            inputValue += n;
            myForm.setInputValue(inputValue);
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
