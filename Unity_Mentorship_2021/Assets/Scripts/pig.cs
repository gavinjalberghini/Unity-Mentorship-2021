using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pig : MonoBehaviour
{
 
    void Awake()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            transform.position = new Vector3(6.7f, -249f, -22.9f);
        }
        else
            transform.position = new Vector3(-12.9f, 9.6f, -105f);
    }
}
