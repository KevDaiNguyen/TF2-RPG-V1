using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathChecker : MonoBehaviour
{
    public GameObject[] actionSlots;
    public GameObject[] timerSlots;
    public GameObject[] infoSlots;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        for (int i = 0; i < actionSlots.Length; i++)
        {
            if (!actionSlots[i].activeInHierarchy)
            {
                timerSlots[i].SetActive(false);
                if (i == 4 || i == 5 || i == 6 || i == 7)
                {
                    infoSlots[i-4].SetActive(false);
                }
            }
            else if (actionSlots[i].activeInHierarchy)
            {
                timerSlots[i].SetActive(true);
                if (i == 4 || i == 5 || i == 6 || i == 7)
                {
                    infoSlots[i-4].SetActive(true);
                }
            }
        }
    }
}
