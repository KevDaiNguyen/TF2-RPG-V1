using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoucyMovement : MonoBehaviour
{
    public GameObject classBoxes;

    public int sideStart;

    public bool leftCheck;
    public bool rightCheck;

    //public Vector3 leftRotation;
    //public Vector3 rightRotation;

    private Quaternion leftRot;
    private Quaternion rightRot;

    public float bounceSpeed;

    // Start is called before the first frame update
    void Start()
    {
        sideStart = Random.Range(0, 2);
        // 0 = Left, 1 = Right

        //Debug.Log(sideStart);

        leftRot = Quaternion.Euler(0, 0, -20);
        rightRot = Quaternion.Euler(0, 0, 20);
    }

    // Update is called once per frame
    void Update()
    {
        if (sideStart == 0)
        {
            classBoxes.transform.rotation = Quaternion.Lerp(classBoxes.transform.rotation, leftRot, bounceSpeed);
            
        }
        else if (sideStart == 1)
        {
            classBoxes.transform.rotation = Quaternion.Lerp(classBoxes.transform.rotation, rightRot, bounceSpeed);
          
        }
    }

    private void LateUpdate()
    {
        if (classBoxes.transform.rotation == rightRot)
        {
            sideStart = 0;
        }
        else if (classBoxes.transform.rotation == leftRot)
        {
            sideStart = 1;
        }
    }
}
