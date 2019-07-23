namespace QuickBuy.Domain.Entities
{
    public class ItemPedido : Entity
    {
        public int Id { get; set; }
        public int ProdutoId { get; set; }
        public int Quantidade { get; set; }

        public override void Validate()
        {
            LimparMensagensValidacao();

            if (ProdutoId == 0)
                AdicionarMensagem("Não foi identificado referência ao produto.");

            if (Quantidade <= 0)
                AdicionarMensagem("Quantidade inválida.");
        }
    }
}
