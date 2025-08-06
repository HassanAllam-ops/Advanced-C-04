using System.Collections;

namespace Advanced_C__04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q1
            //int[] numbers = { 1, 2, 3, 2, 3, 1, 1, 4, 5, 6, 1, 2, 2, 3 };
            //
            //Hashtable FrequencyTable = new Hashtable();
            //
            //foreach (int num in numbers)
            //{
            //    if (FrequencyTable.ContainsKey(num))
            //    {
            //        FrequencyTable[num] = (int)FrequencyTable[num] + 1;
            //    }
            //    else
            //    {
            //        FrequencyTable[num] = 1;
            //    }
            //}
            //
            //foreach (DictionaryEntry entry in FrequencyTable)
            //{
            //    Console.WriteLine($"Element {entry.Key} Occurs {entry.Value} Time(s).");
            //}
            #endregion

            #region Q2
           // Hashtable table = new Hashtable
           // {
           //     { "apple", 5 },
           //     { "banana", "twelve" },
           //     { "cherry", 7 },
           //     { "date", 3 }
           // };
           //
           // object maxKey = null;
           // int maxValue = int.MinValue;
           //
           // foreach (DictionaryEntry entry in table)
           // {
           //     if (entry.Value is int value)
           //     {
           //         if (value > maxValue)
           //         {
           //             maxValue = value;
           //             maxKey = entry.Key;
           //         }
           //     }
           //     else
           //     {
           //         Console.WriteLine($"Skipping key '{entry.Key}' with non-integer value.");
           //     }
           // }
           //
           // if (maxKey != null)
           // {
           //     Console.WriteLine($"Key with highest integer value: {maxKey} (Value: {maxValue})");
           // }
           // else
           // {
           //     Console.WriteLine("No integer values found in the Hashtable.");
           //
           // }
            #endregion

        }
}
}
