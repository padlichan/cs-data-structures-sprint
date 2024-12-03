// Console.WriteLine("Your code can go here, if you like");
using cs_data_structures_sprint.Exercises;
using cs_data_structures_sprint.Playlist;
using cs_data_structures_sprint.RequestBenchmark;

List<Album> albums = new List<Album>();

Album modernEscapism = new Album("Modern Escapism", "blanket");
modernEscapism.AddSong("White Noise", 4.37);
modernEscapism.AddSong("Romance", 5.22);
modernEscapism.AddSong("Last days of the Blue Blood Harvest", 5.27);
modernEscapism.AddSong("Firmament", 3.45);
modernEscapism.AddSong("The Mighty Deep", 2.39);
modernEscapism.AddSong("In Awe", 4.00);
modernEscapism.AddSong("Where the Light Takes Us", 3.51);
modernEscapism.AddSong("Burial", 4.40);
modernEscapism.AddSong("Violence", 5.05);
modernEscapism.AddSong("Silent Ground", 1.35);
modernEscapism.AddSong("Last Light", 5.22);

albums.Add(modernEscapism);

var bonIver = new Album("Bon Iver", "Bon Iver");
bonIver.AddSong("Perth", 4.22);
bonIver.AddSong("Minnesota, WI", 3.52);
bonIver.AddSong("Holocene", 5.37);
bonIver.AddSong("Towers", 3.08);
bonIver.AddSong("Mitchcant", 3.46);
bonIver.AddSong("Hinnom, TX", 2.45);
bonIver.AddSong("Wash", 4.59);
bonIver.AddSong("Calgary", 4.10);
bonIver.AddSong("Lisbon, OH", 1.33);
bonIver.AddSong("Beth/Rest", 5.17);

albums.Add(bonIver);


var playlist = new Playlist();
playlist.AddSong(modernEscapism.FindSong("Where the Light Takes Us"));
playlist.AddSong(modernEscapism.FindSong("In Awe"));
playlist.AddSong(modernEscapism.FindSong("Burial"));
playlist.AddSong(modernEscapism.FindSong("Violence"));
playlist.AddSong(modernEscapism.FindSong("Holocene"));
playlist.AddSong(bonIver.FindSong("Towers"));
playlist.AddSong(bonIver.FindSong("Beth/Rest"));
playlist.AddSong(bonIver.FindSong("Mitchcant"));