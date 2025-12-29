namespace mvcrud.Models
{
    public enum WashingState
    {
        Pendiente,
        Procesando,
        Terminado
    }

    public class WashingOrder
    {
        public int Id { get; set; }
        
        // Foreign Key for Vehicle
        public int VehicleId { get; set; }
        public Vehicle? Vehicle { get; set; }

        public int? ClientId { get; set; }

        // Foreign Key for Service
        public int ServiceId { get; set; }
        public Service? Service { get; set; }

        // Foreign Key for Employee (Empleado)
        public int EmployeeId { get; set; }
        public Empleado? Employee { get; set; }

        public DateTime Fecha { get; set; } = DateTime.Now;
        public WashingState Estado { get; set; }
        public decimal Total { get; set; }
    }
}
