using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Usuario
    {
        public int Id { get; set; }
        [MaxLength(100)]
        [MinLength(3)]
        public string Nome { get; set; }
        public Calendario Calendario { get; set; }
        public string FotoPerfil { get; set; }

    }
    public class Calendario
    {
        public int Id { get; set; }
        public string NomeCalendario { get; set; }
        public Atividades[]? Atividade { get; set; }
        public string Cor {  get; set; }
    }

    public class Atividades
    {
        public int Id { get; set; }
        public string NomeAtividade { get; set; }
        public string? DescAtividade { get; set; }
        public Calendario Calendario { get; set; }
        public DateTime Data { get; set; }
    }
}
