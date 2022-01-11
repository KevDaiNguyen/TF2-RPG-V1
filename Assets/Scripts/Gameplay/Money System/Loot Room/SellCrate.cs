using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class SellCrate : MonoBehaviour
{
    public GameObject unboxPrompt;
    public ScrapCounter scrapInstance;
    public int addedValue;

    public GameObject metalBox;
    public Sprite[] metalList;
    public bool soldOnce;
    

    // Start is called before the first frame update
    void Start()
    {
        soldOnce = false;
    }

    // Update is called once per frame
    void Update()
    {

    }
    
    public void SellTheCrate()
    {
        metalBox.SetActive(true);
        addedValue = Random.Range(1, 27);

        if (!soldOnce)
        {
            if (addedValue < 3)
            {
                metalBox.GetComponent<Image>().sprite = metalList[0];
            }
            else if (addedValue < 27)
            {
                metalBox.GetComponent<Image>().sprite = metalList[1];
            }
            else
            {
                metalBox.GetComponent<Image>().sprite = metalList[2];
            }

            scrapInstance.AddScrap(addedValue);
            metalBox.GetComponentInChildren<TextMeshProUGUI>().text = addedValue + " Scrap";
            soldOnce = true;
        }
    }

    public void NoUnbox()
    {
        unboxPrompt.SetActive(false);
    }
}
