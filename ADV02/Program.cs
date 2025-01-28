using System.Collections;

namespace ADV02
{
    internal class Program
    {
        public static int SumArrayList(ArrayList Numbers)
        {
            int Sum = 0;
            if (Numbers is not null)
            {
                for (int i = 0; i < Numbers.Count; i++)
                {
                    Sum += (int?)Numbers[i] ?? 0; // Casting from Object [Reference Type] to int [Value Type]
                                                  // UnBoxing [Unsafe Casting]
                }
            }
            return Sum;
        }
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
        }
    }
}