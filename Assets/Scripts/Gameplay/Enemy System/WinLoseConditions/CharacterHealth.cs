using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class CharacterHealth : MonoBehaviour
{
    public Image spawnBox;
    public Sprite[] classBodyLists;

    public ScoutData scoutInstance;
    public SoldierData soldierInstance;
    public PyroData pyroInstance;
    public DemomanData demoInstance;
    public HeavyData heavyInstance;
    public EngineerData engineerInstance;
    public MedicData medicInstance;
    public SniperData sniperInstance;
    public SpyData spyInstance;
    public BuildingData buildingInstance;

    public int baseHealth;
    public int baseSpeed;
    public int baseDodgeChance;
    public int baseMovementCount;

    public WhoDied dyingInstance;
    public bool dieOnce;
    public bool switchedClasses;
    public string className;

    public TextMeshProUGUI health;
    public TextMeshProUGUI speed;
    public TextMeshProUGUI dodgeChance;
    public TextMeshProUGUI movementCount;
    public TextMeshProUGUI characterName;

    // Start is called before the first frame update
    void Start()
    {
        switchedClasses = false;
        dieOnce = false;
    }

    // Update is called once per frame
    void Update()
    {
        switch (className)
        {
            case "Scout":
                if (!switchedClasses)
                {
                    spawnBox.sprite = classBodyLists[0];
                    baseHealth = scoutInstance.baseHealth;
                    baseSpeed = scoutInstance.baseSpeed;
                    baseDodgeChance = scoutInstance.baseDodgeChance;
                    baseMovementCount = scoutInstance.baseMovementCount;
                    switchedClasses = true;
                }
                
                break;
            case "Soldier":
                if (!switchedClasses)
                {
                    spawnBox.sprite = classBodyLists[1];
                    baseHealth = soldierInstance.baseHealth;
                    baseSpeed = soldierInstance.baseSpeed;
                    baseDodgeChance = soldierInstance.baseDodgeChance;
                    baseMovementCount = soldierInstance.baseMovementCount;
                    switchedClasses = true;
                }
                
                break;
            case "Pyro":
                if (!switchedClasses)
                {
                    spawnBox.sprite = classBodyLists[2];
                    baseHealth = pyroInstance.baseHealth;
                    baseSpeed = pyroInstance.baseSpeed;
                    baseDodgeChance = pyroInstance.baseDodgeChance;
                    baseMovementCount = pyroInstance.baseMovementCount;
                    switchedClasses = true;
                }
                
                break;
            case "Demoman":
                if (!switchedClasses)
                {
                    spawnBox.sprite = classBodyLists[3];
                    baseHealth = demoInstance.baseHealth;
                    baseSpeed = demoInstance.baseSpeed;
                    baseDodgeChance = demoInstance.baseDodgeChance;
                    baseMovementCount = demoInstance.baseMovementCount;
                    switchedClasses = true;
                }
                
                break;
            case "Heavy":
                if (!switchedClasses)
                {
                    spawnBox.sprite = classBodyLists[4];
                    baseHealth = heavyInstance.baseHealth;
                    baseSpeed = heavyInstance.baseSpeed;
                    baseDodgeChance = heavyInstance.baseDodgeChance;
                    baseMovementCount = heavyInstance.baseMovementCount;
                    switchedClasses = true;
                }
                
                break;
            case "Engineer":
                if (!switchedClasses)
                {
                    spawnBox.sprite = classBodyLists[5];
                    baseHealth = engineerInstance.baseHealth;
                    baseSpeed = engineerInstance.baseSpeed;
                    baseDodgeChance = engineerInstance.baseDodgeChance;
                    baseMovementCount = engineerInstance.baseMovementCount;
                    switchedClasses = true;
                }
                
                break;
            case "Medic":
                if (!switchedClasses)
                {
                    spawnBox.sprite = classBodyLists[6];
                    baseHealth = medicInstance.baseHealth;
                    baseSpeed = medicInstance.baseSpeed;
                    baseDodgeChance = medicInstance.baseDodgeChance;
                    baseMovementCount = medicInstance.baseMovementCount;
                    switchedClasses = true;
                }
                
                break;
            case "Sniper":
                if (!switchedClasses)
                {
                    spawnBox.sprite = classBodyLists[7];
                    baseHealth = sniperInstance.baseHealth;
                    baseSpeed = sniperInstance.baseSpeed;
                    baseDodgeChance = sniperInstance.baseDodgeChance;
                    baseMovementCount = sniperInstance.baseMovementCount;
                    switchedClasses = true;
                }
                
                break;
            case "Spy":
                if (!switchedClasses)
                {
                    spawnBox.sprite = classBodyLists[8];
                    baseHealth = spyInstance.baseHealth;
                    baseSpeed = spyInstance.baseSpeed;
                    baseDodgeChance = spyInstance.baseDodgeChance;
                    baseMovementCount = spyInstance.baseMovementCount;
                    switchedClasses = true;
                }
                
                break;
        }
        
    }

    private void LateUpdate()
    {
        if (baseHealth <= 0 && !dieOnce)
        {
            Die();
            dieOnce = true;
            spawnBox.gameObject.SetActive(false);
        }
    }

    public void TakeDamage(int damageNumber)
    {
        baseHealth -= damageNumber;
    }

    public void Die()
    {
        if (tag == "C1" || tag == "C2" || tag == "C3" || tag == "C4")
        {
            dyingInstance.AllyDied();
        }
        else if (tag == "E1" || tag == "E2" || tag == "E3" || tag == "E4")
        {
            dyingInstance.EnemyDied();
        }
    }

    public void SwitchClasses(string differentClass)
    {
        if (differentClass == "Scout" || differentClass == "Soldier" || differentClass == "Pyro" ||
            differentClass == "Demoman" || differentClass == "Heavy" || differentClass == "Engineer" ||
            differentClass == "Medic" || differentClass == "Sniper" || differentClass == "Spy")
        {
            className = differentClass;
        }
    }

    public void ShowStats()
    {
        health.text = baseHealth.ToString();
        speed.text = baseSpeed.ToString();
        dodgeChance.text = baseDodgeChance.ToString() + "%";
        movementCount.text = baseMovementCount.ToString();
        characterName.text = className;
    }
}
