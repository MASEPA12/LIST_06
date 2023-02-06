using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class THREE : MonoBehaviour
{
    void Start()
    {   //we call the CountDown function once
        StartCoroutine(CountDown());
    }
    private IEnumerator CountDown()
    {   //meanwhile a is bigger than 0, it will wait one second and print a
        for (int a = 60; a >= 0; a--)
        {
            yield return new WaitForSeconds(1);

            Debug.Log(a);
            if (a == 0)
            {
                Debug.Log("COUNTDOWN FINISHED");
            }
        }
    }
}
