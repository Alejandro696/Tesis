using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EjecutarCodigo : MonoBehaviour
{
    public int input;
    public GameObject boton;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void LeerInput(string s)
    {
        
        
       try
       {
            int texto = int.Parse(s);
            input = texto;
            Debug.Log("Entrenamos " + input + " Horas");
            
            if (texto == input)
            {
                boton.SetActive(true);
            }
            else
            {
                boton.SetActive(false);
                
            }
       }
        catch
       {
            Debug.Log("Ingresa las Horas que vas a Entrenar!");
            //boton.SetActive(false);
       }
    }
}
