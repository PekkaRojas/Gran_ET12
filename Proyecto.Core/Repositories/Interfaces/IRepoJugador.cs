using System;
using Models;
using System.Collections.Generic;

namespace Interfaces
{
    public interface IRepoJugador
    {
        List<Jugador> ObtenerTodos();
        Jugador? ObtenerPorId(ushort id);
        Equipo? ObtenerEquipoPorJugador(ushort id);
        Posicion? ObtenerPosicionPorJugador(ushort id);
        void Agregar(Jugador jugador);
        void Eliminar(ushort id);
    }
}