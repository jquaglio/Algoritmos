﻿using Algorithms.LinkedLists;
using Xunit;

namespace AlgorithmsTest.LinkedLists
{
    public class MyLinkedListTest
    {
        [Fact]
        public void Create_My_Linked_List()
        {
            var myLinkedList = new MyLinkedList<int>(10);

            Assert.Equal(10, myLinkedList.Head.Value);
            Assert.Null(myLinkedList.Head.Next);
            Assert.Equal(10, myLinkedList.Tail.Value);
            Assert.Equal(1, myLinkedList.Length);
        }

        [Fact]
        public void Append_An_Element()
        {
            var myLinkedList = new MyLinkedList<int>(10);

            myLinkedList.Append(5);

            Assert.Equal(10, myLinkedList.Head.Value);
            Assert.Equal(5, myLinkedList.Head.Next.Value);
            Assert.Null(myLinkedList.Head.Next.Next);
            Assert.Equal(5, myLinkedList.Tail.Value);
            Assert.Equal(2, myLinkedList.Length);
        }

        [Fact]
        public void Append_Two_Elements()
        {
            var myLinkedList = new MyLinkedList<int>(10);

            myLinkedList.Append(5);
            myLinkedList.Append(16);

            Assert.Equal(10, myLinkedList.Head.Value);
            Assert.Equal(5, myLinkedList.Head.Next.Value);
            Assert.Equal(16, myLinkedList.Head.Next.Next.Value);
            Assert.Null(myLinkedList.Head.Next.Next.Next);
            Assert.Equal(16, myLinkedList.Tail.Value);
            Assert.Equal(3, myLinkedList.Length);
        }

        [Fact]
        public void Prepend_An_Element_In_A_New_MyLinkedList()
        {
            var myLinkedList = new MyLinkedList<int>(10);

            myLinkedList.Prepend(1);

            Assert.Equal(1, myLinkedList.Head.Value);
            Assert.NotNull(myLinkedList.Head.Next);
            Assert.Equal(10, myLinkedList.Head.Next.Value);
            Assert.Equal(10, myLinkedList.Tail.Value);
            Assert.Equal(2, myLinkedList.Length);
        }

        [Fact]
        public void Prepend_Two_Elements_In_A_New_MyLinkedList()
        {
            var myLinkedList = new MyLinkedList<int>(10);

            myLinkedList.Prepend(1);
            myLinkedList.Prepend(2);

            Assert.Equal(2, myLinkedList.Head.Value);
            Assert.Equal(1, myLinkedList.Head.Next.Value);
            Assert.Equal(10, myLinkedList.Head.Next.Next.Value);
            Assert.Equal(10, myLinkedList.Tail.Value);
            Assert.Equal(3, myLinkedList.Length);
        }

        [Fact]
        public void InsertAt_An_Element_At_Index_2_In_An_Existing_LinkedList()
        {
            var myLinkedList = new MyLinkedList<int>(10);
            myLinkedList.Append(5);
            myLinkedList.Append(16);

            myLinkedList.InsertAt(2, 99);

            Assert.Equal(10, myLinkedList.Head.Value);
            Assert.Equal(5, myLinkedList.Head.Next.Value);
            Assert.Equal(99, myLinkedList.Head.Next.Next.Value);
            Assert.Equal(16, myLinkedList.Head.Next.Next.Next.Value);
            Assert.Null(myLinkedList.Head.Next.Next.Next.Next);
            Assert.Equal(16, myLinkedList.Tail.Value);
            Assert.Equal(4, myLinkedList.Length);
        }

        [Fact]
        public void InsertAt_An_Element_At_Index_0_In_An_Existing_LinkedList()
        {
            var myLinkedList = new MyLinkedList<int>(10);
            myLinkedList.Append(5);
            myLinkedList.Append(16);

            myLinkedList.InsertAt(0, 99);

            Assert.Equal(99, myLinkedList.Head.Value);
            Assert.Equal(10, myLinkedList.Head.Next.Value);
            Assert.Equal(5, myLinkedList.Head.Next.Next.Value);
            Assert.Equal(16, myLinkedList.Head.Next.Next.Next.Value);
            Assert.Null(myLinkedList.Head.Next.Next.Next.Next);
            Assert.Equal(16, myLinkedList.Tail.Value);
            Assert.Equal(4, myLinkedList.Length);
        }

