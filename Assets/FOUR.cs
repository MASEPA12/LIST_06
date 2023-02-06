using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FOUR : MonoBehaviour
{
    public int start;
    public int end;

    void Start()
    {
        while (start >= end)
        {

            if (start % 5 == 0)
            {
                Debug.Log(start);
            }
            start += 5;

        }
    }
}
