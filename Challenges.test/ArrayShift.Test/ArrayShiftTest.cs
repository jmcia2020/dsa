using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xunit;
using Challenges.ArrayChallenges;
using System.Threading.Tasks;

namespace Challenges.tests.ArrayChallenges
{
    public class ArrayShiftTest
    {
        [Fact]
        public void Array_shift_takes_an_outside_number_and_places_it_in_the_middle_of_a_given_even_array()
        {
            //Arrange
            int[] evenArray = new int[] {2, 4, 6, 8};
            int newNum = 5;

            //Act add code
            int[] results = ArrayShift.InsertShiftArray(evenArray, newNum);

            //Assert
            int[] expected = new int[] { 2, 4, 5, 6, 8 };

            Assert.Equal(expected, results);
        }

        [Fact]
        public void Array_shift_takes_an_outside_number_and_places_it_in_the_middle_of_a_given_odd_array()
        {
            //Arrange
            int[] oddArray = new int[] { 4, 8, 15, 23, 42 };
            int newNum = 16;

            //Act add code
            int[] results = ArrayShift.InsertShiftArray(oddArray, newNum);

            //Assert
            int[] expected = new int[] { 4, 8, 15, 16, 23, 42 };

            Assert.Equal(expected, results);
        }

    }
            
       
}
