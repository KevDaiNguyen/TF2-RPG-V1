using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GenerateMap : MonoBehaviour
{
    public GameObject originalPoint;
    public GameObject mapPoint;
    public GameObject mapBackground;

    private GameObject staringPoint;

    public Vector3 prevPosition;
    public int roomDecider;
    public bool shopOnce;

    private int leftRightMovement;
    private int tooFar;
    private int overreachDistance;

    public Sprite enemy;
    public Sprite loot;
    public Sprite shop;
    public Sprite eventRoom;

    // Start is called before the first frame update
    void Start()
    {
        GeneratTheMap();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void GeneratTheMap()
    {

        staringPoint = originalPoint;
        shopOnce = false;
        tooFar = 0;

        for (int i = 0; i < 5; i++)
        {
            prevPosition.Set((originalPoint.transform.position).x, (originalPoint.transform.position).y, (originalPoint.transform.position).z);
            //Debug.Log(originalPoint.transform.position);

            leftRightMovement = Random.Range(-70, 70);
            if (leftRightMovement > 0)
            {
                tooFar += leftRightMovement;
            }
            else
            {
                tooFar -= leftRightMovement;
            }

            if (tooFar > 80)
            {
                overreachDistance = tooFar - 80;
                leftRightMovement = overreachDistance * -2;
                //Debug.Log(overreachDistance);
                tooFar = 0;
                overreachDistance = 0;
            }
            else if (tooFar < -80)
            {
                overreachDistance = tooFar + 80;
                leftRightMovement = overreachDistance * 2;
                //Debug.Log(overreachDistance);
                tooFar = 0;
                overreachDistance = 0;
            }

            //Debug.Log(tooFar);

            GameObject mapInstance = Instantiate(mapPoint, originalPoint.transform.position + new Vector3(leftRightMovement, Random.Range(100, 120), 0), mapBackground.transform.rotation, mapBackground.transform);
            //Debug.Log(mapInstance.transform.position);
            originalPoint.GetComponent<LineRenderer>().SetPosition(0, prevPosition + new Vector3(0, 0, -10));
            originalPoint.GetComponent<LineRenderer>().SetPosition(1, mapInstance.transform.position + new Vector3(0, 0, -10));
            originalPoint = mapInstance;
            roomDecider = Random.Range(1, 5);
            if (roomDecider == 1)
            {
                originalPoint.tag = "Enemy";
                originalPoint.GetComponentInChildren<Image>().sprite = enemy;
            }
            else if (roomDecider == 2)
            {
                originalPoint.tag = "Loot";
                originalPoint.GetComponentInChildren<Image>().sprite = loot;
            }
            else if (roomDecider == 3 && !shopOnce)
            {
                originalPoint.tag = "Shop";
                originalPoint.GetComponentInChildren<Image>().sprite = shop;
                shopOnce = true;
            }
            else if (roomDecider == 4)
            {
                originalPoint.tag = "Event";
                originalPoint.GetComponentInChildren<Image>().sprite = eventRoom;
            }
            else
            {
                roomDecider = Random.Range(0, 3);
                //Debug.Log("Else " + roomDecider);
                if (roomDecider == 0)
                {
                    originalPoint.tag = "Enemy";
                    originalPoint.GetComponentInChildren<Image>().sprite = enemy;
                }
                else if (roomDecider == 1)
                {
                    originalPoint.tag = "Loot";
                    originalPoint.GetComponentInChildren<Image>().sprite = loot;
                }
                else if (roomDecider == 2)
                {
                    originalPoint.tag = "Event";
                    originalPoint.GetComponentInChildren<Image>().sprite = eventRoom;
                }

                
            }
            //Debug.Log(originalPoint.transform.position);
        }

        originalPoint = staringPoint;
        originalPoint.tag = "Untagged";
        shopOnce = false;

        for (int i = 0; i < 5; i++)
        {
            prevPosition.Set((originalPoint.transform.position).x, (originalPoint.transform.position).y, (originalPoint.transform.position).z);
            //Debug.Log(originalPoint.transform.position);

            leftRightMovement = Random.Range(-70, 70);
            if (leftRightMovement > 0)
            {
                tooFar += leftRightMovement;
            }
            else
            {
                tooFar -= leftRightMovement;
            }

            if (tooFar > 80)
            {
                overreachDistance = tooFar - 80;
                leftRightMovement = overreachDistance * -2;
                //Debug.Log(overreachDistance);
                tooFar = 0;
                overreachDistance = 0;
            }
            else if (tooFar < -80)
            {
                overreachDistance = tooFar + 80;
                leftRightMovement = overreachDistance * 2;
                //Debug.Log(overreachDistance);
                tooFar = 0;
                overreachDistance = 0;
            }

            //Debug.Log(tooFar);

            GameObject mapInstance = Instantiate(mapPoint, originalPoint.transform.position + new Vector3(leftRightMovement, Random.Range(100, 120), 0), mapBackground.transform.rotation, mapBackground.transform);
            //Debug.Log(mapInstance.transform.position);
            originalPoint.GetComponent<LineRenderer>().SetPosition(0, prevPosition + new Vector3(0, 0, -10));
            originalPoint.GetComponent<LineRenderer>().SetPosition(1, mapInstance.transform.position + new Vector3(0, 0, -10));
            originalPoint = mapInstance;
            roomDecider = Random.Range(1, 4);
            if (roomDecider == 1)
            {
                originalPoint.tag = "Enemy";
                originalPoint.GetComponentInChildren<Image>().sprite = enemy;
            }
            else if (roomDecider == 2)
            {
                originalPoint.tag = "Loot";
                originalPoint.GetComponentInChildren<Image>().sprite = loot;
            }
            else if (roomDecider == 3 && !shopOnce)
            {
                originalPoint.tag = "Shop";
                originalPoint.GetComponentInChildren<Image>().sprite = shop;
                shopOnce = true;
            }
            else if (roomDecider == 4)
            {
                originalPoint.tag = "Event";
                originalPoint.GetComponentInChildren<Image>().sprite = eventRoom;
            }
            else
            {
                roomDecider = Random.Range(0, 3);
                //Debug.Log("Else " + roomDecider);
                if (roomDecider == 0)
                {
                    originalPoint.tag = "Enemy";
                    originalPoint.GetComponentInChildren<Image>().sprite = enemy;
                }
                else if (roomDecider == 1)
                {
                    originalPoint.tag = "Loot";
                    originalPoint.GetComponentInChildren<Image>().sprite = loot;
                }
                else if (roomDecider == 2)
                {
                    originalPoint.tag = "Event";
                    originalPoint.GetComponentInChildren<Image>().sprite = eventRoom;
                }
            }

            //Debug.Log(originalPoint.transform.position);
        }
    }

    public void NextMap()
    {
        originalPoint = staringPoint;        
        shopOnce = false;
        roomDecider = Random.Range(1, 4);
        if (roomDecider == 1)
        {
            originalPoint.tag = "Enemy";
            originalPoint.GetComponentInChildren<Image>().sprite = enemy;
        }
        else if (roomDecider == 2)
        {
            originalPoint.tag = "Loot";
            originalPoint.GetComponentInChildren<Image>().sprite = loot;
        }
        else if (roomDecider == 3 && !shopOnce)
        {
            originalPoint.tag = "Shop";
            originalPoint.GetComponentInChildren<Image>().sprite = shop;
            shopOnce = true;
        }
        else
        {
            originalPoint.tag = "Enemy";
            originalPoint.GetComponentInChildren<Image>().sprite = enemy;
        }
        GeneratTheMap();
    }
}
