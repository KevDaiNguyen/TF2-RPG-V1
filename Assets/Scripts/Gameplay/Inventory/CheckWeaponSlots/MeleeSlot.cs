using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class MeleeSlot : MonoBehaviour
{
    public Sprite[] timeTokenList;
    public CharacterHealth[] classSpawnBoxes;
    public ListOfClassWeapons listWepInstance;
    public GameObject[] actionSlots;

    public ScoutWepStats scoutStats;
    public SoldierWepStats soldierStats;
    public PyroWepStats pyroStats;
    public DemoWepStats demoStats;
    public HeavyWepStats heavyStats;
    public EngiWepStats engiStats;
    public MedicWepStats medicStats;
    public SniperWepStats sniperStats;
    public SpyWepStats spyStats;

    private Sprite currentSprite;
    public Image boxSprite;

    public GameObject timeToken1;
    public GameObject timeToken2;
    public GameObject timeToken3;

    public GameObject textBox1;
    public GameObject textBox2;
    public GameObject textBox3;

    public int numOfActions;

    public int turnCoolDown;
    public int reloadSpeed;

    public int timeCost1;
    public int timeCost2;
    public int timeCost3;

    public string wepDescription1;
    public string wepDescription2;
    public string wepDescription3;

    public int ammoInMag;
    public int ammoInReserve;
    public int totalAmmo;

    public int didStockify;
    public bool slotCheckOnce;

    public string currentClassName;

    // Start is called before the first frame update
    void Start()
    {
        didStockify = 0;
        slotCheckOnce = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (!slotCheckOnce)
        {
            CheckSlot();
            slotCheckOnce = true;
        }
        ShowCurrentSprite();
    }

    public void CheckSlot()
    {
        switch (tag)
        {
            case "C1":
                currentClassName = classSpawnBoxes[0].className;
                break;
            case "C2":
                currentClassName = classSpawnBoxes[1].className;
                break;
            case "C3":
                currentClassName = classSpawnBoxes[2].className;
                break;
            case "C4":
                currentClassName = classSpawnBoxes[3].className;
                break;
        }

        switch (currentClassName)
        {
            case "Scout":
                if (didStockify < 4)
                {
                    StockifyClass(listWepInstance.scoutMelees[0].name);
                }
                currentSprite = scoutStats.currentSprite;
                numOfActions = scoutStats.numOfActions;
                turnCoolDown = scoutStats.turnCoolDown;
                reloadSpeed = scoutStats.reloadSpeed;

                timeCost1 = scoutStats.timeCost1;
                timeCost2 = scoutStats.timeCost2;
                timeCost3 = scoutStats.timeCost3;

                wepDescription1 = scoutStats.wepDescription1;
                wepDescription2 = scoutStats.wepDescription2;
                wepDescription3 = scoutStats.wepDescription3;
                break;
            case "Soldier":
                if (didStockify < 4)
                {
                    StockifyClass(listWepInstance.soldierMelees[0].name);
                }
                currentSprite = soldierStats.currentSprite;
                numOfActions = soldierStats.numOfActions;
                turnCoolDown = soldierStats.turnCoolDown;
                reloadSpeed = soldierStats.reloadSpeed;

                timeCost1 = soldierStats.timeCost1;
                timeCost2 = soldierStats.timeCost2;
                timeCost3 = soldierStats.timeCost3;

                wepDescription1 = soldierStats.wepDescription1;
                wepDescription2 = soldierStats.wepDescription2;
                wepDescription3 = soldierStats.wepDescription3;
                break;
            case "Pyro":
                if (didStockify < 4)
                {
                    StockifyClass(listWepInstance.pyroMelees[0].name);
                }
                currentSprite = pyroStats.currentSprite;
                numOfActions = pyroStats.numOfActions;
                turnCoolDown = pyroStats.turnCoolDown;
                reloadSpeed = pyroStats.reloadSpeed;

                timeCost1 = pyroStats.timeCost1;
                timeCost2 = pyroStats.timeCost2;
                timeCost3 = pyroStats.timeCost3;

                wepDescription1 = pyroStats.wepDescription1;
                wepDescription2 = pyroStats.wepDescription2;
                wepDescription3 = pyroStats.wepDescription3;
                break;
            case "Demoman":
                if (didStockify < 4)
                {
                    StockifyClass(listWepInstance.demomanMelees[0].name);
                }
                currentSprite = demoStats.currentSprite;
                numOfActions = demoStats.numOfActions;
                turnCoolDown = demoStats.turnCoolDown;
                reloadSpeed = demoStats.reloadSpeed;

                timeCost1 = demoStats.timeCost1;
                timeCost2 = demoStats.timeCost2;
                timeCost3 = demoStats.timeCost3;

                wepDescription1 = demoStats.wepDescription1;
                wepDescription2 = demoStats.wepDescription2;
                wepDescription3 = demoStats.wepDescription3;
                break;
            case "Heavy":
                if (didStockify < 4)
                {
                    StockifyClass(listWepInstance.heavyMelees[0].name);
                }
                currentSprite = heavyStats.currentSprite;
                numOfActions = heavyStats.numOfActions;
                turnCoolDown = heavyStats.turnCoolDown;
                reloadSpeed = heavyStats.reloadSpeed;

                timeCost1 = heavyStats.timeCost1;
                timeCost2 = heavyStats.timeCost2;
                timeCost3 = heavyStats.timeCost3;

                wepDescription1 = heavyStats.wepDescription1;
                wepDescription2 = heavyStats.wepDescription2;
                wepDescription3 = heavyStats.wepDescription3;
                break;
            case "Engineer":
                if (didStockify < 4)
                {
                    StockifyClass(listWepInstance.engineerMelees[0].name);
                }
                currentSprite = engiStats.currentSprite;
                numOfActions = engiStats.numOfActions;
                turnCoolDown = engiStats.turnCoolDown;
                reloadSpeed = engiStats.reloadSpeed;

                timeCost1 = engiStats.timeCost1;
                timeCost2 = engiStats.timeCost2;
                timeCost3 = engiStats.timeCost3;

                wepDescription1 = engiStats.wepDescription1;
                wepDescription2 = engiStats.wepDescription2;
                wepDescription3 = engiStats.wepDescription3;
                break;
            case "Medic":
                if (didStockify < 4)
                {
                    StockifyClass(listWepInstance.medicMelees[0].name);
                }
                currentSprite = medicStats.currentSprite;
                numOfActions = medicStats.numOfActions;
                turnCoolDown = medicStats.turnCoolDown;
                reloadSpeed = medicStats.reloadSpeed;

                timeCost1 = medicStats.timeCost1;
                timeCost2 = medicStats.timeCost2;
                timeCost3 = medicStats.timeCost3;

                wepDescription1 = medicStats.wepDescription1;
                wepDescription2 = medicStats.wepDescription2;
                wepDescription3 = medicStats.wepDescription3;
                break;
            case "Sniper":
                if (didStockify < 4)
                {
                    StockifyClass(listWepInstance.sniperMelees[0].name);
                }
                currentSprite = sniperStats.currentSprite;
                numOfActions = sniperStats.numOfActions;
                turnCoolDown = sniperStats.turnCoolDown;
                reloadSpeed = sniperStats.reloadSpeed;

                timeCost1 = sniperStats.timeCost1;
                timeCost2 = sniperStats.timeCost2;
                timeCost3 = sniperStats.timeCost3;

                wepDescription1 = sniperStats.wepDescription1;
                wepDescription2 = sniperStats.wepDescription2;
                wepDescription3 = sniperStats.wepDescription3;
                break;
            case "Spy":
                if (didStockify < 4)
                {
                    StockifyClass(listWepInstance.spyMelees[0].name);
                }
                currentSprite = spyStats.currentSprite;
                numOfActions = spyStats.numOfActions;
                turnCoolDown = spyStats.turnCoolDown;
                reloadSpeed = spyStats.reloadSpeed;

                timeCost1 = spyStats.timeCost1;
                timeCost2 = spyStats.timeCost2;
                timeCost3 = spyStats.timeCost3;

                wepDescription1 = spyStats.wepDescription1;
                wepDescription2 = spyStats.wepDescription2;
                wepDescription3 = spyStats.wepDescription3;
                break;
        }
    }

    public void ShowMeleeStuff()
    {
        ShowCurrentSprite();
        int negativeCounter = 0;

        if (timeCost1 < 0)
        {
            negativeCounter++;
        }
        else if (timeCost2 < 0)
        {
            negativeCounter++;
        }
        else if (timeCost3 < 0)
        {
            negativeCounter++;
        }

        switch (negativeCounter)
        {
            case 1:
                timeToken1.GetComponent<Image>().sprite = timeTokenList[timeCost1];
                timeToken2.GetComponent<Image>().sprite = timeTokenList[timeCost2];
                textBox1.GetComponent<TextMeshProUGUI>().text = wepDescription1;
                textBox2.GetComponent<TextMeshProUGUI>().text = wepDescription2;

                actionSlots[2].SetActive(false);
                break;
            case 2:
                timeToken3.GetComponent<Image>().sprite = timeTokenList[timeCost3];
                textBox3.GetComponent<TextMeshProUGUI>().text = wepDescription3;

                actionSlots[0].SetActive(false);
                actionSlots[1].SetActive(false);
                break;
            default:
                actionSlots[0].SetActive(true);
                actionSlots[1].SetActive(true);
                actionSlots[2].SetActive(true);

                timeToken1.GetComponent<Image>().sprite = timeTokenList[timeCost1];
                timeToken2.GetComponent<Image>().sprite = timeTokenList[timeCost2];
                timeToken3.GetComponent<Image>().sprite = timeTokenList[timeCost3];
                textBox1.GetComponent<TextMeshProUGUI>().text = wepDescription1;
                textBox2.GetComponent<TextMeshProUGUI>().text = wepDescription2;
                textBox3.GetComponent<TextMeshProUGUI>().text = wepDescription3;
                break;
        }
    }

    public void ShowCurrentSprite()
    {
        boxSprite.sprite = currentSprite;
    }

    public void StockifyClass(string weaponInput)
    {
        WeaponChange(weaponInput);
        didStockify++;
        CheckSlot();
    }

    //**********************************************************************************************************************************
    //Sorting Thing
    //**********************************************************************************************************************************
    public void WeaponChange(string newWeapon)
    {
        char[] charName = { newWeapon[3], newWeapon[4], newWeapon[5] };
        char[] wepClassName = { newWeapon[0], newWeapon[1] };
        string weaponName = new string(charName);
        string weaponClassName = new string(wepClassName);

        string scout = "SC";
        string soldier = "SO";
        string pyro = "PY";
        string demo = "DE";
        string heavy = "HE";
        string engi = "EN";
        string medic = "ME";
        string sniper = "SN";
        string spy = "SP";

        if (weaponClassName == scout)
        {
            switch (weaponName)
            {
                case "BAT":
                    scoutStats.Bat();
                    break;
                case "ATO":
                    scoutStats.Atomizer();
                    break;
                case "BSB":
                    scoutStats.BostonBasher();
                    break;
                case "CAC":
                    scoutStats.CandyCane();
                    break;
                case "FOW":
                    scoutStats.FanOWar();
                    break;
                case "SDM":
                    scoutStats.Sandman();
                    break;
                case "SOS":
                    scoutStats.SunOnAStick();
                    break;
                case "WPA":
                    scoutStats.WrapAssassin();
                    break;
            }
        }
        else if (weaponClassName == soldier)
        {
            switch (weaponName)
            {
                case "SVL":
                    soldierStats.Shovel();
                    break;
                case "DSA":
                    soldierStats.DisciplinaryAction();
                    break;
                case "EQR":
                    soldierStats.Equalizer();
                    break;
                case "ESP":
                    soldierStats.EscapePlan();
                    break;
                case "HAZ":
                    soldierStats.HalfZatoichi();
                    break;
                case "MTG":
                    soldierStats.MarketGardener();
                    break;
                case "PNT":
                    soldierStats.PainTrain();
                    break;
            }
        }
        else if (weaponClassName == pyro)
        {
            switch (weaponName)
            {
                case "AXE":
                    pyroStats.FireAxe();
                    break;
                case "AXT":
                    pyroStats.Axtinguisher();
                    break;
                case "BKS":
                    pyroStats.BackScratcher();
                    break;
                case "HMW":
                    pyroStats.Homewrecker();
                    break;
                case "HOH":
                    pyroStats.HotHand();
                    break;
                case "NEA":
                    pyroStats.NeonAnnihilator();
                    break;
                case "POW":
                    pyroStats.Powerjack();
                    break;
                case "SVF":
                    pyroStats.SharpenedVolcanoFragment();
                    break;
                case "TDD":
                    pyroStats.ThirdDegree();
                    break;
            }
        }
        else if (weaponClassName == demo)
        {
            switch (weaponName)
            {
                case "BTL":
                    demoStats.Bottle();
                    break;
                case "CDM":
                    demoStats.ClaidheamhMor();
                    break;
                case "EYE":
                    demoStats.Eyelander();
                    break;
                case "HAZ":
                    demoStats.HalfZatoichi();
                    break;
                case "PNT":
                    demoStats.PainTrain();
                    break;
                case "PSP":
                    demoStats.PersianPersuader();
                    break;
                case "SMS":
                    demoStats.ScotsmansSkullcutter();
                    break;
                case "ULC":
                    demoStats.UllapoolCaber();
                    break;
            }
        }
        else if (weaponClassName == heavy)
        {
            switch (weaponName)
            {
                case "FST":
                    heavyStats.Fists();
                    break;
                case "EVN":
                    heavyStats.EvictionNotice();
                    break;
                case "FOS":
                    heavyStats.FistsOfSteel();
                    break;
                case "GRU":
                    heavyStats.GlovesOfRunningUrgently();
                    break;
                case "HDP":
                    heavyStats.HolidayPunch();
                    break;
                case "KBG":
                    heavyStats.KillingGlovesOfBoxing();
                    break;
                case "WRS":
                    heavyStats.WarriorsSpirit();
                    break;

            }
        }
        else if (weaponClassName == engi)
        {
            switch (weaponName)
            {
                case "WRN":
                    engiStats.Wrench();
                    break;
                case "EKE":
                    engiStats.EurekaEffect();
                    break;
                case "GSR":
                    engiStats.Gunslinger();
                    break;
                case "JAG":
                    engiStats.Jag();
                    break;
                case "SNH":
                    engiStats.SouthernHospitality();
                    break;
            }
        }
        else if (weaponClassName == medic)
        {
            switch (weaponName)
            {
                case "BNS":
                    medicStats.Bonesaw();
                    break;
                case "APR":
                    medicStats.Amputator();
                    break;
                case "SMV":
                    medicStats.SolemnVow();
                    break;
                case "UBS":
                    medicStats.Ubersaw();
                    break;
                case "VTS":
                    medicStats.VitaSaw();
                    break;
            }
        }
        else if (weaponClassName == sniper)
        {
            switch (weaponName)
            {
                case "KKI":
                    sniperStats.Kukuri();
                    break;
                case "BWK":
                    sniperStats.Bushwacka();
                    break;
                case "SNS":
                    sniperStats.Shahanshah();
                    break;
                case "TMS":
                    sniperStats.TribalmansShiv();
                    break;

            }
        }
        else if (weaponClassName == spy)
        {
            switch (weaponName)
            {
                case "KNF":
                    spyStats.Knife();
                    break;
                case "BGE":
                    spyStats.BigEarner();
                    break;
                case "CNC":
                    spyStats.ConniversKunai();
                    break;
                case "SCL":
                    spyStats.Spycicle();
                    break;
                case "YER":
                    spyStats.YourEternalReward();
                    break;

            }
        }
    }
}
