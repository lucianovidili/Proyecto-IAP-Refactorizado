using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GUI : MonoBehaviour
{
    public UnityEngine.UI.Text[] golesGUIJugador1 = {null, null};
    public UnityEngine.UI.Text[] golesGUIJugador2 = {null, null};
    public UnityEngine.UI.Text mensajeControl;
    public UnityEngine.UI.Button botonModo;
    public UnityEngine.UI.Text textoBotonModo;

    public ControladorJuego juego;

    private bool VR = true;

    void Start()
    {
        botonModo.onClick.AddListener(oyente);
    }

    void oyente()
    {
        VR = !VR;
        textoBotonModo.text = VR ? "VR" : "Normal";
        juego.cambiarModo(VR);
    }

    public void setMensajeControl(string mensaje)
    {
        mensajeControl.text = mensaje;
    }

    public void setGoles(int golesJugador1, int golesJugador2)
    {
        golesGUIJugador1[0].text = golesJugador1.ToString();
        golesGUIJugador2[0].text = golesJugador1.ToString();
        golesGUIJugador1[1].text = golesJugador2.ToString();
        golesGUIJugador2[1].text = golesJugador2.ToString();
    }
}