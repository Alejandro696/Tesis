using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CodigoMain : MonoBehaviour
{
    //[SerializeField] public int min, seg;

    public float restante;
    private bool ActivadaTimmer;

    public int timmer,seg,horas;
    public GameManager codigo;
    public Text textoTimmer;
    public Text textoPuntos;
    
    // Start is called before the first frame update
    void Start()
    {
        //textoPuntos = GameObject.Find("Puntaje").GetComponent<Text>();
    }

    private void Awake()
    {
       
        timmer = GameManager.input;
        restante = (timmer * 60)*60;
        

        ActivadaTimmer = true;
    }
    // Update is called once per frame
    void Update()
    {
        if (ActivadaTimmer && restante >=0)
        {
            restante -= Time.deltaTime;
            //float tiempoPuntos = restante / 4;
            //float tiempoPuntos2 = (restante / 4);
            //textoTimmer.text = "Te faltan " + restante + " de enternamiento";

            int tempMin = Mathf.FloorToInt(restante/60);
            int tempMin2 = Mathf.FloorToInt(tempMin % 60);
            int tempSeg = Mathf.FloorToInt(restante%60);
            int tempHoras = Mathf.FloorToInt(tempMin/60);
            textoTimmer.text = string.Format("{00:00}:{01:00}:{02:00}",tempHoras, tempMin2, tempSeg);
            //textoTimmer.text = string.Format("{0}:{1}:{2}", tempHoras, tempMin2, tempSeg);
            if (restante%0.5 == 0)
            {
                GameManager.Puntos += 100;
                
                //int PuntosPartida =GameManager.Puntos += 100;
                Debug.Log("Deberia poder mostrarme los puntos");
                Debug.Log("Pts: "+ GameManager.Puntos.ToString());

                if (GameManager.Puntos == 3000)
                {
                    //Personaje cambia fisicamente
                }
            }
            textoPuntos.text = ("Pts: " + GameManager.Puntos.ToString());
            
        }
        
        //timmer = timmer - 1f + Time.deltaTime;
    }
}
