using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ORUSCURSO.Logica
{
    public class Lasistencias
    {
        public int Id_asistencia { get; set; }
        public int Id_personal { get; set; }
        public DateTime Fecha_entrada { get; set; }
        public DateTime Fecha_salida { get; set; }
        public string Estado { get; set; }
        public double Horas { get; set; }
        public string Observacion { get; set; }
    }
}