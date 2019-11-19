using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Mirror;

public abstract class JugadorAbstracto : NetworkBehaviour
{
    public ControladorJuego juego;
    private Vector3 direccion;
    private float velocidad = 0.2f;

    private GameObject zona;
    private float anchoZona, altoZona;
    private float anchoVentana, altoVentana;

    void Start()
    {
        anchoVentana = Screen.width;
        altoVentana = Screen.height;

        juego.jugadorConectado(this);
    }

    void setearAnchoAltoZona(float anchoZ, float altoZ)
    {
        anchoZona = anchoZ;
        altoZona = altoZ;
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
