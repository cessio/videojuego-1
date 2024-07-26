using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScripPrueba : MonoBehaviour
{
    // Start is called before the first frame update
    // string texto1 = "Nombre1";
    // string texto2 = "Nombre2";

    // int numEntero = 0;

    public float pos;
    //public double dere;
    public bool trasldo1;
    public bool trasldo2;
    public bool trasldo3;


    void Start()
    {

        //transform.Rotate(0,izq,0);
        
        

        if(trasldo1==true){
            transform.Translate(pos,0,pos);
        }if(trasldo2==true){
            transform.Translate(-pos,0,pos);
        }if(trasldo3==true){
            transform.Translate(0,0,pos+2);
        }

        //posicionInicial = transform.position;

        //transform.Translate(2,0,2);
        // if(numEntero == 1)
        //     name = texto1;
        // else
        //     name = texto2;
    }

    // Update is called once per frame
    void Update()
    {
        // if(trasldo1==true)
        //     switch(izq){
        //         case 2: transform.Translate(izq,0,izq); break;
        //         case 
        //     }
        
        
        // if(trasldo){
        //     transform.Translate(izq,0,izq);
        // }else 
        //     if(izq==4){
        //         transform.Translate(-izq,0,izq);
        //     }
            
        // }
       // transform.Translate(0,0,5);

    }

        

        
        
    
}
