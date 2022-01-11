using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MedicData : MonoBehaviour
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
        className = "Medic";
        baseHealth = 150;
        baseSpeed = 107;
        baseDodgeChance = 0;
        baseMovementCount = 1;
        primary = new Sprite[weaponInstance.medicPrimaries.Length];
        secondary = new Sprite[weaponInstance.medicSecondaries.Length];
        melee = new Sprite[weaponInstance.medicMelees.Length];
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
        for (int i = 0; i < weaponInstance.medicPrimaries.Length; i++)
        {
            primary[i] = weaponInstance.medicPrimaries[i];
        }
    }

    public void FillSecondary()
    {
        for (int i = 0; i < weaponInstance.medicSecondaries.Length; i++)
        {
            secondary[i] = weaponInstance.medicSecondaries[i];
        }
    }

    public void FillMelee()
    {
        for (int i = 0; i < weaponInstance.medicMelees.Length; i++)
        {
            melee[i] = weaponInstance.medicMelees[i];
        }
    }
}
