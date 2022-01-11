using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EngiWepStats : MonoBehaviour
{
    public ListOfClassWeapons wepIstances;
    public int totalMetal;
    public int metalCost;

    public Sprite currentSprite;

    public int numOfActions;

    public int turnCoolDown;
    public int reloadSpeed;

    public int timeCost1;
    public int timeCost2;
    public int timeCost3;

    public bool rightPosition;
    public bool rightEnemyPosition;

    public string wepDescription1;
    public string wepDescription2;
    public string wepDescription3;

    public int ammoInMag;
    public int ammoInReserve;
    public int totalAmmo;

    // Start is called before the first frame update
    void Start()
    {
        numOfActions = 1;
        turnCoolDown = 0;
        reloadSpeed = 1;
        timeCost1 = 1;
        timeCost2 = 1;
        timeCost3 = 1;
        rightPosition = false;
        rightEnemyPosition = false;
        wepDescription1 = "Engi";
        wepDescription2 = "Engi";
        wepDescription3 = "Engi";
        ammoInMag = 0;
        ammoInReserve = 0;
        totalAmmo = ammoInMag + ammoInReserve;
        totalMetal = 200;
    }

    //**********************************************************************************************************************************
    //PRIMARY WEAPONS
    //**********************************************************************************************************************************

    public void Shotgun()
    {
        currentSprite = wepIstances.engineerPrimaries[0];
        ammoInMag = 6;
        ammoInReserve = 32;
    }
    public void FrontierJustice()
    {
        currentSprite = wepIstances.engineerPrimaries[4];
        ammoInMag = 3;
        ammoInReserve = 32;
    }
    public void Widowmaker()
    {
        currentSprite = wepIstances.engineerPrimaries[1];
        ammoInMag = 200;
        ammoInReserve = 200;
    }
    public void Pomson6000()
    {
        currentSprite = wepIstances.engineerPrimaries[3];
        ammoInMag = 4;
        ammoInReserve = 4;
    }
    public void RescueRanger()
    {
        currentSprite = wepIstances.engineerPrimaries[2];
        ammoInMag = 4;
        ammoInReserve = 16;
    }
    public void PanicAttack()
    {
        currentSprite = wepIstances.engineerPrimaries[5];
        ammoInMag = 6;
        ammoInReserve = 32;
    }

    //**********************************************************************************************************************************
    //SECONDARY WEAPONS
    //**********************************************************************************************************************************

    public void Pistol()
    {
        currentSprite = wepIstances.engineerSecondaries[0];
        ammoInMag = 12;
        ammoInReserve = 200;
    }
    public void Wrangler()
    {
        currentSprite = wepIstances.engineerSecondaries[1];
        ammoInMag = 0;
        ammoInReserve = 0;
    }
    public void ShortCircuit()
    {
        currentSprite = wepIstances.engineerSecondaries[2];
        ammoInMag = 200;
        ammoInReserve = 200;
    }

    //**********************************************************************************************************************************
    //MELEE WEAPONS
    //**********************************************************************************************************************************

    public void Wrench()
    {
        currentSprite = wepIstances.engineerMelees[0];
    }
    public void Gunslinger()
    {
        currentSprite = wepIstances.engineerMelees[2];
    }
    public void SouthernHospitality()
    {
        currentSprite = wepIstances.engineerMelees[1];
    }
    public void Jag()
    {
        currentSprite = wepIstances.engineerMelees[3];
    }
    public void EurekaEffect()
    {
        currentSprite = wepIstances.engineerMelees[4];
    }
}
