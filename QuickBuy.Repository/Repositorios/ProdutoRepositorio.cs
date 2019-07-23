using QuickBuy.Domain.Contracts;
using QuickBuy.Domain.Entities;
using QuickBuy.Repository.Contexto;

namespace QuickBuy.Repository.Repositorios
{
    public class ProdutoRepositorio : BaseRepositorio<Produto>, IProdutoRepositorio
    {
        public ProdutoRepositorio(QuickBuyContexto quickBuyContexto) : base(quickBuyContexto)
        {
        }
    }
}
