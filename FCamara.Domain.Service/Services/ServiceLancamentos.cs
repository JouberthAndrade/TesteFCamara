using FCamara.Domain.Core.Interfaces.Repositorys;
using FCamara.Domain.Core.Interfaces.Services;
using FCamara.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace FCamara.Domain.Service.Services
{
    public class ServiceLancamentos : BaseServices<Lancamentos>, IServiceLancamento
    {
        private readonly IRepositoryLancamento repositoryLancamento;
        public ServiceLancamentos(IRepositoryLancamento repositoryLancamento) : base(repositoryLancamento)
        {
        }

        public async Task<HttpResponseMessage> RealizarTransacao(ContaCorrente contaOrigem, ContaCorrente contaDestino, decimal valor)
        {
            try
            {
                var lancamento = new Lancamentos(contaOrigem, contaDestino, Shared.Enum.Operacao.Credito, DateTime.Now);
                lancamento.Creditar(lancamento.ContaOrigem, lancamento.ContaDestino, valor);

                await repositoryLancamento.Add(lancamento);
                return new HttpResponseMessage(System.Net.HttpStatusCode.OK);

            }
            catch (Exception ex)
            {
                return new HttpResponseMessage(System.Net.HttpStatusCode.BadRequest);
            }

        }
    }
}
