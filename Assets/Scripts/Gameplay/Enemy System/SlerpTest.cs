using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlerpTest : MonoBehaviour
{
    public GameObject attackingSlot;
    public GameObject targetSlot;
    private float speed;

    private Vector3 originalPosition;
    private float startingTime;
    public float desiredTravelTime;

    // Start is called before the first frame update
    void Start()
    {
        originalPosition = new Vector3(attackingSlot.transform.position.x, attackingSlot.transform.position.y, attackingSlot.transform.position.z);
        startingTime = Time.time;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void DoAttack()
    {
        speed = (Time.time - startingTime) / desiredTravelTime;
        attackingSlot.transform.position = Vector3.Slerp(attackingSlot.transform.position, targetSlot.transform.position, speed);
        startingTime = Time.time;
    }

    public void ResetPosition()
    {
        speed = (Time.time - startingTime) / desiredTravelTime;
        attackingSlot.transform.position = Vector3.Slerp(attackingSlot.transform.position, originalPosition, speed);
        startingTime = Time.time;
    }
}
