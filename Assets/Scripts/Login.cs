using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Login : MonoBehaviour
{
    public Text usuario;
    public Text password;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       
       
    }
    public void CargarJuego(string scenename)  //CREAR EVENTO DEL BOTON PARA CAMBIAR DE ESCENA! - AÑADO EL OBJETO Y LA FUNCION DENTRO DEL BOTON EN UNITY
    {
        SceneManager.LoadScene(scenename);
        //Importo UnityEngine.SceneManagment para poder usar el metodo SceneManager.LoadScene

    }

    public void BtnSubmit()
    {
        switch (usuario.text)
        {
            case "Ale":
                switch (password.text)
                {
                    case "666":
                        CargarJuego("PantallaCarga");
                        break;
                    default:
                        Debug.Log("Haz Ingresado un numero equivocado");
                        break;
                }
                break;
            case "Fer":
                switch (password.text)
                {
                    case "123":
                        CargarJuego("PantallaCarga");
                        break;
                    default:
                        Debug.Log("Haz Ingresado un numero equivocado");
                        break;
                }
                break;
            case "Agus":
                switch (password.text)
                {
                    case "987":
                        CargarJuego("PantallaCarga");
                        break;
                    default:
                        Debug.Log("Haz Ingresado un numero equivocado");
                        break;

                }
                break;
            default:
                Debug.Log("Haz Ingresado un numero equivocado");
                break;

        }
    }
}
