namespace domain.Data.Models
{
    public class Doctor
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public virtual Specialization Specialization { get; set; }
    }
}
