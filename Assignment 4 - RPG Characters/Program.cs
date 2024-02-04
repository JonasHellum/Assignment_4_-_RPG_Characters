using Assignment_4___RPG_Characters.Classes;
using Assignment_4___RPG_Characters.Weapons;

namespace Assignment_4___RPG_Characters;

class Program
{
    static void Main(string[] args)
    {
        Classes.Classes fighter = new Fighter("Gonk");
        Weapons.Weapons staff = new Staff();
        fighter.Attack();
        
        
        fighter.EquipWeapon(staff);
        fighter.Attack();
        
        
        Classes.Classes ranger = new Ranger("Legolas");
        Weapons.Weapons bow = new Bow();
        ranger.EquipWeapon(bow);
        ranger.Attack();
        

        Random rnd = new Random();

        List<Classes.Classes> randomClasses = [];
        randomClasses.Add(new Fighter("Hunk"));
        randomClasses.Add(new Ranger("Robin Hood"));
        randomClasses.Add(new Rogue("Dumblo"));
        randomClasses.Add(new Wizard("Dumbledore"));
        int randomClassesIndex = rnd.Next(randomClasses.Count);
        
        List<Weapons.Weapons> randomWeapons = [];
        randomWeapons.Add(null);
        randomWeapons.Add(new Bow());
        randomWeapons.Add(new Dagger());
        randomWeapons.Add(new Staff());
        randomWeapons.Add(new Wand());
        randomWeapons.Add(new Sword());
        int randomWeaponsIndex = rnd.Next(randomWeapons.Count);
        
        
        Classes.Classes randomClass = randomClasses[randomClassesIndex];
        Weapons.Weapons randomWeapon = randomWeapons[randomWeaponsIndex];
        randomClass.EquipWeapon(randomWeapon);
        randomClass.Attack();

    }
}