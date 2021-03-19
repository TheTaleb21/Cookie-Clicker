using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GlobalBaker : MonoBehaviour
{
    public GameObject fakeButton;
    public GameObject fakeText;
    public GameObject realButton;
    public GameObject realText;
    public int currentCash;
    public static int bakerValue =10;
    public GameObject bakerStats;
    public static int numberOfBakers;
    public static int bakePerSec;


    void Start()
    {
        
    }

    //calculating baker amounts hiringand s
    void Update()
    {
        currentCash = GlobalCash.CashCount;
        bakerStats.GetComponent<Text>().text = "Bakers : " + numberOfBakers +" @ " + bakePerSec + " Per sec";
        fakeText.GetComponent<Text>().text = "Hire Baker - $" + bakerValue;
        realText.GetComponent<Text>().text = "Hire Baker - $" + bakerValue;

        if (currentCash >= bakerValue)
        {
            fakeButton.SetActive(false);
            realButton.SetActive(true);
        }
    }
}