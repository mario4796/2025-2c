using Clase2._202025.Entidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase2._2C2025.Logica
{
    public interface ITipoLocalServicio
    {
        void AgregarTipoLocal(TipoLocal tipoLocal);
        List<TipoLocal> ObtenerTiposLocal();
    }

    public class TipoLocalServicio : ITipoLocalServicio
    {
        private static List<TipoLocal> _tiposLocal = new();

        public void AgregarTipoLocal(TipoLocal tipoLocal)
        {
            _tiposLocal.Add(tipoLocal);
        }

        public List<TipoLocal> ObtenerTiposLocal()
        {
            return _tiposLocal;
        }
    }
}
