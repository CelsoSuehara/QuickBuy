using System.Collections.Generic;
using System.Linq;

namespace QuickBuy.Domain.Entities
{
    public abstract class Entity
    {
        private List<string> _mensagensValidacao { get; set; }

        private List<string> MensagemValidacao
        {
            get { return _mensagensValidacao ?? (_mensagensValidacao = new List<string>()); }
        }

        protected void LimparMensagensValidacao()
        {
            MensagemValidacao.Clear();
        }

        protected void AdicionarMensagem(string mensagem)
        {
            MensagemValidacao.Add(mensagem);
        }

        public abstract void Validate();

        protected bool isValid
        {
            get { return !MensagemValidacao.Any(); }
        }
    }
}
