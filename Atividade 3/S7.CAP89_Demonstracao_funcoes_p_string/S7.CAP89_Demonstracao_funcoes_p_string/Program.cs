using System;

namespace S7.CAP89_Demonstracao_funcoes_p_string
{
    class Program
    {
        static void Main(string[] args)
        {
            string original = "abcde FGHIJ ABC abc DEFG ";
            string s1 = original.ToUpper();
            string s2 = original.ToLower();
            string s3 = original.Trim();
            int n1 = original.IndexOf("bc");
            int n2 = original.LastIndexOf("bc");
            string s4 = original.Substring(3);
            string s5 = original.Substring(3, 5);
            string s6 = original.Replace('a', 'x');
            string s7 = original.Replace("abc", "xy");
            bool b1 = String.IsNullOrEmpty(original);
            bool b2 = String.IsNullOrWhiteSpace(original);

            Console.WriteLine("Original: -" + original + "-");//string normal
            Console.WriteLine("ToUpper: -" + s1 + "-");//tudo maiusculo
            Console.WriteLine("ToLower: -" + s2 + "-");//tudo minusculo
            Console.WriteLine("Trim: -" + s3 + "-");// Apaga os espaços em branco antes e depois da string
            Console.WriteLine("IndexOf('bc'): " + n1);//Busca dentro da string a primeira ocorrencia
            Console.WriteLine("LastIndexOf('bc'): " + n2);//Busca dentro da string a ultima ocorrecia
            Console.WriteLine("Substring(3): -" + s4 + "-");//Recortar string a partir de certo ponto, neste caso corta do "d" em diante
            Console.WriteLine("Substring(3, 5): -" + s5 + "-");//Recortar string a partir de certo ponto, neste caso corta do "d" até "G" 
            Console.WriteLine("Replace('a', 'x'): -" + s6 + "-");//Substituir uma parte da string por outra, neste caso substitui o caracter a por x
            Console.WriteLine("Replace('abc', 'xy'): -" + s7 + "-");//Substituir uma parte dastring por outra, neste caso substitui abc por xy
            Console.WriteLine("IsNullOrEmpty: " + b1);//Testa se o conteúdo da variavel é nulo ou vazio.
            Console.WriteLine("IsNullOrWhiteSpace: " + b2);//Testa se o conteúdo da variavel é nulo ou somente espaço em branco.

            Console.ReadKey();
        }
    }
}
