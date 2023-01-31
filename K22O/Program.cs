
using K22O;

const int indulokSzama = 691;

List<Versenyzo> versenyzok = new();

using StreamReader sr = new(@"..\..\..\RES\bukkm2019.txt");
_ = sr.ReadLine();
while (!sr.EndOfStream) versenyzok.Add(new Versenyzo(sr.ReadLine()!));

double f4 = 100 - (versenyzok.Count / (double)indulokSzama * 100);
Console.WriteLine($"4. feladat: Versenytávot nem teljesítők: {f4}%");

int f5 = versenyzok.Count(x => !x.Nem & x.Tav == "Rövid");
Console.WriteLine($"5. feladat: Női versenyzők száma a rövidtávú vers3enayen: {f5} fő");

bool f6 = versenyzok.Any(x => x.Ido.TotalHours > 6);
Console.WriteLine($"6. feladat: {(f6 ? "Volt": "Nem volt")} ilyen versenyző");

Versenyzo f7 = versenyzok
    .Where(x => x.Kategoria == "ff" & x.Tav == "Rövid")
    .OrderBy(x => x.Ido)
    .First();
Console.WriteLine("7. feladat: a felnőtt férfi (ff) kategória győztese rövid távon:\n" +
    $"\tRajtszám: {f7.Rajtszam}\n" +
    $"\tNév: {f7.Nev}\n" +
    (string.IsNullOrWhiteSpace(f7.Egyesulet) ? string.Empty : $"\tEgyesület: {f7.Egyesulet}\n") +
    $"\tIdő: {f7.Ido}");
    