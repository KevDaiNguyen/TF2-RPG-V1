using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class SecondarySlot : MonoBehaviour
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

    public GameObject secondaryAmmoText;
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
        //Debug.Log("Instances " + tag + " Secondary");

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
                    StockifyClass(listWepInstance.scoutSecondaries[0].name);
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

                ammoInMag = scoutStats.ammoInMag;
                ammoInReserve = scoutStats.ammoInReserve;
                totalAmmo = scoutStats.totalAmmo;
                break;
            case "Soldier":
                if (didStockify < 4)
                {
                    StockifyClass(listWepInstance.soldierSecondaries[0].name);
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

                ammoInMag = soldierStats.ammoInMag;
                ammoInReserve = soldierStats.ammoInReserve;
                totalAmmo = soldierStats.totalAmmo;
                break;
            case "Pyro":
                if (didStockify < 4)
                {
                    StockifyClass(listWepInstance.pyroSecondaries[0].name);
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

                ammoInMag = pyroStats.ammoInMag;
                ammoInReserve = pyroStats.ammoInReserve;
                totalAmmo = pyroStats.totalAmmo;
                break;
            case "Demoman":
                if (didStockify < 4)
                {
                    StockifyClass(listWepInstance.demomanSecondaries[0].name);
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

                ammoInMag = demoStats.ammoInMag;
                ammoInReserve = demoStats.ammoInReserve;
                totalAmmo = demoStats.totalAmmo;
                break;
            case "Heavy":
                if (didStockify < 4)
                {
                    StockifyClass(listWepInstance.heavySecondaries[0].name);
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

                ammoInMag = heavyStats.ammoInMag;
                ammoInReserve = heavyStats.ammoInReserve;
                totalAmmo = heavyStats.totalAmmo;
                break;
            case "Engineer":
                if (didStockify < 4)
                {
                    StockifyClass(listWepInstance.engineerSecondaries[0].name);
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

                ammoInMag = engiStats.ammoInMag;
                ammoInReserve = engiStats.ammoInReserve;
                totalAmmo = engiStats.totalAmmo;
                break;
            case "Medic":
                if (didStockify < 4)
                {
                    StockifyClass(listWepInstance.medicSecondaries[0].name);
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

                ammoInMag = medicStats.ammoInMag;
                ammoInReserve = medicStats.ammoInReserve;
                totalAmmo = medicStats.totalAmmo;
                break;
            case "Sniper":
                if (didStockify < 4)
                {
                    StockifyClass(listWepInstance.sniperSecondaries[0].name);
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

                ammoInMag = sniperStats.ammoInMag;
                ammoInReserve = sniperStats.ammoInReserve;
                totalAmmo = sniperStats.totalAmmo;
                break;
            case "Spy":
                if (didStockify < 4)
                {
                    StockifyClass(listWepInstance.spySecondaries[0].name);
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

                ammoInMag = spyStats.ammoInMag;
                ammoInReserve = spyStats.ammoInReserve;
                totalAmmo = spyStats.totalAmmo;
                break;
        }
    }

    public void ShowSecondaryStuff()
    {
        ShowAmmo();
        ShowCurrentSprite();
        
        switch (3 - numOfActions)
        {
            case 1:
                actionSlots[0].SetActive(true);
                actionSlots[1].SetActive(true);

                timeToken1.GetComponent<Image>().sprite = timeTokenList[timeCost1];
                timeToken2.GetComponent<Image>().sprite = timeTokenList[timeCost2];
                textBox1.GetComponent<TextMeshProUGUI>().text = wepDescription1;
                textBox2.GetComponent<TextMeshProUGUI>().text = wepDescription2;

                actionSlots[2].SetActive(false);
                break;
            case 2:
                actionSlots[2].SetActive(true);

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

    public void ShowAmmo()
    {
        secondaryAmmoText.GetComponent<TextMeshProUGUI>().text = ammoInMag + "/" + ammoInReserve;
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
                case "PST":
                    scoutStats.Pistol();
                    break;
                case "BNK":
                    scoutStats.BONK();
                    break;
                case "COC":
                    scoutStats.CritACola();
                    break;
                case "FLG":
                    scoutStats.FlyingGuillotine();
                    break;
                case "MDM":
                    scoutStats.MadMilk();
                    break;
                case "PBP":
                    scoutStats.PrettyBoysPocketPistol();
                    break;
                case "WNG":
                    scoutStats.Winger();
                    break;
            }
        }
        else if (weaponClassName == soldier)
        {
            switch (weaponName)
            {
                case "STG":
                    soldierStats.Shotgun();
                    break;
                case "BBU":
                    soldierStats.BatallionsBackup();
                    break;
                case "BFB":
                    soldierStats.BuffBanner();
                    break;
                case "BJR":
                    soldierStats.BASEJumper();
                    break;
                case "CNR":
                    soldierStats.Concheror();
                    break;
                case "GNB":
                    soldierStats.Gunboats();
                    break;
                case "MNT":
                    soldierStats.Mantreads();
                    break;
                case "PAN":
                    soldierStats.PanicAttack();
                    break;
                case "RBS":
                    soldierStats.RighteousBison();
                    break;
                case "RSR":
                    soldierStats.ReserveShooter();
                    break;
            }
        }
        else if (weaponClassName == pyro)
        {
            switch (weaponName)
            {
                case "STG":
                    pyroStats.Shotgun();
                    break;
                case "DTN":
                    pyroStats.Detonator();
                    break;
                case "FLG":
                    pyroStats.FlareGun();
                    break;
                case "GSP":
                    pyroStats.GasPasser();
                    break;
                case "MNM":
                    pyroStats.ManMelter();
                    break;
                case "PAN":
                    pyroStats.PanicAttack();
                    break;
                case "RSR":
                    pyroStats.ReserveShooter();
                    break;
                case "SCS":
                    pyroStats.ScorchShot();
                    break;
                case "TMT":
                    pyroStats.ThermalThruster();
                    break;
            }
        }
        else if (weaponClassName == demo)
        {
            switch (weaponName)
            {
                case "SBL":
                    demoStats.StickybombLauncher();
                    break;
                case "CNT":
                    demoStats.CharginTarge();
                    break;
                case "QBL":
                    demoStats.QuickiebombLauncher();
                    break;
                case "SDS":
                    demoStats.SplendidScreen();
                    break;
                case "SJR":
                    demoStats.StickyJumper();
                    break;
                case "SRC":
                    demoStats.ScottishResistance();
                    break;
                case "TDT":
                    demoStats.TideTurner();
                    break;
            }
        }
        else if (weaponClassName == heavy)
        {
            switch (weaponName)
            {
                case "STG":
                    heavyStats.Shotgun();
                    break;
                case "BSS":
                    heavyStats.BuffaloSteakSandvich();
                    break;
                case "DLB":
                    heavyStats.DalokohsBar();
                    break;
                case "FMB":
                    heavyStats.FamilyBusiness();
                    break;
                case "PAN":
                    heavyStats.PanicAttack();
                    break;
                case "SDB":
                    heavyStats.SecondBanana();
                    break;
                case "SND":
                    heavyStats.Sandvich();
                    break;
            }
        }
        else if (weaponClassName == engi)
        {
            switch (weaponName)
            {
                case "PST":
                    engiStats.Pistol();
                    break;
                case "SCT":
                    engiStats.ShortCircuit();
                    break;
                case "WGL":
                    engiStats.Wrangler();
                    break;
            }
        }
        else if (weaponClassName == medic)
        {
            switch (weaponName)
            {
                case "MDG":
                    medicStats.Medigun();
                    break;
                case "KKG":
                    medicStats.Kritzkrieg();
                    break;
                case "QFX":
                    medicStats.QuickFix();
                    break;
                case "VCN":
                    medicStats.Vaccinator();
                    break;
            }
        }
        else if (weaponClassName == sniper)
        {
            switch (weaponName)
            {
                case "SMG":
                    sniperStats.SMG();
                    break;
                case "CRC":
                    sniperStats.CleanersCarbine();
                    break;
                case "CZC":
                    sniperStats.CozyCamper();
                    break;
                case "DDS":
                    sniperStats.DarwinsDangerShield();
                    break;
                case "JRT":
                    sniperStats.Jarate();
                    break;
                case "RZB":
                    sniperStats.Razorback();
                    break;

            }
        }
        else if (weaponClassName == spy)
        {
            switch (weaponName)
            {
                case "SPR":
                    spyStats.Sapper();
                    break;
                case "RTR":
                    spyStats.RedTapeRecorder();
                    break;

            }
        }
    }
}
