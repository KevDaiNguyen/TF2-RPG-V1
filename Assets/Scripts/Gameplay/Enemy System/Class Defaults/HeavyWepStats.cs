using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeavyWepStats : MonoBehaviour
{
    public ListOfClassWeapons wepIstances;

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
        timeCost2 = 2;
        timeCost3 = 4;
        rightPosition = false;
        rightEnemyPosition = false;
        wepDescription1 = "Heavy";
        wepDescription2 = "Heavy";
        wepDescription3 = "Heavy";
        ammoInMag = 0;
        ammoInReserve = 0;
        totalAmmo = ammoInMag + ammoInReserve;
    }

    //**********************************************************************************************************************************
    //PRIMARY WEAPONS
    //**********************************************************************************************************************************

    public void Minigun()
    {
        currentSprite = wepIstances.heavyPrimaries[0];
        ammoInMag = 200;
        ammoInReserve = 200;
    }
    public void Natascha()
    {
        currentSprite = wepIstances.heavyPrimaries[3];
        ammoInMag = 200;
        ammoInReserve = 200;
    }
    public void BrassBeast()
    {
        currentSprite = wepIstances.heavyPrimaries[4];
        ammoInMag = 200;
        ammoInReserve = 200;
    }
    public void Tomislav()
    {
        currentSprite = wepIstances.heavyPrimaries[1];
        ammoInMag = 200;
        ammoInReserve = 200;
    }
    public void HuoLongHeater()
    {
        currentSprite = wepIstances.heavyPrimaries[2];
        ammoInMag = 200;
        ammoInReserve = 200;
    }

    //**********************************************************************************************************************************
    //SECONDARY WEAPONS
    //**********************************************************************************************************************************

    public void Shotgun()
    {
        currentSprite = wepIstances.heavySecondaries[0];
        ammoInMag = 6;
        ammoInReserve = 32;
    }
    public void Sandvich()
    {
        currentSprite = wepIstances.heavySecondaries[2];
        ammoInMag = 100;
        ammoInReserve = 100;
    }
    public void DalokohsBar()
    {
        currentSprite = wepIstances.heavySecondaries[3];
        ammoInMag = 100;
        ammoInReserve = 100;
    }
    public void BuffaloSteakSandvich()
    {
        currentSprite = wepIstances.heavySecondaries[6];
        ammoInMag = 100;
        ammoInReserve = 100;
    }
    public void FamilyBusiness()
    {
        currentSprite = wepIstances.heavySecondaries[5];
        ammoInMag = 8;
        ammoInReserve = 32;
    }
    public void PanicAttack()
    {
        currentSprite = wepIstances.heavySecondaries[4];
        ammoInMag = 6;
        ammoInReserve = 32;
    }
    public void SecondBanana()
    {
        currentSprite = wepIstances.heavySecondaries[1];
        ammoInMag = 100;
        ammoInReserve = 100;
    }

    //**********************************************************************************************************************************
    //MELEE WEAPONS
    //**********************************************************************************************************************************

    public void Fists()
    {
        currentSprite = wepIstances.heavyMelees[0];
    }
    public void KillingGlovesOfBoxing()
    {
        currentSprite = wepIstances.heavyMelees[1];
    }
    public void GlovesOfRunningUrgently()
    {
        currentSprite = wepIstances.heavyMelees[4];
    }
    public void WarriorsSpirit()
    {
        currentSprite = wepIstances.heavyMelees[2];
    }
    public void FistsOfSteel()
    {
        currentSprite = wepIstances.heavyMelees[5];
    }
    public void EvictionNotice()
    {
        currentSprite = wepIstances.heavyMelees[6];
    }
    public void HolidayPunch()
    {
        currentSprite = wepIstances.heavyMelees[3];
    }
}
