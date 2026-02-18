using System.ComponentModel;

class Podcast 
{
    private List<Episodio> episodios = new();

    public Podcast(string nome, string host, string convidado )
    {
        Nome = nome;
        Host = host;
        Convidado = convidado;
    }

    
    public string Host { get;  }
    public string Convidado { get; }
    public string Nome { get; }
    public int TotalEpisodios => episodios.Count;
    

    public void AdicionarEpisodio(Episodio episodio)
    {
        episodios.Add(episodio);
    }

    // Exibir Detalahes
    // Deve mostrar Nome do Podcast e Seu host na 1 linha
    // em seguida sua lista de Episodios ordenados por sequencia
    // e por fim o total de episodios

    public void ExibirDetalhes()
    {
        Console.WriteLine("=============================================");
        Console.WriteLine($"Nome do podcast {Nome}");
        Console.WriteLine($"Host: {Host}");
        Console.WriteLine("=============================================");
        foreach (var episodio in episodios)
        {
            Console.WriteLine(episodio.Resumo);
        }
        Console.WriteLine($"A quantidade de episodios nesse podcast e de {TotalEpisodios}");

    }
}