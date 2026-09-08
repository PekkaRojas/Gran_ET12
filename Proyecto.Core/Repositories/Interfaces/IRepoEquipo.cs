using System;
using Models;
using System.Collections.Generic;

namespace Interfaces
{
    public interface IRepoEquipo
    {
        List<Equipo> ObtenerTodos();
        Equipo? ObtenerPorId(ushort id);
        List<Jugador> ObtenerJugadoresPorEquipo(ushort id);
        void Agregar(Equipo equipo);
        void Eliminar(ushort id);
    }
}