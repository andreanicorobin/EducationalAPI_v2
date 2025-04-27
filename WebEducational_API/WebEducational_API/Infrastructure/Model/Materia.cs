namespace WebEducational_API.Infrastructure.Model
{
    public class Materia
    {
        public int MateriaID { get; set; }
        public string Nombre { get; set; }
        public int Creditos { get; set; } = 3;
        public int ProfesorID { get; set; }
    }
}
