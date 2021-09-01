using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoseCondition : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (gameObject.tag == "enemy" && Input.GetKeyDown(KeyCode.DownArrow)) 
        {
            Time.timeScale = 0;
        }
    }
}
