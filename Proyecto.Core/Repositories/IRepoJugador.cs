using System;
using Models;
using System.Collections.Generic;

namespace Repositories
{
    public interface IRepoJugador
    {
        List<Jugador> ObtenerTodos();
        Jugador? ObtenerPorId(ushort id);
        Equipo? ObtenerEquipoPorJugador(ushort id);
        Posicion? ObtenerPosicionPorJugador(ushort id);
        Jugador Agregar(Jugador jugador);
        void Eliminar(ushort id);
    }
}