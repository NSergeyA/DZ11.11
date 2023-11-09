using System;


namespace LAB
{
    internal class Song
    {
        private string name;
        private string author;
        private Song prev;

        public Song()
        {

        }
        public Song(string name, string author)
        {
            this.name = name;
            this.author = author;
            prev = null;
        }
        public Song(string name, string author, Song prev)
        {
            this.name = name;
            this.author = author;
            this.prev = prev;
        }

        public void Songname(string name)
        {
            this.name = name;
        }
        public void Songauthor(string author)
        {
            this.author = author;

        }
        public void Prevsong(Song previoussong)
        {
            prev = previoussong;
        }
        public void Title()
        {
            Console.WriteLine("Название: " + name);
            Console.WriteLine("Автор: " + author);
        }
        public override bool Equals(object d)
        {
            if (d == null || GetType() != d.GetType())
            {
                return false;
            }

            Song song = (Song)d;
            return name == song.name && author == song.author;
        }

    }
}