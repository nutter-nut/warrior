using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camera_1_controller : MonoBehaviour
{
    public Transform obj;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
            transform.position = new Vector3 (obj.position.x, transform.position.y, transform.position.z);
    }
}