        [Fact]
        public void InsertAt_An_Element_At_The_End_Of_An_Existing_LinkedList()
        {
            var myLinkedList = new MyLinkedList<int>(10);
            myLinkedList.Append(5);
            myLinkedList.Append(16);

            myLinkedList.InsertAt(3, 99);

            Assert.Equal(10, myLinkedList.Head.Value);
            Assert.Equal(5, myLinkedList.Head.Next.Value);
            Assert.Equal(16, myLinkedList.Head.Next.Next.Value);
            Assert.Equal(99, myLinkedList.Head.Next.Next.Next.Value);
            Assert.Null(myLinkedList.Head.Next.Next.Next.Next);
            Assert.Equal(99, myLinkedList.Tail.Value);
            Assert.Equal(4, myLinkedList.Length);
        }

        [Fact]
        public void RemoveAt_An_Element_At_Index_1_In_An_Existing_LinkedList()
        {
            var myLinkedList = new MyLinkedList<int>(10);
            myLinkedList.Append(5);
            myLinkedList.Append(16);

            myLinkedList.RemoveAt(1);

            Assert.Equal(10, myLinkedList.Head.Value);
            Assert.Equal(16, myLinkedList.Head.Next.Value);
            Assert.Null(myLinkedList.Head.Next.Next);
            Assert.Equal(16, myLinkedList.Tail.Value);
            Assert.Equal(2, myLinkedList.Length);
        }

        [Fact]
        public void RemoveAt_An_Element_At_Index_0_In_An_Existing_LinkedList()
        {
            var myLinkedList = new MyLinkedList<int>(10);
            myLinkedList.Append(5);
            myLinkedList.Append(16);

            myLinkedList.RemoveAt(0);

            Assert.Equal(5, myLinkedList.Head.Value);
            Assert.Equal(16, myLinkedList.Head.Next.Value);
            Assert.Null(myLinkedList.Head.Next.Next);
            Assert.Equal(16, myLinkedList.Tail.Value);
            Assert.Equal(2, myLinkedList.Length);
        }

        [Fact]
        public void RemoveAt_Last_Element_In_An_Existing_LinkedList()
        {
            var myLinkedList = new MyLinkedList<int>(10);
            myLinkedList.Append(5);
            myLinkedList.Append(16);

            myLinkedList.RemoveAt(2);

            Assert.Equal(10, myLinkedList.Head.Value);
            Assert.Equal(5, myLinkedList.Head.Next.Value);
            Assert.Null(myLinkedList.Head.Next.Next);
            Assert.Equal(5, myLinkedList.Tail.Value);
            Assert.Equal(2, myLinkedList.Length);
        }

        [Fact]
        public void GetAt_An_Element_In_An_Existing_LinkedList()
        {
            var myLinkedList = new MyLinkedList<int>(10);
            myLinkedList.Append(5);
            myLinkedList.Append(16);

            var node = myLinkedList.GetAt(1);

            Assert.Equal(5, node.Value);
            Assert.Equal(16, node.Next.Value);
        }

        [Fact]
        public void GetAt_The_First_Element_In_An_Existing_LinkedList()
        {
            var myLinkedList = new MyLinkedList<int>(10);
            myLinkedList.Append(5);
            myLinkedList.Append(16);

            var node = myLinkedList.GetAt(0);

            Assert.Equal(10, node.Value);
            Assert.Equal(5, node.Next.Value);
        }

        [Fact]
        public void GetAtToLast_An_Element_In_An_Existing_LinkedList()
        {
            var myLinkedList = new MyLinkedList<int>(10);
            myLinkedList.Append(5);
            myLinkedList.Append(16);

            var node = myLinkedList.GetAtToLast(1);

            Assert.Equal(16, node.Value);
            Assert.Null(node.Next);
        }

        [Fact]
        public void GetAtToLast_The_First_Element_In_An_Existing_LinkedList()
        {
            var myLinkedList = new MyLinkedList<int>(10);
            myLinkedList.Append(5);
            myLinkedList.Append(16);

            var node = myLinkedList.GetAtToLast(2);

            Assert.Equal(5, node.Value);
            Assert.Equal(16, node.Next.Value);
        }

