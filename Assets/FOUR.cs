using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FOUR : MonoBehaviour
{
    public int start;
    public int end;

    void Start()
    {
        //as long as the start is less than or equal to the end, the numbers whose module between 5 is 0 (divisible by 5) will be displayed
        while (start <= end)
        {
            start++;
            if (start % 5 == 0)
            {
                Debug.Log(start);
            }
        }
    }
}
