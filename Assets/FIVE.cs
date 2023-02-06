using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FIVE : MonoBehaviour
{
    public int[] ArraY;
    private int variable = 0;

    void Start()
    {
        foreach(int number in ArraY)
        {
            variable += number;

            Debug.Log(variable);
        }
    }
}
