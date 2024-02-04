namespace Assignment_4___RPG_Characters.Weapons;

public class Staff : Weapons
{
    public Staff()
    {
        attackDescription = "A big bulky staff, used to conjure powerful spells. Could be used to hit the target with as well";
        attackMessage = "Staff strike";
        affixes = "confused the target";
        attackDamage = "10";
    }
    
    public override string ToString()
    {
        return "Staff";
    }
}