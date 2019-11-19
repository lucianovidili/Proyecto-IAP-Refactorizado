﻿using System;

public class EstadoGolJugador1 : EstadoGolAbstracto
{
    public ControladorJuego juego;

    public EstadoGolJugador1(ControladorJuego ctrlJuego)
    {
        // Constructor
        this.juego = ctrlJuego;
    }

    public override void Ejecutar()
    {
        // Realiza la acción correspondiente
        base.EjecutarGol(juego);

        if (!typeof(EstadoFin).Equals(juego.estado.GetType()))      // estado != Estados.fin
        {
            // Gol del Jugador1
            juego.cambiarEstado(new EstadoSacaJugador2(juego));
            juego.resetearDisco(3.2f);
        }
    }
}