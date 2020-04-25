using System.Collections.Generic;

namespace QuickBuy.Dominio.Entidades
{
    public class Usuario : Entidade
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public string Nome { get; set; }
        public string Sobrenome { get; set; }

        /// <summary>
        /// Um Usuário pode ter Nenhum ou Muitos Pedidos
        /// </summary>
        public ICollection<Pedido> Pedidos { get; set; }

        public override void Validate()
        {
            if (string.IsNullOrEmpty(Id.ToString()))
                AdicionarCritica("Obrigatório preenchimento do Código do Usuário");
            if (string.IsNullOrEmpty(Email))
                AdicionarCritica("Obrigatório preenchimento do E-mail");
            if (string.IsNullOrEmpty(Senha))
                AdicionarCritica("Senha não pode ser nula");
            if (string.IsNullOrEmpty(Nome))
                AdicionarCritica("Obrigatório preenchimento do Nome");
            if (string.IsNullOrEmpty(Sobrenome))
                AdicionarCritica("Obrigatório preenchimento do Sobrenome");
        }
    }
}
