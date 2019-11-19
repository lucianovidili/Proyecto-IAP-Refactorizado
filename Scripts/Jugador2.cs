using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Mirror;

public class Jugador2 : JugadorAbstracto
{
    public GameObject zonaJugador2;
    public Material materialJugador2;

    void Start()
    {
        base.Start();
        GetComponent<Renderer>().material = materialJugador2;
        zona = zonaJugador2;

        setearAnchoAltoZona(zona.transform.localScale.x * 1.0f, zona.transform.localScale.z * 1.0f);
    }

    void Update()
    {
        if (hasAuthority)
        {
            Vector3 posicionActual = Vector3.one;
            posicionActual.x = (anchoZona / anchoVentana) * Input.mousePosition.x;
            posicionActual.z = (altoZona / altoVentana) * Input.mousePosition.y;

            posicionActual.x += zona.transform.position.x - (anchoZona / 2.0f);
            posicionActual.z += zona.transform.position.z - (altoZona / 2.0f);

            posicionActual.y = 0.32f;
            transform.position = posicionActual;
        }
    }
}
