using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Farmer : MonoBehaviour
{

    int lifeTime = 1;
    public void Start()
    {
        StartCoroutine(WaitThenDie());
    }



    IEnumerator WaitThenDie()
    {
        yield return new WaitForSeconds(lifeTime);
        gameObject.SetActive(false);
    }






}
