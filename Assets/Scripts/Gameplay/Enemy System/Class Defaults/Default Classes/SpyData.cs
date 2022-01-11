using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpyData : MonoBehaviour
{
    public ListOfClassWeapons weaponInstance;
    public Sprite[] primary;
    public Sprite[] secondary;
    public Sprite[] melee;
    public Sprite[] watches;
    public Sprite[] disguises;

    public int baseHealth;
    public int baseSpeed;
    public int baseDodgeChance;
    public int baseMovementCount;

    public string className;

    // Start is called before the first frame update
    void Start()
    {
        className = "Spy";
        baseHealth = 125;
        baseSpeed = 107;
        baseDodgeChance = 0;
        baseMovementCount = 1;
        primary = new Sprite[weaponInstance.spyPrimaries.Length];
        secondary = new Sprite[weaponInstance.spySecondaries.Length];
        melee = new Sprite[weaponInstance.spyMelees.Length];
        disguises = new Sprite[weaponInstance.spyMasks.Length];
        watches = new Sprite[weaponInstance.spyWatches.Length];
        FillPrimary();
        FillSecondary();
        FillMelee();
        FillDisguises();
        FillWatches();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void FillPrimary()
    {
        for (int i = 0; i < weaponInstance.spyPrimaries.Length; i++)
        {
            primary[i] = weaponInstance.spyPrimaries[i];
        }
    }

    public void FillSecondary()
    {
        for (int i = 0; i < weaponInstance.spySecondaries.Length; i++)
        {
            secondary[i] = weaponInstance.spySecondaries[i];
        }
    }

    public void FillMelee()
    {
        for (int i = 0; i < weaponInstance.spySecondaries.Length; i++)
        {
            melee[i] = weaponInstance.scoutMelees[i];
        }
    }

    public void FillWatches()
    {
        for (int i = 0; i < weaponInstance.spyWatches.Length; i++)
        {
            watches[i] = weaponInstance.spyWatches[i];
        }
    }

    public void FillDisguises()
    {
        for (int i = 0; i < weaponInstance.spyMasks.Length; i++)
        {
            disguises[i] = weaponInstance.spyMasks[i];
        }
    }
}
