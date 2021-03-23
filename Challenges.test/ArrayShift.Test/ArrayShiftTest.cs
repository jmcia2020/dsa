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
        public void Array_shift_takes_an_outside_number_and_places_it_in_the_middle_of_a_given_array()
        {
            //Arrange
            int[] array = new int[] {2, 4, 6, 8};
            int newNum = 5;

            //Act add code
            int[] results = ArrayShift.InsertShiftArray(array, newNum);

            //Assert
            int[] expected = new int[] { 2, 4, 5, 6, 8 };

            Assert.Equal(expected, results);
        }

}
            
       
}
