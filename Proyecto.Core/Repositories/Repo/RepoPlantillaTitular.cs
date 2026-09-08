using System;
using System.Collections.Generic;
using Models;
using Interfaces;

namespace Repositories
{
    public interface IRepoPlantillaTitular
    {
        List<PlantillaTitular> ObtenerTodos();
        PlantillaTitular? ObtenerPorId(ushort id);
        List<Jugador> ObtenerTitularPlantilla(ushort id);
        void Agregar(PlantillaTitular plantillaTitular);
        void Eliminar(ushort id);
    }
}