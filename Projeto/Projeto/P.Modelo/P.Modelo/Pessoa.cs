//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace P.Modelo
{
    using System;
    using System.Collections.Generic;
    
    public partial class Pessoa
    {
        public int idPessoa { get; set; }
        public int idEndereco { get; set; }
        public string nome { get; set; }
    
        public virtual Aluno Aluno { get; set; }
        public virtual Endereco Endereco { get; set; }
        public virtual Professor Professor { get; set; }
    }
}