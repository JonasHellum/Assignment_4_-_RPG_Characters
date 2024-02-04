using System.Runtime.InteropServices.JavaScript;

namespace Assignment_4___RPG_Characters.Classes;

public class Classes
{
    private String name;
    protected String description;
    protected String attack;
    protected String attackDamage;
    protected String affixes;
    protected Weapons.Weapons weapon;
    

    public Classes(String name)
    {
        this.name = name;
    }

    public String GetName()
    {
        return name;
    }

    public String GetDescription()
    {
        return description;
    }
    
    
    public void EquipWeapon(Weapons.Weapons weapon)
    {
        this.weapon = weapon;
    }
    

    public void Attack()
    {
        if (weapon != null)
        {
            Console.WriteLine($"You are a {ToString()} named {name} equiped with a {weapon.ToString()}");
            weapon.Use();
        }
        else
        {
            Console.WriteLine($"You are a {ToString()} named {name} equiped with nothing");
            Console.WriteLine($"You used {attack} which did {attackDamage} damage + {affixes}\n");
        }
    }

}