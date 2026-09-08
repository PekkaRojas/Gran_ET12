using System;
using System.Collections.Generic;
using Models;
using Interfaces;

namespace Repositories
{
    public class RepoPlantilla : IRepoPlantilla
    {
        public List<Plantilla> ObtenerTodos()
        {
            throw new NotImplementedException("Falta conectar el repositorio real de plantillas.");
        }

        public Plantilla? ObtenerPorId(ushort id)
        {
            throw new NotImplementedException("Falta conectar el repositorio real de plantillas.");
        }

        public List<Jugador> ObtenerJugadoresPorPlantilla(ushort id)
        {
            throw new NotImplementedException("Falta conectar el repositorio real de plantillas.");
        }

        public float ObtenerCalificacionPlantilla(ushort id)
        {
            throw new NotImplementedException("Falta conectar el repositorio real de plantillas.");
        }

        public void Agregar(Plantilla plantilla)
        {
            throw new NotImplementedException("Falta conectar el repositorio real de plantillas.");
        }

        public void Eliminar(ushort id)
        {
            throw new NotImplementedException("Falta conectar el repositorio real de plantillas.");
        }
    }
}