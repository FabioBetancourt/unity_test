using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayerX : MonoBehaviour
{
    public GameObject plane;
    private Vector3 offset = new Vector3(23,1,3);

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    private void LateUpdate()
    {
        transform.position = plane.transform.position + offset;
    }
}
