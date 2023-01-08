namespace LinkedList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            LinkedList list = new LinkedList();
            LinkedListStack stack = new LinkedListStack();
            bool flag = true;
            while (flag)
            {
                Console.WriteLine("Select Programs\n 1.Create LinkedList\n 2.Add Elements in Reverse Order\n 3.Append the elements\n 4.Insert Elements in LinkedList\n 5.Delete the Elements in LinkedList\n 6.Delete Last Elements in LinkedList\n 7.Search node on LinkedList\n 8.Insert 40 Elements on LinkedList\n 9.Delete Elemens" +
                    "ts on LinkedList\n 10.Arrange Elements in AscendingOrder\n 11.Create Stack");
                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        list.Add(56);
                        list.Add(30);
                        list.Add(70);
                        list.Display();
                        break;
                    case 2:
                        list.AddInReverseOrder(70);
                        list.AddInReverseOrder(30);
                        list.AddInReverseOrder(56);
                        list.Display();
                        break;
                    case 3:
                        list.Append(56);
                        list.Append(30);
                        list.Append(70);
                        list.Display();
                        break;
                    case 4:
                        list.AddInReverseOrder(70);
                        list.InsertAtGivenPosition(1, 30);
                        list.AddInReverseOrder(56);
                        list.Display();
                        break;
                    case 5:
                        list.Add(56);
                        list.Add(30);
                        list.Add(70);
                        list.Pop();
                        list.Display();
                        break;
                    case 6:
                        list.Add(56);
                        list.Add(30);
                        list.Add(70);
                        list.PopLast();
                        list.Display();
                        break;
                    case 7:
                        list.Search(56);
                        list.Display();
                        break;
                    case 8:
                        list.InsertNodeAfterParticularNode(40, 30);
                        list.Display();
                        break;
                    case 9:
                        list.DeleteAtParticularPosition(2);
                        list.size();
                        list.Display();
                        break;
                    case 10:
                        list.AscendingOrderSort(56);
                        list.AscendingOrderSort(30);
                        list.AscendingOrderSort(40);
                        list.AscendingOrderSort(70);
                        list.Display();
                        break;
                    case 11:
                        stack.Push(70);
                        stack.Push(30);
                        stack.Push(56);
                        stack.Display();
                        break;
                }
            }
        }
    }
}