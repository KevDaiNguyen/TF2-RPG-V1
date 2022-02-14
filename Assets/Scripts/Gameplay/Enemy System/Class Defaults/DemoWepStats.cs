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
        numOfActions = 2;

        wepDescription1 = "Pipe Launch: Launch the greande at a steep angle, hitting further away and slightly damage one adjacent slot if successful";
        wepDescription2 = "Pipe Lob: Launch the grenade at a shallow angle, hitting close angles and slightly damage one adjacent slot if successful";
        wepDescription3 = "Throw: Throw the guillotine at an enemy, causing bleeding for 2 turns";

        timeCost1 = 1;
        timeCost2 = 1;
        timeCost3 = 1;
    }
    public void LochNLoad()
    {
        currentSprite = wepIstances.demomanPrimaries[2];
        ammoInMag = 3;
        ammoInReserve = 16;
        numOfActions = 2;

        wepDescription1 = "Pipe Launch: Launch the greande at a steep angle, hitting further away and dealing more damage to buildings";
        wepDescription2 = "Pipe Lob: Launch the grenade at a shallow angle, hitting close angles and dealing more damage to buildings";
        wepDescription3 = "Throw: Throw the guillotine at an enemy, causing bleeding for 2 turns";

        timeCost1 = 1;
        timeCost2 = 1;
        timeCost3 = 1;
    }
    public void AliBabasWeeBooties()
    {
        currentSprite = wepIstances.demomanPrimaries[5];
        ammoInMag = 0;
        ammoInReserve = 0;
        numOfActions = 1;

        wepDescription1 = "Pipe Launch: Launch the greande at a steep angle, hitting further away and slightly damage one adjacent slot if successful";
        wepDescription2 = "Pipe Lob: Launch the grenade at a shallow angle, hitting close angles and slightly damage one adjacent slot if successful";
        wepDescription3 = "Magical Shoes: (PASSIVE) Increases maximum health by 25 and other benefits when a sheild is equipped";

        timeCost1 = 1;
        timeCost2 = 1;
        timeCost3 = 0;
    }
    public void LooseCannon()
    {
        currentSprite = wepIstances.demomanPrimaries[1];
        ammoInMag = 4;
        ammoInReserve = 16;
        numOfActions = 2;

        wepDescription1 = "Cannon Charge: Spend X time tokens to charge up and lower the distance before it explodes, propperly timed shots deal mini-crit damage";
        wepDescription2 = "Cannon Jump: Overload the Loose Cannon and launch yourself into the AIR for 2 turns at the cost of a large amount of health";
        wepDescription3 = "Throw: Throw the guillotine at an enemy, causing bleeding for 2 turns";

        timeCost1 = 10;
        timeCost2 = 2;
        timeCost3 = 1;
    }
    public void BASEJumper()
    {
        currentSprite = wepIstances.demomanPrimaries[4];
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
    public void IronBomber()
    {
        currentSprite = wepIstances.demomanPrimaries[3];
        ammoInMag = 4;
        ammoInReserve = 16;
        numOfActions = 2;

        wepDescription1 = "Pipe Launch: Launch the greande at a steep angle, hitting further away";
        wepDescription2 = "Pipe Lob: Launch the grenade at a shallow angle, hitting close angles";
        wepDescription3 = "Throw: Throw the guillotine at an enemy, causing bleeding for 2 turns";

        timeCost1 = 1;
        timeCost2 = 1;
        timeCost3 = 1;
    }

    //**********************************************************************************************************************************
    //SECONDARY WEAPONS
    //**********************************************************************************************************************************

    public void StickybombLauncher()
    {
        currentSprite = wepIstances.demomanSecondaries[0];
        ammoInMag = 8;
        ammoInReserve = 24;
        numOfActions = 3;
        maxStickies = 8;

        wepDescription1 = "Launcher Charge: Spend X time tokens to charge the launcher to land X slots away";
        wepDescription2 = "Sticky Jump: Sacrifice some health to launch yourself into the AIR for 2-4 turns";
        wepDescription3 = "Detonate: Blows up all stickies on the floor";

        timeCost1 = 1;
        timeCost2 = 3;
        timeCost3 = 4;
    }
    public void CharginTarge()
    {
        currentSprite = wepIstances.demomanSecondaries[1];
        ammoInMag = 100;
        ammoInReserve = 100;
        numOfActions = 3;

        wepDescription1 = "Shield Bash: Charge into an enemy that is in your path and deal some damage";
        wepDescription2 = "Demo Charge: Charge into the enemy and swing your melee weapon at them, dealing critical damage if from far away and mini-crit damage if any closer";
        wepDescription3 = "Shield Protection: (PASSIVE) Providees some resistance to fire and explosive damage";

        timeCost1 = 1;
        timeCost2 = 3;
        timeCost3 = 0;
    }
    public void ScottishResistance()
    {
        currentSprite = wepIstances.demomanSecondaries[5];
        ammoInMag = 8;
        ammoInReserve = 36;
        numOfActions = 3;
        maxStickies = 14;

        wepDescription1 = "Launcher Charge: Spend X time tokens to charge the launcher to land X slots away";
        wepDescription2 = "Sticky Jump: Sacrifice some health to launch yourself into the AIR for 2-4 turns";
        wepDescription3 = "Detonate: Blows up all stickies on the floor";

        timeCost1 = 1;
        timeCost2 = 3;
        timeCost3 = 4;
    }
    public void StickyJumper()
    {
        currentSprite = wepIstances.demomanSecondaries[3];
        ammoInMag = 8;
        ammoInReserve = 72;
        numOfActions = 2;
        maxStickies = 2;

        wepDescription1 = "Sticky Jump Low: Use 1 sticky bomb to launch yourself into the AIR for 1-2 turns";
        wepDescription2 = "Sticky Jump High: Use 2 sticky bombs to launch yourself into the AIR for 2-4 turns";
        wepDescription3 = "Sticky Jump:";

        timeCost1 = 2;
        timeCost2 = 4;
        timeCost3 = 4;
    }
    public void SplendidScreen()
    {
        currentSprite = wepIstances.demomanSecondaries[4];
        ammoInMag = 100;
        ammoInReserve = 100;
        numOfActions = 2;

        wepDescription1 = "Shield Bash: Charge into an enemy that is in your path and deal high damage";
        wepDescription2 = "Demo Charge: Charge into the enemy and swing your melee weapon at them, dealing critical damage if from far away and mini-crit damage if any closer";
        wepDescription3 = "Shield Protection: (PASSIVE) Providees some resistance to fire and explosive damage";

        timeCost1 = 1;
        timeCost2 = 3;
        timeCost3 = 4;
    }
    public void TideTurner()
    {
        currentSprite = wepIstances.demomanSecondaries[2];
        ammoInMag = 100;
        ammoInReserve = 100;
        numOfActions = 2;

        wepDescription1 = "Shield Bash: Charge into an enemy that is in your path and deal some damage";
        wepDescription2 = "Demo Charge: Charge into the enemy and swing your melee weapon at them, dealing mini-crit damage no matter the distance";
        wepDescription3 = "Shield Protection: (PASSIVE) Providees some resistance to fire and explosive damage";

        timeCost1 = 1;
        timeCost2 = 3;
        timeCost3 = 4;
    }
    public void QuickiebombLauncher()
    {
        currentSprite = wepIstances.demomanSecondaries[6];
        ammoInMag = 4;
        ammoInReserve = 24;
        numOfActions = 3;
        maxStickies = 8;

        wepDescription1 = "Launcher Charge: Spend X time tokens to charge the launcher to land X slots away";
        wepDescription2 = "Sticky Jump: Sacrifice some health to launch yourself into the AIR for 2-4 turns";
        wepDescription3 = "Detonate: Blows up all stickies on the floor";

        timeCost1 = 1;
        timeCost2 = 3;
        timeCost3 = 4;

    }

    //**********************************************************************************************************************************
    //MELEE WEAPONS
    //**********************************************************************************************************************************
    public void Bottle()
    {
        currentSprite = wepIstances.demomanMelees[0];
        numOfActions = 1;

        wepDescription1 = "Throw: Randomly fire innacurate pistol at enemy, hitting 1-6 times";
        wepDescription2 = "Pepper: Fire your shotgun from moderate range, hopefully finishing off weak opponents";
        wepDescription3 = "Slice Em Up: Hit the enemy in front of you for moderate damage";

        timeCost1 = 1;
        timeCost2 = 1;
        timeCost3 = 1;
    }
    public void Eyelander()
    {
        currentSprite = wepIstances.demomanMelees[7];
        ammoInMag = 0;
        ammoInReserve = 0;
        numOfActions = 1;

        wepDescription1 = "Throw: Randomly fire innacurate pistol at enemy, hitting 1-6 times";
        wepDescription2 = "Pepper: Fire your shotgun from moderate range, hopefully finishing off weak opponents";
        wepDescription3 = "Slice Em Up: Hit the enemy up to two slots in front of you for moderate damage, sucessful kills increase movement speed and maximum health";

        timeCost1 = 1;
        timeCost2 = 1;
        timeCost3 = 1;
    }
    public void PainTrain()
    {
        currentSprite = wepIstances.demomanMelees[5];
        numOfActions = 1;

        wepDescription1 = "Throw: Randomly fire innacurate pistol at enemy, hitting 1-6 times";
        wepDescription2 = "Pepper: Fire your shotgun from moderate range, hopefully finishing off weak opponents";
        wepDescription3 = "Slice Em Up: Hit the enemy in front of you for moderate damage";

        timeCost1 = 1;
        timeCost2 = 1;
        timeCost3 = 1;
    }
    public void ScotsmansSkullcutter()
    {
        currentSprite = wepIstances.demomanMelees[2];
        numOfActions = 1;

        wepDescription1 = "Throw: Randomly fire innacurate pistol at enemy, hitting 1-6 times";
        wepDescription2 = "Pepper: Fire your shotgun from moderate range, hopefully finishing off weak opponents";
        wepDescription3 = "Slice Em Up: Hit the enemy up to two slots in front of you for high damage";

        timeCost1 = 1;
        timeCost2 = 1;
        timeCost3 = 1;
    }
    public void ClaidheamhMor()
    {
        currentSprite = wepIstances.demomanMelees[3];
        numOfActions = 1;

        wepDescription1 = "Throw: Randomly fire innacurate pistol at enemy, hitting 1-6 times";
        wepDescription2 = "Pepper: Fire your shotgun from moderate range, hopefully finishing off weak opponents";
        wepDescription3 = "Slice Em Up: Hit the enemy up to two slots in front of you for moderate damage";

        timeCost1 = 1;
        timeCost2 = 1;
        timeCost3 = 1;
    }
    public void UllapoolCaber()
    {
        currentSprite = wepIstances.demomanMelees[1];
        ammoInMag = 1;
        ammoInReserve = 1;
        numOfActions = 1;

        wepDescription1 = "Throw: Randomly fire innacurate pistol at enemy, hitting 1-6 times";
        wepDescription2 = "Pepper: Fire your shotgun from moderate range, hopefully finishing off weak opponents";
        wepDescription3 = "Slice Em Up: Hit the enemy in front of you, exploding the grenade and dealing high damage to self and enemy. Next swings are much weaker";

        timeCost1 = 1;
        timeCost2 = 1;
        timeCost3 = 1;
    }
    public void HalfZatoichi()
    {
        currentSprite = wepIstances.demomanMelees[6];
        numOfActions = 1;

        wepDescription1 = "Throw: Randomly fire innacurate pistol at enemy, hitting 1-6 times";
        wepDescription2 = "Pepper: Fire your shotgun from moderate range, hopefully finishing off weak opponents";
        wepDescription3 = "Slice Em Up: Hit the enemy up to two slots in front of you for moderate damage, successful kills heal half of your base health";

        timeCost1 = 1;
        timeCost2 = 1;
        timeCost3 = 1;
    }
    public void PersianPersuader()
    {
        currentSprite = wepIstances.demomanMelees[4];
        numOfActions = 1;

        wepDescription1 = "Throw: Randomly fire innacurate pistol at enemy, hitting 1-6 times";
        wepDescription2 = "Pepper: Fire your shotgun from moderate range, hopefully finishing off weak opponents";
        wepDescription3 = "Slice Em Up: Hit the enemy in front of you for moderate damage, on successful kill recharge 20% of charge";

        timeCost1 = 1;
        timeCost2 = 1;
        timeCost3 = 1;
    }
}
