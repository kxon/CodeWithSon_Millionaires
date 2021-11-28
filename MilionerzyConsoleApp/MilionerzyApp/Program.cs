// See https://aka.ms/new-console-template for more information
Console.WriteLine("Witamy w grze Milionerzy");
Console.Write("Wpisz swoje imię:");
string? imie = Console.ReadLine();
Console.WriteLine("Cześć " + imie);



Console.WriteLine("Pytanie 1:");
Console.WriteLine("Ile to jest 90 * 50");
Console.WriteLine("A) 45 000 B) 4 500");
Console.WriteLine("C) 5 000 D) 450");
Console.Write("Wybieram odpowiedz: ");

var odpowiedz1 = Console.ReadKey().Key.ToString();
Console.WriteLine();

if (odpowiedz1 != "B")
{
    Console.WriteLine("Przegrałeś masz 0$");
    return;
}
Console.WriteLine("");
Console.WriteLine("BRAWO " + imie + ", poprwawan odpowiedz, masz 500 $ i awansujesz do kolejnej rundy");
//------------------------------------------------------------------------------------------------
Console.WriteLine("Pytanie 2:");
Console.WriteLine("W jakim mieście odbędą się zimowe igrzyska olimpijskie 2022");
Console.WriteLine("A) Sochi B) Paryż");
Console.WriteLine("C) Pekin D) Tokio");
Console.Write("Wybieram odpowiedz: ");

var odpowiedz2 = Console.ReadKey().Key.ToString();
Console.WriteLine();

if (odpowiedz2 != "C")
{
    Console.WriteLine("Przegrałeś masz 500$");
    return;
}
Console.WriteLine("");
Console.WriteLine("BRAWO " + imie + ", poprwawan odpowiedz, masz 1 000 $ i awansujesz do kolejnej rundy");
//------------------------------------------------------------------------------------------------
Console.WriteLine("Pytanie 3:");
Console.WriteLine("jaki jest najwieksz ocean na swiecie");
Console.WriteLine("A) indyjski B) atlantycki");
Console.WriteLine("C) arktyczny D) spokojny");
Console.Write("Wybieram odpowiedz: ");

var odpowiedz3 = Console.ReadKey().Key.ToString();
Console.WriteLine();

if (odpowiedz3 != "D")
{
    Console.WriteLine("Przegrałeś masz 1 000$");
    return;
}
Console.WriteLine("");
Console.WriteLine("BRAWO " + imie + ", poprwawan odpowiedz, masz 2 000 $ i awansujesz do kolejnej rundy");

//------------------------------------------------------------------------------------------------
Console.WriteLine("Pytanie 4:");
Console.WriteLine("jaki jest najwieksz kraj na swiecie");
Console.WriteLine("A) Rosja B) Kanada");
Console.WriteLine("C) USA D) Australia");
Console.Write("Wybieram odpowiedz: ");

var odpowiedz4 = Console.ReadKey().Key.ToString();
Console.WriteLine();

if (odpowiedz4 != "A")
{
    Console.WriteLine("Przegrałeś masz 2 000$");
    return;
}
Console.WriteLine("");
Console.WriteLine("BRAWO " + imie + ", poprwawan odpowiedz, masz 5 000 $ i awansujesz do kolejnej rundy");
//------------------------------------------------------------------------------------------------
Console.WriteLine("Pytanie 5:");
Console.WriteLine("jaka jest stolica USA ");
Console.WriteLine("A) Waszynkton B) New York");
Console.WriteLine("C) Los Angeles D) Moskwa");
Console.Write("Wybieram odpowiedz: ");

var odpowiedz5 = Console.ReadKey().Key.ToString();
Console.WriteLine();

if (odpowiedz5 != "A")
{
    Console.WriteLine("Przegrałeś masz  5 000$");
    return;
}
Console.WriteLine("");
Console.WriteLine("BRAWO " + imie + ", poprwawan odpowiedz, masz 10 000 $ i awansujesz do kolejnej rundy");
//------------------------------------------------------------------------------------------------
Console.WriteLine("Pytanie 6:");
Console.WriteLine("jaka jest stolica Rosji ");
Console.WriteLine("A) Rostov B) New York");
Console.WriteLine("C) Petersburg D) Moskwa");
Console.Write("Wybieram odpowiedz: ");

var odpowiedz6 = Console.ReadKey().Key.ToString();
Console.WriteLine();

if (odpowiedz6 != "D")
{
    Console.WriteLine("Przegrałeś masz 10 000$");
    return;
}
Console.WriteLine("");
Console.WriteLine("BRAWO " + imie + ", poprwawan odpowiedz, masz 20 000 $ i awansujesz do kolejnej rundy");
//------------------------------------------------------------------------------------------------
Console.WriteLine("Pytanie 7:");
Console.WriteLine("jaka jest najdluzsza rzeka Swiata ");
Console.WriteLine("A) Nil B)  Amazonka");
Console.WriteLine("C) Ren D) Dunaj");
Console.Write("Wybieram odpowiedz: ");

