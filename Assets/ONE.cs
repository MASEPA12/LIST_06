using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ONE : MonoBehaviour
{
    void Start()
    {
        //Starting from 100, until 0, it will print a number every 2 
        for (int i = 100; i >= 0; i -= 2)
        {
            Debug.Log(i);
        }
    }
}
