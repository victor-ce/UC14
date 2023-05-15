namespace ExoAPI.Models
{
    public class Projeto
    {
        public int Id { get; set; }
        public string? NomeProjeto { get; set; }
        public DateOnly? DataInicio { get; set; }
        public DateOnly? DataTermino { get; set; }
        public string? Tecnologias { get; set; }

    }
}
