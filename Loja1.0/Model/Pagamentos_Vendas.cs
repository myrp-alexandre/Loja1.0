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
    
    public partial class Pagamentos_Vendas
    {
        public int id { get; set; }
        public int id_Venda { get; set; }
        public int id_Pagamento { get; set; }
    
        public virtual Pagamentos Pagamentos { get; set; }
        public virtual Vendas Vendas { get; set; }
    }
}
