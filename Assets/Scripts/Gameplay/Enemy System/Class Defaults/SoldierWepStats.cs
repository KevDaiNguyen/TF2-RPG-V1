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
        numOfActions = 2;

        wepDescription1 = "Rocket Launch: Fire a rocket at the enemy, dealing half damage to the surrounding enemeis";
        wepDescription2 = "Rocket Jump: Launch yourself into the AIR for 1-3 turns after this turn ends, sacrificing some health";
        wepDescription3 = "Throw: Throw the guillotine at an enemy, causing bleeding for 2 turns";

        timeCost1 = 2;
        timeCost2 = 2;
        timeCost3 = 1;
    }
    public void DirectHit()
    {
        currentSprite = wepIstances.soldierPrimaries[4];
        ammoInMag = 4;
        ammoInReserve = 20;
        numOfActions = 2;

        wepDescription1 = "Rocket Launch: Fire a high damage rocket at the enemy";
        wepDescription2 = "Rocket Jump: Launch yourself into the AIR for 1-3 turns after this turn ends, sacrificing some health";
        wepDescription3 = "Throw: Throw the guillotine at an enemy, causing bleeding for 2 turns";

        timeCost1 = 2;
        timeCost2 = 2;
        timeCost3 = 1;
    }
    public void BlackBox()
    {
        currentSprite = wepIstances.soldierPrimaries[5];
        ammoInMag = 3;
        ammoInReserve = 20;
        numOfActions = 2;

        wepDescription1 = "Rocket Launch: Fire a rocket at the enemy, dealing half damage to the surrounding enemeis and healing up to 20 health based on the damage";
        wepDescription2 = "Rocket Jump: Launch yourself into the AIR for 1-3 turns after this turn ends, sacrificing some health";
        wepDescription3 = "Throw: Throw the guillotine at an enemy, causing bleeding for 2 turns";

        timeCost1 = 2;
        timeCost2 = 2;
        timeCost3 = 1;
    }
    public void RocketJumper()
    {
        currentSprite = wepIstances.soldierPrimaries[1];
        ammoInMag = 4;
        ammoInReserve = 60;
        numOfActions = 1;

        wepDescription1 = "Rocket Launch: Fire a rocket at the enemy, dealing half damage to the surrounding enemeis";
        wepDescription2 = "Rocket Jump: Launch yourself into the AIR for 1-3 turns after this turn ends, sacrificing some health";
        wepDescription3 = "Rocket Jump: Launch yourself into the AIR for 1-3 turns after this turn ends, dealing no damage to yourself";

        timeCost1 = 2;
        timeCost2 = 2;
        timeCost3 = 1;
    }
    public void LibertyLauncher()
    {
        currentSprite = wepIstances.soldierPrimaries[3];
        ammoInMag = 5;
        ammoInReserve = 20;
        numOfActions = 2;

        wepDescription1 = "Rocket Launch: Fire a low damage rocket at the enemy, dealing half damage to the surrounding enemeis";
        wepDescription2 = "Rocket Jump: Launch yourself into the AIR for 1-3 turns after this turn ends, sacrificing barely any health";
        wepDescription3 = "Throw: Throw the guillotine at an enemy, causing bleeding for 2 turns";

        timeCost1 = 2;
        timeCost2 = 2;
        timeCost3 = 1;

    }
    public void CowMangler5000()
    {
        currentSprite = wepIstances.soldierPrimaries[2];
        ammoInMag = 4;
        ammoInReserve = 4;
        numOfActions = 3;

        wepDescription1 = "Rocket Launch: Fire a rocket at the enemy, dealing half damage to the surrounding enemeis";
        wepDescription2 = "Rocket Jump: Launch yourself into the AIR for 1-3 turns after this turn ends, sacrificing some health";
        wepDescription3 = "Charge Up: Use up all of current ammo and shot a powerful shot at the enemy and giving them 2 turns of afterburn";

        timeCost1 = 2;
        timeCost2 = 2;
        timeCost3 = 5;
    }
    public void BeggarsBazooka()
    {
        currentSprite = wepIstances.soldierPrimaries[6];
        ammoInMag = 3;
        ammoInReserve = 20;
        numOfActions = 2;

        wepDescription1 = "Stockpile: Load up to 3 rockets into the barrel and unleash it at random enemy slots";
        wepDescription2 = "Rocket Jump: Launch yourself into the AIR for 1-3 turns after this turn ends, sacrificing some health";
        wepDescription3 = "Stockpile: Load up to 3 rockets into the barrel and unleash it at random enemy slots";

        timeCost1 = 2;
        timeCost2 = 2;
        timeCost3 = 10;
    }
    public void AirStrike()
    {
        currentSprite = wepIstances.soldierPrimaries[7];
        ammoInMag = 4;
        ammoInReserve = 20;
        numOfActions = 2;

        wepDescription1 = "Rocket Launch: Fire a low damage rocket at the enemy, firing faster if in AIR";
        wepDescription2 = "Rocket Jump: Launch yourself into the AIR for 1-3 turns after this turn ends, sacrificing barely any health";
        wepDescription3 = "Throw: Throw the guillotine at an enemy, causing bleeding for 2 turns";

        timeCost1 = 2;
        timeCost2 = 2;
        timeCost3 = 1;
    }

    //**********************************************************************************************************************************
    //SECONDARY WEAPONS
    //**********************************************************************************************************************************
    public void Shotgun()
    {
        currentSprite = wepIstances.soldierSecondaries[0];
        ammoInMag = 6;
        ammoInReserve = 32;
        numOfActions = 2;

        wepDescription1 = "Meatshot: Barrel stuff the shotgun into the enemy's chest, dealing massive damage";
        wepDescription2 = "Pepper: Fire your shotgun from moderate range, hopefully finishing off weak opponents";
        wepDescription3 = "Throw: Throw the guillotine at an enemy, causing bleeding for 2 turns";

        timeCost1 = 2;
        timeCost2 = 1;
        timeCost3 = 1;
    }
    public void BuffBanner()
    {
        currentSprite = wepIstances.soldierSecondaries[6];
        ammoInMag = 0;
        ammoInReserve = 600;
        numOfActions = 1;

        wepDescription1 = "Meatshot: Barrel stuff the shotgun into the enemy's chest, dealing massive damage";
        wepDescription2 = "Pepper: Fire your shotgun from moderate range, hopefully finishing off weak opponents";
        wepDescription3 = "Hornblow: After filling up the meter, blow your horn to gain minicrits for your whole team for 2 turns and this turn";

        timeCost1 = 2;
        timeCost2 = 1;
        timeCost3 = 2;
    }
    public void Gunboats()
    {
        currentSprite = wepIstances.soldierSecondaries[5];
        ammoInMag = 0;
        ammoInReserve = 0;
        numOfActions = 1;

        wepDescription1 = "Meatshot: Barrel stuff the shotgun into the enemy's chest, dealing massive damage";
        wepDescription2 = "Pepper: Fire your shotgun from moderate range, hopefully finishing off weak opponents";
        wepDescription3 = "Blast Protection: (PASSIVE) Deals less damage to yourself when you Rocket Jump";

        timeCost1 = 2;
        timeCost2 = 1;
        timeCost3 = 0;
    }
    public void BatallionsBackup()
    {
        currentSprite = wepIstances.soldierSecondaries[7];
        ammoInMag = 0;
        ammoInReserve = 600;
        numOfActions = 1;

        wepDescription1 = "Meatshot: Barrel stuff the shotgun into the enemy's chest, dealing massive damage";
        wepDescription2 = "Pepper: Fire your shotgun from moderate range, hopefully finishing off weak opponents";
        wepDescription3 = "Hornblow: After filling up the meter, blow your horn to gain crit immunity and damage reduction for your whole team for 2 turns and this turn";

        timeCost1 = 2;
        timeCost2 = 1;
        timeCost3 = 2;
    }
    public void Concheror()
    {
        currentSprite = wepIstances.soldierSecondaries[3];
        ammoInMag = 0;
        ammoInReserve = 480;
        numOfActions = 1;

        wepDescription1 = "Meatshot: Barrel stuff the shotgun into the enemy's chest, dealing massive damage";
        wepDescription2 = "Pepper: Fire your shotgun from moderate range, hopefully finishing off weak opponents";
        wepDescription3 = "Hornblow: After filling up the meter, blow your horn to gain movement speed and vampiric damage for your whole team for 2 turns and this turn";

        timeCost1 = 2;
        timeCost2 = 1;
        timeCost3 = 2;
    }
    public void Mantreads()
    {
        currentSprite = wepIstances.soldierSecondaries[4];
        ammoInMag = 0;
        ammoInReserve = 0;
        numOfActions = 1;

        wepDescription1 = "Meatshot: Barrel stuff the shotgun into the enemy's chest, dealing massive damage";
        wepDescription2 = "Pepper: Fire your shotgun from moderate range, hopefully finishing off weak opponents";
        wepDescription3 = "Air Control: (PASSIVE) Gain an extra turn turn in the AIR whenever you rocket jump";

        timeCost1 = 2;
        timeCost2 = 1;
        timeCost3 = 0;
    }
    public void ReserveShooter()
    {
        currentSprite = wepIstances.soldierSecondaries[2];
        ammoInMag = 4;
        ammoInReserve = 32;
        numOfActions = 2;

        wepDescription1 = "Meatshot: Barrel stuff the shotgun into the enemy's chest, dealing massive damage and even more if the enemy is in the AIR";
        wepDescription2 = "Pepper: Fire your shotgun from moderate range and dealing more damage if the enemy is in the AIR";
        wepDescription3 = "Throw: Throw the guillotine at an enemy, causing bleeding for 2 turns";

        timeCost1 = 2;
        timeCost2 = 1;
        timeCost3 = 1;
    }
    public void RighteousBison()
    {
        currentSprite = wepIstances.soldierSecondaries[1];
        ammoInMag = 4;
        ammoInReserve = 4;
        numOfActions = 1;

        wepDescription1 = "Meatshot: Barrel stuff the shotgun into the enemy's chest, dealing massive damage";
        wepDescription2 = "Pepper: Fire your shotgun from moderate range, hopefully finishing off weak opponents";
        wepDescription3 = "Laser Shot: Fire a penetrating laser at the enemy, dealing less damage per penetration";

        timeCost1 = 2;
        timeCost2 = 1;
        timeCost3 = 1;
    }
    public void BASEJumper()
    {
        currentSprite = wepIstances.soldierSecondaries[8];
        ammoInMag = 0;
        ammoInReserve = 0;
        numOfActions = 1;

        wepDescription1 = "Meatshot: Barrel stuff the shotgun into the enemy's chest, dealing massive damage";
        wepDescription2 = "Pepper: Fire your shotgun from moderate range, hopefully finishing off weak opponents";
        wepDescription3 = "Parachute: Activate once while in the AIR to increase turns in the AIR by 2 turns, but lowering movement speed at the same time. Activate again to cancel";

        timeCost1 = 2;
        timeCost2 = 1;
        timeCost3 = 1;
    }
    public void PanicAttack()
    {
        currentSprite = wepIstances.soldierSecondaries[9];
        ammoInMag = 6;
        ammoInReserve = 32;
        numOfActions = 2;

        wepDescription1 = "Meatshot: Barrel stuff the shotgun into the enemy's chest, dealing massive damage. More shots in a row reduces accuracy";
        wepDescription2 = "Pepper: Fire your shotgun from moderate range, hopefully finishing off weak opponents. More shots in a row reduces accuracy";
        wepDescription3 = "Throw: Throw the guillotine at an enemy, causing bleeding for 2 turns";

        timeCost1 = 2;
        timeCost2 = 1;
        timeCost3 = 1;
    }

    //**********************************************************************************************************************************
    //MELEE WEAPONS
    //**********************************************************************************************************************************
    public void Shovel()
    {
        currentSprite = wepIstances.soldierMelees[0];
        numOfActions = 1;

        wepDescription1 = "Meatshot: Barrel stuff the shotgun into the enemy's chest, dealing massive damage. More shots in a row reduces accuracy";
        wepDescription2 = "Pepper: Fire your shotgun from moderate range, hopefully finishing off weak opponents. More shots in a row reduces accuracy";
        wepDescription3 = "Melee Swing: Hit the enemy in front for moderate damage";

        timeCost1 = 2;
        timeCost2 = 1;
        timeCost3 = 1;
    }
    public void Equalizer()
    {
        currentSprite = wepIstances.soldierMelees[5];
        numOfActions = 1;

        wepDescription1 = "Melee Swing: Hit the enemy in front for moderate damage, dealing more damage at low health and less damage at high health";
        wepDescription2 = "Kamikaze: Use the grenades on your chest to blow yourself and the enemy in front of you, deal near unsurvivable damage";
        wepDescription3 = "Melee Swing: Hit the enemy in front for moderate damage, dealing more damage at low health and less damage at high health";

        timeCost1 = 1;
        timeCost2 = 8;
        timeCost3 = 1;
    }
    public void PainTrain()
    {
        currentSprite = wepIstances.soldierMelees[1];
        numOfActions = 1;

        wepDescription1 = "Meatshot: Barrel stuff the shotgun into the enemy's chest, dealing massive damage. More shots in a row reduces accuracy";
        wepDescription2 = "Pepper: Fire your shotgun from moderate range, hopefully finishing off weak opponents. More shots in a row reduces accuracy";
        wepDescription3 = "Melee Swing: Hit the enemy in front for moderate damage";

        timeCost1 = 2;
        timeCost2 = 1;
        timeCost3 = 1;
    }
    public void HalfZatoichi()
    {
        currentSprite = wepIstances.soldierMelees[3];
        numOfActions = 1;

        wepDescription1 = "Meatshot: Barrel stuff the shotgun into the enemy's chest, dealing massive damage. More shots in a row reduces accuracy";
        wepDescription2 = "Pepper: Fire your shotgun from moderate range, hopefully finishing off weak opponents. More shots in a row reduces accuracy";
        wepDescription3 = "Melee Swing: Hit the enemy up to two front for moderate damage, on successful kill heal half of your base health";

        timeCost1 = 2;
        timeCost2 = 1;
        timeCost3 = 1;
    }
    public void DisciplinaryAction()
    {
        currentSprite = wepIstances.soldierMelees[6];
        numOfActions = 2;

        wepDescription1 = "Melee Swing: Hit the enemy in up to two slots in front of you for low damage";
        wepDescription2 = "Helpful Whips: Hit a teammate to give you and your teammate a speed boost for 1 turn";
        wepDescription3 = "Melee Swing: Hit the enemy in front for low damage";

        timeCost1 = 1;
        timeCost2 = 1;
        timeCost3 = 1;
    }
    public void MarketGardener()
    {
        currentSprite = wepIstances.soldierMelees[2];
        numOfActions = 1;

        wepDescription1 = "Meatshot: Barrel stuff the shotgun into the enemy's chest, dealing massive damage. More shots in a row reduces accuracy";
        wepDescription2 = "Pepper: Fire your shotgun from moderate range, hopefully finishing off weak opponents. More shots in a row reduces accuracy";
        wepDescription3 = "Melee Swing: Hit the enemy in front for moderate damage, if in AIR deal a critical hit";

        timeCost1 = 2;
        timeCost2 = 1;
        timeCost3 = 1;
    }
    public void EscapePlan()
    {
        currentSprite = wepIstances.soldierMelees[4];
        numOfActions = 1;

        wepDescription1 = "Melee Swing: Hit the enemy in front for moderate damage";
        wepDescription2 = "Kamikaze: Use the grenades on your chest to blow yourself and the enemy in front of you, deal near unsurvivable damage";
        wepDescription3 = "Melee Swing: Hit the enemy in front for moderate damage, dealing more damage at low health and less damage at high health";

        timeCost1 = 1;
        timeCost2 = 8;
        timeCost3 = 1;
    }
}
