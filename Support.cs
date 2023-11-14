namespace Task
{
    public class Simple
    {
        // retorna character com maior frequencia
        public static char MaxCountChar(string str)
        {
            Dictionary<char, int> dict = new Dictionary<char, int>();
            // preenche dict com a frequencia de cada char 
            foreach(char ch in str)
            {
                if( !dict.ContainsKey(ch) )
                    dict.Add(ch, 1);
                else
                    dict[ch]++;
            }
            // verifica dict.Key com maior dict.Value correspondente
            return dict.Aggregate((a, b) => a.Value > b.Value ? a : b).Key;
        }

        // retorna vogal com maior frequncia
        public static char MaxCountVewel(string str)
        {
            List<char> listChar = new List<char> {'a', 'e', 'i', 'o', 'u'};
            Dictionary<char, int> dict = new Dictionary<char, int>();

            // preenche dict com a frequencia de cada vogal da string
            foreach( char ch in str )
            {
                if(listChar.Contains(ch))
                {
                    if(!dict.ContainsKey(ch))
                        dict.Add(ch, 1);
                    else
                        dict[ch]++;
                }
            }        
            // verifica dict.Key com maior dict.Value correspondente
            return dict.Aggregate((a, b) => a.Value > b.Value ? a : b).Key;
        }
    }
}


