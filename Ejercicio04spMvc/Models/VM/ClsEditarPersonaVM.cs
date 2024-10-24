﻿using Ejercicio04spMvc.Models.DAL;
using Ejercicio04spMvc.Models.ENT;

namespace Ejercicio04spMvc.Models.VM
{
    public class ClsEditarPersonaVM : ClsPersona
    {
        public List<ClsDepartamento> Departamentos { get; set; }

        // Constructor
        public ClsEditarPersonaVM()
        {
            // Llenar el listado de departamentos al iniciar el ViewModel
            Departamentos = ClsListado.ObtenerDepartamentos(); // Llama al método estático para obtener departamentos
        }
    }
}
