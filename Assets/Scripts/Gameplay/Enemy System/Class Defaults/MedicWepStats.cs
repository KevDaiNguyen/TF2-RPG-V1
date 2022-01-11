using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MedicWepStats : MonoBehaviour
{
    public ListOfClassWeapons wepIstances;
    public int uberPercent;

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
        wepDescription1 = "Medic";
        wepDescription2 = "Medic";
        wepDescription3 = "Medic";
        ammoInMag = 8008;
        ammoInReserve = 0;
        totalAmmo = ammoInMag + ammoInReserve;
        uberPercent = 0;
    }

    //**********************************************************************************************************************************
    //PRIMARY WEAPONS
    //**********************************************************************************************************************************

    public void SyringeGun()
    {
        currentSprite = wepIstances.medicPrimaries[0];
        ammoInMag = 40;
        ammoInReserve = 150;
    }
    public void Blutsauger()
    {
        currentSprite = wepIstances.medicPrimaries[1];
        ammoInMag = 40;
        ammoInReserve = 150;
    }
    public void CrusadersCrossbow()
    {
        currentSprite = wepIstances.medicPrimaries[2];
        ammoInMag = 1;
        ammoInReserve = 38;
    }
    public void Overdose()
    {
        currentSprite = wepIstances.medicPrimaries[3];
        ammoInMag = 40;
        ammoInReserve = 150;
    }

    //**********************************************************************************************************************************
    //SECONDARY WEAPONS
    //**********************************************************************************************************************************

    public void Medigun()
    {
        currentSprite = wepIstances.medicSecondaries[0];
        ammoInMag = 0;
        ammoInReserve = 100;
    }
    public void Kritzkrieg()
    {
        currentSprite = wepIstances.medicSecondaries[2];
        ammoInMag = 0;
        ammoInReserve = 100;
    }
    public void QuickFix()
    {
        currentSprite = wepIstances.medicSecondaries[3];
        ammoInMag = 0;
        ammoInReserve = 100;
    }
    public void Vaccinator()
    {
        currentSprite = wepIstances.medicSecondaries[1];
        ammoInMag = 0;
        ammoInReserve = 100;
    }

    //**********************************************************************************************************************************
    //MELEE WEAPONS
    //**********************************************************************************************************************************

    public void Bonesaw()
    {
        currentSprite = wepIstances.medicMelees[0];
    }
    public void Ubersaw()
    {
        currentSprite = wepIstances.medicMelees[3];
    }
    public void VitaSaw()
    {
        currentSprite = wepIstances.medicMelees[2];
    }
    public void Amputator()
    {
        currentSprite = wepIstances.medicMelees[4];
    }
    public void SolemnVow()
    {
        currentSprite = wepIstances.medicMelees[1];
    }
}
