using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeavyData : MonoBehaviour
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
        className = "Heavy";
        baseHealth = 300;
        baseSpeed = 77;
        baseDodgeChance = 0;
        baseMovementCount = 1;
        primary = new Sprite[weaponInstance.heavyPrimaries.Length];
        secondary = new Sprite[weaponInstance.heavySecondaries.Length];
        melee = new Sprite[weaponInstance.heavyMelees.Length];
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
        for (int i = 0; i < weaponInstance.heavyPrimaries.Length; i++)
        {
            primary[i] = weaponInstance.heavyPrimaries[i];
        }
    }

    public void FillSecondary()
    {
        for (int i = 0; i < weaponInstance.heavySecondaries.Length; i++)
        {
            secondary[i] = weaponInstance.heavySecondaries[i];
        }
    }

    public void FillMelee()
    {
        for (int i = 0; i < weaponInstance.heavyMelees.Length; i++)
        {
            melee[i] = weaponInstance.heavyMelees[i];
        }
    }
}
