using System;

namespace todols.Web.Mvc.Models
{
    public class TarefasModel
    {
        public string Id { get; set; }
        public string Nome  { get; set; }
        public string Descricao { get; set; }
        public string tipo { get; set; }
        public string IdUsuario { get; set; }
        public DateTime DataCriacao { get; set; }
    }
}