        [Fact]
        public void FindNode_With_Value_5_In_An_Existing_LinkedList()
        {
            var myLinkedList = new MyLinkedList<int>(10);
            myLinkedList.Append(5);
            myLinkedList.Append(16);

            var node = myLinkedList.FindNodeBy(5);

            Assert.Equal(5, node.Value);
            Assert.Equal(16, node.Next.Value);
        }

        [Fact]
        public void FindNode_With_Value_99_In_An_Existing_LinkedList_Will_Return_Null()
        {
            var myLinkedList = new MyLinkedList<int>(10);
            myLinkedList.Append(5);
            myLinkedList.Append(16);

            var node = myLinkedList.FindNodeBy(99);

            Assert.Null(node);
        }

        [Fact]
        public void The_LinkedList_Is_Not_Cyclic()
        {
            var myLinkedList = new MyLinkedList<int>(10);
            myLinkedList.Append(5);
            myLinkedList.Append(16);

            var isCyclic = myLinkedList.IsCyclic();

            Assert.False(isCyclic);
        }

        [Fact]
        public void The_LinkedList_Is_Cyclic()
        {
            var myLinkedList = new MyLinkedList<int>(10);
            myLinkedList.Append(5);
            myLinkedList.Append(16);
            myLinkedList.Tail.Next = myLinkedList.Head;

            var isCyclic = myLinkedList.IsCyclic();

            Assert.True(isCyclic);
        }

        [Fact]
        public void Swap_Nodes_At_Position_1_And_3()
        {
            var myLinkedList = new MyLinkedList<int>(10);
            myLinkedList.Append(5);
            myLinkedList.Append(16);
            myLinkedList.Append(99);

            myLinkedList.SwapNodes(1, 3);

            Assert.Equal(10, myLinkedList.Head.Value);
            Assert.Equal(99, myLinkedList.Head.Next.Value);
            Assert.Equal(16, myLinkedList.Head.Next.Next.Value);
            Assert.Equal(5, myLinkedList.Head.Next.Next.Next.Value);
            Assert.Equal(5, myLinkedList.Tail.Value);
            Assert.Null(myLinkedList.Tail.Next);
        }

        [Fact]
        public void Swap_Nodes_At_Position_0_And_3()
        {
            var myLinkedList = new MyLinkedList<int>(10);
            myLinkedList.Append(5);
            myLinkedList.Append(16);
            myLinkedList.Append(99);

            myLinkedList.SwapNodes(0, 3);

            Assert.Equal(99, myLinkedList.Head.Value);
            Assert.Equal(5, myLinkedList.Head.Next.Value);
            Assert.Equal(16, myLinkedList.Head.Next.Next.Value);
            Assert.Equal(10, myLinkedList.Head.Next.Next.Next.Value);
            Assert.Equal(10, myLinkedList.Tail.Value);
            Assert.Null(myLinkedList.Tail.Next);
        }

        [Fact]
        public void Swap_Nodes_At_Position_1_And_2()
        {
            var myLinkedList = new MyLinkedList<int>(10);
            myLinkedList.Append(5);
            myLinkedList.Append(16);
            myLinkedList.Append(99);

            myLinkedList.SwapNodes(1, 2);

            Assert.Equal(10, myLinkedList.Head.Value);
            Assert.Equal(16, myLinkedList.Head.Next.Value);
            Assert.Equal(5, myLinkedList.Head.Next.Next.Value);
            Assert.Equal(99, myLinkedList.Head.Next.Next.Next.Value);
            Assert.Equal(99, myLinkedList.Tail.Value);
            Assert.Null(myLinkedList.Tail.Next);
        }

        [Fact]
        public void Copy_LinkedList()
        {
            var myLinkedList = new MyLinkedList<int>(10);
            myLinkedList.Append(51);
            myLinkedList.Append(16);
            myLinkedList.Append(99);

            var newLinkedList = myLinkedList.Copy();

            Assert.Equal(10, newLinkedList.Value);
            Assert.Equal(51, newLinkedList.Next.Value);
            Assert.Equal(16, newLinkedList.Next.Next.Value);
            Assert.Equal(99, newLinkedList.Next.Next.Next.Value);
            Assert.Null(newLinkedList.Next.Next.Next.Next);
        }

