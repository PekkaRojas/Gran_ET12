using System;
using Models;
using System.Collections.Generic;

namespace Interfaces
{
    public interface IRepoPlantillaTitular
    {
        List<PlantillaTitular> ObtenerTodos();
        PlantillaTitular? ObtenerPorId(ushort id);
        List<Jugador> ObtenerTitularesPlantilla(ushort id);
        PlantillaTitular Agregar(PlantillaTitular plantillaTitular);
        bool Eliminar(int id);
    }
}