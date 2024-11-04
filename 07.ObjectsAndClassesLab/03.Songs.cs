namespace _03.Songs
{
    class Song
    {
        public string TypeList { get; set; }
        public string Name { get; set; }
        public string Time { get; set; }
    }
    class Program
    {

        static void Main(string[] args)
        {
            int totalSongs = int.Parse(Console.ReadLine());
            List<Song> songs = new List<Song>();
            for (int i = 0; i < totalSongs; i++)
            {
                string[] data = Console.ReadLine().Split('_');

                string type = data[0];
                string name = data[1];
                string time = data[2];

                Song song = new Song()
                {
                    TypeList = type,
                    Name = name,
                    Time = time
                };
                songs.Add(song);
            }
            string lastType = Console.ReadLine();
            if (lastType == "all")
            {
                foreach (Song song in songs)
                {
                    Console.WriteLine(song.Name);
                }
            }
            else
            {
                foreach (Song song in songs)
                {
                    if (song.TypeList == lastType)
                    {
                        Console.WriteLine(song.Name);
                    }

                }
            }

        }



    }
}







