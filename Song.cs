using System.Collections.Generic;

namespace Json
{
    public class Song
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public Song(string name, string description)
        {
            Name = name;
            Description = description;
        }
        public override string ToString()
        {
            return $"Song name: {Name}, description: {Description}";
        }

        public static IEnumerator<Song> GetEnumerator()
        {
            return null;
        }

    }
}
