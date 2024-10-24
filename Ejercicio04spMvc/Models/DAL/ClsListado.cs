using Ejercicio04spMvc.Models.ENT;

namespace Ejercicio04spMvc.Models.DAL
{
    public class ClsListado
    {
        private static List<ClsDepartamento> departamentos = new List<ClsDepartamento>
    {
        new ClsDepartamento("Recursos Humanos"),
        new ClsDepartamento("IT"),
        new ClsDepartamento("Marketing")
    };

        private static List<ClsPersona> personas = new List<ClsPersona>
    {
        new ClsPersona { Nombre = "Juan", Apellido = "Pérez", idDepartamento = 1 },
        new ClsPersona { Nombre = "Ana", Apellido = "García", idDepartamento = 2 },
        new ClsPersona { Nombre = "Luis", Apellido = "Martínez", idDepartamento = 3 }
    };

        public static ClsPersona ObtenerPersonaAleatoria()
        {
            Random rnd = new Random();
            int index = rnd.Next(personas.Count);
            return personas[index];
        }

        public static List<ClsDepartamento> ObtenerDepartamentos()
        {
            return departamentos;
        }
    }


}