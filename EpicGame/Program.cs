//string[] heroes = { "Harry Potter", "Luke Skywalker", "Bella", "Scooby-doo" };
//string[] villains = { "Voldemort", "Darth Vader", "Dracula", "Joker", "Sauron" };

string folderPath = "\Users\elinkass\Downloads\";

string heroFile = "hereos.txt";
string villainFile = "villains.txt";


string[] heroes = File.ReadAllLines(Path.Combine(folderPath, heroFile));
string[] villains = File.ReadAllLines(Path.Combine(folderPath, villainFile));


string[] weapon = { "Magic wand", "Plastic fork", "Banana", "wooden sword", "Lego brick" };



string hero = GetRandomValueFromArray(heroes);
string heroWeapon = GetRandomValueFromArray(weapon);
Console.WriteLine($"Today {hero} with {heroWeapon} saves the day!");


string villain = GetRandomValueFromArray(villains);
string villainweapon = GetRandomValueFromArray(weapon);
Console.WriteLine($"Today {villain} with {villainweapon} tries to take over the world!");

static string GetRandomValueFromArray(string[] someArray)
{
    Random rnd = new Random();
    int randomIndex = rnd.Next(0, someArray.Length);
    string randomStringFromArray = someArray[randomIndex];
    return randomStringFromArray;
}

