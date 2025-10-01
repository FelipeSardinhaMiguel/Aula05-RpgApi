using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RpgAPI.Models.Enuns;

namespace RpgAPI.Models
{
    public class Personagem
    {
        public int Id { get; set; }
        public string Nome { get; set; } = string.Empty;
        public int PontosVida { get; set; }
        public int Forca { get; set; }
        public int Defesa { get; set; }
        public int Inteligencia { get; set; }
        
        /*public stiring Raca { get; set; } = string.Empty*/
        
        public ClasseEnum Classe { get; set; }
        public byte[]? FotoPersonagem { get; set; }
        public int? UsuarioId { get; set; }
        public Usuario? Usuario { get; set; }
    
        
        

    }
}