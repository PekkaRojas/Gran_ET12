using System;
using Models;
using System.Collections.Generic;

namespace Interfaces
{
    public interface IRepoPlantilla
    {
        List<Plantilla> ObtenerTodos();
        Plantilla? ObtenerPorId(ushort id);
        List<Jugador> ObtenerJugadoresPorPlantilla(ushort id);
        float ObtenerCalificacionPlantilla(ushort id);
        void Agregar(Plantilla plantilla);
        void Eliminar(ushort id);
    }
}