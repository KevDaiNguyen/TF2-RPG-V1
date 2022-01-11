using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpyWepStats : MonoBehaviour
{
    public ListOfClassWeapons wepIstances;
    public int cloakPercent;

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
        wepDescription1 = "Spy";
        wepDescription2 = "Spy";
        wepDescription3 = "Spy";
        ammoInMag = 0;
        ammoInReserve = 0;
        totalAmmo = ammoInMag + ammoInReserve;
        cloakPercent = 0;
    }

    //**********************************************************************************************************************************
    //PRIMARY WEAPONS
    //**********************************************************************************************************************************

    public void Revolver()
    {
        currentSprite = wepIstances.spyPrimaries[0];
        ammoInMag = 6;
        ammoInReserve = 24;
    }
    public void Ambassador()
    {
        currentSprite = wepIstances.spyPrimaries[4];
        ammoInMag = 6;
        ammoInReserve = 24;
    }
    public void LEtranger()
    {
        currentSprite = wepIstances.spyPrimaries[1];
        ammoInMag = 6;
        ammoInReserve = 24;
    }
    public void Enforcer()
    {
        currentSprite = wepIstances.spyPrimaries[2];
        ammoInMag = 6;
        ammoInReserve = 24;
    }
    public void Diamondback()
    {
        currentSprite = wepIstances.spyPrimaries[3];
        ammoInMag = 6;
        ammoInReserve = 24;
    }

    //**********************************************************************************************************************************
    //SECONDARY WEAPONS
    //**********************************************************************************************************************************

    public void Sapper()
    {
        currentSprite = wepIstances.spySecondaries[0];
        ammoInMag = 1;
        ammoInReserve = 1;
    }
    public void RedTapeRecorder()
    {
        currentSprite = wepIstances.spySecondaries[1];
        ammoInMag = 1;
        ammoInReserve = 1;
    }


    //**********************************************************************************************************************************
    //MELEE WEAPONS
    //**********************************************************************************************************************************

    public void Knife()
    {
        currentSprite = wepIstances.spyMelees[0];
    }
    public void YourEternalReward()
    {
        currentSprite = wepIstances.spyMelees[2];
    }
    public void ConniversKunai()
    {
        currentSprite = wepIstances.spyMelees[3];
    }
    public void BigEarner()
    {
        currentSprite = wepIstances.spyMelees[4];
    }
    public void Spycicle()
    {
        currentSprite = wepIstances.spyMelees[1];
        ammoInMag = 1;
        ammoInReserve = 1;
    }
    //**********************************************************************************************************************************
    //WATCHES
    //**********************************************************************************************************************************

    public void InvisWatch()
    {
        currentSprite = wepIstances.spyWatches[0];
    }
    public void CloackAndDagger()
    {
        currentSprite = wepIstances.spyWatches[2];
    }
    public void DeadRinger()
    {
        currentSprite = wepIstances.spyWatches[1];
    }
}
