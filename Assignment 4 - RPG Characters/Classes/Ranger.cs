namespace Assignment_4___RPG_Characters.Classes;

public class Ranger : Classes
{
    public Ranger(String name) : base(name)
    {
        description = "Mastery with the bow and friendly with nature.";
        attack = "Eagle attack";
        attackDamage = "4";
        affixes = "curses the target with Curse of the woods";
    }
    
    public override string ToString()
    {
        return "Ranger";
    }
    
}