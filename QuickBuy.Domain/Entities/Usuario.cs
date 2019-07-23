using System.Collections.Generic;

namespace QuickBuy.Domain.Entities
{
    public class Usuario : Entity
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        /// <summary>
        /// O usuário pode ter nenhum ou muitos pedidos
        /// </summary>
        public virtual ICollection<Pedido> Pedidos { get; set; }

        public override void Validate()
        {
            LimparMensagensValidacao();

            if (string.IsNullOrEmpty(Email))
                AdicionarMensagem("Email não informado");

            if (string.IsNullOrEmpty(Senha))
                AdicionarMensagem("Senha não informada");

        }
    }
}
