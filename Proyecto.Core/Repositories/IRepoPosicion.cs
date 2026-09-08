using System;
using Models;
using System.Collections.Generic;
namespace Repositories
{
    public interface IRepoPosicion
    {
        List<Posicion> ObtenerTodos();
        Posicion? ObtenerPorId(ushort id);
        List<Jugador> ObtenerJugadoresPorPosicion(ushort id);
        Posicion Agregar(Posicion posicion);
        void Eliminar(ushort id);
    }
}