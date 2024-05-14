using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Newtonsoft.Json;

namespace Json
{
    public class MusicAlbom
    {
        public string Name { get; set; }
        public string NameSinger { get; set; }
        public DateTime DateCreateAlbom {  get; set; }
        public string Duration { get; set; }
        public string RecorsStudio { get; set; }

        public List<Song> Songs { get; set; } = new List<Song>();

        public MusicAlbom(string name, string nameSinger, DateTime dateCreateAlbom, string duration, string recorsStudio)
        {
            Name = name;
            NameSinger = nameSinger;
            DateCreateAlbom = dateCreateAlbom;
            Duration = duration;
            RecorsStudio = recorsStudio;
            Songs = new List<Song>();
        }

        public MusicAlbom(string name, string nameSinger, DateTime dateCreateAlbom, string duration, string recorsStudio, List<Song> songs)
        {
            Name = name;
            NameSinger = nameSinger;
            DateCreateAlbom = dateCreateAlbom;
            Duration = duration;
            RecorsStudio = recorsStudio;
            Songs = songs;
        }

        public static new IEnumerator<MusicAlbom> GetEnumerator() 
        {
            return GetEnumerator();
        }

        public override string ToString()
        {
            string songsInfo = string.Join(", ", Songs.Select(song => song.ToString()));
            return $"Name albom: {Name}, name singer: {NameSinger}, " +
                   $"date creating albom: {DateCreateAlbom}, " +
                   $"duration: {Duration}, recording studio: {RecorsStudio}, " +
                   $"songs: {songsInfo}";
        }
        public static void ShowContentFile(string json)
        {
            List<MusicAlbom> albom = new List<MusicAlbom>(JsonConvert.DeserializeObject<List<MusicAlbom>>(json));

            foreach (var item in albom)
            {
                Console.WriteLine(item.ToString());
            }
        }

        public static string ReadJsonFile(string file)
        {
            try
            {
                return File.ReadAllText(file);

            }
            catch (IOException e)
            {
                return($"An error occurred while reading the file: {e.Message}");
            };

        }

        

        public static string GetJson(MusicAlbom albom,string fileContentJson)
        {
            List<MusicAlbom> fileContent = JsonConvert.DeserializeObject<List<MusicAlbom>>(fileContentJson);
            fileContent.Add(albom);
            return JsonConvert.SerializeObject(fileContent);
        }

        public static string GetJson(MusicAlbom albom)
        {
            List<MusicAlbom> fileContent = new List<MusicAlbom>();
            fileContent.Add(albom);
            return JsonConvert.SerializeObject(fileContent);
        }

        public static void writeFileJson(string file, MusicAlbom albom)
        {
            if (File.Exists(file))
            {
                string json = File.ReadAllText(file);
                using(StreamWriter sw = new StreamWriter(file,false))
                {
                    sw.WriteLine(GetJson(albom, json));
                }
            }
            else
            {
                using (StreamWriter sw = new StreamWriter(file, false))
                {
                    sw.WriteLine(GetJson(albom));
                }

            }
        }

        public void AddSong(Song song)
        { 
            Songs.Add(song);
        }

    }
}
