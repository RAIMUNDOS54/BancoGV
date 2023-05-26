using System.Runtime.Serialization;

namespace BancoGV.Exceptions
{
    public class LancamentoException : APIException
    {
        public LancamentoException(string? message) : base(message)
        {
        }
    }
}
