using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PyroWepStats : MonoBehaviour
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
        timeCost2 = 1;
        timeCost3 = 1;
        rightPosition = false;
        rightEnemyPosition = false;
        wepDescription1 = "Pyro";
        wepDescription2 = "Pyro";
        wepDescription3 = "Pyro";
        ammoInMag = 0;
        ammoInReserve = 0;
        totalAmmo = ammoInMag + ammoInReserve;
    }

    //**********************************************************************************************************************************
    //PRIMARY WEAPONS
    //**********************************************************************************************************************************

    public void FlameThrower()
    {
        currentSprite = wepIstances.pyroPrimaries[0];
        ammoInMag = 200;
        ammoInReserve = 200;
    }
    public void Backburner()
    {
        currentSprite = wepIstances.pyroPrimaries[3];
        ammoInMag = 200;
        ammoInReserve = 200;
    }
    public void Degreaser()
    {
        currentSprite = wepIstances.pyroPrimaries[2];
        ammoInMag = 200;
        ammoInReserve = 200;
    }
    public void Phlogistinator()
    {
        currentSprite = wepIstances.pyroPrimaries[1];
        ammoInMag = 200;
        ammoInReserve = 200;
    }
    public void DragonsFury()
    {
        currentSprite = wepIstances.pyroPrimaries[4];
        ammoInMag = 40;
        ammoInReserve = 40;
    }

    //**********************************************************************************************************************************
    //SECONDARY WEAPONS
    //**********************************************************************************************************************************
    public void Shotgun()
    {
        currentSprite = wepIstances.pyroSecondaries[0];
        ammoInMag = 6;
        ammoInReserve = 32;
    }
    public void FlareGun()
    {
        currentSprite = wepIstances.pyroSecondaries[3];
        ammoInMag = 1;
        ammoInReserve = 16;
    }
    public void Detonator()
    {
        currentSprite = wepIstances.pyroSecondaries[7];
        ammoInMag = 1;
        ammoInReserve = 16;
    }
    public void ReserveShooter()
    {
        currentSprite = wepIstances.pyroSecondaries[2];
        ammoInMag = 4;
        ammoInReserve = 32;
    }
    public void ManMelter()
    {
        currentSprite = wepIstances.pyroSecondaries[4];
        ammoInMag = 1;
        ammoInReserve = 1;
    }
    public void ScorchShot()
    {
        currentSprite = wepIstances.pyroSecondaries[1];
        ammoInMag = 1;
        ammoInReserve = 16;
    }
    public void PanicAttack()
    {
        currentSprite = wepIstances.pyroSecondaries[6];
        ammoInMag = 6;
        ammoInReserve = 32;
    }
    public void ThermalThruster()
    {
        currentSprite = wepIstances.pyroSecondaries[8];
        ammoInMag = 100;
        ammoInReserve = 100;
    }
    public void GasPasser()
    {
        currentSprite = wepIstances.pyroSecondaries[5];
        ammoInMag = 100;
        ammoInReserve = 100;
    }

    //**********************************************************************************************************************************
    //MELEE WEAPONS
    //**********************************************************************************************************************************
    public void FireAxe()
    {
        currentSprite = wepIstances.pyroMelees[0];
    }
    public void Axtinguisher()
    {
        currentSprite = wepIstances.pyroMelees[8];
    }
    public void Homewrecker()
    {
        currentSprite = wepIstances.pyroMelees[6];
    }
    public void Powerjack()
    {
        currentSprite = wepIstances.pyroMelees[3];
    }
    public void BackScratcher()
    {
        currentSprite = wepIstances.pyroMelees[7];
    }
    public void SharpenedVolcanoFragment()
    {
        currentSprite = wepIstances.pyroMelees[1];
    }
    public void NeonAnnihilator()
    {
        currentSprite = wepIstances.pyroMelees[4];
    }
    public void HotHand()
    {
        currentSprite = wepIstances.pyroMelees[5];
    }

    public void ThirdDegree()
    {
        currentSprite = wepIstances.pyroMelees[2];
    }
}
