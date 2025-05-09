using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lab3_esercizio10 : MonoBehaviour
{
    float time = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;
        if(time <= 15) 
            Debug.Log("Sono trascorsi meno di 30 secondi");
        else if(time >= 30) 
           Debug.Log("Sono trascorsi più di 30 secondi");   
        else if(time >= 45)
            Debug.Log("Sono trascorsi più di 45 secondi");    
        else if(time >= 60)
            Debug.Log("E' trascorso un minuto");   

        Debug.Log("Time -->" + time);
    }
}
