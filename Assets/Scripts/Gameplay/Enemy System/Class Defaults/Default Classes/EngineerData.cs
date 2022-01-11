using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EngineerData : MonoBehaviour
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
        className = "Engineer";
        baseHealth = 125;
        baseSpeed = 100;
        baseDodgeChance = 0;
        baseMovementCount = 1;
        primary = new Sprite[weaponInstance.engineerPrimaries.Length];
        secondary = new Sprite[weaponInstance.engineerSecondaries.Length];
        melee = new Sprite[weaponInstance.engineerMelees.Length];
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
        for (int i = 0; i < weaponInstance.engineerPrimaries.Length; i++)
        {
            primary[i] = weaponInstance.engineerPrimaries[i];
        }
    }

    public void FillSecondary()
    {
        for (int i = 0; i < weaponInstance.engineerSecondaries.Length; i++)
        {
            secondary[i] = weaponInstance.engineerSecondaries[i];
        }
    }

    public void FillMelee()
    {
        for (int i = 0; i < weaponInstance.engineerMelees.Length; i++)
        {
            melee[i] = weaponInstance.engineerMelees[i];
        }
    }
}
