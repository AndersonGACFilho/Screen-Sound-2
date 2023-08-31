using System;
using System.Collections.Generic;

Banda banda = new Banda("The Beatles");
Album album1 = new Album("Please Please Me");
Album album2 = new Album("With the Beatles");
Album album3 = new Album("A Hard Day's Night");

Musica musica1 = new Musica("I Saw Her Standing There", 159);
Musica musica2 = new Musica("Misery", 111);
Musica musica3 = new Musica("Anna (Go to Him)", 150);
Musica musica4 = new Musica("Chains", 143);

album1.AdicionarMusica(musica1);
album1.AdicionarMusica(musica2);

album2.AdicionarMusica(musica3);

album3.AdicionarMusica(musica4);

banda.AdicionarAlbum(album1);
banda.AdicionarAlbum(album2);
banda.AdicionarAlbum(album3);

banda.ExibirDiscografia();

Podcast podcast = new Podcast("NerdCast", "Alexandre Ottoni e Deive Pazos");

Episodio episodio1 = new Episodio("NerdCast 1", "NerdCast 1", 360, 1, new DateTime( 2006, 10, 23));
Episodio episodio2 = new Episodio("NerdCast 2", "NerdCast 2", 360, 2, new DateTime( 2006, 10, 30));
Episodio episodio3 = new Episodio("NerdCast 3", "NerdCast 3", 360, 3, new DateTime( 2006, 11, 6));
Episodio episodio4 = new Episodio("NerdCast 4", "NerdCast 4", 360, 4, new DateTime( 2006, 11, 13));

episodio1.AdicionarConvidado("Rex");
episodio1.AdicionarConvidado("Azaghal");
episodio1.AdicionarConvidado("Jovem Nerd");

episodio2.AdicionarConvidado("Rex");
episodio2.AdicionarConvidado("Azaghal");
episodio2.AdicionarConvidado("Jovem Nerd");

podcast.AdicionarEpisodio(episodio1);
podcast.AdicionarEpisodio(episodio2);
podcast.AdicionarEpisodio(episodio3);
podcast.AdicionarEpisodio(episodio4);


Console.WriteLine(podcast.ToString());

Console.WriteLine(podcast.DescricaoDetalhada());
