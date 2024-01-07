using System;

interface IItemBiblioteca
{
    string Nome { get; set; }
    string ObterDataDevolucao();
}

class Livro : IItemBiblioteca
{
    public string Nome { get; set; }

    public string ObterDataDevolucao()
    {
        DateTime dataFutura = DateTime.Now.AddDays(5);
      string dataFormatada = dataFutura.ToString("dd/MM/yyyy");
        return $"O livro é {Nome} e sua data de devolução é dia {dataFormatada}";
    }
}

class Jornal : IItemBiblioteca
{
    public string Nome { get; set; }

    public string ObterDataDevolucao()
    {
        DateTime dataFutura = DateTime.Now.AddDays(7);
      string dataFormatada = dataFutura.ToString("dd/MM/yyyy");
        return $"O jornal é {Nome} e sua data de devolução é dia {dataFormatada}";
    }
}

class Revista : IItemBiblioteca
{
    public string Nome { get; set; }

    public string ObterDataDevolucao()
    {
        DateTime dataFutura = DateTime.Now.AddDays(5);
      string dataFormatada = dataFutura.ToString("dd/MM/yyyy");
        return $"A revista é {Nome} e sua data de devolução é dia {dataFormatada}";
    }
}


class Program {
  public static void Main (string[] args) {

    Console.WriteLine("Digite o que você quer levar da biblioteca (livro, revista ou jornal)");
        string respostaBibliote = Console.ReadLine();

        IItemBiblioteca itemBiblioteca = null;

        if (respostaBibliote == "livro")
        {
            Console.WriteLine("Digite o nome do livro");
            string nomeLivro = Console.ReadLine();
            itemBiblioteca = new Livro { Nome = nomeLivro };
        }
        else if (respostaBibliote == "jornal")
        {
            Console.WriteLine("Digite o nome do jornal");
            string nomeJornal = Console.ReadLine();
            itemBiblioteca = new Jornal { Nome = nomeJornal };
        }
        else if (respostaBibliote == "revista")
        {
            Console.WriteLine("Digite o nome da revista");
            string nomeRevista = Console.ReadLine();
            itemBiblioteca = new Revista { Nome = nomeRevista };
        }
    Console.WriteLine(itemBiblioteca.ObterDataDevolucao());
    
    
  }
}