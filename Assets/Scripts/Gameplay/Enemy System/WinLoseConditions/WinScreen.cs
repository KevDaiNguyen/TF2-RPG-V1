using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WinScreen : MonoBehaviour
{
    public WeaponPool weaponPoolInstance;
    public ScrapCounter scrapInstance;
    public GameObject winScreen;

    public GameObject[] slots;
    public GameObject[] backgrounds;

    public int chosenAmount;
    private int leftOver;
    private bool finishedSelection;
    public int toggle1;
    public int toggle2;
    public int toggle3;
    public int toggle4;
    public int toggle5;
    public int toggle6;
    public int toggle7;
    public int toggle8;


    public void OnWin()
    {
        winScreen.SetActive(true);
        for (int i = 0; i < backgrounds.Length; i++)
        {
            backgrounds[i].SetActive(false);
            slots[i].GetComponent<Image>().sprite = weaponPoolInstance.nonStockPool[Random.Range(0, weaponPoolInstance.nonStockPool.Length)];
        }
    }

    public void SelectedS1()
    {
        toggle1 *= -1;
        if (toggle1 > 0)
        {
            backgrounds[0].SetActive(true);
        }
        else if (toggle1 < 0)
        {
            backgrounds[0].SetActive(false);
        }

        if (backgrounds[0].activeInHierarchy)
        {
            chosenAmount++;
        }
        else if (!backgrounds[0].activeInHierarchy)
        {
            chosenAmount--;
        }
    }
    public void SelectedS2()
    {
        toggle2 *= -1;
        if (toggle2 > 0)
        {
            backgrounds[1].SetActive(true);
        }
        else if (toggle2 < 0)
        {
            backgrounds[1].SetActive(false);
        }

        if (backgrounds[1].activeInHierarchy)
        {
            chosenAmount++;
        }
        else if (!backgrounds[1].activeInHierarchy)
        {
            chosenAmount--;
        }
    }
    public void SelectedS3()
    {
        toggle3 *= -1;
        if (toggle3 > 0)
        {
            backgrounds[2].SetActive(true);
        }
        else if (toggle3 < 0)
        {
            backgrounds[2].SetActive(false);
        }


        if (backgrounds[2].activeInHierarchy)
        {
            chosenAmount++;
        }
        else if (!backgrounds[2].activeInHierarchy)
        {
            chosenAmount--;
        }
    }
    public void SelectedS4()
    {
        toggle4 *= -1;
        if (toggle4 > 0)
        {
            backgrounds[3].SetActive(true);
        }
        else if (toggle4 < 0)
        {
            backgrounds[3].SetActive(false);
        }

        if (backgrounds[3].activeInHierarchy)
        {
            chosenAmount++;
        }
        else if (!backgrounds[3].activeInHierarchy)
        {
            chosenAmount--;
        }
    }
    public void SelectedS5()
    {
        toggle5 *= -1;
        if (toggle5 > 0)
        {
            backgrounds[4].SetActive(true);
        }
        else if (toggle5 < 0)
        {
            backgrounds[4].SetActive(false);
        }

        if (backgrounds[4].activeInHierarchy)
        {
            chosenAmount++;
        }
        else if (!backgrounds[4].activeInHierarchy)
        {
            chosenAmount--;
        }
    }
    public void SelectedS6()
    {
        toggle6 *= -1;
        if (toggle6 > 0)
        {
            backgrounds[5].SetActive(true);
        }
        else if (toggle6 < 0)
        {
            backgrounds[5].SetActive(false);
        }

        if (backgrounds[5].activeInHierarchy)
        {
            chosenAmount++;
        }
        else if (!backgrounds[5].activeInHierarchy)
        {
            chosenAmount--;
        }
    }
    public void SelectedS7()
    {
        toggle7 *= -1;
        if (toggle7 > 0)
        {
            backgrounds[6].SetActive(true);
        }
        else if (toggle7 < 0)
        {
            backgrounds[6].SetActive(false);
        }

        if (backgrounds[6].activeInHierarchy)
        {
            chosenAmount++;
        }
        else if (!backgrounds[6].activeInHierarchy)
        {
            chosenAmount--;
        }
    }
    public void SelectedS8()
    {
        toggle8 *= -1;
        if (toggle8 > 0)
        {
            backgrounds[7].SetActive(true);
        }
        else if (toggle8 < 0)
        {
            backgrounds[7].SetActive(false);
        }

        if (backgrounds[7].activeInHierarchy)
        {
            chosenAmount++;
        }
        else if (!backgrounds[7].activeInHierarchy)
        {
            chosenAmount--;
        }
    }

    public void EndWinScreen()
    {
        if (!finishedSelection)
        {
            leftOver = 8 - chosenAmount;
            leftOver /= 2;
            scrapInstance.AddScrap(leftOver);
            finishedSelection = true;
            winScreen.SetActive(false); 
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        toggle1 = -1;
        toggle2 = -1;
        toggle3 = -1;
        toggle4 = -1;
        toggle5 = -1;
        toggle6 = -1;
        toggle7 = -1;
        toggle8 = -1;
        finishedSelection = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
