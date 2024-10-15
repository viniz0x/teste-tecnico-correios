using System.Security.Cryptography.X509Certificates;
using Microsoft.VisualBasic;

public class Contador {
    static void Main() {

        //Contagem daquele que mais se repete
        string entrada = "4v7q3y464j8c7vq64897vqj304jc57jc6q834j6qc34c5j0876&*¨%*¨*&&*#¨%&*(W$)Jh7y47tywegs";
        var frequencia = entrada.GroupBy(c => c).Select(group => new { Chave = group.Key, Contador = group.Count()})
                                .OrderByDescending(x => x.Contador)
                                .ToList();

        //Aquele que aparece com mais se repete
        char mostrarFrequencia = frequencia.First().Chave;

        //Quantidade de caracteres substituidos
        int quantidadeSubstituida = entrada.Count(c => c != mostrarFrequencia);

        //Subistituaindo todos os caracterea pelo que mais se repete
        string resultado = new string(entrada.Select(c => mostrarFrequencia).ToArray());

        Console.WriteLine("Quantidade de valores subistituidos: " + quantidadeSubstituida);
        Console.WriteLine("Valor de entrada: " + entrada);
        Console.WriteLine("Resultado: " + resultado);
    }
}