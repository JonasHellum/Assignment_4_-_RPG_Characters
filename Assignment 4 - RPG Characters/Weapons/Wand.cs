namespace Assignment_4___RPG_Characters.Weapons;

public class Wand : Weapons
{
    public Wand()
    {
        attackDescription = "shoots out a small lightning ball";
        attackMessage = "wand shot";
        affixes = "stuns the target";
        attackDamage = "4";
    }
    
    public override string ToString()
    {
        return "Wand";
    }
}