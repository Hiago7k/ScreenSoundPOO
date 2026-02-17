Banda queen = new Banda("Queen");

Album albumDoQueen = new Album("A Night at the Operah");

Musica musica1 = new Musica(queen, "Love of my life")
{
    Duracao = 213,
    Disponivel = true,
};
Musica musica2 = new Musica(queen, "Bohemian Rhapsody")
{
    Duracao = 352,
    Disponivel = false,
};

//Add musicas dentro do Album que criamos, na LISTA
albumDoQueen.AdicionarMusica(musica1);
albumDoQueen.AdicionarMusica(musica2);
queen.AdicionarALbum(albumDoQueen);

musica1.ExibirFichaTecnica();
musica2.ExibirFichaTecnica();
albumDoQueen.ExibirMusicasDoAlbum();
queen.ExibirDiscografia();