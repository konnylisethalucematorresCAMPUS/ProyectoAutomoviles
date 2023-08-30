using System.ComponentModel.DataAnnotations;

namespace Dominio.Entities;

    public class RevisionRegular
    {
        [Key]
        public int IdRevisionRegular { get; set; }
        public int IdServicio { get; set; }
        public Servicio ? Servicios { get; set;}
        public int IdVehiculo { get; set; }
        public DateTime FechaRevision { get; set; }
        public int IdMecanico { get; set; }
        public string ? Descripcion { get; set;}
        public string ? ResultadosRevision { get; set;}
        public string ? ReparacionesRecomendadas { get; set; }


    }
