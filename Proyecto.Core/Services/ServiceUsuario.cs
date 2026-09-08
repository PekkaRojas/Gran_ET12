using System;
using System.Collections.Generic;
using Repositories;
using Interfaces;
using Models;

namespace Services
{
    public class ServiceUsuario : IRepoUsuario
    {
        private readonly IRepoUsuario _repoUsuario;

        public ServiceUsuario(IRepoUsuario repoUsuario)
        {
            _repoUsuario = repoUsuario;
        }

        public void Agregar(Usuario usuario)
        {
            _repoUsuario.Agregar(usuario);
        }

        public List<Usuario> ObtenerTodos()
        {
            return _repoUsuario.ObtenerTodos();
        }

        public Usuario? ObtenerPorId(ushort id)
        {
            return _repoUsuario.ObtenerPorId(id);
        }

        public void Eliminar(ushort id)
        {
            _repoUsuario.Eliminar(id);
        }
    }
}
