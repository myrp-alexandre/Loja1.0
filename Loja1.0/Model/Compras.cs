//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Loja1._0.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class Compras
    {
        public int id { get; set; }
        public int id_produto { get; set; }
        public int qnt_compra { get; set; }
        public System.DateTime dt_compra { get; set; }
        public decimal preco_compra { get; set; }
        public decimal preco_venda { get; set; }
        public decimal icms_pago { get; set; }
        public int id_fornecedor { get; set; }
        public int status { get; set; }
    
        public virtual Fornecedores Fornecedores { get; set; }
        public virtual Produtos Produtos { get; set; }
    }
}