        [Fact]
        public void Destroy_LinkedList()
        {
            var myLinkedList = new MyLinkedList<int>(10);
            myLinkedList.Append(51);
            myLinkedList.Append(16);
            myLinkedList.Append(99);

            myLinkedList.Destroy();

            Assert.Null(myLinkedList.Head);
            Assert.Null(myLinkedList.Tail);
            Assert.Equal(0, myLinkedList.Length);
        }

        [Fact]
        public void Reverse_Linked_List_With_Even_Length_Of_Elements()
        {
            var myLinkedList = new MyLinkedList<int>(10);
            myLinkedList.Append(51);
            myLinkedList.Append(16);
            myLinkedList.Append(99);

            myLinkedList.Reverse();

            Assert.Equal(99, myLinkedList.Head.Value);
            Assert.Equal(16, myLinkedList.Head.Next.Value);
            Assert.Equal(51, myLinkedList.Head.Next.Next.Value);
            Assert.Equal(10, myLinkedList.Head.Next.Next.Next.Value);
            Assert.Null(myLinkedList.Head.Next.Next.Next.Next);
            Assert.Equal(10, myLinkedList.Tail.Value);
            Assert.Null(myLinkedList.Tail.Next);
        }

        [Fact]
        public void Reverse_Linked_List_With_Odd_Length_Of_Elements()
        {
            var myLinkedList = new MyLinkedList<int>(10);
            myLinkedList.Append(51);
            myLinkedList.Append(16);
            myLinkedList.Append(99);
            myLinkedList.Append(33);

            myLinkedList.Reverse();

            Assert.Equal(33, myLinkedList.Head.Value);
            Assert.Equal(99, myLinkedList.Head.Next.Value);
            Assert.Equal(16, myLinkedList.Head.Next.Next.Value);
            Assert.Equal(51, myLinkedList.Head.Next.Next.Next.Value);
            Assert.Equal(10, myLinkedList.Head.Next.Next.Next.Next.Value);
            Assert.Null(myLinkedList.Head.Next.Next.Next.Next.Next);
            Assert.Equal(10, myLinkedList.Tail.Value);
            Assert.Null(myLinkedList.Tail.Next);
        }

        [Fact]
        public void Reverse_AnotherWay_Linked_List_With_Even_Length_Of_Elements()
        {
            var myLinkedList = new MyLinkedList<int>(10);
            myLinkedList.Append(51);
            myLinkedList.Append(16);
            myLinkedList.Append(99);

            myLinkedList.Reverse_AnotherWay();

            Assert.Equal(99, myLinkedList.Head.Value);
            Assert.Equal(16, myLinkedList.Head.Next.Value);
            Assert.Equal(51, myLinkedList.Head.Next.Next.Value);
            Assert.Equal(10, myLinkedList.Head.Next.Next.Next.Value);
            Assert.Null(myLinkedList.Head.Next.Next.Next.Next);
            Assert.Equal(10, myLinkedList.Tail.Value);
            Assert.Null(myLinkedList.Tail.Next);
        }

        [Fact]
        public void Reverse_AnotherWay_Linked_List_With_Odd_Length_Of_Elements()
        {
            var myLinkedList = new MyLinkedList<int>(10);
            myLinkedList.Append(51);
            myLinkedList.Append(16);
            myLinkedList.Append(99);
            myLinkedList.Append(33);

            myLinkedList.Reverse_AnotherWay();

            Assert.Equal(33, myLinkedList.Head.Value);
            Assert.Equal(99, myLinkedList.Head.Next.Value);
            Assert.Equal(16, myLinkedList.Head.Next.Next.Value);
            Assert.Equal(51, myLinkedList.Head.Next.Next.Next.Value);
            Assert.Equal(10, myLinkedList.Head.Next.Next.Next.Next.Value);
            Assert.Null(myLinkedList.Head.Next.Next.Next.Next.Next);
            Assert.Equal(10, myLinkedList.Tail.Value);
            Assert.Null(myLinkedList.Tail.Next);
        }
    }
}