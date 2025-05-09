using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lab3_esercizio6_7 : MonoBehaviour
{
    public int partenza = 4;
    // Start is called before the first frame update
    void Start()
    {
        Stampa2Successivi();
        Stampa2Precedenti();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void Stampa2Successivi()
    {
        Debug.Log("il numero di partenza è --> " + partenza);
        Debug.Log("il numero successivo è --> " + (partenza + 1).ToString());
        Debug.Log("il numero successivo è --> " + (partenza + 2).ToString());
    }
    void Stampa2Precedenti()
    {
        Debug.Log("il numero di partenza è --> " + partenza);
        Debug.Log("il numero precedente è --> " + (partenza - 1).ToString());
        Debug.Log("il numero precedente è --> " + (partenza - 2).ToString());
    }

}
