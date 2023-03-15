using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesteGacha1.Class
{
    public class Personagem
    {

        public Personagem(string nome, Image foto)
        {
            Nome = nome;
            Foto = foto;
        }

        public Guid Id { get; set; }
        public string Nome { get; set; }
        public Image Foto { get; set; }
    }
    
    public class Lista1
    {
        public List<Personagem> PersonagemOverlord { get; set; }

        public Lista1()
        {
            PersonagemOverlord = new List<Personagem>();
            PersonagemOverlord.Add(new Personagem("Ainz", Image.FromFile("Ainz.jpg")));
        }
    }
}
