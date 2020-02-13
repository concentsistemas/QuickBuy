using QuickBuy.Dominio.ObjetoDeValor;
using System;
using System.Collections.Generic;
using System.Linq;

namespace QuickBuy.Dominio.Entidades
{
    public class Pedido : Entidade
    {
        public int Id { get; set; }
        public DateTime DataPedido { get; set; }
        public int UsuarioID { get; set; }

        private ICollection<ItemPedido> itensPedido;

        public ICollection<ItemPedido> GetItensPedido()
        {
            return itensPedido;
        }

        public void SetItensPedido(ICollection<ItemPedido> value)
        {
            itensPedido = value;
        }

        public DateTime DataPrevisaoEntrega { get; set; }
        public string CEP { get; set; }
        public string Estado { get; set; }
        public string Endereco { get; set; }
        public string numero { get; set; }
        public string Cidade { get; set; }
        public int FormaPagamentoId { get; set; }
        public FormaPagamento FormaPagamento { get; set; }

        public ICollection<ItemPedido> ItensPedido { get; set; }
        public override void Validate()
        {
            LimparMensagemValidacao();

            if (!ItensPedido.Any())
                AdicionaCritica("E Obrigatorio ter itens no pedido!");
            if (string.IsNullOrEmpty(CEP))
                AdicionaCritica("CEP do endereco nao informado!");
        }
    }
}
