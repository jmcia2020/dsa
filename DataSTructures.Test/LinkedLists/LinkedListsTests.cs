using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xunit;
using DataStructures.LinkedLists;
using System.Threading.Tasks;


namespace DataSTructures.Test.LinkedLists
{
    public class LinkedListsTests
    {
        [Fact]
        public void Empty_list_has_null_HEAD()
        {

            //Arrange/Act
            LinkedList linkedList = new LinkedList();

            //Assert
            Assert.Null(list.HEAD);

            Assert.Equal("NULL", list.ToString();
        }

        [Fact]
        public void Insert_works_for_empty_list();
        {
            //Arrange
            LinkedList list = new LinkedList();

        int value 5;

        //Act
        list.Insert(5);

            //Assert
            //no longer empty
            Assert.NotNull(list.Head.value);

        }

    [Fact(Skip: = Homework")]
        public void Insert_works_for_list_that_is_not_empty()
        {
            //Arrange
            LinkedList list = new LinkedList();
            list.Insert(5);

            int value = 3;

            //Act
            list.Insert(3);

            //Assert
            Assert.NotNull(list.Head);
            Assert.Equal(value, list.Head.Value);
            Assert.NotNull(list.Head.Next);
            Assert.Equal(5, list.Head.Next.Value);
        }

        [Theory]
    }
}
