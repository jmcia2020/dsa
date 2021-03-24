using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenges.ArrayChallenges
{
    public class ArrayShift
    {
        public static int[] InsertShiftArray(int[] array, int num)
        {
            //new array is size of old array +1
            int[] shiftArray = new int[array.Length + 1];

            int arrayHalf = shiftArray.Length / 2; 
            for (int i = 0; i < shiftArray.Length; i++)
			{
                if (i < arrayHalf)
                {
                    shiftArray[i] = array[i];
                }
                else if(i == arrayHalf)
                {
                    shiftArray[i] = num;
                }
                else
                {
                    shiftArray[i] = array[i - 1];
                }
          	}
            return shiftArray;
        }
    }
}
