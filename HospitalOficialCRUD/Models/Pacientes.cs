using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace HospitalOficialCRUD.Models
{
    public class Pacientes
    {
        public int IdPaciente { get; set; }

        public string RutPaciente { get; set; }

        public string NombrePaciente { get; set; }

        public string ApellidoPaciente { get; set; }

        public string DireccionPaciente { get; set; }

        public DateOnly FechaNacimiento { get; set; }

        public string FonoPaciente { get; set; }

    }
}
