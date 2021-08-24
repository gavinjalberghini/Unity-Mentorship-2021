using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ProgressBar : MonoBehaviour
{

    public Slider slider;
    private float targetProgress = 0;
    public float FillSpeed = 0.5f;


    private void Awake()
    {
        slider = gameObject.GetComponent<Slider>();
    }


    void Start()
    {
        IncrementProgress(1f); 
    }

    // Update is called once per frame
    void Update()
    {

        if(slider.value < targetProgress && Input.GetKey(KeyCode.DownArrow))
        {
            slider.value += FillSpeed * Time.deltaTime; 
        }


    }


    public void IncrementProgress(float newProgress)
    {
        targetProgress = slider.value + newProgress;
        Time.timeScale = 0;
    }


}
