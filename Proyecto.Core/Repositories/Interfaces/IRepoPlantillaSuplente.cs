using System;
using Models;
using System.Collections.Generic;

namespace Interfaces
{
    public interface IRepoPlantillaSuplente
    {
        List<PlantillaSuplente> ObtenerTodos();
        PlantillaSuplente? ObtenerPorId(ushort id);
        List<Jugador> ObtenerSuplentesPlantilla(ushort id);
        void Agregar(PlantillaSuplente plantillaSuplente);
        void Eliminar(ushort id);
    }
}