# Objetos Usados / Finalidade / Justificativa

        <> Dictionary         : contabilizar elementos                | evita redundância diante de elementos repetidos
                                                                      | ex : "bananabana"    ------ >        { 'b' : 2, 'a' : 5, 'n' : 3 } 
                                                                            
        <> Array              : registro de dados específicos         | tamanho fixo e mais enxuto 
                              : quantidade conhecida                  | ex : char[] arrayVowels = new char[] { 'a', 'e', 'i', 'o', 'u' };
                                                                             
        <> List               : registrar de dados gerais/específicos | tamanho variável, maior flexibilidade, praticidade
                              : quantidade desconhecida               | ex : List<char> listElem = new List<char> {};
                                     
# Métodos Usados / Finalidade / Exemplo

        <> Contains           : verificar se contém tal elemento em array/lista/...     
                                        | arrayVowels.Contains(char);
                                                
        <> ContainsKey        : verificar se contém tal elemento em Dictionary.Keys  
                                        | dict.ContainsKey(keyValue);
                                                
        <> IndexOf            : encontra o índice da primeira ocorrência             
                                        | Array.IndexOf(arrayCountConsoant, arrayCountConsoant.Max());
        
        <> Aggregate          : retorna valor correspondente à aplicação de uma função em uma sequência de valores agregados
                                        | dict.Aggregate( (prev, next) => prev.Value > next.Value ? prev : next ).Key;
