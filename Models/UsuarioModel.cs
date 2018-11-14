using System;

namespace todols.Web.Mvc.Models
{
    public class UsuarioModel
    {
        public string Id { get; set; }
        public string Nome  { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public string tipo { get; set; }
        public DateTime DataNascimento { get; set; }
    }
}