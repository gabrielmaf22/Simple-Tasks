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
            char[] listVowels = new char[] {'a', 'e', 'i', 'o', 'u',
                                             'A', 'E', 'I', 'O', 'U' };
                                             
            Dictionary<char, int> dict = new Dictionary<char, int>();

            // preenche dict com a frequencia de cada vogal da string
            foreach( char ch in str )
            {
                if(listVowels.Contains(ch))
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
            char[] listVowels = new char[] {'a', 'e', 'i', 'o', 'u',
                                             'A', 'E', 'I', 'O', 'U' };
            
            // countConsoant possui cada indice correspondendo a cada string de subString
            string[] subStrings = str.Split(' ');
            int[] countConsoant = new int[subStrings.Length];

            // preenche countConsoant com a frequencia de consoantes de cada substring
            for(int rep = 0; rep < subStrings.Length; rep++)
            {
                foreach( char ch in subStrings[rep] )
                {
                    if(!listVowels.Contains(ch) && !Char.IsDigit(ch))
                        countConsoant[rep]++;
                }
            }

            // pegando o indice da substring com maior frequencia de consoante
            int index = Array.IndexOf(countConsoant, countConsoant.Max());
            return subStrings[index];
        }

    }
}











