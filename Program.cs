using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MergeSortAssist
{
    public class Program
    {
        static void Main(string[] args)
        {
            runApp();
        }
        static void runApp()
        {

            int[] marks = new int[6];
            marks[0] = 92;
            marks[1] = 86;
            marks[2] = 76;
            marks[3] = 72;
            marks[4] = 82;
            marks[5] = 96;

            MergeSort.Sort(marks);

            Console.WriteLine("Sorted List of Marks in Ascending Order:");
            foreach (var mark in marks)
            {
                Console.WriteLine($"Mark: {mark}");
            }

            Console.ReadLine();
        }
        
    
      
    }
}
