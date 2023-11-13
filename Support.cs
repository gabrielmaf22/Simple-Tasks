namespace Task
{
    public class Simple
    {
        public static void MaxCountChar(string str)
        {
            Dictionary<char, int> dict = new Dictionary<char, int>();

            foreach(char ch in str)
            {
                if( !dict.ContainsKey(ch) )
                    dict.Add(ch, 1);
                else
                    dict[ch]++;
            }

            Console.WriteLine($"MaxCountChar : {dict.Aggregate((a, b) 
                                                => a.Value > b.Value ? a : b).Key} (x{dict.Values.Max()})");

        }
    }
}




// Encontrar character com maior frequência