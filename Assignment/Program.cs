using System.Collections;

namespace Assignment
{
    internal class Program
    {


        static void ReverseArrayList(ArrayList list)
        {
            int start = 0;
            int end = list.Count - 1;

            while (start < end)
            {

                object temp = list[start];
                list[start] = list[end];
                list[end] = temp;


                start++;
                end--;
            }
        }


        static List<int> GetEvenNumbers(List<int> numbers)
        {
            List<int> evenNumbers = new List<int>();

            foreach (int number in numbers)
            {
                if (number % 2 == 0)
                {
                    evenNumbers.Add(number);
                }
            }

            return evenNumbers;
        }

        static void Main(string[] args)
        {
            #region Q1
            //ArrayList List = new ArrayList { 1, 2, 3, 4, 5 };

            //ReverseArrayList(List);


            //foreach (var item in List)
            //{
            //    Console.Write(item + " ");
            //}

            #endregion

            #region Q2

            //List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            //List<int> evenNumbers = GetEvenNumbers(numbers);

            //Console.WriteLine(string.Join(" ", evenNumbers));
            #endregion

            #region Q3

            //try
            //{

            //    Console.Write("Enter the capacity of the list: ");
            //    int capacity = int.Parse(Console.ReadLine());



            //    FixedSizeList<int> list = new FixedSizeList<int>(capacity);


            //    while (true)
            //    {
            //        Console.Write("Enter an item to add (or type 'done' to finish): ");
            //        string input = Console.ReadLine();

            //        if (input.ToLower() == "done")
            //        {
            //            break;
            //        }

            //        int item = int.Parse(input);
            //        list.Add(item);
            //    }



            //    Console.WriteLine("\nItems in the list:");
            //    for (int i = 0; i < list.Count; i++)
            //    {
            //        Console.WriteLine($"Index {i}: {list.Get(i)}");
            //    }


            //    Console.Write("\nEnter an index to retrieve an item: ");
            //    int index = int.Parse(Console.ReadLine());
            //    Console.WriteLine($"Item at index {index}: {list.Get(index)}");
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine($"Error: {ex.Message}");
            //}


            #endregion
        }
    }
}       
  
