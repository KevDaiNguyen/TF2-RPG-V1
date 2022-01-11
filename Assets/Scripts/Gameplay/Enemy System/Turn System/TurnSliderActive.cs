using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurnSliderActive : MonoBehaviour
{
    public GameObject battleRoom;
    public GameObject turnChecker;
    public GameObject bottomButton;
    public GameObject turnCounter;
    public GameObject battleStats;

    public GameObject mapThing;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (!battleRoom.activeInHierarchy)
        {
            turnChecker.SetActive(false);
            bottomButton.SetActive(false);
            turnCounter.SetActive(false);
            battleStats.SetActive(false);

            mapThing.SetActive(true);
        }
        else if (battleRoom.activeInHierarchy)
        {
            turnChecker.SetActive(true);
            bottomButton.SetActive(true);
            turnCounter.SetActive(true);
            battleStats.SetActive(true);

            mapThing.SetActive(false);
        }
    }
}
