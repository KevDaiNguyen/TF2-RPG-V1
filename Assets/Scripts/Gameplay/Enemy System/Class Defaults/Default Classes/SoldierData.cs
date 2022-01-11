using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoldierData : MonoBehaviour
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
        className = "Soldier";
        baseHealth = 200;
        baseSpeed = 80;
        baseDodgeChance = 0;
        baseMovementCount = 1;
        primary = new Sprite[weaponInstance.soldierPrimaries.Length];
        secondary = new Sprite[weaponInstance.soldierSecondaries.Length];
        melee = new Sprite[weaponInstance.soldierMelees.Length];
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
        for (int i = 0; i < weaponInstance.soldierPrimaries.Length; i++)
        {
            primary[i] = weaponInstance.soldierPrimaries[i];
        }
    }

    public void FillSecondary()
    {
        for (int i = 0; i < weaponInstance.soldierSecondaries.Length; i++)
        {
            secondary[i] = weaponInstance.soldierSecondaries[i];
        }
    }

    public void FillMelee()
    {
        for (int i = 0; i < weaponInstance.soldierMelees.Length; i++)
        {
            melee[i] = weaponInstance.soldierMelees[i];
        }
    }
}
