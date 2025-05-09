using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lab3_esercizio8_9 : MonoBehaviour
{
    [SerializeField] int num1 = 8;
    [SerializeField] int num2 = 2;
    [SerializeField] int num3 = 90;
    [SerializeField] int num4 = 43;

    // Start is called before the first frame update
    void Start()
    {
        MaggioreTra2(num2, num1);
        MinoreTra2(num3, num4);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void MaggioreTra2(int a, int b)
    {
        if (a > b)
        {
            Debug.Log(a +" è maggiore di "+ b);
        }
        else
        Debug.Log(b +" è maggiore di "+ a);
    }

    void MinoreTra2(int a, int b)
    {
        if (a < b)
        {
            Debug.Log(a +" è minore di "+ b);
        }
        else
        Debug.Log(b +" è minore di "+ a);
    }
}