var odpowiedz7 = Console.ReadKey().Key.ToString();
Console.WriteLine();

if (odpowiedz7 != "A")
{
    Console.WriteLine("Przegrałeś masz 20 000$");
    return;
}
Console.WriteLine("");
Console.WriteLine("BRAWO " + imie + ", poprwawan odpowiedz, masz 40 000 $ i awansujesz do kolejnej rundy");
//------------------------------------------------------------------------------------------------
Console.WriteLine("Pytanie 8:");
Console.WriteLine("jaki jest najdludniejszy kraj Swiata ");
Console.WriteLine("A) USA B)  Chiny");
Console.WriteLine("C) indie D) Rosja");
Console.Write("Wybieram odpowiedz: ");

var odpowiedz8 = Console.ReadKey().Key.ToString();
Console.WriteLine();

if (odpowiedz8 != "B")
{
    Console.WriteLine("Przegrałeś masz 40 000");
    return;
}
Console.WriteLine("");
Console.WriteLine("BRAWO " + imie + ", poprwawan odpowiedz, masz 75 000 $ i awansujesz do kolejnej rundy");
//------------------------------------------------------------------------------------------------
Console.WriteLine("Pytanie 9:");
Console.WriteLine("jaka jest stolica  słowacji ");
Console.WriteLine("A) Poprad B) Monachium");
Console.WriteLine("C) Bratysława D) Praga");
Console.Write("Wybieram odpowiedz: ");

var odpowiedz9 = Console.ReadKey().Key.ToString();
Console.WriteLine();

if (odpowiedz9 != "C")
{
    Console.WriteLine("Przegrałeś masz 75 000$");
    return;
}
Console.WriteLine("");
Console.WriteLine("BRAWO " + imie + ", poprwawan odpowiedz, masz 125 000 $ i awansujesz do kolejnej rundy");
//------------------------------------------------------------------------------------------------
Console.WriteLine("Pytanie 10:");
Console.WriteLine("Ile trwala druga wojna swiatowa ");
Console.WriteLine("A) 6 lat B) 4 lata");
Console.WriteLine("C) 10 lat D) 7 lat");
Console.Write("Wybieram odpowiedz: ");

var odpowiedz10 = Console.ReadKey().Key.ToString();
Console.WriteLine();

if (odpowiedz10 != "A")
{
    Console.WriteLine("Przegrałeś masz 125 000$");
    return;
}
Console.WriteLine("");
Console.WriteLine("BRAWO " + imie + ", poprwawan odpowiedz, masz 250 000 $ i awansujesz do kolejnej rundy");
//------------------------------------------------------------------------------------------------
Console.WriteLine("Pytanie 11:");
Console.WriteLine("Ile trwala pierwsza wojna swiatowa ");
Console.WriteLine("A) 6 lat B) 4 lata");
Console.WriteLine("C) 10 lat D) 7 lat");
Console.Write("Wybieram odpowiedz: ");

var odpowiedz11 = Console.ReadKey().Key.ToString();
Console.WriteLine();

if (odpowiedz11 != "B")
{
    Console.WriteLine("Przegrałeś masz 250 000$");
    return;
}
Console.WriteLine("");
Console.WriteLine("BRAWO " + imie + ", poprwawan odpowiedz, masz 500 000 $ i awansujesz do kolejnej rundy");
//------------------------------------------------------------------------------------------------
Console.WriteLine("Pytanie 11:");
Console.WriteLine("Jaka jest stolic Syri ");
Console.WriteLine("A) Madryt  B) Kaszpad");
Console.WriteLine("C) Domaszk D) Palestyna");
Console.Write("Wybieram odpowiedz: ");

var odpowiedz12 = Console.ReadKey().Key.ToString();
Console.WriteLine();

if (odpowiedz12 != "C")
{
    Console.WriteLine("Przegrałeś masz 500 000$");
    return;
}
Console.WriteLine("");
Console.WriteLine("BRAWO " + imie + ", poprwawan odpowiedz, masz  500 000 $ i awansujesz do finalu");
//------------------------------------------------------------------------------------------------
Console.WriteLine("Pytanie 11:");
Console.WriteLine("ile trwala wojna secesyjna ");
Console.WriteLine("A) 10 lata B)6 lat");
Console.WriteLine("C) 4 lata D)3 lata");
Console.Write("Wybieram odpowiedz: ");

var odpowiedz13 = Console.ReadKey().Key.ToString();
Console.WriteLine();

if (odpowiedz13 != "C")
{
    Console.WriteLine("Przegrałeś masz 500 000$");
    return;
}
Console.WriteLine("");
Console.WriteLine("BRAWO " + imie + ", poprwawan odpowiedz, masz  1 000 000 $ i WYGRYWASZ TELETURNIEJ Milionerzy");