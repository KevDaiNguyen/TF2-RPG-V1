using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ScrapCounter : MonoBehaviour
{
    public int scrapCount;
    public Image metalIcon;
    public GameObject textBox;
    public Sprite[] metalList;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        textBox.GetComponent<TextMeshProUGUI>().text = scrapCount + "  Scrap";

        if (scrapCount <= 0)
        {
            metalIcon.sprite = metalList[3];
        }
        else if (scrapCount < 3)
        {
            metalIcon.sprite = metalList[0];
        }
        else if (scrapCount < 27)
        {
            metalIcon.sprite = metalList[1];
        }
        else
        {
            metalIcon.sprite = metalList[2];
        }
    }

    public void BuyBig()
    {
        if (scrapCount >= 27)
        {
            scrapCount -= 27;
        }
        
    }

    public void BuyMedium()
    {
        if (scrapCount >= 9)
        {
            scrapCount -= 9;
        }
    }

    public void BuySmall()
    {
        if (scrapCount >= 3)
        {
            scrapCount -= 3;
        }
    }

    public void BuyCrate()
    {
        if (scrapCount >= 54)
        {
            scrapCount -= 54;
        }
    }

    public void AddScrap(int newScrap)
    {
        scrapCount += newScrap;
    }
}
