using System;

namespace CS_Testing_Enviroment
{

    class Program
    {

        static string FindNum(int num, int[] myArr, int myArrLength, int upperBound, int lowerBound)
        {

            if (myArr[myArrLength] == num)
            {
                string result = String.Format("You found the number! The number is {0}!", myArr[myArrLength]);
                return result;
            }

            else if (num < myArr[myArrLength])
            {

                return FindNum(num, myArr, (myArrLength + lowerBound) / 2, (upperBound + lowerBound) / 2, lowerBound);
            }

            else
            {

                return FindNum(num, myArr, (myArrLength + upperBound) / 2, upperBound, (lowerBound + upperBound) / 2);
            }
        }

        static void Main()
        {

            int[] myArr = { 1, 2, 5, 8, 17, 18, 19, 21, 27, 33, 48, 57, 65, 101, 132, 234, 257, 342, 568, 978, 1003 };
            int upperBound = myArr.Length;
            int myArrLength = upperBound / 2;
            int lowerBound = 0;
            string arrayString = " {";

            foreach (int number in myArr)
            {
                arrayString += number;
                arrayString += " ";
            }

            int arrayStirngLength = arrayString.Length - 1;
            arrayString = arrayString.Substring(0, arrayStirngLength);
            arrayString += "}";

            Console.WriteLine("Enter a number from the following array" + arrayString);
            int num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(FindNum(num, myArr, myArrLength, upperBound, lowerBound));
        }
    }
}
