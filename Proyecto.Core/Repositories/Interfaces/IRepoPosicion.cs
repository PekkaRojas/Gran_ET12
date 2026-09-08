using System;
using Models;
using System.Collections.Generic;

namespace Interfaces
{
    public interface IRepoPosicion
    {
        List<Posicion> ObtenerTodos();
        Posicion? ObtenerPorId(ushort id);
        List<Jugador> ObtenerJugadoresPorPosicion(ushort id);
        void Agregar(Posicion posicion);
        void Eliminar(ushort id);
    }
}