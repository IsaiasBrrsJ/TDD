namespace Empretimos.Core.Domain
{
    public class EmpretimosReq
    {
        public EmpretimosReq()
        {
        }

        public string PrimeiroNome { get; set; }
        public string UltimoNome { get; set; }
        public string Email { get; set; }
        public DateTime Data { get; set; }
    }
}