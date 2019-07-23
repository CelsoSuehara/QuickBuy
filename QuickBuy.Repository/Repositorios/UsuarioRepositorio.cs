using QuickBuy.Domain.Contracts;
using QuickBuy.Domain.Entities;
using QuickBuy.Repository.Contexto;

namespace QuickBuy.Repository.Repositorios
{
    public class UsuarioRepositorio : BaseRepositorio<Usuario>, IUsuarioRepositorio
    {
        public UsuarioRepositorio(QuickBuyContexto quickBuyContexto) : base(quickBuyContexto)
        {
        }
    }
}
