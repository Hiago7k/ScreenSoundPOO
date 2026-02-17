class Musica
{
    public Musica(Banda artista, string nome)
    {
        Artista = artista;
        Nome = nome;
    }


   public string Nome { get; }
   public Banda Artista { get; }
   public int Duracao { get; set; }
   public bool Disponivel { get; set; }
   public string DescricaoResumida => $"A musica {Nome} pertence a {Artista}"; // LAMBDA
   public Genero Genero { get; set; }
    // Para criar um Relacionamento de Classes, utilizamos a Classe como propriedade
    // da Nossa classe principal


    public void ExibirFichaTecnica()
    {
        Console.WriteLine($"Nome da Musica: {Nome} ");
        Console.WriteLine($"Artista: {Artista.Nome} ");
        Console.WriteLine($"Duracao: {Duracao} ");
        if (Disponivel)
        {
            Console.WriteLine("Esta disponivel no seu plano!");
        }
        else 
        {
            Console.WriteLine("Nao esta disponivel no seu plano");
        }
    }
}

