//string[] heros = { "Harry Potter", "Luke Skywalker", "Lara Croft", "Scooby-Doo" };
//string[] villains = { "voldemort", "Joker", "Thanos", "Sauron", "Dracula" };

string folderPath = @"C:\Users\Admin\Documents\data\";
string heroFile = "heros.txt";
string villainFile = "villains.txt";

string[] heros = File.ReadAllLines(Path.Combine(folderPath, heroFile));
string[] villains = File.ReadAllLines(Path.Combine(folderPath, villainFile));

string[] weapons = { "magic wand", "plastic spoon", "apple", "knife" };

string hero = GetRandomValueFromArray(heros);
string heroWeapon = GetRandomValueFromArray(weapons);
Console.WriteLine($"Today {heros} saves the day! With a {heroWeapon}");

string villan = GetRandomValueFromArray(villains);
string villanWeapon = GetRandomValueFromArray(weapons); 
Console.WriteLine($"Today {villan} tries to ruin the day! With a {villanWeapon}");
     
static string GetRandomValueFromArray(string[] someArray)
{
    Random rnd = new Random();
    int randomIndex = rnd.Next(0, someArray.Length);
    string randomStringFromArray = someArray[randomIndex];
    return randomStringFromArray;
}