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
    
    public partial class Fornecedores
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Fornecedores()
        {
            this.Compras = new HashSet<Compras>();
        }
    
        public int id { get; set; }
        public string nome { get; set; }
        public string cnpj { get; set; }
        public string telefone { get; set; }
        public string celular { get; set; }
        public string operadora { get; set; }
        public string recado { get; set; }
        public string endereço { get; set; }
        public string numeral { get; set; }
        public string bairro { get; set; }
        public int id_Cidade { get; set; }
        public string contato { get; set; }
        public string email { get; set; }
        public int status { get; set; }
    
        public virtual Cidades Cidades { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Compras> Compras { get; set; }
    }
}
