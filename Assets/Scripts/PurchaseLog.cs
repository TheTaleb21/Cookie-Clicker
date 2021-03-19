using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PurchaseLog : MonoBehaviour
{
    public GameObject AutoCookie;
    public AudioSource playSound; 

    //doublethe cost after hiring the baker
    public void StartAutoCookie()
    {
        playSound.Play();
        AutoCookie.SetActive(true);
        if (GlobalCash.CashCount >= GlobalBaker.bakerValue)
        {
            GlobalCash.CashCount -= GlobalBaker.bakerValue;

        GlobalBaker.bakerValue *= 2;
        GlobalBaker.bakePerSec += 1;
        GlobalBaker.numberOfBakers += 1;    
        }

    }
}
