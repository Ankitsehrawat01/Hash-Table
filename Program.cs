﻿namespace HashTableProblem
{
    public class Program
    {
        public static void Main(string[] args)
        {
            bool check = true;
            while (check)
            {
                Console.WriteLine("Hash Table Program");
                Console.WriteLine("1) Program for a Line to be or not to be\n" +
                              "2) Program for a Para\n");
                int option = Convert.ToInt32(Console.ReadLine());

                switch (option)
                {
                    case 1:
                        MyMapNode<string, string> hash = new MyMapNode<string, string>(5);
                        hash.Add("0", "to");
                        hash.Add("1", "be");
                        hash.Add("2", "or");
                        hash.Add("3", "not");
                        hash.Add("4", "to");
                        hash.Add("5", "be");
                        string hash1 = hash.Get("5");
                        Console.WriteLine("5th index value is: " + hash1);
                        break;
                    case 2:
                        MyMapNode<string, string> hash2 = new MyMapNode<string, string>(5);
                        hash2.Add("0", "Paranoids");
                        hash2.Add("1", "are");
                        hash2.Add("2", "not");
                        hash2.Add("3", "paranoid");
                        hash2.Add("4", "because");
                        hash2.Add("5", "they");
                        hash2.Add("6", "are");
                        hash2.Add("7", "paranoid");
                        hash2.Add("8", "but");
                        hash2.Add("9", "because");
                        hash2.Add("10", "they");
                        hash2.Add("11", "keep");
                        hash2.Add("12", "putting");
                        hash2.Add("13", "themselves");
                        hash2.Add("14", "deliberately");
                        hash2.Add("15", "into");
                        hash2.Add("16", "paranoid");
                        hash2.Add("17", "avoidable");
                        hash2.Add("18", "situations");
                        string hash3 = hash2.Get("5");
                        Console.WriteLine("5th index value is: " + hash3);
                        break;
                }
            }
        }
    }
}
 