namespace Assignment_4___RPG_Characters.Weapons;

public class Sword : Weapons
{
    public Sword()
    {
        attackDescription = "A huge two-handed sword, has enough power to slice whatever comes in it's path";
        attackMessage = "cleave";
        affixes = "bleeds the target";
        attackDamage = "9";
    }
    
    public override string ToString()
    {
        return "Sword";
    }
}