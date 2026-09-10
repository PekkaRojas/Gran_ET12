using System;
using System.Collections.Generic;
using Models;
using Interfaces;

namespace Repositories
{
    public interface IRepoPlantillaTitular
    {
        List<PlantillaTitular> ObtenerTodos()
        {
            throw new NotImplementedException("Falta conectar el repositorio real de plantillas titulares.");
        }

        PlantillaTitular? ObtenerPorId(ushort id)
        {
            throw new NotImplementedException("Falta conectar el repositorio real de plantillas titulares.");
        }

        List<Jugador> ObtenerTitularPlantilla(ushort id)
        {
            throw new NotImplementedException("Falta conectar el repositorio real de plantillas titulares.");
        }

        PlantillaTitular Agregar(PlantillaTitular plantillaTitular)
        {
            throw new NotImplementedException("Falta conectar el repositorio real de plantillas titulares.");
        }
        
        bool Eliminar(ushort id)
        {
            throw new NotImplementedException("Falta conectar el repositorio real de plantillas titulares.");
            return false;
        }
    }
}