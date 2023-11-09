using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace LAB
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("Упражнение 9.3");
            BankType type = BankType.Сберегательный;
            Bankaccount account = new Bankaccount(type);
            Bankaccount account1 = new Bankaccount(1000);
            Bankaccount account2 = new Bankaccount(type, 1000);
            account.Transfer(account1, amount: 100);
            account.Dispose();
            Console.WriteLine("Для продолжения нажмите любую кнопку...");
            Console.ReadKey();



            Console.WriteLine("Домашнее задание 9.1");
            Console.WriteLine("Домашнее задание 8.2");
            List<Song> songs = new List<Song>();
            Song song1 = new Song("Я Русский", "SHAMAN");
            

            Song song2 = new Song("Я Русский", "SHAMAN", song1);
            

            Song song3 = new Song("Astral step", "Shadowraze", song2);
            

            Song song4 = new Song("Mana break", "Zxcursed", song3);
            

            Song song5 = new Song("Astral step", "Shadowraze", song4);
            

            song2.Prevsong(song1);
            song3.Prevsong(song2);
            song4.Prevsong(song3);
            song5.Prevsong(song4);
            songs.Add(song1);
            songs.Add(song2);
            songs.Add(song3);
            songs.Add(song4);
            songs.Add(song5);
            foreach (Song song in songs)
            {
                song.Title();
                Console.WriteLine();
            }


            for (int i = 0; i < songs.Count; i++)
            {
                for (int j = i + 1; j < songs.Count; j++)
                {
                    bool areEqual = songs[i].Equals(songs[j]);
                    Console.WriteLine($"Песня {i + 1} и песня {j + 1} одинаковы: " + areEqual);
                }
            }
            Console.ReadKey();
        }
    }
}
