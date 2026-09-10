using System;
using System.Collections.Generic;
using Models;
using Interfaces;

namespace Repositories
{
    public class RepoPlantillaSuplente : IRepoPlantillaSuplente
    {
        public List<PlantillaSuplente> ObtenerTodos()
        {
            throw new NotImplementedException("Falta conectar el repositorio real de plantillas suplentes.");
        }

        public PlantillaSuplente? ObtenerPorId(ushort id)
        {
            throw new NotImplementedException("Falta conectar el repositorio real de plantillas suplentes.");
        }

        public List<Jugador> ObtenerSuplentesPlantilla(ushort id)
        {
            throw new NotImplementedException("Falta conectar el repositorio real de plantillas suplentes.");
        }

        public void Agregar(PlantillaSuplente plantillaSuplente)
        {
            throw new NotImplementedException("Falta conectar el repositorio real de plantillas suplentes.");
        }

        public void Eliminar(ushort id)
        {
            throw new NotImplementedException("Falta conectar el repositorio real de plantillas suplentes.");
        }
    }
}