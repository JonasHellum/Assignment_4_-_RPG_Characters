namespace Assignment_4___RPG_Characters.Classes;

public class Rogue : Classes
{
    public Rogue(String name) : base(name)
    {
        description = "A stealthy and agile character.";
        attack = "Backstab partymember";
        attackDamage = "7";
        affixes = "makes you hostile to your party members, RUN";
    }
    
    public override string ToString()
    {
        return "Rogue";
    }
    
}