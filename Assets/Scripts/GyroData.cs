using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GyroData : MonoBehaviour
{
    public GameObject ControllableObject;
    public float attenuation;
    // Start is called before the first frame update
    void Start()
    {
            
    }

    // Update is called once per frame
    void Update()
    {
        ControllableObject.transform.Translate(Input.acceleration * attenuation);
    }
}
