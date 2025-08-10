using System.Collections;
using System.Collections.Generic;
using System.Linq;

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

            #region Q3
            //Hashtable table = new Hashtable
            //{
            //    {"Key 1" , "apple" },
            //    {"Key 2" , "bannana" },
            //    {"Key 3" , "apple" }
            //};
            //
            //Console.WriteLine("Enter Your Target Value : ");
            //string targetValue = Console.ReadLine();
            //
            //bool Founded = false;
            //
            //foreach (DictionaryEntry entry in table)
            //{
            //    if (entry.Value != null && entry.Value.ToString() == targetValue)
            //    {
            //        Console.WriteLine(entry.Key);
            //        Founded = true;
            //    }
            //}
            //
            //if (!Founded)
            //{
            //    Console.WriteLine("Key Not Founded");
            //}
            #endregion

            #region Q4
            //string[] words = { "eat", "tea", "tan", "ate", "nat", "bat" };
            //
            //var grouped = GroupAnagrams(words);
            //
            //foreach (var group in grouped)
            //{
            //    Console.WriteLine("[ " + string.Join(", ", group) + " ]");
            //}
            #endregion

            #region Q5
            //int[] array = { 30, 55, 12, 16, 31, 12, 16, 31, 90, 55 };
            //bool hasDuplicates = ContainDuplicates(array);
            //Console.WriteLine($"Contains Duplicates?" + hasDuplicates);
            #endregion

            #region Q6
            //SortedDictionary<int, string> Students = new SortedDictionary<int, string>();
            //
            //// Add Students
            //Students.Add(3, "Allam");
            //Students.Add(1, "Hassan");
            //Students.Add(2, "Essam");
            //Students.Add(4, "Ahmed");
            //
            //// retrieving student names (by id)
            //int SearchId = 2;
            //if (Students.TryGetValue(SearchId , out string name))
            //{
            //    Console.WriteLine($"Student Id ({SearchId}) His Name {name}");
            //}
            //else
            //{
            //    Console.WriteLine($"Student Id {SearchId} Not Found.");
            //}
            //
            //// Remove Student
            //Students.Remove(4);
            //
            //// Display all Students to make Sure this student if removed or not and if they sorted or not.
            //foreach(var display in Students)
            //{
            //    Console.WriteLine($"Id : {display.Key} , Name : {display.Value}");
            //}
            #endregion

            #region Q7
            //SortedList<int , string> EmployeeDictionary = new SortedList<int , string>();
            //
            //EmployeeDictionary.Add(5 , "Mahmoud");
            //EmployeeDictionary.Add(8, "Hamada");
            //EmployeeDictionary.Add(7, "Omar");
            //EmployeeDictionary.Add(6 , "Mohamed");
            //
            //int ifEmployeeFound = 6;
            //if (EmployeeDictionary.TryGetValue(ifEmployeeFound, out string name)) 
            //{
            //    Console.WriteLine($"Employee Id = {ifEmployeeFound} And His Name Is {name}"); 
            //}
            //else
            //{
            //    Console.WriteLine($"Employee Id = {ifEmployeeFound} Not Founded");
            //}
            //Console.WriteLine();
            //
            //foreach (var display in EmployeeDictionary)
            //{
            //    Console.WriteLine($"Employee Id = {display.Key} , Employee Name = {display.Value}");
            //}
            #endregion

            #region Q8
            //int[] array = { 1, 2, 4, 5, 7 };
            //int N = 7;
            //
            //List<int> Missing = FindMissingNumbers(array, N);
            //
            //Console.WriteLine("Missing Numbers Is : ");
            //foreach (int i in Missing) Console.WriteLine(i);
            #endregion

            #region Q9
            //List<int> numbers = new List<int> {1 , 1 , 2 , 3 , 4 , 4 , 5 , 5 , 6 , 7 , 7 };
            //
            //HashSet<int> UniqueNumbers = new HashSet<int>(numbers);
            //
            //Console.WriteLine("Unique Numbers : ");
            //foreach (int num in UniqueNumbers)
            //{
            //    Console.WriteLine(num);
            //}
            #endregion

            #region Q10
            //Hashtable Original = new Hashtable
            //{
            //    {"Hassan" , 1},
            //    {"Essam" , 2},
            //    {"Allam" , 3}
            //};
            //
            //Hashtable Swaped = new Hashtable();
            //
            //foreach (DictionaryEntry entry in Original)
            //{
            //    Swaped[entry.Value] = entry.Key;
            //}
            //
            //Console.WriteLine("Swaped Hash Table : ");
            //foreach (DictionaryEntry entry in Swaped)
            //{
            //    Console.WriteLine($"{entry.Key} ==> {entry.Value}");
            //}
            #endregion

            #region Q11
            //HashSet<int> Set1 = new HashSet<int> { 1, 2, 3 , 4 , 5 , 6};
            //HashSet<int> Set2 = new HashSet<int> { 5 , 6 , 7 , 8 , 9 , 10 };
            //
            //HashSet<int> UnionSet = new HashSet<int>(Set1);
            //UnionSet.UnionWith(Set2);
            //
            //Console.WriteLine("Union Set :");
            //foreach (int num in UnionSet)
            //{
            //    Console.WriteLine(num);
            //}
            #endregion
        }

        #region Fun Q4
        //static List<List<string>> GroupAnagrams(string[] strs)
        //
        //{
        //    Dictionary<string, List<string>> map = new Dictionary<string, List<string>>();
        //
        //    foreach (string word in strs)
        //    {
        //        char[] chars = word.ToCharArray();
        //        Array.Sort(chars);
        //        string key = new string(chars);
        //
        //        if (!map.ContainsKey(key))
        //        {
        //            map[key] = new List<string>();
        //        }
        //        map[key].Add(word);
        //    }
        //
        //    return map.Values.ToList();

        #endregion

        #region Fun Q5
        //static bool ContainDuplicates(int[] nums)
        //{
        //    HashSet<int> seen = new HashSet<int>();
        //    foreach (int num in nums)
        //    {
        //        if (seen.Contains(num))
        //        {
        //            return true;
        //        }
        //        seen.Add(num);
        //    }
        //    return false;
        //}
        #endregion

        #region Fun Q8
        //static List<int> FindMissingNumbers(int[] inputArray, int N)
        //{
        //    HashSet<int> PresentNumbers = new HashSet<int>(inputArray);
        //
        //    List<int> MissingNumbers = new List<int>();
        //
        //    for (int i = 1; i <= N; i++)
        //    {
        //        if (!PresentNumbers.Contains(i))
        //        {
        //            MissingNumbers.Add(i);
        //        }
        //    }
        //    return MissingNumbers;
        //}
        #endregion
    }
}

