using System;
using System.Collections.Generic;

namespace BancoGV.Models
{
    public partial class Operador
    {
        public Operador()
        {
            InverseCriadoPorNavigation = new HashSet<Operador>();
            InverseModificadoPorNavigation = new HashSet<Operador>();
            LancamentoCriadoPorNavigations = new HashSet<Lancamento>();
            LancamentoModificadoPorNavigations = new HashSet<Lancamento>();
            LancamentosTipoCriadoPorNavigations = new HashSet<LancamentoTipo>();
            LancamentosTipoModificadoPorNavigations = new HashSet<LancamentoTipo>();
            LancamentosTipoNaturezaCriadoPorNavigations = new HashSet<LancamentoTipoNatureza>();
            LancamentosTipoNaturezaModificadoPorNavigations = new HashSet<LancamentoTipoNatureza>();
            TitulareCriadoPorNavigations = new HashSet<Titular>();
            TitulareModificadoPorNavigations = new HashSet<Titular>();
        }

        public long Id { get; set; }
        public string Nome { get; set; } = null!;
        public string Sobrenome { get; set; } = null!;
        public string Usuario { get; set; } = null!;
        public string Email { get; set; } = null!;
        public DateTime DataCriacao { get; set; }
        public DateTime DataModificacao { get; set; }
        public long CriadoPor { get; set; }
        public long ModificadoPor { get; set; }

        public virtual Operador CriadoPorNavigation { get; set; } = null!;
        public virtual Operador ModificadoPorNavigation { get; set; } = null!;
        public virtual ICollection<Operador> InverseCriadoPorNavigation { get; set; }
        public virtual ICollection<Operador> InverseModificadoPorNavigation { get; set; }
        public virtual ICollection<Lancamento> LancamentoCriadoPorNavigations { get; set; }
        public virtual ICollection<Lancamento> LancamentoModificadoPorNavigations { get; set; }
        public virtual ICollection<LancamentoTipo> LancamentosTipoCriadoPorNavigations { get; set; }
        public virtual ICollection<LancamentoTipo> LancamentosTipoModificadoPorNavigations { get; set; }
        public virtual ICollection<LancamentoTipoNatureza> LancamentosTipoNaturezaCriadoPorNavigations { get; set; }
        public virtual ICollection<LancamentoTipoNatureza> LancamentosTipoNaturezaModificadoPorNavigations { get; set; }
        public virtual ICollection<Titular> TitulareCriadoPorNavigations { get; set; }
        public virtual ICollection<Titular> TitulareModificadoPorNavigations { get; set; }
    }
}
