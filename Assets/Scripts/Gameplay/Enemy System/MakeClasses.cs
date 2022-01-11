using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class MakeClasses : MonoBehaviour
{
    public ListOfClassWeapons listWepInstance;

    public ScoutWepStats scoutWepInstance;
    public SoldierWepStats soldierWepInstance;
    public PyroWepStats pyroWepInstance;
    public DemoWepStats demoWepInstance;
    public HeavyWepStats heavyWepInstance;
    public EngiWepStats engiWepInstance;
    public MedicWepStats medicWepInstance;
    public SniperWepStats sniperWepInstance;
    public SpyWepStats spyWepInstance;

    public CharacterHealth[] battleSlots;

    public PrimarySlot[] primarySlots;
    public SecondarySlot[] secondarySlots;
    public MeleeSlot[] meleeSlots;
    public ExtraSlot[] extraSlots;

    public int sizeLimit;

    // Start is called before the first frame update
    void Start()
    {
        sizeLimit = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void AddScout(int slotPosition)
    {
        if (sizeLimit >= 4)
        {
            switch (slotPosition)
            {
                case 0:
                    battleSlots[slotPosition].className = "Scout";
                    break;
                case 1:
                    battleSlots[slotPosition].className = "Scout";
                    break;
                case 2:
                    battleSlots[slotPosition].className = "Scout";
                    break;
                case 3:
                    battleSlots[slotPosition].className = "Scout";
                    break;
                case 4:
                    battleSlots[slotPosition].className = "Scout";
                    sizeLimit++;
                    break;
                case 5:
                    battleSlots[slotPosition].className = "Scout";
                    sizeLimit++;
                    break;
                case 6:
                    battleSlots[slotPosition].className = "Scout";
                    sizeLimit++;
                    break;
                case 7:
                    battleSlots[slotPosition].className = "Scout";
                    sizeLimit++;
                    break;  
            }
        }
    }

    public void AddSoldier(int slotPosition)
    {
        if (sizeLimit >= 4)
        {
            switch (slotPosition)
            {
                case 0:
                    battleSlots[slotPosition].className = "Soldier";
                    break;
                case 1:
                    battleSlots[slotPosition].className = "Soldier";
                    break;
                case 2:
                    battleSlots[slotPosition].className = "Soldier";
                    break;
                case 3:
                    battleSlots[slotPosition].className = "Soldier";
                    break;
                case 4:
                    battleSlots[slotPosition].className = "Soldier";
                    sizeLimit++;
                    break;
                case 5:
                    battleSlots[slotPosition].className = "Soldier";
                    sizeLimit++;
                    break;
                case 6:
                    battleSlots[slotPosition].className = "Soldier";
                    sizeLimit++;
                    break;
                case 7:
                    battleSlots[slotPosition].className = "Soldier";
                    sizeLimit++;
                    break;
            }
        }
    }

    public void AddPyro(int slotPosition)
    {
        if (sizeLimit >= 4)
        {
            switch (slotPosition)
            {
                case 0:
                    battleSlots[slotPosition].className = "Pyro";
                    break;
                case 1:
                    battleSlots[slotPosition].className = "Pyro";
                    break;
                case 2:
                    battleSlots[slotPosition].className = "Pyro";
                    break;
                case 3:
                    battleSlots[slotPosition].className = "Pyro";
                    break;
                case 4:
                    battleSlots[slotPosition].className = "Pyro";
                    sizeLimit++;
                    break;
                case 5:
                    battleSlots[slotPosition].className = "Pyro";
                    sizeLimit++;
                    break;
                case 6:
                    battleSlots[slotPosition].className = "Pyro";
                    sizeLimit++;
                    break;
                case 7:
                    battleSlots[slotPosition].className = "Pyro";
                    sizeLimit++;
                    break;
            }
        }
    }

    public void AddDemo(int slotPosition)
    {
        if (sizeLimit >= 4)
        {
            switch (slotPosition)
            {
                case 0:
                    battleSlots[slotPosition].className = "Demoman";
                    break;
                case 1:
                    battleSlots[slotPosition].className = "Demoman";
                    break;
                case 2:
                    battleSlots[slotPosition].className = "Demoman";
                    break;
                case 3:
                    battleSlots[slotPosition].className = "Demoman";
                    break;
                case 4:
                    battleSlots[slotPosition].className = "Demoman";
                    sizeLimit++;
                    break;
                case 5:
                    battleSlots[slotPosition].className = "Demoman";
                    sizeLimit++;
                    break;
                case 6:
                    battleSlots[slotPosition].className = "Demoman";
                    sizeLimit++;
                    break;
                case 7:
                    battleSlots[slotPosition].className = "Demoman";
                    sizeLimit++;
                    break;
            }
        }
    }

    public void AddHeavy(int slotPosition)
    {
        if (sizeLimit >= 4)
        {
            switch (slotPosition)
            {
                case 0:
                    battleSlots[slotPosition].className = "Heavy";
                    break;
                case 1:
                    battleSlots[slotPosition].className = "Heavy";
                    break;
                case 2:
                    battleSlots[slotPosition].className = "Heavy";
                    break;
                case 3:
                    battleSlots[slotPosition].className = "Heavy";
                    break;
                case 4:
                    battleSlots[slotPosition].className = "Heavy";
                    sizeLimit++;
                    break;
                case 5:
                    battleSlots[slotPosition].className = "Heavy";
                    sizeLimit++;
                    break;
                case 6:
                    battleSlots[slotPosition].className = "Heavy";
                    sizeLimit++;
                    break;
                case 7:
                    battleSlots[slotPosition].className = "Heavy";
                    sizeLimit++;
                    break;
            }
        }
    }

    public void AddEngi(int slotPosition)
    {
        if (sizeLimit >= 4)
        {
            switch (slotPosition)
            {
                case 0:
                    battleSlots[slotPosition].className = "Engineer";
                    break;
                case 1:
                    battleSlots[slotPosition].className = "Engineer";
                    break;
                case 2:
                    battleSlots[slotPosition].className = "Engineer";
                    break;
                case 3:
                    battleSlots[slotPosition].className = "Engineer";
                    break;
                case 4:
                    battleSlots[slotPosition].className = "Engineer";
                    sizeLimit++;
                    break;
                case 5:
                    battleSlots[slotPosition].className = "Engineer";
                    sizeLimit++;
                    break;
                case 6:
                    battleSlots[slotPosition].className = "Engineer";
                    sizeLimit++;
                    break;
                case 7:
                    battleSlots[slotPosition].className = "Engineer";
                    sizeLimit++;
                    break;
            }
        }
    }

    public void AddMedic(int slotPosition)
    {
        if (sizeLimit >= 4)
        {
            switch (slotPosition)
            {
                case 0:
                    battleSlots[slotPosition].className = "Medic";
                    break;
                case 1:
                    battleSlots[slotPosition].className = "Medic";
                    break;
                case 2:
                    battleSlots[slotPosition].className = "Medic";
                    break;
                case 3:
                    battleSlots[slotPosition].className = "Medic";
                    break;
                case 4:
                    battleSlots[slotPosition].className = "Medic";
                    sizeLimit++;
                    break;
                case 5:
                    battleSlots[slotPosition].className = "Medic";
                    sizeLimit++;
                    break;
                case 6:
                    battleSlots[slotPosition].className = "Medic";
                    sizeLimit++;
                    break;
                case 7:
                    battleSlots[slotPosition].className = "Medic";
                    sizeLimit++;
                    break;
            }
        }
    }

    public void AddSniper(int slotPosition)
    {
        if (sizeLimit >= 4)
        {
            switch (slotPosition)
            {
                case 0:
                    battleSlots[slotPosition].className = "Sniper";
                    break;
                case 1:
                    battleSlots[slotPosition].className = "Sniper";
                    break;
                case 2:
                    battleSlots[slotPosition].className = "Sniper";
                    break;
                case 3:
                    battleSlots[slotPosition].className = "Sniper";
                    break;
                case 4:
                    battleSlots[slotPosition].className = "Sniper";
                    sizeLimit++;
                    break;
                case 5:
                    battleSlots[slotPosition].className = "Sniper";
                    sizeLimit++;
                    break;
                case 6:
                    battleSlots[slotPosition].className = "Sniper";
                    sizeLimit++;
                    break;
                case 7:
                    battleSlots[slotPosition].className = "Sniper";
                    sizeLimit++;
                    break;
            }
        }
    }

    public void AddSpy(int slotPosition)
    {
        if (sizeLimit >= 4)
        {
            switch (slotPosition)
            {
                case 0:
                    battleSlots[slotPosition].className = "Spy";
                    break;
                case 1:
                    battleSlots[slotPosition].className = "Spy";
                    break;
                case 2:
                    battleSlots[slotPosition].className = "Spy";
                    break;
                case 3:
                    battleSlots[slotPosition].className = "Spy";
                    break;
                case 4:
                    battleSlots[slotPosition].className = "Spy";
                    sizeLimit++;
                    break;
                case 5:
                    battleSlots[slotPosition].className = "Spy";
                    sizeLimit++;
                    break;
                case 6:
                    battleSlots[slotPosition].className = "Spy";
                    sizeLimit++;
                    break;
                case 7:
                    battleSlots[slotPosition].className = "Spy";
                    sizeLimit++;
                    break;
            }
        }
    }
}
