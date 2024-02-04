namespace Assignment_4___RPG_Characters.Weapons;

public class Bow : Weapons
{
    public Bow()
    {
        attackDescription = "A bow imbued with the power of fire, shoots a powerful arrow.";
        attackMessage = "Super shot";
        affixes = "burns the target";
        attackDamage = "7";
    }
    
    public override string ToString()
    {
        return "Bow";
    }
}