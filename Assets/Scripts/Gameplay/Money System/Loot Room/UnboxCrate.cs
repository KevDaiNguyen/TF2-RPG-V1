using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UnboxCrate : MonoBehaviour
{
    public WeaponPool weaponPoolInstance;
    public GameObject sellPrompt;
    
    public GameObject slot1;
    public GameObject slot2;
    public GameObject slot3;
    public GameObject slot4;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Unbox()
    {
        slot1.SetActive(true);
        slot2.SetActive(true);
        slot3.SetActive(true);
        slot4.SetActive(true);

        slot1.GetComponent<Image>().sprite = weaponPoolInstance.nonStockPool[Random.Range(0, weaponPoolInstance.nonStockPool.Length)];
        slot2.GetComponent<Image>().sprite = weaponPoolInstance.nonStockPool[Random.Range(0, weaponPoolInstance.nonStockPool.Length)];
        slot3.GetComponent<Image>().sprite = weaponPoolInstance.nonStockPool[Random.Range(0, weaponPoolInstance.nonStockPool.Length)];
        slot4.GetComponent<Image>().sprite = weaponPoolInstance.nonStockPool[Random.Range(0, weaponPoolInstance.nonStockPool.Length)];
    }

    public void ChoseOne()
    {
        slot2.SetActive(false);
        slot3.SetActive(false);
        slot4.SetActive(false);
    }

    public void ChoseTwo()
    {
        slot1.SetActive(false);
        slot3.SetActive(false);
        slot4.SetActive(false);
    }

    public void ChoseThree()
    {
        slot1.SetActive(false);
        slot2.SetActive(false);
        slot4.SetActive(false);
    }

    public void ChoseFour()
    {
        slot1.SetActive(false);
        slot2.SetActive(false);
        slot3.SetActive(false);
    }

    public void NoSell()
    {
        sellPrompt.SetActive(false);
    }
}
