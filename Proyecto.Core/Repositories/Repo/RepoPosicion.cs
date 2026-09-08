using System;
using System.Collections.Generic;
using Models;
using Interfaces;

namespace Repositories
{
    public class RepoPosicion : IRepoPosicion
    {
        public void Agregar(Posicion posicion)
        {
            throw new NotImplementedException("Falta conectar el repositorio real de posiciones.");
        }

        public List<Posicion> ObtenerTodos()
        {
            throw new NotImplementedException("Falta conectar el repositorio real de posiciones.");
        }

        public List<Jugador> ObtenerJugadoresPorPosicion(ushort id)
        {
            throw new NotImplementedException("Falta conectar el repositorio real de posiciones.");
        }

        public Posicion? ObtenerPorId(ushort id)
        {
            throw new NotImplementedException("Falta conectar el repositorio real de posiciones.");
        }

        public void Eliminar(ushort id)
        {
            throw new NotImplementedException("Falta conectar el repositorio real de posiciones.");
        }
    }
}