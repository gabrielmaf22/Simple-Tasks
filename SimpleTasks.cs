using System;
using System.Linq;
using System.Collections.Generic;


namespace SimpleTasks
{
    public class Sample
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
        public static char CharVewelMaxCount(string str)
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
        public static string StringConsoantMaxCount(string str)
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
        public static string StringDiphthongMaxCount(string str)
        {   
            // inicializa o dicionário com cada substring separada por espaço 
            Dictionary<string, int> dict = str.Split(' ').ToDictionary( strKey   => strKey,
                                                                        intValue => 0 );

            char[] arrayVowels = new char[] {'a', 'e', 'i', 'o', 'u',
                                             'A', 'E', 'I', 'O', 'U' };

            List<char> listElem = new List<char> {};

            // preenche dict.Values com a frequencia de ditongo 
            foreach( KeyValuePair<string, int> kvp in dict )
            {   
                // obs : atualiza se for tritongo
                for(int rep = 0; rep < kvp.Key.Length; rep++)
                {   
                    if(arrayVowels.Contains(kvp.Key[rep]))
                    {
                        listElem.Add(kvp.Key[rep]);
                        if(listElem.Count == 2)
                        {
                            dict[kvp.Key]++;
                        }
                        else if(listElem.Count > 2)
                        {
                            dict[kvp.Key]--;
                        }
                    }else {
                        listElem.Clear();
                    }
                }       
            }
            // verifica dict.Key com maior dict.Value correspondente
            return dict.Aggregate( (prev, next) => prev.Value > next.Value ? prev : next).Key;
        }


        // retorna lista com strings com tamanho acima da média 
        public static List<string> ListStringAboveAverage(List<string> listStr)
        {
            int intAverage = 0;
            
            // preenche intAverage com o tamanho de cada string
            foreach( string substring in listStr )
                intAverage += substring.Length;
            // reformula intAverage com o calculo da media de tamanho das strings
            intAverage /= listStr.Count;

            // removendo strings com tamanho inferior
            for( int rep = 0; rep < listStr.Count; rep++ )
            {
                if(listStr[rep].Length <= intAverage)
                    listStr.RemoveAt(rep);
            }

            return listStr;
        }
    }
}



// Aggregate 
