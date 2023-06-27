using Empretimos.Core.Domain;

namespace Empretimos.Core.Processor
{
    public class EmpretimosProcessor
    {
        public EmprestimosResult LerDados(EmpretimosReq req)
        {
            return new EmprestimosResult
            {
                Data = req.Data,
                Email = req.Email,
                PrimeiroNome = req.PrimeiroNome,
                UltimoNome = req.UltimoNome
            };
        }
    }
}