using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lab3_esercizio4 : MonoBehaviour
{

    [SerializeField] int num1 = 5;
    [SerializeField] int num2 = 10;
    [SerializeField] int num3 = 15;
    [SerializeField] int num4 = 20;

    private int somma;
    private int prodotto;
    private float media;
    
    // Start is called before the first frame update
    void Start()
    {
        somma = num1+num2+num3+num4;
        Debug.Log("La somma è "+somma);

        prodotto = num1*num2*num3*num4;
        Debug.Log("Il prodotto è "+ prodotto);

        media = (num1+num2+num3+num4)/4;
        Debug.Log("La media è "+media);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
