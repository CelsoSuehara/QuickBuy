using QuickBuy.Domain.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;

namespace QuickBuy.Domain.Entities
{
    public class Pedido : Entity
    {
        public int Id { get; set; }
        public DateTime DataPedido { get; set; }

        public int UsuarioId { get; set; }
        public virtual Usuario Usuario { get; set; }

        public DateTime DataPrevisaoEntrega { get; set; }
        public string CEP { get; set; }
        public string Estado { get; set; }
        public string Cidade { get; set; }
        public string EnderecoCompleto { get; set; }
        public int NumeroEndereco { get; set; }

        // Value Object
        public int FormaPagamentoId { get; set; }
        public virtual FormaPagamento FormaPagamento { get; set; }

        /// <summary>
        /// O pedido deve ter pelo menos um item ou muitos
        /// </summary>
        public virtual ICollection<ItemPedido> ItensPedido { get; set; }

        public override void Validate()
        {
            LimparMensagensValidacao();

            if (!ItensPedido.Any())
                AdicionarMensagem("Pedido deve ter pelo menos um item.");

            if (string.IsNullOrEmpty(CEP))
                AdicionarMensagem("Preencha o CEP do endereço de entraga.");

            if (FormaPagamentoId == 0)
                AdicionarMensagem("Não foi identificado referência à forma de pagamento.");
        }
    }
}
