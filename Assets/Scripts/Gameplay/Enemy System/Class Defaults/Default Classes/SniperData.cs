using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SniperData : MonoBehaviour
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
        className = "Sniper";
        baseHealth = 125;
        baseSpeed = 100;
        baseDodgeChance = 0;
        baseMovementCount = 1;
        primary = new Sprite[weaponInstance.sniperPrimaries.Length];
        secondary = new Sprite[weaponInstance.sniperSecondaries.Length];
        melee = new Sprite[weaponInstance.sniperMelees.Length];
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
        for (int i = 0; i < weaponInstance.sniperPrimaries.Length; i++)
        {
            primary[i] = weaponInstance.sniperPrimaries[i];
        }
    }

    public void FillSecondary()
    {
        for (int i = 0; i < weaponInstance.sniperSecondaries.Length; i++)
        {
            secondary[i] = weaponInstance.sniperSecondaries[i];
        }
    }

    public void FillMelee()
    {
        for (int i = 0; i < weaponInstance.sniperMelees.Length; i++)
        {
            melee[i] = weaponInstance.sniperMelees[i];
        }
    }
}
