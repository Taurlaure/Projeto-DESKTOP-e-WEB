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
    
    public partial class AlunoDisciplina
    {
        public int idDisciplina { get; set; }
        public int idPessoaAluno { get; set; }
        public double nota { get; set; }
    
        public virtual Aluno Aluno { get; set; }
        public virtual Disciplina Disciplina { get; set; }
    }
}
