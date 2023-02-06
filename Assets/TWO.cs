using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TWO : MonoBehaviour
{
    void Start()
    {
        for(int i = 100; i >= 0; i-=2)
        {
            Debug.Log(i);
        }    
    }
}
