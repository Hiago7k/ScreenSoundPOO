class Album 
{
    // Campo Privado Lista
    private List<Musica> musicas = new List<Musica>();

    public Album(string nome)
    {
        Nome = nome;
    }

    public string Nome { get; }
    public int DuracaoTotal => musicas.Sum(m => m.Duracao); // pegar a duracao de todas as musicas


    // Criar um metodo onde colocamos musica dentro do nosso ALBUM
    public void AdicionarMusica(Musica musica)
    {
        musicas.Add(musica);
    }

    public void ExibirMusicasDoAlbum() 
    {
        Console.WriteLine($"Lista de musicas do album {Nome}: \n");
        foreach (var musica in musicas)
        {
            Console.WriteLine($"Musica: {musica.Nome}");
        }
        Console.WriteLine($"\nEste album tem a duracao de {DuracaoTotal}");
    }
}