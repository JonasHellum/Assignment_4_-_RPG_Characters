namespace Assignment_4___RPG_Characters.Classes;

public class Wizard : Classes
{
    public Wizard(String name) : base(name)
    {
        description = "A powerful spellcaster";
        attack = "Water boulder";
        attackDamage = "11";
        affixes = "slows the target";
    }
    
    public override string ToString()
    {
        return "Wizard";
    }
    
}