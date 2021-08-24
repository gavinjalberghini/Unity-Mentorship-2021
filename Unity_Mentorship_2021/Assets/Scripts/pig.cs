using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pig : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
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
            transform.position = new Vector3(-5.8f, 4.85f, -99.1f);

    }
}
