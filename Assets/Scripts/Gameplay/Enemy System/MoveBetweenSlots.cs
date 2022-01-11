using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class MoveBetweenSlots : MonoBehaviour
{
    public SlotChecker slotInstance;
    
    public GameObject leftButton;
    public GameObject rightButton;

    public CharacterHealth[] characterHealthInstance;
    public PrimarySlot[] primarySlotInstance;
    public SecondarySlot[] secondarySlotInstance;
    public MeleeSlot[] meleeSlotInstance;
    public ExtraSlot[] extraSlotInstance;

    public int movingCharacter;
    public int slotMovedTo;

    public bool canLeft;
    public bool canRight;

    public bool buttonOnce;

    private CharacterHealth tempHealth;
    private PrimarySlot tempPrimary;
    private SecondarySlot tempSecondary;
    private MeleeSlot tempMelee;
    private ExtraSlot tempExtra;

    // Start is called before the first frame update
    void Start()
    {
        canLeft = false;
        canRight = false;

        buttonOnce = false;
    }

    // Update is called once per frame
    void Update()
    {
        CheckMovement();
        if (!canLeft)
        {
            leftButton.SetActive(false);
        }
        else
        {
            leftButton.SetActive(true);
        }
        
        if (!canRight)
        {
            rightButton.SetActive(false);
        }
        else
        {
            rightButton.SetActive(true);
        }
    }

    public void MoveLeft()
    {
        CheckMovement();
        if (canLeft)
        {
            slotMovedTo = movingCharacter + 1;
            SwapCharacterHealth();
            if (movingCharacter >=4 && movingCharacter <= 7 && !buttonOnce)
            {
                movingCharacter -= 4;
                slotMovedTo = movingCharacter + 1;
                
                SwapPrimaries();
                SwapSecondaries();
                SwapMelees();
                SwapExtra();

                buttonOnce = true;
            }
        }
    }
    
    public void MoveRight()
    {
        CheckMovement();
        if (canRight)
        {
            slotMovedTo = movingCharacter - 1;
            SwapCharacterHealth();
            if (movingCharacter >= 4 && movingCharacter <= 7 && !buttonOnce)
            {
                movingCharacter -= 4;
                slotMovedTo = movingCharacter - 1;
                
                SwapPrimaries();
                SwapSecondaries();
                SwapMelees();
                SwapExtra();

                buttonOnce = true;
            }
        }
    }

    public void CheckMovement()
    {
        switch (slotInstance.currentTag) 
        {
            case "E4":
                movingCharacter = 0;
                break;
            case "E3":
                movingCharacter = 1;
                break;
            case "E2":
                movingCharacter = 2;
                break;
            case "E1":
                movingCharacter = 3;
                break;
            case "C1":
                movingCharacter = 4;
                break;
            case "C2":
                movingCharacter = 5;
                break;
            case "C3":
                movingCharacter = 6;
                break;
            case "C4":
                movingCharacter = 7;
                break;
        }

        //Debug.Log(slotInstance.currentTag);

        switch (movingCharacter)
        {
            case 0:
                canLeft = true;
                canRight = false;
                break;
            case 1:
                canLeft = true;
                canRight = true;
                break;
            case 2:
                canLeft = true;
                canRight = true;
                break;
            case 3:
                canLeft = false;
                canRight = true;
                break;
            case 4:
                canLeft = true;
                canRight = false;
                break;
            case 5:
                canLeft = true;
                canRight = true;
                break;
            case 6:
                canLeft = true;
                canRight = true;
                break;
            case 7:
                canLeft = false;
                canRight = true;
                break;
        }
    }

    public void SwapCharacterHealth()
    {
        tempHealth.spawnBox.sprite = characterHealthInstance[movingCharacter].spawnBox.sprite;
        tempHealth.baseHealth = characterHealthInstance[movingCharacter].baseHealth;
        tempHealth.baseSpeed = characterHealthInstance[movingCharacter].baseSpeed;
        tempHealth.baseDodgeChance = characterHealthInstance[movingCharacter].baseDodgeChance;
        tempHealth.baseMovementCount = characterHealthInstance[movingCharacter].baseMovementCount;
        tempHealth.characterName = characterHealthInstance[movingCharacter].characterName;
        tempHealth.switchedClasses = characterHealthInstance[movingCharacter].switchedClasses;
        tempHealth.dieOnce = characterHealthInstance[movingCharacter].dieOnce;

        characterHealthInstance[movingCharacter].spawnBox.sprite = characterHealthInstance[slotMovedTo].spawnBox.sprite;
        characterHealthInstance[movingCharacter].baseHealth = characterHealthInstance[slotMovedTo].baseHealth;
        characterHealthInstance[movingCharacter].baseSpeed = characterHealthInstance[slotMovedTo].baseSpeed;
        characterHealthInstance[movingCharacter].baseDodgeChance = characterHealthInstance[slotMovedTo].baseDodgeChance;
        characterHealthInstance[movingCharacter].baseMovementCount = characterHealthInstance[slotMovedTo].baseMovementCount;
        characterHealthInstance[movingCharacter].characterName = characterHealthInstance[slotMovedTo].characterName;
        characterHealthInstance[movingCharacter].switchedClasses = characterHealthInstance[slotMovedTo].switchedClasses;
        characterHealthInstance[movingCharacter].dieOnce = characterHealthInstance[slotMovedTo].dieOnce;

        characterHealthInstance[slotMovedTo].spawnBox.sprite = tempHealth.spawnBox.sprite;
        characterHealthInstance[slotMovedTo].baseHealth = tempHealth.baseHealth;
        characterHealthInstance[slotMovedTo].baseSpeed = tempHealth.baseSpeed;
        characterHealthInstance[slotMovedTo].baseDodgeChance = tempHealth.baseDodgeChance;
        characterHealthInstance[slotMovedTo].baseMovementCount = tempHealth.baseMovementCount;
        characterHealthInstance[slotMovedTo].characterName = tempHealth.characterName;
        characterHealthInstance[slotMovedTo].switchedClasses = tempHealth.switchedClasses;
        characterHealthInstance[slotMovedTo].dieOnce = tempHealth.dieOnce;
    }

    public void SwapPrimaries()
    {
        tempPrimary.numOfActions = primarySlotInstance[movingCharacter].numOfActions;
        tempPrimary.turnCoolDown = primarySlotInstance[movingCharacter].turnCoolDown;
        tempPrimary.reloadSpeed = primarySlotInstance[movingCharacter].reloadSpeed;
        tempPrimary.timeCost1 = primarySlotInstance[movingCharacter].timeCost1;
        tempPrimary.timeCost2 = primarySlotInstance[movingCharacter].timeCost2;
        tempPrimary.timeCost3 = primarySlotInstance[movingCharacter].timeCost3;
        tempPrimary.wepDescription1 = primarySlotInstance[movingCharacter].wepDescription1;
        tempPrimary.wepDescription2 = primarySlotInstance[movingCharacter].wepDescription2;
        tempPrimary.wepDescription3 = primarySlotInstance[movingCharacter].wepDescription3;
        tempPrimary.ammoInMag = primarySlotInstance[movingCharacter].ammoInMag;
        tempPrimary.ammoInReserve = primarySlotInstance[movingCharacter].ammoInReserve;
        tempPrimary.totalAmmo = primarySlotInstance[movingCharacter].totalAmmo;
        tempPrimary.didStockify = primarySlotInstance[movingCharacter].didStockify;
        tempPrimary.slotCheckOnce = primarySlotInstance[movingCharacter].slotCheckOnce;
        tempPrimary.currentClassName = primarySlotInstance[movingCharacter].currentClassName;

        primarySlotInstance[movingCharacter].numOfActions = primarySlotInstance[slotMovedTo].numOfActions;
        primarySlotInstance[movingCharacter].turnCoolDown = primarySlotInstance[slotMovedTo].turnCoolDown;
        primarySlotInstance[movingCharacter].reloadSpeed = primarySlotInstance[slotMovedTo].reloadSpeed;
        primarySlotInstance[movingCharacter].timeCost1 = primarySlotInstance[slotMovedTo].timeCost1;
        primarySlotInstance[movingCharacter].timeCost2 = primarySlotInstance[slotMovedTo].timeCost2;
        primarySlotInstance[movingCharacter].timeCost3 = primarySlotInstance[slotMovedTo].timeCost3;
        primarySlotInstance[movingCharacter].wepDescription1 = primarySlotInstance[slotMovedTo].wepDescription1;
        primarySlotInstance[movingCharacter].wepDescription2 = primarySlotInstance[slotMovedTo].wepDescription2;
        primarySlotInstance[movingCharacter].wepDescription3 = primarySlotInstance[slotMovedTo].wepDescription3;
        primarySlotInstance[movingCharacter].ammoInMag = primarySlotInstance[slotMovedTo].ammoInMag;
        primarySlotInstance[movingCharacter].ammoInReserve = primarySlotInstance[slotMovedTo].ammoInReserve;
        primarySlotInstance[movingCharacter].totalAmmo = primarySlotInstance[slotMovedTo].totalAmmo;
        primarySlotInstance[movingCharacter].didStockify = primarySlotInstance[slotMovedTo].didStockify;
        primarySlotInstance[movingCharacter].slotCheckOnce = primarySlotInstance[slotMovedTo].slotCheckOnce;
        primarySlotInstance[movingCharacter].currentClassName = primarySlotInstance[slotMovedTo].currentClassName;

        primarySlotInstance[slotMovedTo].numOfActions = tempPrimary.numOfActions;
        primarySlotInstance[slotMovedTo].turnCoolDown = tempPrimary.turnCoolDown;
        primarySlotInstance[slotMovedTo].reloadSpeed = tempPrimary.reloadSpeed;
        primarySlotInstance[slotMovedTo].timeCost1 = tempPrimary.timeCost1;
        primarySlotInstance[slotMovedTo].timeCost2 = tempPrimary.timeCost2;
        primarySlotInstance[slotMovedTo].timeCost3 = tempPrimary.timeCost3;
        primarySlotInstance[slotMovedTo].wepDescription1 = tempPrimary.wepDescription1;
        primarySlotInstance[slotMovedTo].wepDescription2 = tempPrimary.wepDescription2;
        primarySlotInstance[slotMovedTo].wepDescription3 = tempPrimary.wepDescription3;
        primarySlotInstance[slotMovedTo].ammoInMag = tempPrimary.ammoInMag;
        primarySlotInstance[slotMovedTo].ammoInReserve = tempPrimary.ammoInReserve;
        primarySlotInstance[slotMovedTo].totalAmmo = tempPrimary.totalAmmo;
        primarySlotInstance[slotMovedTo].didStockify = tempPrimary.didStockify;
        primarySlotInstance[slotMovedTo].slotCheckOnce = tempPrimary.slotCheckOnce;
        primarySlotInstance[slotMovedTo].currentClassName = tempPrimary.currentClassName;
    }

    public void SwapSecondaries()
    {
        tempSecondary.numOfActions = secondarySlotInstance[movingCharacter].numOfActions;
        tempSecondary.turnCoolDown = secondarySlotInstance[movingCharacter].turnCoolDown;
        tempSecondary.reloadSpeed = secondarySlotInstance[movingCharacter].reloadSpeed;
        tempSecondary.timeCost1 = secondarySlotInstance[movingCharacter].timeCost1;
        tempSecondary.timeCost2 = secondarySlotInstance[movingCharacter].timeCost2;
        tempSecondary.timeCost3 = secondarySlotInstance[movingCharacter].timeCost3;
        tempSecondary.wepDescription1 = secondarySlotInstance[movingCharacter].wepDescription1;
        tempSecondary.wepDescription2 = secondarySlotInstance[movingCharacter].wepDescription2;
        tempSecondary.wepDescription3 = secondarySlotInstance[movingCharacter].wepDescription3;
        tempSecondary.ammoInMag = secondarySlotInstance[movingCharacter].ammoInMag;
        tempSecondary.ammoInReserve = secondarySlotInstance[movingCharacter].ammoInReserve;
        tempSecondary.totalAmmo = secondarySlotInstance[movingCharacter].totalAmmo;
        tempSecondary.didStockify = secondarySlotInstance[movingCharacter].didStockify;
        tempSecondary.slotCheckOnce = secondarySlotInstance[movingCharacter].slotCheckOnce;
        tempSecondary.currentClassName = secondarySlotInstance[movingCharacter].currentClassName;

        secondarySlotInstance[movingCharacter].numOfActions = secondarySlotInstance[slotMovedTo].numOfActions;
        secondarySlotInstance[movingCharacter].turnCoolDown = secondarySlotInstance[slotMovedTo].turnCoolDown;
        secondarySlotInstance[movingCharacter].reloadSpeed = secondarySlotInstance[slotMovedTo].reloadSpeed;
        secondarySlotInstance[movingCharacter].timeCost1 = secondarySlotInstance[slotMovedTo].timeCost1;
        secondarySlotInstance[movingCharacter].timeCost2 = secondarySlotInstance[slotMovedTo].timeCost2;
        secondarySlotInstance[movingCharacter].timeCost3 = secondarySlotInstance[slotMovedTo].timeCost3;
        secondarySlotInstance[movingCharacter].wepDescription1 = secondarySlotInstance[slotMovedTo].wepDescription1;
        secondarySlotInstance[movingCharacter].wepDescription2 = secondarySlotInstance[slotMovedTo].wepDescription2;
        secondarySlotInstance[movingCharacter].wepDescription3 = secondarySlotInstance[slotMovedTo].wepDescription3;
        secondarySlotInstance[movingCharacter].ammoInMag = secondarySlotInstance[slotMovedTo].ammoInMag;
        secondarySlotInstance[movingCharacter].ammoInReserve = secondarySlotInstance[slotMovedTo].ammoInReserve;
        secondarySlotInstance[movingCharacter].totalAmmo = secondarySlotInstance[slotMovedTo].totalAmmo;
        secondarySlotInstance[movingCharacter].didStockify = secondarySlotInstance[slotMovedTo].didStockify;
        secondarySlotInstance[movingCharacter].slotCheckOnce = secondarySlotInstance[slotMovedTo].slotCheckOnce;
        secondarySlotInstance[movingCharacter].currentClassName = secondarySlotInstance[slotMovedTo].currentClassName;

        secondarySlotInstance[slotMovedTo].numOfActions = tempSecondary.numOfActions;
        secondarySlotInstance[slotMovedTo].turnCoolDown = tempSecondary.turnCoolDown;
        secondarySlotInstance[slotMovedTo].reloadSpeed = tempSecondary.reloadSpeed;
        secondarySlotInstance[slotMovedTo].timeCost1 = tempSecondary.timeCost1;
        secondarySlotInstance[slotMovedTo].timeCost2 = tempSecondary.timeCost2;
        secondarySlotInstance[slotMovedTo].timeCost3 = tempSecondary.timeCost3;
        secondarySlotInstance[slotMovedTo].wepDescription1 = tempSecondary.wepDescription1;
        secondarySlotInstance[slotMovedTo].wepDescription2 = tempSecondary.wepDescription2;
        secondarySlotInstance[slotMovedTo].wepDescription3 = tempSecondary.wepDescription3;
        secondarySlotInstance[slotMovedTo].ammoInMag = tempSecondary.ammoInMag;
        secondarySlotInstance[slotMovedTo].ammoInReserve = tempSecondary.ammoInReserve;
        secondarySlotInstance[slotMovedTo].totalAmmo = tempSecondary.totalAmmo;
        secondarySlotInstance[slotMovedTo].didStockify = tempSecondary.didStockify;
        secondarySlotInstance[slotMovedTo].slotCheckOnce = tempSecondary.slotCheckOnce;
        secondarySlotInstance[slotMovedTo].currentClassName = tempSecondary.currentClassName;
    }

    public void SwapMelees()
    {
        tempMelee.numOfActions = meleeSlotInstance[movingCharacter].numOfActions;
        tempMelee.turnCoolDown = meleeSlotInstance[movingCharacter].turnCoolDown;
        tempMelee.reloadSpeed = meleeSlotInstance[movingCharacter].reloadSpeed;
        tempMelee.timeCost1 = meleeSlotInstance[movingCharacter].timeCost1;
        tempMelee.timeCost2 = meleeSlotInstance[movingCharacter].timeCost2;
        tempMelee.timeCost3 = meleeSlotInstance[movingCharacter].timeCost3;
        tempMelee.wepDescription1 = meleeSlotInstance[movingCharacter].wepDescription1;
        tempMelee.wepDescription2 = meleeSlotInstance[movingCharacter].wepDescription2;
        tempMelee.wepDescription3 = meleeSlotInstance[movingCharacter].wepDescription3;
        tempMelee.ammoInMag = meleeSlotInstance[movingCharacter].ammoInMag;
        tempMelee.ammoInReserve = meleeSlotInstance[movingCharacter].ammoInReserve;
        tempMelee.totalAmmo = meleeSlotInstance[movingCharacter].totalAmmo;
        tempMelee.didStockify = meleeSlotInstance[movingCharacter].didStockify;
        tempMelee.slotCheckOnce = meleeSlotInstance[movingCharacter].slotCheckOnce;
        tempMelee.currentClassName = meleeSlotInstance[movingCharacter].currentClassName;

        meleeSlotInstance[movingCharacter].numOfActions = meleeSlotInstance[slotMovedTo].numOfActions;
        meleeSlotInstance[movingCharacter].turnCoolDown = meleeSlotInstance[slotMovedTo].turnCoolDown;
        meleeSlotInstance[movingCharacter].reloadSpeed = meleeSlotInstance[slotMovedTo].reloadSpeed;
        meleeSlotInstance[movingCharacter].timeCost1 = meleeSlotInstance[slotMovedTo].timeCost1;
        meleeSlotInstance[movingCharacter].timeCost2 = meleeSlotInstance[slotMovedTo].timeCost2;
        meleeSlotInstance[movingCharacter].timeCost3 = meleeSlotInstance[slotMovedTo].timeCost3;
        meleeSlotInstance[movingCharacter].wepDescription1 = meleeSlotInstance[slotMovedTo].wepDescription1;
        meleeSlotInstance[movingCharacter].wepDescription2 = meleeSlotInstance[slotMovedTo].wepDescription2;
        meleeSlotInstance[movingCharacter].wepDescription3 = meleeSlotInstance[slotMovedTo].wepDescription3;
        meleeSlotInstance[movingCharacter].ammoInMag = meleeSlotInstance[slotMovedTo].ammoInMag;
        meleeSlotInstance[movingCharacter].ammoInReserve = meleeSlotInstance[slotMovedTo].ammoInReserve;
        meleeSlotInstance[movingCharacter].totalAmmo = meleeSlotInstance[slotMovedTo].totalAmmo;
        meleeSlotInstance[movingCharacter].didStockify = meleeSlotInstance[slotMovedTo].didStockify;
        meleeSlotInstance[movingCharacter].slotCheckOnce = meleeSlotInstance[slotMovedTo].slotCheckOnce;
        meleeSlotInstance[movingCharacter].currentClassName = meleeSlotInstance[slotMovedTo].currentClassName;

        meleeSlotInstance[slotMovedTo].numOfActions = tempMelee.numOfActions;
        meleeSlotInstance[slotMovedTo].turnCoolDown = tempMelee.turnCoolDown;
        meleeSlotInstance[slotMovedTo].reloadSpeed = tempMelee.reloadSpeed;
        meleeSlotInstance[slotMovedTo].timeCost1 = tempMelee.timeCost1;
        meleeSlotInstance[slotMovedTo].timeCost2 = tempMelee.timeCost2;
        meleeSlotInstance[slotMovedTo].timeCost3 = tempMelee.timeCost3;
        meleeSlotInstance[slotMovedTo].wepDescription1 = tempMelee.wepDescription1;
        meleeSlotInstance[slotMovedTo].wepDescription2 = tempMelee.wepDescription2;
        meleeSlotInstance[slotMovedTo].wepDescription3 = tempMelee.wepDescription3;
        meleeSlotInstance[slotMovedTo].ammoInMag = tempMelee.ammoInMag;
        meleeSlotInstance[slotMovedTo].ammoInReserve = tempMelee.ammoInReserve;
        meleeSlotInstance[slotMovedTo].totalAmmo = tempMelee.totalAmmo;
        meleeSlotInstance[slotMovedTo].didStockify = tempMelee.didStockify;
        meleeSlotInstance[slotMovedTo].slotCheckOnce = tempMelee.slotCheckOnce;
        meleeSlotInstance[slotMovedTo].currentClassName = tempMelee.currentClassName;
    }

    public void SwapExtra()
    {

    }
}
