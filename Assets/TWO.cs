using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TWO : MonoBehaviour
{
    private int t = 1;
    void Start()
    {
        // it prints twenty times this message
        while (t <= 20)
        {
            Debug.Log("“Hola, holita, vecinito");
            t++;
        }
    }
}
