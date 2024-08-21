using System;
using System.Collections.Generic;

class Film
{
    public string Isim { get; set; }
    public double ImdbPuani { get; set; }

    public Film(string isim, double imdbPuani)
    {
        Isim = isim;
        ImdbPuani = imdbPuani;
    }

    public void BilgileriYazdir()
    {
        Console.WriteLine($"Film: {Isim}, IMDb Puanı: {ImdbPuani}");
    }
}

class Program
{
    static void Main(string[] args)
    {
        List<Film> filmListesi = new List<Film>();
        string devamMi;

        do
        {
            Console.Write("Film adını giriniz: ");
            string isim = Console.ReadLine();

            Console.Write("IMDb puanını giriniz: ");
            double imdbPuani;
            while (!double.TryParse(Console.ReadLine(), out imdbPuani))
            {
                Console.WriteLine("Geçerli bir IMDb puanı giriniz.");
            }

            Film yeniFilm = new Film(isim, imdbPuani);
            filmListesi.Add(yeniFilm);

            Console.Write("Yeni bir film eklemek ister misiniz? (Evet/Hayır): ");
            devamMi = Console.ReadLine().ToLower();

        } while (devamMi == "evet");

        Console.WriteLine("\nEklediğiniz Filmler:");
        foreach (Film film in filmListesi)
        {
            film.BilgileriYazdir();
        }

        Console.WriteLine("\nProgram sonlandırıldı.");
    }
}

