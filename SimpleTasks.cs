using System;
using System.Linq;
using System.Collections.Generic;


namespace Sample
{
    public class SimpleTasks
    {

        // retorna character com maior frequencia
        public static char CharMaxCount(string str)
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
        public static char VewelMaxCount(string str)
        {
            char[] arrayVowels = new char[] {'a', 'e', 'i', 'o', 'u',
                                             'A', 'E', 'I', 'O', 'U' };
                                             
            Dictionary<char, int> dict = new Dictionary<char, int>();

            // preenche dict com a frequencia de cada vogal da string
            foreach( char ch in str )
            {
                if(arrayVowels.Contains(ch))
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


        // retorna substring com maior frequencia de consoantes
        public static string SubConsoantMaxCount(string str)
        {
            char[] arrayVowels = new char[] {'a', 'e', 'i', 'o', 'u',
                                             'A', 'E', 'I', 'O', 'U' };
            
            // countConsoant possui cada indice correspondendo a cada string de subString
            string[] subStrings = str.Split(' ');
            int[] countConsoant = new int[subStrings.Length];

            // preenche countConsoant com a frequencia de consoantes de cada substring
            for(int rep = 0; rep < subStrings.Length; rep++)
            {
                foreach( char ch in subStrings[rep] )
                {
                    if(!arrayVowels.Contains(ch) && !Char.IsDigit(ch))
                        countConsoant[rep]++;
                }
            }

            // pegando o indice da substring com maior frequencia de consoante
            int index = Array.IndexOf(countConsoant, countConsoant.Max());
            return subStrings[index];
        }


        // retorna substring com maior frequencia de ditongos
        public static string SubDiphthongMaxCount(string str)
        {   
            // inicializa o dicionário com cada substring separada por espaço 
            Dictionary<string, int> dict = str.Split(' ').ToDictionary( strKey   => strKey,
                                                                        intValue => 0 );

            char[] arrayVowels = new char[] {'a', 'e', 'i', 'o', 'u',
                                             'A', 'E', 'I', 'O', 'U' };

            char previous;
            // preenche dict.Values com a frequencia de ditongo 
            foreach( KeyValuePair<string, int> kvp in dict )
            {   
                previous = kvp.Key[0];
                for(int rep = 0; rep < kvp.Key.Length; rep++)
                {
                    if(arrayVowels.Contains(previous) && arrayVowels.Contains(kvp.Key[rep]))
                        dict[kvp.Key]++;

                    previous = kvp.Key[rep];
                }       
            }
            // verifica dict.Key com maior dict.Value correspondente
            return dict.Aggregate( (prev, next) => prev.Value > next.Value ? prev : next).Key;

            // Att : ainda falta tratar para nao enquadrar tritongos
        }
    }
}