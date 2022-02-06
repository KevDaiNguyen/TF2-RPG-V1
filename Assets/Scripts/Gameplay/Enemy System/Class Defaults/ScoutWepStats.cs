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
        numOfActions = 2;

        wepDescription1 = "Meatshot: Barrel stuff the shotgun into the enemy's chest, dealing massive damage";
        wepDescription2 = "Pepper: Fire your shotgun from moderate range, hopefully finishing off weak opponents";
        wepDescription3 = "Sucks";

        timeCost1 = 2;
        timeCost2 = 1;
        timeCost3 = 1;
    }

    public void ForceANature()
    {
        currentSprite = wepIstances.scoutPrimaries[3];
        ammoInMag = 2;
        ammoInReserve = 32;
        numOfActions = 3;

        wepDescription1 = "Meatshot: Barrel stuff the shotgun into the enemy's chest, dealing massive damage";
        wepDescription2 = "Pepper: Fire your shotgun from moderate range, hopefully finishing off weak opponents";
        wepDescription3 = "Airborne: Launch yourself into the AIR for 1 turn";

        timeCost1 = 2;
        timeCost2 = 1;
        timeCost3 = 2;
    }

    public void ShortStop()
    {
        currentSprite = wepIstances.scoutPrimaries[1];
        ammoInMag = 4;
        ammoInReserve = 32;
        numOfActions = 3;

        wepDescription1 = "Meatshot: Barrel stuff the shotgun into the enemy's chest, dealing massive damage";
        wepDescription2 = "Pepper: Fire your shotgun from moderate range, hopefully finishing off weak opponents";
        wepDescription3 = "Shove It: Push an enemy in front you to move back one slot";

        timeCost1 = 2;
        timeCost2 = 1;
        timeCost3 = 1;
    }

    public void SodaPopper()
    {
        currentSprite = wepIstances.scoutPrimaries[2];
        ammoInMag = 2;
        ammoInReserve = 32;
        numOfActions = 3;

        wepDescription1 = "Meatshot: Barrel stuff the shotgun into the enemy's chest, dealing massive damage";
        wepDescription2 = "Pepper: Fire your shotgun from moderate range, hopefully finishing off weak opponents";
        wepDescription3 = "Pop Fly: After filling up your hype meter, launch yourself into the AIR for 2 turns";

        timeCost1 = 2;
        timeCost2 = 1;
        timeCost3 = 3;
    }

    public void BabyFacesBlaster()
    {
        currentSprite = wepIstances.scoutPrimaries[5];
        ammoInMag = 4;
        ammoInReserve = 32;
        numOfActions = 2;

        wepDescription1 = "Meatshot: Barrel stuff the shotgun into the enemy's chest, dealing massive damage";
        wepDescription2 = "Pepper: Fire your shotgun from moderate range, hopefully finishing off weak opponents";
        wepDescription3 = "Sucks";

        timeCost1 = 2;
        timeCost2 = 1;
        timeCost3 = 1;
    }

    public void BackScatter()
    {
        currentSprite = wepIstances.scoutPrimaries[4];
        ammoInMag = 4;
        ammoInReserve = 32;
        numOfActions = 3;

        wepDescription1 = "Meatshot: Barrel stuff the shotgun into the enemy's chest, dealing massive damage";
        wepDescription2 = "Pepper: Fire your shotgun from moderate range, hopefully finishing off weak opponents";
        wepDescription3 = "Behind You: Sneaks behind the targeted enemy and shoots their back, dealing even more damage than Meatshot";

        timeCost1 = 2;
        timeCost2 = 1;
        timeCost3 = 3;
    }

    //**********************************************************************************************************************************
    //SECONDARY WEAPONS
    //**********************************************************************************************************************************

    public void Pistol()
    {
        currentSprite = wepIstances.scoutSecondaries[0];
        ammoInMag = 12;
        ammoInReserve = 36;
        numOfActions = 1;

        wepDescription1 = "Pistol Poppin': Randomly fire innacurate pistol at enemy, hitting 1-6 times";
        wepDescription2 = "Pepper: Fire your shotgun from moderate range, hopefully finishing off weak opponents";
        wepDescription3 = "Pistol Poppin': Randomly fire innacurate pistol at enemy, hitting 1-6 times";

        timeCost1 = 1;
        timeCost2 = 1;
        timeCost3 = 2;
    }

    public void BONK()
    {
        currentSprite = wepIstances.scoutSecondaries[3];
        ammoInMag = 100;
        ammoInReserve = 100;
        numOfActions = 1;

        wepDescription1 = "Drink: Start your drinking sequence, becoming for 2 turns after this turn ends";
        wepDescription2 = "Pepper: Fire your shotgun from moderate range, hopefully finishing off weak opponents";
        wepDescription3 = "Drink: Start your drinking sequence, becoming for 2 turns after this turn ends";

        timeCost1 = 1;
        timeCost2 = 1;
        timeCost3 = 3;
    }

    public void CritACola()
    {
        currentSprite = wepIstances.scoutSecondaries[6];
        ammoInMag = 100;
        ammoInReserve = 100;
        numOfActions = 1;

        wepDescription1 = "Drink: Start your drinking sequence, becoming for 2 turns after this turn ends";
        wepDescription2 = "Pepper: Fire your shotgun from moderate range, hopefully finishing off weak opponents";
        wepDescription3 = "Drink: Start your drinking sequence, dealing minicrit damage for 2 turns after this turn ends";

        timeCost1 = 1;
        timeCost2 = 1;
        timeCost3 = 3;
    }

    public void MadMilk()
    {
        currentSprite = wepIstances.scoutSecondaries[4];
        ammoInMag = 100;
        ammoInReserve = 100;
        numOfActions = 1;

        wepDescription1 = "Drink: Start your drinking sequence, becoming for 2 turns after this turn ends";
        wepDescription2 = "Pepper: Fire your shotgun from moderate range, hopefully finishing off weak opponents";
        wepDescription3 = "Milk? Throw: Throw on an enemy to debuff them or on an ally to extinguish them";

        timeCost1 = 1;
        timeCost2 = 1;
        timeCost3 = 1;
    }

    public void Winger()
    {
        currentSprite = wepIstances.scoutSecondaries[1];
        ammoInMag = 5;
        ammoInReserve = 36;
        numOfActions = 2;

        wepDescription1 = "Pistol Poppin': Randomly fire innacurate pistol at enemy, hitting 1-6 times";
        wepDescription2 = "Airborne: Jump into the AIR for this turn";
        wepDescription3 = "Pistol Poppin': Randomly fire innacurate pistol at enemy, hitting 1-6 times";

        timeCost1 = 1;
        timeCost2 = 2;
        timeCost3 = 2;
    }

    public void PrettyBoysPocketPistol()
    {
        currentSprite = wepIstances.scoutSecondaries[2];
        ammoInMag = 9;
        ammoInReserve = 36;
        numOfActions = 1;

        wepDescription1 = "Pistol Poppin': Randomly fire innacurate pistol at enemy, hitting 1-6 times and slightly healing you on each successful hit";
        wepDescription2 = "Pepper: Fire your shotgun from moderate range, hopefully finishing off weak opponents";
        wepDescription3 = "Pistol Poppin': Randomly fire innacurate pistol at enemy, hitting 1-6 times and slightly healing you on each successful hit";

        timeCost1 = 1;
        timeCost2 = 1;
        timeCost3 = 2;
    }

    public void FlyingGuillotine()
    {
        currentSprite = wepIstances.scoutSecondaries[5];
        ammoInMag = 100;
        ammoInReserve = 100;
        numOfActions = 1;

        wepDescription1 = "Throw: Randomly fire innacurate pistol at enemy, hitting 1-6 times";
        wepDescription2 = "Pepper: Fire your shotgun from moderate range, hopefully finishing off weak opponents";
        wepDescription3 = "Throw: Throw the guillotine at an enemy, causing bleeding for 2 turns";

        timeCost1 = 1;
        timeCost2 = 1;
        timeCost3 = 1;
    }

    //**********************************************************************************************************************************
    //MELEE WEAPONS
    //**********************************************************************************************************************************

    public void Bat()
    {
        currentSprite = wepIstances.scoutMelees[0]; 
        numOfActions = 1;

        wepDescription1 = "Throw: Randomly fire innacurate pistol at enemy, hitting 1-6 times";
        wepDescription2 = "Pepper: Fire your shotgun from moderate range, hopefully finishing off weak opponents";
        wepDescription3 = "Swing Batter Batter: Hit the enemy in front of you with your bat";

        timeCost1 = 1;
        timeCost2 = 1;
        timeCost3 = 1;

    }

    public void Sandman()
    {
        currentSprite = wepIstances.scoutMelees[4];
        ammoInMag = 100;
        ammoInReserve = 100;
        numOfActions = 2;

        wepDescription1 = "Batters Up: Launch a baseball at the enemy that slows down the enemy, the further the enemy the more turns they are slowed down for";
        wepDescription2 = "Swing Batter Batter: Hit the enemy in front of you with your bat";
        wepDescription3 = "Throw: Throw the guillotine at an enemy, causing bleeding for 2 turns";

        timeCost1 = 2;
        timeCost2 = 1;
        timeCost3 = 1;
    }

    public void CandyCane()
    {
        currentSprite = wepIstances.scoutMelees[5];
        numOfActions = 1;

        wepDescription1 = "Throw: Randomly fire innacurate pistol at enemy, hitting 1-6 times";
        wepDescription2 = "Pepper: Fire your shotgun from moderate range, hopefully finishing off weak opponents";
        wepDescription3 = "Swing Batter Batter: Hit the enemy in front of you with your bat";

        timeCost1 = 1;
        timeCost2 = 1;
        timeCost3 = 1;
    }

    public void BostonBasher()
    {
        currentSprite = wepIstances.scoutMelees[1];
        numOfActions = 1;

        wepDescription1 = "Throw: Randomly fire innacurate pistol at enemy, hitting 1-6 times";
        wepDescription2 = "Pepper: Fire your shotgun from moderate range, hopefully finishing off weak opponents";
        wepDescription3 = "Swing Batter Batter: Hit the enemy in front of you with your bat, enemy will bleed for 2 turns (If there are no enemy in front, deal hit yourself instead)";

        timeCost1 = 1;
        timeCost2 = 1;
        timeCost3 = 1;
    }

    public void SunOnAStick()
    {
        currentSprite = wepIstances.scoutMelees[3];
        numOfActions = 1;

        wepDescription1 = "Throw: Randomly fire innacurate pistol at enemy, hitting 1-6 times";
        wepDescription2 = "Pepper: Fire your shotgun from moderate range, hopefully finishing off weak opponents";
        wepDescription3 = "Swing Batter Batter: Hit the enemy in front of you with your bat, if the enemy is on fire, deal more damage";

        timeCost1 = 1;
        timeCost2 = 1;
        timeCost3 = 1;
    }
    public void FanOWar()
    {
        currentSprite = wepIstances.scoutMelees[7];
        numOfActions = 1;

        wepDescription1 = "Throw: Randomly fire innacurate pistol at enemy, hitting 1-6 times";
        wepDescription2 = "Pepper: Fire your shotgun from moderate range, hopefully finishing off weak opponents";
        wepDescription3 = "Swing Batter Batter: Hit the enemy in front of you with your bat and marks the enemy for death";

        timeCost1 = 1;
        timeCost2 = 1;
        timeCost3 = 1;
    }
    public void Atomizer()
    {
        currentSprite = wepIstances.scoutMelees[6];
        numOfActions = 2;

        wepDescription1 = "Swing Batter Batter: Hit the enemy in front of you with your bat";
        wepDescription2 = "Triple Jump: Put yourself into the AIR for 1 turn after this turn ends";
        wepDescription3 = "Swing Batter Batter: Hit the enemy in front of you with your bat";

        timeCost1 = 1;
        timeCost2 = 1;
        timeCost3 = 1;
    }
    public void WrapAssassin()
    {
        currentSprite = wepIstances.scoutMelees[2];
        ammoInMag = 100;
        ammoInReserve = 100;
        numOfActions = 2;

        wepDescription1 = "Batters Up: Launch a bauble at the enemy that causes the enemy to bleed for 2 turns";
        wepDescription2 = "Swing Batter Batter: Hit the enemy in front of you with your bat";
        wepDescription3 = "Throw: Throw the guillotine at an enemy, causing bleeding for 2 turns";

        timeCost1 = 2;
        timeCost2 = 1;
        timeCost3 = 1;
    }
}
