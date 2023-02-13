using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FIVE : MonoBehaviour
{
    public int[] ArraY;
    private int variable = 0;
    private string message;


    void Start()
    {
        foreach(int number in ArraY)
        {   //save to message variable the components of the array plus the string +
            message += number.ToString() + " + ";
            //sum every number of the array
            variable += number;
           
        }
        //delete the two last caracters of the message
        message = message.Remove(message.Length - 2);
        //add "=" and the sum of the components to the message
        message += "= " + variable;
        //print message
        Debug.Log(message);
    }
}
