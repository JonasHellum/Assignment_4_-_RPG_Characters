using System.Runtime.InteropServices.JavaScript;

namespace Assignment_4___RPG_Characters.Classes;

public class Fighter : Classes
{
    public Fighter(String name) : base(name)
    {
        description = "Has big muscles.";
        attack = "Smash";
        attackDamage = "15";
        affixes = "scares the target";
    }

    public override string ToString()
    {
        return "Fighter";
    }

}