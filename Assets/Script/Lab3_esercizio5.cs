using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lab3_esercizio5 : MonoBehaviour
{
    [SerializeField] int num1 = 29;
    // Start is called before the first frame update
    void Start()
    {
        if (num1 % 2 == 0){
            Debug.Log("Il numero "+ num1 + "è pari");
        }
        else
        Debug.Log("Il numero "+ num1 + " è dispari");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
