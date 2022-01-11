using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DemoWepStats : MonoBehaviour
{
    public ListOfClassWeapons wepIstances;
    public int maxStickies;
    public int currentStickies;

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
        wepDescription1 = "Demo";
        wepDescription2 = "Demo";
        wepDescription3 = "Demo";
        ammoInMag = 0;
        ammoInReserve = 0;
        totalAmmo = ammoInMag + ammoInReserve;
        maxStickies = 8;
        currentStickies = 0;
    }

    //**********************************************************************************************************************************
    //PRIMARY WEAPONS
    //**********************************************************************************************************************************

    public void GrenadeLauncher()
    {
        currentSprite = wepIstances.demomanPrimaries[0];
        ammoInMag = 4;
        ammoInReserve = 16;
    }
    public void LochNLoad()
    {
        currentSprite = wepIstances.demomanPrimaries[2];
        ammoInMag = 3;
        ammoInReserve = 16;
    }
    public void AliBabasWeeBooties()
    {
        currentSprite = wepIstances.demomanPrimaries[5];
        ammoInMag = 0;
        ammoInReserve = 0;
    }
    public void LooseCannon()
    {
        currentSprite = wepIstances.demomanPrimaries[1];
        ammoInMag = 4;
        ammoInReserve = 16;
    }
    public void BASEJumper()
    {
        currentSprite = wepIstances.demomanPrimaries[4];
        ammoInMag = 0;
        ammoInReserve = 0;
    }
    public void IronBomber()
    {
        currentSprite = wepIstances.demomanPrimaries[3];
        ammoInMag = 4;
        ammoInReserve = 16;
    }

    //**********************************************************************************************************************************
    //SECONDARY WEAPONS
    //**********************************************************************************************************************************

    public void StickybombLauncher()
    {
        currentSprite = wepIstances.demomanSecondaries[0];
        ammoInMag = 8;
        ammoInReserve = 24;
    }
    public void CharginTarge()
    {
        currentSprite = wepIstances.demomanSecondaries[1];
        ammoInMag = 100;
        ammoInReserve = 100;
    }
    public void ScottishResistance()
    {
        currentSprite = wepIstances.demomanSecondaries[5];
        ammoInMag = 8;
        ammoInReserve = 36;
    }
    public void StickyJumper()
    {
        currentSprite = wepIstances.demomanSecondaries[3];
        ammoInMag = 8;
        ammoInReserve = 72;
    }
    public void SplendidScreen()
    {
        currentSprite = wepIstances.demomanSecondaries[4];
        ammoInMag = 100;
        ammoInReserve = 100;
    }
    public void TideTurner()
    {
        currentSprite = wepIstances.demomanSecondaries[2];
        ammoInMag = 100;
        ammoInReserve = 100;
    }
    public void QuickiebombLauncher()
    {
        currentSprite = wepIstances.demomanSecondaries[6];
        ammoInMag = 4;
        ammoInReserve = 24;
    }

    //**********************************************************************************************************************************
    //MELEE WEAPONS
    //**********************************************************************************************************************************
    public void Bottle()
    {
        currentSprite = wepIstances.demomanMelees[0];
    }
    public void Eyelander()
    {
        currentSprite = wepIstances.demomanMelees[7];
        ammoInMag = 0;
        ammoInReserve = 0;
    }
    public void PainTrain()
    {
        currentSprite = wepIstances.demomanMelees[5];
    }
    public void ScotsmansSkullcutter()
    {
        currentSprite = wepIstances.demomanMelees[2];
    }
    public void ClaidheamhMor()
    {
        currentSprite = wepIstances.demomanMelees[3];
    }
    public void UllapoolCaber()
    {
        currentSprite = wepIstances.demomanMelees[1];
        ammoInMag = 1;
        ammoInReserve = 1;
    }
    public void HalfZatoichi()
    {
        currentSprite = wepIstances.demomanMelees[6];
    }
    public void PersianPersuader()
    {
        currentSprite = wepIstances.demomanMelees[4];
    }
}
