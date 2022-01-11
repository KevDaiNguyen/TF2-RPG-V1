using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SniperWepStats : MonoBehaviour
{
    public ListOfClassWeapons wepIstances;
    public int chargeTime;

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
        wepDescription1 = "Sniper";
        wepDescription2 = "Sniper";
        wepDescription3 = "Sniper";
        ammoInMag = 0;
        ammoInReserve = 0;
        totalAmmo = ammoInMag + ammoInReserve;
        chargeTime = 0;
    }

    //**********************************************************************************************************************************
    //PRIMARY WEAPONS
    //**********************************************************************************************************************************

    public void SniperRifle()
    {
        currentSprite = wepIstances.sniperPrimaries[0];
        ammoInMag = 25;
        ammoInReserve = 25;
    }
    public void Huntsman()
    {
        currentSprite = wepIstances.sniperPrimaries[4];
        ammoInMag = 1;
        ammoInReserve = 12;
    }
    public void SydneySleeper()
    {
        currentSprite = wepIstances.sniperPrimaries[1];
        ammoInMag = 25;
        ammoInReserve = 25;
    }
    public void BazaarBargain()
    {
        currentSprite = wepIstances.sniperPrimaries[6];
        ammoInMag = 25;
        ammoInReserve = 25;
    }
    public void Machina()
    {
        currentSprite = wepIstances.sniperPrimaries[2];
        ammoInMag = 25;
        ammoInReserve = 25;
    }
    public void HitmansHeatmaker()
    {
        currentSprite = wepIstances.sniperPrimaries[3];
        ammoInMag = 25;
        ammoInReserve = 25;
    }
    public void Classic()
    {
        currentSprite = wepIstances.sniperPrimaries[5];
        ammoInMag = 25;
        ammoInReserve = 25;
    }

    //**********************************************************************************************************************************
    //SECONDARY WEAPONS
    //**********************************************************************************************************************************

    public void SMG()
    {
        currentSprite = wepIstances.sniperSecondaries[0];
        ammoInMag = 25;
        ammoInReserve = 75;
    }
    public void Jarate()
    {
        currentSprite = wepIstances.sniperSecondaries[3];
        ammoInMag = 100;
        ammoInReserve = 100;
    }
    public void Razorback()
    {
        currentSprite = wepIstances.sniperSecondaries[2];
        ammoInMag = 1;
        ammoInReserve = 1;
    }
    public void DarwinsDangerShield()
    {
        currentSprite = wepIstances.sniperSecondaries[4];
        ammoInMag = 0;
        ammoInReserve = 0;
    }
    public void CozyCamper()
    {
        currentSprite = wepIstances.sniperSecondaries[1];
        ammoInMag = 0;
        ammoInReserve = 0;
    }
    public void CleanersCarbine()
    {
        currentSprite = wepIstances.sniperSecondaries[5];
        ammoInMag = 20;
        ammoInReserve = 75;
    }

    //**********************************************************************************************************************************
    //MELEE WEAPONS
    //**********************************************************************************************************************************
    public void Kukuri()
    {
        currentSprite = wepIstances.sniperMelees[0];
    }
    public void TribalmansShiv()
    {
        currentSprite = wepIstances.sniperMelees[1];
    }
    public void Bushwacka()
    {
        currentSprite = wepIstances.sniperMelees[3];
    }
    public void Shahanshah()
    {
        currentSprite = wepIstances.sniperMelees[2];
    }
}
