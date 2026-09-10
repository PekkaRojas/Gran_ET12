using System;
using System.Collections.Generic;
using Models;
using Interfaces;

namespace Repositories
{
    public class RepoUsuario : IRepoUsuario
    {
        public void Agregar(Usuario usuario)
        {
            throw new NotImplementedException("Falta conectar el repositorio real de usuarios.");
        }

        public List<Usuario> ObtenerTodos()
        {
            throw new NotImplementedException("Falta conectar el repositorio real de usuarios.");
        }

        public Usuario? ObtenerPorId(ushort id)
        {
            throw new NotImplementedException("Falta conectar el repositorio real de usuarios.");
        }

        public void Eliminar(ushort id)
        {
            throw new NotImplementedException("Falta conectar el repositorio real de usuarios.");
        }
    }
}