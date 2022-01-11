using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PyroData : MonoBehaviour
{
    public ListOfClassWeapons weaponInstance;
    public Sprite[] primary;
    public Sprite[] secondary;
    public Sprite[] melee;

    public int baseHealth;
    public int baseSpeed;
    public int baseDodgeChance;
    public int baseMovementCount;

    public string className;

    // Start is called before the first frame update
    void Start()
    {
        className = "Pyro";
        baseHealth = 175;
        baseSpeed = 100;
        baseDodgeChance = 0;
        baseMovementCount = 1;
        primary = new Sprite[weaponInstance.pyroPrimaries.Length];
        secondary = new Sprite[weaponInstance.pyroSecondaries.Length];
        melee = new Sprite[weaponInstance.pyroMelees.Length];
        FillPrimary();
        FillSecondary();
        FillMelee();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void FillPrimary()
    {
        for (int i = 0; i < weaponInstance.pyroPrimaries.Length; i++)
        {
            primary[i] = weaponInstance.pyroPrimaries[i];
        }
    }

    public void FillSecondary()
    {
        for (int i = 0; i < weaponInstance.pyroSecondaries.Length; i++)
        {
            secondary[i] = weaponInstance.pyroSecondaries[i];
        }
    }

    public void FillMelee()
    {
        for (int i = 0; i < weaponInstance.pyroMelees.Length; i++)
        {
            melee[i] = weaponInstance.pyroMelees[i];
        }
    }
}
