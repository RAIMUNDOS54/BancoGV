using System;
using System.Collections.Generic;

namespace BancoGV.Models
{
    public partial class Lancamento
    {
        public long Id { get; set; }
        public string Nome { get; set; } = null!;
        public string? Descricao { get; set; }
        public decimal Valor { get; set; }
        public long? Titular { get; set; }
        public long Tipo { get; set; }
        public DateTime Data { get; set; }
        public DateTime DataCriacao { get; set; }
        public DateTime DataModificacao { get; set; }
        public long CriadoPor { get; set; }
        public long ModificadoPor { get; set; }

        public virtual Operador CriadoPorNavigation { get; set; } = null!;
        public virtual Operador ModificadoPorNavigation { get; set; } = null!;
        public virtual LancamentoTipo TipoNavigation { get; set; } = null!;
        public virtual Titular? TitularNavigation { get; set; }
    }
}
