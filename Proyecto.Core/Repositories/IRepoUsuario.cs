using System;
using Models;
using System.Collections.Generic;

namespace Repositories
{
    public interface IRepoUsuario
    {
        List<Usuario> ObtenerTodos();
        Usuario? ObtenerPorId(ushort id);
        Usuario Agregar(Usuario usuario);
        void Eliminar(ushort id);

    }
}