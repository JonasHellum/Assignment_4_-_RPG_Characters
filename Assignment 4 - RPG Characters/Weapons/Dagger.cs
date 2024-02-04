namespace Assignment_4___RPG_Characters.Weapons;

public class Dagger : Weapons
{
    public Dagger()
    {
        attackDescription = "A small, sharp blade dipped in poison, used for quick and precise attacks.";
        attackMessage = "quick stab";
        affixes = "poisons the target";
        attackDamage = "5";
    }
    
    public override string ToString()
    {
        return "Dagger";
    }
}