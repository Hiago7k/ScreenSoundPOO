//Banda queen = new Banda("Queen");

//Album albumDoQueen = new Album("A Night at the Operah");

//Musica musica1 = new Musica(queen, "Love of my life")
//{
//    Duracao = 213,
//    Disponivel = true,
//};
//Musica musica2 = new Musica(queen, "Bohemian Rhapsody")
//{
//    Duracao = 352,
//    Disponivel = false,
//};

////Add musicas dentro do Album que criamos, na LISTA
//albumDoQueen.AdicionarMusica(musica1);
//albumDoQueen.AdicionarMusica(musica2);
//queen.AdicionarALbum(albumDoQueen);

//musica1.ExibirFichaTecnica();
//musica2.ExibirFichaTecnica();
//albumDoQueen.ExibirMusicasDoAlbum();
//queen.ExibirDiscografia();


Podcast podcast1 = new Podcast("Flow", "Igor", "" );

Episodio episodio1 = new Episodio();
episodio1.Duracao = 231;
episodio1.Ordem = 1;
episodio1.Titulo = "Corinthians Campeao Mundial";
episodio1.AdicionarConvidados("Hiago");
episodio1.AdicionarConvidados("Marcelo");
Console.WriteLine(episodio1.Resumo);
podcast1.AdicionarEpisodio(episodio1);


Episodio episodio2 = new Episodio()
{
    Duracao = 5000,
    Ordem = 2,
    Titulo = "Exploracao em Marte, Criaturas",
    
};
podcast1.AdicionarEpisodio(episodio2);





//Episodio episodio3 = new Episodio()
//{
//    Duracao = 15000,
//    Ordem = 3,
//    Titulo = "Tamo competindo tamo compentindo?"
//};
//podcast1.AdicionarEpisodio(episodio3);


//Episodio episodio4 = new Episodio()
//{
//    Duracao = 0,
//    Ordem = 4,
//    Titulo = "Mundial do Palmeiras"
//};
//podcast1.AdicionarEpisodio(episodio4);

//Episodio episodio5 = new Episodio()
//{
//    Duracao = 23455,
//    Ordem = 5,
//    Titulo = "Investimentos renda fixa ou variavel"
//};

// podcast1.AdicionarEpisodio(episodio5);


podcast1.ExibirDetalhes();



