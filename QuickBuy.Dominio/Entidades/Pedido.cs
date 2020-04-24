﻿using QuickBuy.Dominio.ObjetoDeValor;
using System;
using System.Collections.Generic;
using System.Linq;

namespace QuickBuy.Dominio.Entidades
{
    public class Pedido : Entidade
    {
        public int Id { get; set; }
        public DateTime DataPedido { get; set; }
        public int UsuarioId { get; set; }
        public DateTime DataPrevisaoEntrega { get; set; }
        public string CEP { get; set; }
        public string  Estado { get; set; }
        public string Cidade { get; set; }
        public string EnderecoCompleto { get; set;}
        public string NumeroEndereco { get; set; }
        public int FormaPagamentoId { get; set; }
        public FormaPagamento FormaPagamento { get; set; }

        /// <summary>
        /// Um Pedido pode ter um ou muitos Itens de Pedido
        /// </summary>
        public ICollection<ItemPedido> ItensPedido { get; set; }

        public override void Validate()
        {
            LimparMensagensValidacao();
            
            if (!ItensPedido.Any())
                AdicionarCritica("Pedido não possui Itens!");
            if (string.IsNullOrEmpty(CEP))
                AdicionarCritica("Obrigatório preenchimento do CEP");
        }
    }
}
