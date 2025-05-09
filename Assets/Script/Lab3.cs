using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lab3 : MonoBehaviour
{
    //attraverso public si espone la varibile nell'inspector ed essa sarà modificabile anche da altre classe
    public int EsempioA = 5;

    // //attraverso [SerializeField] si espone la varibile nell'inspector ma 
    // ed NON sarà modificabile da altre classe
    [SerializeField] int EsempioB = 5;
    

    
    void Start()
    {
        // Debug.Log("Hello World");

        /*
        CONSOLE: messaggio ripetuto una volta
        Hello World
        */
    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log("Hello World");

        /*
        CONSOLE: messaggio ripetuto per ogni frame
        Hello World
        */
    }
}
