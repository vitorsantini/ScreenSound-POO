Banda evanescence = new Banda("Evanescence");

Album albumDoEvanescence = new Album("Fallen");


Musica musica1 = new Musica(evanescence, "Taking Over Me")
{
    Duracao = 228,
    Disponivel = true,
 
};

Musica musica2 = new Musica(evanescence, "My Immortal")
{
    Duracao = 262,
    Disponivel = false,
    
};


albumDoEvanescence.AdicionarMusica(musica1);
albumDoEvanescence.AdicionarMusica(musica2);
evanescence.AdicionarAlbum(albumDoEvanescence);

musica1.ExibirFichaTecnica();
musica2.ExibirFichaTecnica();
albumDoEvanescence.ExibirMusicasDoAlbum();
evanescence.ExibirDiscografia();
