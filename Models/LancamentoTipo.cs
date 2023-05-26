using System;
using System.Collections.Generic;

namespace BancoGV.Models
{
    public partial class LancamentoTipo
    {
        public LancamentoTipo()
        {
            Lancamentos = new HashSet<Lancamento>();
        }

        public long Id { get; set; }
        public string Nome { get; set; } = null!;
        public string? Descricao { get; set; }
        public long Natureza { get; set; }
        public DateTime DataCriacao { get; set; }
        public DateTime DataModificacao { get; set; }
        public long CriadoPor { get; set; }
        public long ModificadoPor { get; set; }

        public virtual Operador CriadoPorNavigation { get; set; } = null!;
        public virtual Operador ModificadoPorNavigation { get; set; } = null!;
        public virtual LancamentoTipoNatureza NaturezaNavigation { get; set; } = null!;
        public virtual ICollection<Lancamento> Lancamentos { get; set; }
    }
}
