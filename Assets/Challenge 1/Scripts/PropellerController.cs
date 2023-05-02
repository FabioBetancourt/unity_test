using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PropellerController : MonoBehaviour
{
    private float rotateSpeed = 1000.0f;
    private Vector3 rotationDirection = new Vector3(0,0,1);
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(rotationDirection * (rotateSpeed * Time.deltaTime));
    }
}
