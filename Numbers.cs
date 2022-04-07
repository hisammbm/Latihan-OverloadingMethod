using System;

namespace LatihanOverloadingMethod
{
    class Numbers
    {
        public int FindMinimum(int number1, int number2)
        {
            int Minimum;

            if(number1 < number2){
                Minimum = number1;
            }else{
                Minimum = number2;
            }

            return Minimum;
        }

        public int FindMinimum(int number1, int number2, float number3)
        {
            int Minimum;

            if(number1 < number2 && number1 < number3){
                Minimum = number1;
            }else if((number2 < number1) && (number2 < number3)){
                Minimum = number2;
            }else{
                Minimum = Convert.ToInt32(number3);
            }

            return Minimum;
        }
            
        public int FindMaximum(int number1, int number2)
        {
            int Maximum;

            if(number1 > number2){
                Maximum = number1;
            }else{
                Maximum = number2;
            }

            return Maximum;
        }

        public int FindMaximum(int number1, int number2, float number3)
        {
            int Maximum;

            if(number1 > number2 && number1 > number3){
                Maximum = number1;
            }else if((number2 > number1) && (number2 > number3)){
                Maximum = number2;
            }else{
                Maximum = Convert.ToInt32(number3);
            }

            return Maximum;
        }
    }
}