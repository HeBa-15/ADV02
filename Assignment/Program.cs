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

            List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            List<int> evenNumbers = GetEvenNumbers(numbers);

            Console.WriteLine(string.Join(" ", evenNumbers));
            #endregion
        }
        }
    }