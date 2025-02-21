using System.Collections;

namespace ADV02
{
    internal class Program
    {
        //public static int SumArrayList(ArrayList Numbers)
        //{
        //    int Sum = 0;
        //    if (Numbers is not null)
        //    {
        //        for (int i = 0; i < Numbers.Count; i++)
        //        {
        //            Sum += (int?)Numbers[i] ?? 0; // Casting from Object [Reference Type] to int [Value Type]
        //                                          // UnBoxing [Unsafe Casting]
        //        }
        //    }
        //    return Sum;
        //}

        ///public static int SumOfList(List<int> list)
        ///{
        ///    int sum = 0;
        ///    if (list ?.Count > 0)
        ///    {
        ///        for (int i = 0; i <= list.Count; i++) 
        ///        {
        ///            sum += list[i];
        ///        }
        ///    }
        ///    return sum;
        ///}
        static void Main(string[] args)
        {
            #region Non-Generic Collections - ArrayList

            //ArrayList Numbers = new ArrayList(5);
            //Numbers.Add(1); // Casting from int [Value type] to object [Reference type] --> Boxing
            //Numbers.Add(2); // Casting from int [Value type] to object [Reference type] --> Boxing
            //Numbers.Add(3); // Casting from int [Value type] to object [Reference type] --> Boxing
            //Numbers.Add(4); // Casting from int [Value type] to object [Reference type] --> Boxing
            //Numbers.Add(5); // Casting from int [Value type] to object [Reference type] --> Boxing
            //int Result = SumArrayList(Numbers);
            //Console.WriteLine($"Result = {Result}"); 

            #endregion

            #region Non-Generic Collections [Array List]

            ///ArrayList nums = new ArrayList(5) { 1, 2, 3, 4, 5 };
            ///Console.WriteLine($"Count = {nums.Count}, Capacity = {nums.Capacity}");
            ///if (nums.Capacity < 21)
            ///    nums.Capacity = 21;
            ///for (int i = 6; i<=21;  i++)
            ///{
            ///    nums.Add(i);
            ///}
            ///Console.WriteLine($"Count = {nums.Count}, Capacity = {nums.Capacity}");

            ///Adding and Trimming
            ///nums.Add(1);
            ///nums.Add(2);
            ///nums.AddRange(new int[] { 3, 4 });
            ///Console.WriteLine($"Count = {nums.Count}, Capacity = {nums.Capacity}");
            ///nums.Add(5);
            ///Console.WriteLine($"Count = {nums.Count}, Capacity = {nums.Capacity}");
            ///nums.TrimToSize();
            ///Console.WriteLine("After Trimming");
            ///Console.WriteLine($"Count = {nums.Count}, Capacity = {nums.Capacity}");

            ///ArrayList nums = new ArrayList(5);
            ///nums.Add(1);
            ///nums.Add(2);
            ///nums.Add(3);
            ///nums.Add(4);
            ///nums.Add("Hamada");
            ///int res = SumOfArrayList()
            #endregion

            #region Generic Collection [List]

            //List<int> nums = new List<int>(5);
            ///Console.WriteLine($"Count = {nums.Count}, Capacity = {nums.Capacity}");
            ///
            ///nums.Add(1);
            ///nums.Add(2);
            ///nums.AddRange([3, 4]);
            ///Console.WriteLine($"Count = {nums.Count}, Capacity = {nums.Capacity}");
            ///nums.Add(5);
            ///Console.WriteLine($"Count = {nums.Count}, Capacity = {nums.Capacity}");
            ///
            ///nums.TrimExcess();
            ///Console.WriteLine($"Count = {nums.Count}, Capacity = {nums.Capacity}");

            ///foreach(int i in nums)
            ///{
            ///    Console.WriteLine(i);
            ///}

            ///Console.WriteLine($"Count = {nums.Count}, Capacity = {nums.Capacity}");
            ///nums.EnsureCapacity(21);
            ///for (int i = 6; i < 21; i++)
            ///{
            ///    nums.Add(i);
            ///}
            ///
            ///Console.WriteLine($"Count = {nums.Count}, Capacity = {nums.Capacity}");

            ///nums.Add(1);
            ///nums.Add(2);
            ///nums.Add(3);
            ///nums.Add(4);
            ///
            ///int res = SumOfList(nums);
            ///Console.WriteLine(res);

            #endregion

            #region Generic Collection Methods [List]

            //List<int> nums = new List<int>(5) { 1, 2, 3, 4, 5 };
            //nums.Insert(0, 100);
            //nums.InsertRange(1, [101, 102, 103, 10]);
            //IReadOnlyList<int> ReadOnlyNumbers = nums.AsReadOnly();

            //int index = nums.BinarySearch(10);
            //Console.WriteLine($"Index = {index}");

            ///List<Employee> emp = new List<Employee>()
            ///{
            ///    new Employee(7, "Ali", 7000),
            ///    new Employee(10, "Ahmed", 5000),
            ///    new Employee(13, "Mina", 6000)
            ///};
            ///
            ///emp.Sort(new EmpName());
            ///
            ///int index = emp.BinarySearch(new Employee() { ID = 7});
            ///index = emp.BinarySearch(new Employee() { Name = "Ali" }, new EmpName());
            ///index = emp.BinarySearch(1, 2, new Employee() { Name = "Ali" }, new EmpName());
            ///Console.WriteLine($"Index: {index}");

            ///nums.Clear();
            ///List <long> n = nums.Select<int, long>(N => N).ToList();
            ///
            ///int[] arr = new int[7];
            ///nums.CopyTo(arr);
            ///
            ///nums.Reverse();
            ///
            ///foreach (int i in arr)
            ///{
            ///    Console.WriteLine(i);
            ///}
            #endregion

            #region Generic Collection Methods [Linked List]
            ///LinkedList<int> nums = new LinkedList<int>(); 
            ///LinkedListNode<int> firstnode = nums.AddFirst(1);
            ///LinkedListNode<int> fourthnode = nums.AddLast(4);
            ///LinkedListNode<int> secondnode = nums.AddAfter(firstnode, 2);
            ///LinkedListNode<int> thirdnode = nums.AddBefore(fourthnode, 3);
            ///Console.WriteLine(thirdnode.Previous.Value);
            #endregion

            #region Generic Collection Methods [Stack]
            ///Stack<int> nums = new Stack<int>();
            ///nums.Push(1);
            ///nums.Push(2);
            ///nums.Push(3);
            ///nums.Pop();
            ///Console.WriteLine(nums.TryPop(out int Value01));
            ///Console.WriteLine(nums.TryPop(out int Value02));
            ///
            ///Console.WriteLine(nums.TryPop(out int Value));
            ///Console.WriteLine(Value);

            #endregion

            #region Generic Collection Methods [Queue]
            ///Queue<int> queue = new Queue<int>();
            ///nums.Enqueue(1);
            ///nums.Enqueue(2);
            ///nums.Enqueue(3);
            ///nums.Dequeue();
            ///Console.WriteLine(nums.TryDequeue(out int Value01));
            ///Console.WriteLine(nums.TryDequeue(out int Value02));
            ///Console.WriteLine(nums.TryDequeue(out int Value03));
            ///Console.WriteLine(nums.TryDequeue(out int Value04));
            ///
            ///Console.WriteLine(Value01);
            ///Console.WriteLine(Value02);
            ///Console.WriteLine(Value03);
            ///Console.WriteLine(Value04);
            #endregion
        }
    }
}