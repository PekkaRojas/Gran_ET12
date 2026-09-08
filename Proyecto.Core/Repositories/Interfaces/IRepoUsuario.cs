using System;
using Models;
using System.Collections.Generic;

namespace Interfaces
{
    public interface IRepoUsuario
    {
        List<Usuario> ObtenerTodos();
        Usuario? ObtenerPorId(ushort id);
        void Agregar(Usuario usuario);
        void Eliminar(ushort id);

    }
}