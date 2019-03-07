using System;

namespace PadawansTask2
{
    public static class ArithmeticSequence
    {
        public static int Calculate(int number, int add, int count)
        {
            // put your code here
            for (int i = 1; i <= count; i++)
            {
                for (int j = add; j <= count-1; j++)
                {

                    int sum = number + add;
                    sum += sum + 1;
                    // put your code here

                }
            }
            throw new NotImplementedException();
        }
    }
}
