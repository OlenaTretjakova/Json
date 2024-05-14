using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Json
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Завдання 1:
            //Створіть програму для роботи з масивом цілих чисел з такою
            //функціональністю:
            //1.Введення масиву цілих чисел з клавіатури.
            //2.Фільтр масиву.Залежно від вибору користувача,
            //прибираємо прості числа або числа Фібоначчі.
            //3.Серіалізація масиву.
            //4.Збереження серіалізованого масиву у файл.
            //5.Завантаження серіалізованого масиву з файлу. Після
            //завантаження потрібно виконати десеріалізацію.
            //Вибір певного формату серіалізації потрібно зробити вам.
            //Звертаємо вашу увагу, що вибір має бути обґрунтованим.

            


            Console.WriteLine("Enter array numbers through a space:");

            
            string stringNumbers = Console.ReadLine();

            string jsonString = ServicFun.GetJson(stringNumbers);


            ServicFun.WritenToFile("fileTask1.txt", jsonString);


            Console.WriteLine("What numbers do you want to add to the array:");

            stringNumbers = Console.ReadLine();

            jsonString = ServicFun.GetJson(stringNumbers);


            ServicFun.WritenToFile("fileTask1.txt", jsonString);


            //Task 2.
            //Створіть програму для роботи з інформацією про музичний
            //альбом, яка зберігатиме таку інформацію:
            //1.Назва альбому.
            //2.Назва виконавця.
            //3.Рік випуску.
            //4.Тривалість.
            //5.Студія звукозапису.
            //Програма має бути з такою функціональністю:
            //1.Введення інформації про альбом.
            //2.Виведення інформації про альбом.
            //3.Серіалізація альбому.
            //4.Збереження серіалізованого альбому у файл.
            //5.Завантаження серіалізованого альбому з файлу. Після
            //завантаження потрібно виконати десеріалізацію альбому.
            //Вибір певного формату серіалізації потрібно зробити вам.
            //Звертаємо вашу увагу, що вибір має бути обґрунтованим.

            Console.WriteLine();
            Console.WriteLine("Task 2.");

            MusicAlbom albom1 = new MusicAlbom("AlbumName1", "SingerName1", new DateTime(2020,01,02), "Duration1", "RecordingStudio1");
                                                                            
            MusicAlbom albom2 = new MusicAlbom("AlbumName2", "SingerName2", new DateTime(2021, 09, 02), "Duration2", "RecordingStudio2");
                                                                            
            MusicAlbom albom3 = new MusicAlbom("AlbumName3", "SingerName3", new DateTime(2024, 04, 1), "Duration3", "RecordingStudio3");

            Console.WriteLine(albom1.ToString());
            Console.WriteLine(albom2.ToString());
            Console.WriteLine(albom3.ToString());

            MusicAlbom.writeFileJson("musicAlboms.txt", albom1);
            MusicAlbom.writeFileJson("musicAlboms.txt", albom2);
            MusicAlbom.writeFileJson("musicAlboms.txt", albom3);

            string contentMusicAlbomsFile = MusicAlbom.ReadJsonFile("musicAlboms.txt");

            Console.WriteLine();
            Console.WriteLine("It was reading from file:");
            MusicAlbom.ShowContentFile(contentMusicAlbomsFile);

            //ця частина дає помилку не знаю чому?????
            //Song song1 = new Song("Name 1", "Description 1");
            //MusicAlbom albom4 = new MusicAlbom("AlbumName4", "SingerName4", new DateTime(2020, 04,11), "Duration4", "RecordingStudio3");
            //albom4.AddSong(song1);
            //
            //MusicAlbom.writeFileJson("musicAlboms.txt",albom4);
            //
            //string contentMusicAlbomsFile1 = MusicAlbom.ReadJsonFile("musicAlboms.txt");
            //MusicAlbom.ShowContentFile(contentMusicAlbomsFile1);
            //Console.ReadLine();

        }
    }
}
