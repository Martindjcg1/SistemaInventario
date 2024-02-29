using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace SistemaInventario.AccesoDatos.Repositorio.IRepositorio
{                                                                   
    public interface IRepositorio<T> where T : class
    {
        //T= Para cualquier tipo de clase
        Task<T> Obtener(int id);
                                                        //Bodega (0 Elementos)=Filtro = null
                                                        //Bodega (10 Elementos)= Filtro = True
        Task<IEnumerable<T>> ObtenerTodos(Expression<Func<T, bool>> filtro=null, 
                                    Func<IQueryable<T>, IOrderedQueryable<T>> OrdeBy= null,
                                    string incluirPropiedades=null,
                                    bool isTracking = true 
                                    ); //Hace una consulta con los parametros mandados por el usuario y ordena dicha consulta
                                       //bool isTracking = true significa que unicamente se esta leyendo, si fuera false, se estaria escribiendo
        Task<T> ObtenerPrimero(Expression<Func<T, bool>> filtro = null,
                                    string incluirPropiedades = null,
                                    bool isTracking = true
                                    ); //Hace una consulta al primer resultado obtenido
        Task Agregar(T entidad);

        void Remover(T entidad);

        void RemoverRango(IEnumerable<T> entidad);


    }
}
