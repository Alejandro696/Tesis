using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PantallaCarga : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(AccederJuego());
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator AccederJuego()
    {
        yield return new WaitForSeconds(3);
        CargarJuego("MenuPrincipal");
    }
    public void CargarJuego(string scenename)  //CREAR EVENTO DEL BOTON PARA CAMBIAR DE ESCENA! - AÑADO EL OBJETO Y LA FUNCION DENTRO DEL BOTON EN UNITY
    {
        SceneManager.LoadScene(scenename);
        //Importo UnityEngine.SceneManagment para poder usar el metodo SceneManager.LoadScene

    }
}
