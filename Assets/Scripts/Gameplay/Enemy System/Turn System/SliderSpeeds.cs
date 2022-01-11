using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SliderSpeeds : MonoBehaviour
{
    public CharacterHealth[] characterHealths;
    public GameObject[] sliderObjects;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        sliderObjects[0].GetComponent<ConstantForce>().force = new Vector3(0, characterHealths[0].baseSpeed * -285, 0);
        sliderObjects[1].GetComponent<ConstantForce>().force = new Vector3(0, characterHealths[1].baseSpeed * -250, 0);
        sliderObjects[2].GetComponent<ConstantForce>().force = new Vector3(0, characterHealths[2].baseSpeed * -235, 0);
        sliderObjects[3].GetComponent<ConstantForce>().force = new Vector3(0, characterHealths[3].baseSpeed * -200, 0);
        sliderObjects[4].GetComponent<ConstantForce>().force = new Vector3(0, characterHealths[4].baseSpeed * -210, 0);
        sliderObjects[5].GetComponent<ConstantForce>().force = new Vector3(0, characterHealths[5].baseSpeed * -225, 0);
        sliderObjects[6].GetComponent<ConstantForce>().force = new Vector3(0, characterHealths[6].baseSpeed * -260, 0);
        sliderObjects[7].GetComponent<ConstantForce>().force = new Vector3(0, characterHealths[7].baseSpeed * -275, 0);
    }
}
