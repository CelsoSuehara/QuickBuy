namespace QuickBuy.Domain.Entities
{
    public class Produto : Entity
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public decimal Preco { get; set; }

        public override void Validate()
        {
            LimparMensagensValidacao();

            if (Preco <= 0)
                AdicionarMensagem("Preço inválido.");
        }
    }
}
