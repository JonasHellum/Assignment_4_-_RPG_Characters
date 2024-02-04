namespace Assignment_4___RPG_Characters.Classes;

public class Wizard : Classes
{
    public Wizard(String name) : base(name)
    {
        description = "A powerful spellcaster";
        attack = "Fire boulder";
        attackDamage = "11";
        affixes = "burns the target";
    }
    
    public override string ToString()
    {
        return "Wizard";
    }
    
}