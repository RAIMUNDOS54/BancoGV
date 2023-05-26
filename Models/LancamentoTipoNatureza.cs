using System;
using System.Collections.Generic;

namespace BancoGV.Models
{
    public partial class LancamentoTipoNatureza
    {
        public LancamentoTipoNatureza()
        {
            LancamentosTipos = new HashSet<LancamentoTipo>();
        }

        public long Id { get; set; }
        public string Nome { get; set; } = null!;
        public string SimboloOperacao { get; set; } = null!;
        public DateTime DataCriacao { get; set; }
        public DateTime DataModificacao { get; set; }
        public long CriadoPor { get; set; }
        public long ModificadoPor { get; set; }

        public virtual Operador CriadoPorNavigation { get; set; } = null!;
        public virtual Operador ModificadoPorNavigation { get; set; } = null!;
        public virtual ICollection<LancamentoTipo> LancamentosTipos { get; set; }
    }
}
