using SistemaInventario.AccesoDatos;
using SistemaInventario.AccesoDatos.Repositorio.IRepositorio;
using SistemaInventario.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemaInventario.AccesoDatos.Data;

namespace SistemaInventario.AccesoDatos.Repositorio
{
    public class UsuarioAplicacionRepositorio : Repositorio<UsuarioAplicacion>, IUsuarioAplicacionRepositorio
    {
        private readonly ApplicationDbContext _db;

        public UsuarioAplicacionRepositorio(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public void Actualizar(UsuarioAplicacion usuarioAplicacion)
        {
           
        }
    }
}
