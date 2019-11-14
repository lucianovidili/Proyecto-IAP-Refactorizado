﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IA : MonoBehaviour
{
    public ControladorJuego juego;

    private Vector3 direccion;

    private float velocidad = 0.2f;

    private float movIzquierdaDerecha = 1;

	void Update()
	{
		move();
	}

    public void move()
    {
        direccion = new Vector3(movIzquierdaDerecha, 0.0f, 0.0f);
        GetComponent<Rigidbody>().position += direccion * velocidad;
        GetComponent<Rigidbody>().position = new Vector3(
                Mathf.Clamp(GetComponent<Rigidbody>().position.x,-3.3f,3.3f),
                0.0f,
                6f);
    }

    void OnTriggerEnter(Collider colision)
    {
        GameObject obj = colision.gameObject;

        if (colision.gameObject.tag == "Costado")
            movIzquierdaDerecha *= -1;
    }

    public void sacar(Vector2 dir)
    {
        direccion = new Vector3(dir.x, 0.0f, dir.y);
        GetComponent<Rigidbody>().position += direccion * velocidad;
    }

    public Vector2 getPosicion()
    {
        return new Vector2(GetComponent<Rigidbody>().position.x, GetComponent<Rigidbody>().position.z);
    }

    public void setPosicion(float x, float y, float z)
    {
        GetComponent<Rigidbody>().position = new Vector3(x, y, z);
    }
}
