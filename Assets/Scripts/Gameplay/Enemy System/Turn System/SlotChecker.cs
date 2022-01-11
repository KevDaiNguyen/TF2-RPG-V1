using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class SlotChecker : MonoBehaviour
{
    public GameObject actionScreen;
    public CharacterHealth[] healthInstances;
    public PrimarySlot[] primaryInstances;
    public SecondarySlot[] secondaryInstances;
    public MeleeSlot[] meleeInstances;
    
    public string slotTag;
    public GameObject[] slotList;
    
    public Vector3 originalPosition1;
    public Vector3 originalPosition2;
    public Vector3 originalPosition3;
    public Vector3 originalPosition4;
    
    public Vector3 leftSlot;

    public GameObject[] timeSlots;
    public GameObject[] timeHitboxes;

    public TextMeshProUGUI turnText;
    public int passedTurns;
    private bool recentlyPaused;
    public string currentTag;

    // Start is called before the first frame update
    void Start()
    {
        recentlyPaused = false;
        SavedPositions();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        PauseTime();
        leftSlot = slotList[3].transform.position;

        //Debug.Log(other.tag);
        other.transform.position = timeSlots[0].transform.position;
        currentTag = other.tag;
        switch (currentTag) {
            case "C1":
                slotList[0].transform.position = leftSlot;
                healthInstances[0].ShowStats();
                primaryInstances[0].ShowAmmo();
                secondaryInstances[0].ShowAmmo();
                primaryInstances[0].ShowPrimaryStuff();
                actionScreen.SetActive(true);
                break;
            case "C2":
                slotList[1].transform.position = leftSlot;
                healthInstances[1].ShowStats();
                primaryInstances[1].ShowAmmo();
                secondaryInstances[1].ShowAmmo();
                primaryInstances[1].ShowPrimaryStuff();
                actionScreen.SetActive(true);
                break;
            case "C3":
                slotList[2].transform.position = leftSlot;
                healthInstances[2].ShowStats();
                primaryInstances[2].ShowAmmo();
                secondaryInstances[2].ShowAmmo();
                primaryInstances[2].ShowPrimaryStuff();
                actionScreen.SetActive(true);
                break;
            case "C4":
                slotList[3].transform.position = leftSlot;
                healthInstances[3].ShowStats();
                primaryInstances[3].ShowAmmo();
                secondaryInstances[3].ShowAmmo();
                primaryInstances[3].ShowPrimaryStuff();
                actionScreen.SetActive(true);
                break;
            default:
                actionScreen.SetActive(false);
                break;
        }
    }

    public void PauseTime()
    {
        for (int i = 0; i < timeHitboxes.Length; i++)
        {
            timeHitboxes[i].GetComponent<Rigidbody>().isKinematic = true;
        }
        recentlyPaused = true;
    }

    public void UnpauseTime()
    {
        for (int i = 0; i < timeHitboxes.Length; i++)
        {
            timeHitboxes[i].GetComponent<Rigidbody>().isKinematic = false;
        }
        if (recentlyPaused)
        {
            passedTurns++;
            turnText.text = "Turn " + passedTurns;
            recentlyPaused = false;
            actionScreen.SetActive(false);
            switch (currentTag)
            {
                case "C1":
                    //Debug.Log("C1");
                    slotList[0].transform.position = originalPosition1;
                    break;
                case "C2":
                    //Debug.Log("C2");
                    slotList[1].transform.position = originalPosition2;
                    break;
                case "C3":
                    //Debug.Log("C3");
                    slotList[2].transform.position = originalPosition3;
                    break;
                case "C4":
                    //Debug.Log("C4");
                    slotList[3].transform.position = originalPosition4;
                    break;
            }
        }
    }

    private void OnEnable()
    {
        for (int i = 0; i < timeHitboxes.Length; i++)
        {
            timeHitboxes[i].transform.position = timeSlots[0].transform.position;
        }
    }

    public void SavedPositions()
    {
        originalPosition1 = new Vector3(792, 157, 0);
        originalPosition2 = new Vector3(584, 157, 0);
        originalPosition3 = new Vector3(376, 157, 0);
        originalPosition4 = new Vector3(168, 157, 0);
    }
}
