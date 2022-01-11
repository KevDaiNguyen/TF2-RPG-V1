using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DemomanData : MonoBehaviour
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
        className = "Demoman";
        baseHealth = 175;
        baseSpeed = 93;
        baseDodgeChance = 0;
        baseMovementCount = 1;
        primary = new Sprite[weaponInstance.demomanPrimaries.Length];
        secondary = new Sprite[weaponInstance.demomanSecondaries.Length];
        melee = new Sprite[weaponInstance.demomanMelees.Length];
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
        for (int i = 0; i < weaponInstance.demomanPrimaries.Length; i++)
        {
            primary[i] = weaponInstance.demomanPrimaries[i];
        }
    }

    public void FillSecondary()
    {
        for (int i = 0; i < weaponInstance.demomanSecondaries.Length; i++)
        {
            secondary[i] = weaponInstance.demomanSecondaries[i];
        }
    }

    public void FillMelee()
    {
        for (int i = 0; i < weaponInstance.demomanMelees.Length; i++)
        {
            melee[i] = weaponInstance.demomanMelees[i];
        }
    }
}
