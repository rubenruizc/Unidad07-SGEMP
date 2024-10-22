using Ejercicio04spMvc.Models.DAL;
using Ejercicio04spMvc.Models.ENT;

namespace Ejercicio04spMvc.Models.VM
{
    public class ClsEditarPersonaVM : ClsPersona
    {
        List<ClsDepartamento> departamentos { get; }

        ClsEditarPersonaVM()
        {
            departamentos = ClsListado.ObtenerDepartamento();

    }
    }
}
