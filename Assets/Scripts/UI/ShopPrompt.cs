using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShopPrompt : MonoBehaviour
{
    [SerializeField] public GameObject hoverPrompt;
    private void OnMouseOver()
    {
        hoverPrompt.SetActive(true);
    }

    private void OnMouseEnter()
    {
        hoverPrompt.SetActive(true);
    }

    private void OnMouseExit()
    {
        hoverPrompt.SetActive(false);
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
