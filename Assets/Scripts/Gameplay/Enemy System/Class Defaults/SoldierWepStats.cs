using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoldierWepStats : MonoBehaviour
{
    public ListOfClassWeapons wepIstances;
    public Sprite[] trumpets;

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
        wepDescription1 = "Soldier";
        wepDescription2 = "Soldier";
        wepDescription3 = "Soldier";
        ammoInMag = 0;
        ammoInReserve = 0;
        totalAmmo = ammoInMag + ammoInReserve;
    }

    //**********************************************************************************************************************************
    //PRIMARY WEAPONS
    //**********************************************************************************************************************************

    public void RocketLauncher()
    {
        currentSprite = wepIstances.soldierPrimaries[0];
        ammoInMag = 4;
        ammoInReserve = 20;
    }
    public void DirectHit()
    {
        currentSprite = wepIstances.soldierPrimaries[4];
        ammoInMag = 4;
        ammoInReserve = 20;
    }
    public void BlackBox()
    {
        currentSprite = wepIstances.soldierPrimaries[5];
        ammoInMag = 3;
        ammoInReserve = 20;
    }
    public void RocketJumper()
    {
        currentSprite = wepIstances.soldierPrimaries[1];
        ammoInMag = 4;
        ammoInReserve = 60;
    }
    public void LibertyLauncher()
    {
        currentSprite = wepIstances.soldierPrimaries[3];
        ammoInMag = 5;
        ammoInReserve = 20;
    }
    public void CowMangler5000()
    {
        currentSprite = wepIstances.soldierPrimaries[2];
        ammoInMag = 4;
        ammoInReserve = 4;
    }
    public void BeggarsBazooka()
    {
        currentSprite = wepIstances.soldierPrimaries[6];
        ammoInMag = 3;
        ammoInReserve = 20;
    }
    public void AirStrike()
    {
        currentSprite = wepIstances.soldierPrimaries[7];
        ammoInMag = 4;
        ammoInReserve = 20;
    }

    //**********************************************************************************************************************************
    //SECONDARY WEAPONS
    //**********************************************************************************************************************************
    public void Shotgun()
    {
        currentSprite = wepIstances.soldierSecondaries[0];
        ammoInMag = 6;
        ammoInReserve = 32;
    }
    public void BuffBanner()
    {
        currentSprite = wepIstances.soldierSecondaries[6];
        ammoInMag = 0;
        ammoInReserve = 600;
    }
    public void Gunboats()
    {
        currentSprite = wepIstances.soldierSecondaries[5];
        ammoInMag = 0;
        ammoInReserve = 0;
    }
    public void BatallionsBackup()
    {
        currentSprite = wepIstances.soldierSecondaries[7];
        ammoInMag = 0;
        ammoInReserve = 600;
    }
    public void Concheror()
    {
        currentSprite = wepIstances.soldierSecondaries[3];
        ammoInMag = 0;
        ammoInReserve = 480;
    }
    public void Mantreads()
    {
        currentSprite = wepIstances.soldierSecondaries[4];
        ammoInMag = 0;
        ammoInReserve = 0;
    }
    public void ReserveShooter()
    {
        currentSprite = wepIstances.soldierSecondaries[2];
        ammoInMag = 4;
        ammoInReserve = 32;
    }
    public void RighteousBison()
    {
        currentSprite = wepIstances.soldierSecondaries[1];
        ammoInMag = 4;
        ammoInReserve = 4;
    }
    public void BASEJumper()
    {
        currentSprite = wepIstances.soldierSecondaries[8];
        ammoInMag = 0;
        ammoInReserve = 0;
    }
    public void PanicAttack()
    {
        currentSprite = wepIstances.soldierSecondaries[9];
        ammoInMag = 6;
        ammoInReserve = 32;
    }

    //**********************************************************************************************************************************
    //MELEE WEAPONS
    //**********************************************************************************************************************************
    public void Shovel()
    {
        currentSprite = wepIstances.soldierMelees[0];
    }
    public void Equalizer()
    {
        currentSprite = wepIstances.soldierMelees[5];
    }
    public void PainTrain()
    {
        currentSprite = wepIstances.soldierMelees[1];
    }
    public void HalfZatoichi()
    {
        currentSprite = wepIstances.soldierMelees[3];
    }
    public void DisciplinaryAction()
    {
        currentSprite = wepIstances.soldierMelees[6];
    }
    public void MarketGardener()
    {
        currentSprite = wepIstances.soldierMelees[2];
    }
    public void EscapePlan()
    {
        currentSprite = wepIstances.soldierMelees[4];
    }
}
