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
        numOfActions = 3;

        wepDescription1 = "Hot Roast: Spend X time tokens to deal moderate damage per token spent 2 slots in front of you. Enemies hit will gain afterburn for how much time spent.";
        wepDescription2 = "Airblast prep: For the next 2 turns, any projectiles shot from the enemy team is reflected back and using some a portion of ammo in the process";
        wepDescription3 = "Compression Blast: Push the enemy back 2 slots, sacrificing some ammo";

        timeCost1 = 10;
        timeCost2 = 3;
        timeCost3 = 1;
    }
    public void Backburner()
    {
        currentSprite = wepIstances.pyroPrimaries[3];
        ammoInMag = 200;
        ammoInReserve = 200;
        numOfActions = 3;

        wepDescription1 = "Hot Roast: Spend X time tokens to deal moderate damage per token spent 2 slots in front of you. Enemies hit will gain afterburn for how much time spent.";
        wepDescription2 = "Airblast prep: For the next 2 turns, any projectiles shot from the enemy team is reflected back and using some a large portion of ammo in the process";
        wepDescription3 = "Butt Burn: Sneak around the enemy slot and burn them for 2 time tokens, dealing significant damage";

        timeCost1 = 10;
        timeCost2 = 3;
        timeCost3 = 4;
    }
    public void Degreaser()
    {
        currentSprite = wepIstances.pyroPrimaries[2];
        ammoInMag = 200;
        ammoInReserve = 200;
        numOfActions = 3;

        wepDescription1 = "Hot Roast: Spend X time tokens to deal moderate damage per token spent 2 slots in front of you. Enemies hit will gain afterburn for how much time spent.";
        wepDescription2 = "Airblast prep: For the next 2 turns, any projectiles shot from the enemy team is reflected back and using some a portion of ammo in the process";
        wepDescription3 = "Compression Blast: Push the enemy back 2 slots, sacrificing some ammo";

        timeCost1 = 10;
        timeCost2 = 3;
        timeCost3 = 1;
    }
    public void Phlogistinator()
    {
        currentSprite = wepIstances.pyroPrimaries[1];
        ammoInMag = 200;
        ammoInReserve = 200;
        numOfActions = 2;

        wepDescription1 = "Hot Roast: Spend X time tokens to deal moderate damage per token spent 2 slots in front of you. Enemies hit will gain afterburn for how much time spent.";
        wepDescription2 = "Scienfitic Achievement: For the next 2 turns after taunting, all flamethrower damage is critical damage";
        wepDescription3 = "Sucks";

        timeCost1 = 10;
        timeCost2 = 3;
        timeCost3 = 1;
    }
    public void DragonsFury()
    {
        currentSprite = wepIstances.pyroPrimaries[4];
        ammoInMag = 40;
        ammoInReserve = 40;
        numOfActions = 2;

        wepDescription1 = "Hot Roast: Spend X time tokens to deal moderate damage per token spent 2 slots in front of you. Enemies hit will gain afterburn for how much time spent.";
        wepDescription2 = "Airblast prep: For the next 2 turns, any projectiles shot from the enemy team is reflected back and using some a portion of ammo in the process";
        wepDescription3 = "Sucks";

        timeCost1 = 10;
        timeCost2 = 3;
        timeCost3 = 1;
    }

    //**********************************************************************************************************************************
    //SECONDARY WEAPONS
    //**********************************************************************************************************************************
    public void Shotgun()
    {
        currentSprite = wepIstances.pyroSecondaries[0];
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
    public void FlareGun()
    {
        currentSprite = wepIstances.pyroSecondaries[3];
        ammoInMag = 1;
        ammoInReserve = 16;
        numOfActions = 1;

        wepDescription1 = "Meatshot: Barrel stuff the shotgun into the enemy's chest, dealing massive damage and even more if the enemy is in the AIR";
        wepDescription2 = "Pepper: Fire your shotgun from moderate range and dealing more damage if the enemy is in the AIR";
        wepDescription3 = "Flare Shot: Hit enemy to deal damage and give them afterburn, enemies already on fire will take critical damage";

        timeCost1 = 2;
        timeCost2 = 1;
        timeCost3 = 1;
    }
    public void Detonator()
    {
        currentSprite = wepIstances.pyroSecondaries[7];
        ammoInMag = 1;
        ammoInReserve = 16;
        numOfActions = 2;

        wepDescription1 = "Flare Shot: Hit enemy to deal damage and give them afterburn, enemies already on fire will take mini-crit damage";
        wepDescription2 = "Detonate: Fire a flare and detonate at the chosen slot, lighting that slot and adgjacent slots on fire";
        wepDescription3 = "Flare Shot: Hit enemy to deal damage and give them afterburn, enemies already on fire will take critical damage";

        timeCost1 = 1;
        timeCost2 = 2;
        timeCost3 = 1;
    }
    public void ReserveShooter()
    {
        currentSprite = wepIstances.pyroSecondaries[2];
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
    public void ManMelter()
    {
        currentSprite = wepIstances.pyroSecondaries[4];
        ammoInMag = 1;
        ammoInReserve = 1;
        numOfActions = 2;

        wepDescription1 = "Flare Shot: Hit enemy to deal damage and give them afterburn";
        wepDescription2 = "Good Suck: Extinguish any teammate on fire, giving your next Flare Shot critical damage";
        wepDescription3 = "Flare Shot: Hit enemy to deal damage and give them afterburn, enemies already on fire will take critical damage";

        timeCost1 = 1;
        timeCost2 = 1;
        timeCost3 = 1;
    }
    public void ScorchShot()
    {
        currentSprite = wepIstances.pyroSecondaries[1];
        ammoInMag = 1;
        ammoInReserve = 16;
        numOfActions = 2;

        wepDescription1 = "Flare Shot: Hit enemy to deal damage and give them afterburn, enemies already on fire will take mini-crit damage";
        wepDescription2 = "Splash Fire: Hit the enemy slot, igniting the slot and adjacent slots on fire";
        wepDescription3 = "Flare Shot: Hit enemy to deal damage and give them afterburn, enemies already on fire will take critical damage";

        timeCost1 = 1;
        timeCost2 = 2;
        timeCost3 = 1;

    }
    public void PanicAttack()
    {
        currentSprite = wepIstances.pyroSecondaries[6];
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
    public void ThermalThruster()
    {
        currentSprite = wepIstances.pyroSecondaries[8];
        ammoInMag = 100;
        ammoInReserve = 100;
        numOfActions = 2;

        wepDescription1 = "Red Rocket: Fly into the AIR for 2 turns";
        wepDescription2 = "Hard Landing: If in the AIR, can choose to land on an enemy for some damage";
        wepDescription3 = "Throw: Throw the guillotine at an enemy, causing bleeding for 2 turns";

        timeCost1 = 3;
        timeCost2 = 1;
        timeCost3 = 1;
    }
    public void GasPasser()
    {
        currentSprite = wepIstances.pyroSecondaries[5];
        ammoInMag = 100;
        ammoInReserve = 100;
        numOfActions = 1;

        wepDescription1 = "Meatshot: Barrel stuff the shotgun into the enemy's chest, dealing massive damage. More shots in a row reduces accuracy";
        wepDescription2 = "Pepper: Fire your shotgun from moderate range, hopefully finishing off weak opponents. More shots in a row reduces accuracy";
        wepDescription3 = "Gas Throw: Coat two slots in gasoline, in which any damage taken will ignite them";

        timeCost1 = 2;
        timeCost2 = 1;
        timeCost3 = 1;
    }

    //**********************************************************************************************************************************
    //MELEE WEAPONS
    //**********************************************************************************************************************************
    public void FireAxe()
    {
        currentSprite = wepIstances.pyroMelees[0];
        numOfActions = 1;

        wepDescription1 = "Meatshot: Barrel stuff the shotgun into the enemy's chest, dealing massive damage. More shots in a row reduces accuracy";
        wepDescription2 = "Pepper: Fire your shotgun from moderate range, hopefully finishing off weak opponents. More shots in a row reduces accuracy";
        wepDescription3 = "Melee Swing: Hit the enemy in front for moderate damage";

        timeCost1 = 2;
        timeCost2 = 1;
        timeCost3 = 1;
    }
    public void Axtinguisher()
    {
        currentSprite = wepIstances.pyroMelees[8];
        numOfActions = 1;

        wepDescription1 = "Meatshot: Barrel stuff the shotgun into the enemy's chest, dealing massive damage. More shots in a row reduces accuracy";
        wepDescription2 = "Pepper: Fire your shotgun from moderate range, hopefully finishing off weak opponents. More shots in a row reduces accuracy";
        wepDescription3 = "Melee Swing: Hit the enemy in front for low damage, dealing higher damage if the enemy is on fire";

        timeCost1 = 2;
        timeCost2 = 1;
        timeCost3 = 1;
    }
    public void Homewrecker()
    {
        currentSprite = wepIstances.pyroMelees[6];
        numOfActions = 1;

        wepDescription1 = "Meatshot: Barrel stuff the shotgun into the enemy's chest, dealing massive damage. More shots in a row reduces accuracy";
        wepDescription2 = "Pepper: Fire your shotgun from moderate range, hopefully finishing off weak opponents. More shots in a row reduces accuracy";
        wepDescription3 = "Melee Swing: Hit the enemy in front for moderate damage, dealing higher damage to buildings and can unsap friendly buildings";

        timeCost1 = 2;
        timeCost2 = 1;
        timeCost3 = 1;
    }
    public void Powerjack()
    {
        currentSprite = wepIstances.pyroMelees[3];
        numOfActions = 1;

        wepDescription1 = "Meatshot: Barrel stuff the shotgun into the enemy's chest, dealing massive damage. More shots in a row reduces accuracy";
        wepDescription2 = "Pepper: Fire your shotgun from moderate range, hopefully finishing off weak opponents. More shots in a row reduces accuracy";
        wepDescription3 = "Melee Swing: Hit the enemy in front for moderate damage, getting a successful kill will grant some health";

        timeCost1 = 2;
        timeCost2 = 1;
        timeCost3 = 1;
    }
    public void BackScratcher()
    {
        currentSprite = wepIstances.pyroMelees[7];
        numOfActions = 1;

        wepDescription1 = "Meatshot: Barrel stuff the shotgun into the enemy's chest, dealing massive damage. More shots in a row reduces accuracy";
        wepDescription2 = "Pepper: Fire your shotgun from moderate range, hopefully finishing off weak opponents. More shots in a row reduces accuracy";
        wepDescription3 = "Melee Swing: Hit the enemy in front for high damage";

        timeCost1 = 2;
        timeCost2 = 1;
        timeCost3 = 1;
    }
    public void SharpenedVolcanoFragment()
    {
        currentSprite = wepIstances.pyroMelees[1];
        numOfActions = 1;

        wepDescription1 = "Meatshot: Barrel stuff the shotgun into the enemy's chest, dealing massive damage. More shots in a row reduces accuracy";
        wepDescription2 = "Pepper: Fire your shotgun from moderate range, hopefully finishing off weak opponents. More shots in a row reduces accuracy";
        wepDescription3 = "Melee Swing: Hit the enemy in front for moderate damage but set them on fire";

        timeCost1 = 2;
        timeCost2 = 1;
        timeCost3 = 1;
    }
    public void NeonAnnihilator()
    {
        currentSprite = wepIstances.pyroMelees[4];
        numOfActions = 1;

        wepDescription1 = "Meatshot: Barrel stuff the shotgun into the enemy's chest, dealing massive damage. More shots in a row reduces accuracy";
        wepDescription2 = "Pepper: Fire your shotgun from moderate range, hopefully finishing off weak opponents. More shots in a row reduces accuracy";
        wepDescription3 = "Melee Swing: Hit the enemy in front for moderate damage, dealing high damage if the enemy is wet";

        timeCost1 = 2;
        timeCost2 = 1;
        timeCost3 = 1;
    }
    public void HotHand()
    {
        currentSprite = wepIstances.pyroMelees[5];
        numOfActions = 1;

        wepDescription1 = "Meatshot: Barrel stuff the shotgun into the enemy's chest, dealing massive damage. More shots in a row reduces accuracy";
        wepDescription2 = "Pepper: Fire your shotgun from moderate range, hopefully finishing off weak opponents. More shots in a row reduces accuracy";
        wepDescription3 = "Melee Swing: Hit the enemy in front for low damage, but hits twice";

        timeCost1 = 2;
        timeCost2 = 1;
        timeCost3 = 1;
    }

    public void ThirdDegree()
    {
        currentSprite = wepIstances.pyroMelees[2];
        numOfActions = 1;

        wepDescription1 = "Meatshot: Barrel stuff the shotgun into the enemy's chest, dealing massive damage. More shots in a row reduces accuracy";
        wepDescription2 = "Pepper: Fire your shotgun from moderate range, hopefully finishing off weak opponents. More shots in a row reduces accuracy";
        wepDescription3 = "Melee Swing: Hit the enemy in front for moderate damage, but if a medic is healing the opponent, the medic takes the same damage";

        timeCost1 = 2;
        timeCost2 = 1;
        timeCost3 = 1;
    }
}
