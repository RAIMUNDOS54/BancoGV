namespace BancoGV.Exceptions
{
    public class LancamentoValidationException : LancamentoException
    {
        public LancamentoValidationException(string? message) : base(message)
        {
        }
    }
}
