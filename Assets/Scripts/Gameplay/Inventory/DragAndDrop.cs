using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class DragAndDrop : MonoBehaviour, IPointerDownHandler, IBeginDragHandler, IEndDragHandler, IDragHandler
{
    public GameObject inventoryItem;
    private RectTransform invTransform;

    public Canvas HUDCanvas;
    private CanvasGroup invCanvasGroup;

    public float divideScale;

    private void Start()
    {
        invTransform = inventoryItem.GetComponent<RectTransform>();
        //Debug.Log(HUDCanvas.scaleFactor);
    }

    public void OnBeginDrag(PointerEventData eventData)
    {
        
    }

    public void OnDrag(PointerEventData eventData)
    {
        invTransform.anchoredPosition += (eventData.delta / divideScale);
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        
    }

    public void OnPointerDown(PointerEventData eventData)
    {

    }
}
