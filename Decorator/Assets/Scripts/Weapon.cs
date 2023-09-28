using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : IWeapon
{
    //This class does not implement any behaviors; it's 
    //  just a representation of the configurable properties
    //  of a weapon.
    public float Range
    {
        get { return _config.Range; }
    }

    public float Rate
    {
        get { return _config.Rate; }
    }

    public float Strength
    {
        get { return _config.Strength;  }
    }

    public float Cooldown
    {
        get { return _config.Cooldown; }
    }

    private readonly WeaponConfig _config; 

    public Weapon(WeaponConfig weaponConfig)
    {
        _config = weaponConfig; 
    }
}
