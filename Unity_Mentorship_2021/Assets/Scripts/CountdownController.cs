using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CountdownController : MonoBehaviour
{

    public int time;
    public Text countdownDisplay;

    IEnumerator CountdownToStart()
    {
        while (time > 0)
        {
        countdownDisplay.text = time.ToString();

        yield return new WaitForSeconds(1f);

        time--;
        }

countdownDisplay.text = "yee";

       // GameController.instance.BeginGame();


        yield return new WaitForSeconds(1f);
        countdownDisplay.gameObject.SetActive(false);

    }












    private void Start()
    {

        StartCoroutine(CountdownToStart());
    }
   


}

