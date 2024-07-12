namespace ProyectoFraccionamiento.Entities
{
    public class SocialAreaEntity
    {
        public SocialAreaEntity()
        {
        }

        public Guid Id { get; set; }
        public string Name { get; set; }=null!;
        public string Apellido { get; set; }=null!;

        public DateTime  FechaReserva { get; set;}

        

    }
}