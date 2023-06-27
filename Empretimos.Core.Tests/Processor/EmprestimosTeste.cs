using Empretimos.Core.Domain;
using Empretimos.Core.Processor;
using Xunit;

namespace Empretimos.Core.Tests.Processor
{
    public class EmprestimosTeste
    {
        private readonly EmpretimosProcessor _processor;
        public EmprestimosTeste()
        {
            _processor = new EmpretimosProcessor();
        }
        [Fact]
        public void DeveRetornarDadosEmprestimosComValoresDaRequisicao()
        {
            //Organizar requisicao
            var req = new EmpretimosReq()
            {
                PrimeiroNome = "Isaias",
                UltimoNome = "Barros",
                Email = "isaias@gmail.com",
                Data = DateTime.Now
            };

            //processar a requisição e retornar o resultado
           
            EmprestimosResult result = _processor.LerDados(req);

            //Afirnamação
            Assert.NotNull(result);
            Assert.Equal(req.PrimeiroNome, result.PrimeiroNome);
            Assert.Equal(req.UltimoNome, result.UltimoNome);
            Assert.Equal(req.Email, result.Email);
            Assert.Equal(req.Data, result.Data);

        }


        [Fact]
       public void DeveRetornarUmaExceptionSeReqForNula()
        {
            var exception = Assert.Throws<ArgumentNullException>(() => _processor.LerDados(null));

            Assert.Equal("req", exception.ParamName);
        }
    }
}
