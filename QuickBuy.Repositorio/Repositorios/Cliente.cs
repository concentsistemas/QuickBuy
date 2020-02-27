using QuickBuy.Dominio.Entidades;

namespace QuickBuy.Repositorio.Repositorios
{
    public class Cliente
    {
        public Cliente()
        {
            var usuariorepositorio = new UsuarioRepositorio();
            var usuario = new Usuario();
            usuariorepositorio.Adicionar(usuario);
        }
    }
}
