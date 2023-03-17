using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character
{
    public string name;
    public int exp = 0;

    public Character()
    {
        name = "unnamed";
    }

    public Character(string name)
    {
        this.name = name;
    }

    public virtual void PrintStatsInfo()
    {
        Character hero = new Character("HERO");
        Character heroine = new Character("HEROINE");

        Debug.LogFormat("Name: {0}, Age: {1}", hero.name, hero.exp);
        Debug.LogFormat("Name: {0}, Age: {1}", heroine.name, heroine.exp);
    }
}

public class Paladin : Character
{
    public Weapon weapon;

    public Paladin(string name, Weapon weapon) : base(name)
    {
        this.weapon = weapon;
    }

    public override void PrintStatsInfo()
    {
        Paladin knight = new Paladin("Knight", this.weapon);
        Debug.LogFormat("Hail {0} - take up your {1}!", knight.name, knight.weapon.name);
    }
}

public struct Weapon
{
    public string name;
    public int damage;

    public Weapon(string name, int damage)
    {
        this.name = name;
        this.damage = damage;
    }

    void WeapCreator()
    {
        Weapon huntingBow = new Weapon("huntingBow", 5);
        Weapon warBow = new Weapon("warBow", 10);
        Debug.LogFormat("Weapon: {0} - {1} DMG", warBow.name, warBow.damage);
        Debug.LogFormat("Weapon: {0} - {1} DMG", huntingBow.name, huntingBow.damage);
    }
}

