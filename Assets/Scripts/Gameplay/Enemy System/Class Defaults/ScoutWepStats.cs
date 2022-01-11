using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoutWepStats : MonoBehaviour
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
        numOfActions = 2;
        turnCoolDown = 0;
        reloadSpeed = 1;
        timeCost1 = 1;
        timeCost2 = 1;
        timeCost3 = 1;
        rightPosition = false;
        rightEnemyPosition = false;
        wepDescription1 = "Scout";
        wepDescription2 = "Scout";
        wepDescription3 = "Scout";
        ammoInMag = 69;
        ammoInReserve = 230;
    }

    private void Update()
    {
        totalAmmo = ammoInMag + ammoInReserve;
    }

    //**********************************************************************************************************************************
    //PRIMARY WEAPONS
    //**********************************************************************************************************************************

    public void Scattergun()
    {
        currentSprite = wepIstances.scoutPrimaries[0];
        ammoInMag = 6;
        ammoInReserve = 32;

        wepDescription1 = "Scout";
        wepDescription2 = "Toes";
        wepDescription3 = "Sucks";

        timeCost1 = 1;
        timeCost2 = 1;
        timeCost3 = 1;
    }

    public void ForceANature()
    {
        currentSprite = wepIstances.scoutPrimaries[3];
        ammoInMag = 2;
        ammoInReserve = 32;
    }

    public void ShortStop()
    {
        currentSprite = wepIstances.scoutPrimaries[1];
        ammoInMag = 4;
        ammoInReserve = 32;
    }

    public void SodaPopper()
    {
        currentSprite = wepIstances.scoutPrimaries[2];
        ammoInMag = 2;
        ammoInReserve = 32;
    }

    public void BabyFacesBlaster()
    {
        currentSprite = wepIstances.scoutPrimaries[5];
        ammoInMag = 4;
        ammoInReserve = 32;
    }

    public void BackScatter()
    {
        currentSprite = wepIstances.scoutPrimaries[4];
        ammoInMag = 4;
        ammoInReserve = 32;
    }

    //**********************************************************************************************************************************
    //SECONDARY WEAPONS
    //**********************************************************************************************************************************

    public void Pistol()
    {
        currentSprite = wepIstances.scoutSecondaries[0];
        ammoInMag = 12;
        ammoInReserve = 36;
    }

    public void BONK()
    {
        currentSprite = wepIstances.scoutSecondaries[3];
        ammoInMag = 100;
        ammoInReserve = 100;
    }

    public void CritACola()
    {
        currentSprite = wepIstances.scoutSecondaries[6];
        ammoInMag = 100;
        ammoInReserve = 100;
    }

    public void MadMilk()
    {
        currentSprite = wepIstances.scoutSecondaries[4];
        ammoInMag = 100;
        ammoInReserve = 100;
    }

    public void Winger()
    {
        currentSprite = wepIstances.scoutSecondaries[1];
        ammoInMag = 5;
        ammoInReserve = 36;
    }

    public void PrettyBoysPocketPistol()
    {
        currentSprite = wepIstances.scoutSecondaries[2];
        ammoInMag = 9;
        ammoInReserve = 36;
    }

    public void FlyingGuillotine()
    {
        currentSprite = wepIstances.scoutSecondaries[5];
        ammoInMag = 100;
        ammoInReserve = 100;
    }

    //**********************************************************************************************************************************
    //MELEE WEAPONS
    //**********************************************************************************************************************************

    public void Bat()
    {
        currentSprite = wepIstances.scoutMelees[0];
    }

    public void Sandman()
    {
        currentSprite = wepIstances.scoutMelees[4];
        ammoInMag = 100;
        ammoInReserve = 100;
    }

    public void CandyCane()
    {
        currentSprite = wepIstances.scoutMelees[5];
    }

    public void BostonBasher()
    {
        currentSprite = wepIstances.scoutMelees[1];
    }

    public void SunOnAStick()
    {
        currentSprite = wepIstances.scoutMelees[3];
    }
    public void FanOWar()
    {
        currentSprite = wepIstances.scoutMelees[7];
    }
    public void Atomizer()
    {
        currentSprite = wepIstances.scoutMelees[6];
    }
    public void WrapAssassin()
    {
        currentSprite = wepIstances.scoutMelees[2];
        ammoInMag = 100;
        ammoInReserve = 100;
    }
}
