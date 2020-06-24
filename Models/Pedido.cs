using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace NoelFelipe.Models
{
    public class Pedido
    {
        [Key]
        public int IdPedido { get; set; }
        [ForeignKey("Produtos")]
        public int IdProduto { get; set; }
        public List<Produto> Produtos { get; set; }
        [ForeignKey("Cliente")]
        public int IdCliente { get; set; }
        public Cliente Cliente { get; set; }
    }
}