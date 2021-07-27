using System;

namespace APISaudacao.Models
{
    public class Mensagem
    {
        public string Saudacao { get; set; }
        public string Horario { get; init; } = $"{DateTime.Now:HH:mm:ss}";
    }
}