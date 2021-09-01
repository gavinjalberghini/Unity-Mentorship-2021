using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PigFlip : MonoBehaviour
{
   // Start is called before the first frame update
    void Start()
    {
        transform.position = new Vector3(3121f, -249f, -22.9f);
    }

    // Update is called once per frame
    void Update()
    {
            if (Input.GetKeyDown(KeyCode.DownArrow))
            {
                transform.position = new Vector3(16.9f, 4.8f, -105f);
            }
            else
                transform.position = new Vector3(3121f, -249f, -22.9f);


    }

    





}
