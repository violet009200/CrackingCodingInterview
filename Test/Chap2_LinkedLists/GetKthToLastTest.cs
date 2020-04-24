using System;
using Xunit;
using Helper;
using System.Collections.Generic;

namespace Chap2_LinkedLists
{
    public class GetKthToLastTest
    {   

        //k is bigger than size of input list
        [Fact]
        public void KIsBiggerThanInputSize()
        {
            LinkedListHelper<int> helper = new LinkedListHelper<int>();
            LinkedList<int> input = helper.CreateLinkedList(1,2);

            GetKthToLast getKth = new GetKthToLast();
            
            Assert.Throws<ArgumentException>(() => getKth.GetKth_WithSizeInput(input, 4));
            Assert.Throws<ArgumentException>(() => getKth.GetKth_WithOutSizeInput(input, 4));

        }

        [Fact]
        public void KIsSameAsInputSize()
        {
            LinkedListHelper<int> helper = new LinkedListHelper<int>();
            LinkedList<int> input = helper.CreateLinkedList(1, 2, 3, 4, 5);

            GetKthToLast getKth = new GetKthToLast();
            int k = getKth.GetKth_WithSizeInput(input, 5);
            int r = getKth.GetKth_WithOutSizeInput(input, 5);

            Assert.Equal(1, r);

            Assert.Equal(1, k);
        }

        [Fact]
        public void BasicTest()
        {
            LinkedListHelper<int> helper = new LinkedListHelper<int>();
            LinkedList<int> input = helper.CreateLinkedList(1, 2, 3, 4, 5);

            GetKthToLast getKth = new GetKthToLast();
            int k = getKth.GetKth_WithSizeInput(input, 2);

            int r = getKth.GetKth_WithOutSizeInput(input, 2);

            Assert.Equal(4, k);
            Assert.Equal(4, r);
        }

    }
}
