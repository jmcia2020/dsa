using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xunit;
using DataStructures.LinkedLists;
using System.Threading.Tasks;


namespace DataSTructures.Test.LinkedLists
{
    public class KthFromTheEndTests
    {
        [Fact(Skip = "Test for code not yet written")]
        //Happy Path Test
        public void KFromTheEnd_returns_value_at_position()
        {

            //Arrange
            LinkedList list = new LinkedList();
            list.Insert(2);
            list.Insert(8);
            list.Insert(3);
            list.Insert(1);

            //Act
            int result = list.KthFromTheEnd(2);

            //Assert
            Assert.Equal(3, result);
        }
    }

}