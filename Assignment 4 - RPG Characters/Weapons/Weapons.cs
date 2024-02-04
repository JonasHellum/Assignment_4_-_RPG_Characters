using System.Runtime.InteropServices.JavaScript;

namespace Assignment_4___RPG_Characters.Weapons;

public class Weapons
{
    protected String attackDescription;
    protected String attackMessage;
    protected String affixes;
    protected String attackDamage;
    

    public String GetAttackDescription()
    {
        return attackDescription;
    }

    public String GetAttackMessage()
    {
        return attackMessage;
    }
    
    public String GetAffixes()
    {
        return affixes;
    }

    public String getAttackDamage()
    {
        return attackDamage;
    }
    
    private String Attack()
    {
        return $"You used {attackMessage} which did {attackDamage} damage + {affixes}";
    }

    public void Use()
    {
        Console.WriteLine(Attack());
    }
}