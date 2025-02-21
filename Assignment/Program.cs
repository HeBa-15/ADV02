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
            static void Main(string[] args)
            {
                #region Q1
                ArrayList List = new ArrayList { 1, 2, 3, 4, 5 };

                ReverseArrayList(List);

              
                foreach (var item in List)
                {
                    Console.Write(item + " ");
                }

                #endregion
            }
        }
    }