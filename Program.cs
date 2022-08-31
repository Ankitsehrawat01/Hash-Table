namespace HashTableProblem
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hash Table Program");
            MyMapNode<string, string> hash = new MyMapNode<string, string>(5);
            hash.Add("0", "to");
            hash.Add("1", "be");
            hash.Add("2", "or");
            hash.Add("3", "not");
            hash.Add("4", "to");
            hash.Add("5", "be");
            string hash5 = hash.Get("5");
            Console.WriteLine("5th index value is: " + hash5);
        }
    }
}
