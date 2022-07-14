using System;
using System.Collections.Generic;

#nullable disable

namespace taskList.Models
{
    public partial class Tarea
    {
        public int IdTarea { get; set; }
        public string Nombre { get; set; }
        public string Estado { get; set; }
    }
}
