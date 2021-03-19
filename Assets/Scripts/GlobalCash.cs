using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GlobalCash : MonoBehaviour
{

    //Finally making da moneys basically duplicated our other script and changed the name
    public static int CashCount;
    public GameObject CashDisplay;
    public int InternalCash; 

    // this is the part of the cooking counting adding
    void Update()
    {   
        InternalCash = CashCount;

        CashDisplay.GetComponent<Text>().text = "$" + InternalCash;
         
    }
}
