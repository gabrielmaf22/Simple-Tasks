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
                for(int rep = 0; rep < kvp.Key.Length; rep++)
                {   
                    // processa ao encontrar elemento vogal
                    if(arrayVowels.Contains(kvp.Key[rep]))
                    {   
                        // lista que serve como parâmetro de verificação
                        listElem.Add(kvp.Key[rep]);
                        if(listElem.Count == 2)
                        {
                            dict[kvp.Key]++;
                        }
                        // remove a frequencia ao se deparar com tritongo/+
                        else if(listElem.Count > 2)
                        {
                            dict[kvp.Key]--;
                        }
                    }
                    // reseta listElem ao encontrar um elemento não vogal (consoante)
                    else    
                        listElem.Clear();
                }       
            }
            // verifica dict.Key com maior dict.Value correspondente
            return dict.Aggregate( (prev, next) => prev.Value > next.Value ? prev : next ).Key;
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

            List<string> listAux = new List<string> {};
            // alimenta listAux com as strings de tamanho superior à média 
            for(int rep = 0; rep < listStr.Count; rep++)
            {
                if(listStr[rep].Length > intAverage)
                    listAux.Add(listStr[rep]);
            }         

            return listAux;
        }   


        // retorna lista com números inteiros
        public static List<int> ListIntOddNumbers( List<int> listInt )
        {
            List<int> listAux = new List<int> {};
            for( int rep = 0; rep < listInt.Count; rep++ )
            {
                if( listInt[rep] % 2 != 0 )
                    listAux.Add(listInt[rep]);
            }
            return listAux;
        }

    }
}

