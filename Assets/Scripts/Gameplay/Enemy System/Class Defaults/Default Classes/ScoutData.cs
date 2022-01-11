using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoutData : MonoBehaviour
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
        className = "Scout";
        baseHealth = 125;
        baseSpeed = 133;
        baseDodgeChance = 12;
        baseMovementCount = 2;
        primary = new Sprite[weaponInstance.scoutPrimaries.Length];
        secondary = new Sprite[weaponInstance.scoutSecondaries.Length];
        melee = new Sprite[weaponInstance.scoutMelees.Length];
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
        for (int i = 0; i < weaponInstance.scoutPrimaries.Length; i++)
        {
            primary[i] = weaponInstance.scoutPrimaries[i];
        }
    }

    public void FillSecondary()
    {
        for (int i = 0; i < weaponInstance.scoutSecondaries.Length; i++)
        {
            secondary[i] = weaponInstance.scoutSecondaries[i];
        }
    }

    public void FillMelee()
    {
        for (int i = 0; i < weaponInstance.scoutMelees.Length; i++)
        {
            melee[i] = weaponInstance.scoutMelees[i];
        }
    }
}
