using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControladorDeEscena : MonoBehaviour {
    public GameObject Jugador;
    public Camera CamaraDeJuego;
    public GameObject[] BloquePreFab;
    public float PunteroDeJuego;
    public float LugarSeguroDeGeneracion = 12; 


    // Start is called before the first frame update
    void Start() {
        PunteroDeJuego = -7;
    }

    // Update is called once per frame
    void Update() {
        if(Jugador!= null) { 
        CamaraDeJuego.transform.position = new Vector3(
            Jugador.transform.position.x,
            CamaraDeJuego.transform.position.y,
            CamaraDeJuego.transform.position.z
            );
        }

        while (Jugador != null && PunteroDeJuego < Jugador.transform.position.x + LugarSeguroDeGeneracion) 
        {
            int indiceBloque = Random.Range(0, BloquePreFab.Length - 1);
        }

    }
}
