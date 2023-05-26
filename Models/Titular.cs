using System;
using System.Collections.Generic;

namespace BancoGV.Models
{
    public partial class Titular
    {
        public Titular()
        {
            Lancamentos = new HashSet<Lancamento>();
        }

        public long Id { get; set; }
        public string Nome { get; set; } = null!;
        public string Sobrenome { get; set; } = null!;
        public string Cpfcnpj { get; set; } = null!;
        public DateTime DataCriacao { get; set; }
        public DateTime DataModificacao { get; set; }
        public long CriadoPor { get; set; }
        public long ModificadoPor { get; set; }

        public virtual Operador CriadoPorNavigation { get; set; } = null!;
        public virtual Operador ModificadoPorNavigation { get; set; } = null!;
        public virtual ICollection<Lancamento> Lancamentos { get; set; }
    }
}
