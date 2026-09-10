using System;
using Models;
using System.Collections.Generic;

namespace Interfaces
{
    public interface IRepoPuntuacion
    {
        List<Puntuacion> ObtenerTodos();
        Puntuacion? ObtenerPorId(ushort id);
        List<Jugador> ObtenerJugadoresPorPuntuacion(ushort id);
        float ObtenerCalificacionPuntuacion(ushort id);
        Puntuacion Agregar(Puntuacion puntuacion);
        bool Eliminar(int id);
    }
}