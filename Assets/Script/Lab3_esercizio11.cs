using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

public class Lab3_esercizio11 : MonoBehaviour
{
    public float voto = 9;

    // Start is called before the first frame update
    void Start()
    {
        //if(voto >= 10) {
        //    Debug.Log("A+");
        //}
        //else if(voto >= 9) {
        //    Debug.Log("A");
        //}
        //else if(voto >= 7 || voto >= 8){
        //    Debug.Log("B");
        //}
        //else if(voto >= 6){
        //    Debug.Log("C");
        //}
        //else if(voto >= 5){
        //    Debug.Log("E");
        //}
        //else if(voto >= 0.4f){
        //    Debug.Log("F");
        //}

        switch (voto)
        {
            case >= 10:
                UnityEngine.Debug.Log("A+");
                break;
            case >= 9:
                UnityEngine.Debug.Log("A");
                break;
            case >= 7:
                UnityEngine.Debug.Log("B");
                break;
            case >= 6:
                UnityEngine.Debug.Log("C");
                break;
            case >= 5:
                UnityEngine.Debug.Log("E");
                break;
            case >= 0:
                UnityEngine.Debug.Log("F");
                break;
        }
    }
}
