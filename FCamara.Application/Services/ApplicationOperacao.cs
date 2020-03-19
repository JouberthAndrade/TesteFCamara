using AutoMapper;
using FCamara.Application.Command;
using FCamara.Application.Interfaces;
using FCamara.Domain.Core.Interfaces.Services;
using FCamara.Domain.Entities;
using FCamara.Shared.Dto;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace FCamara.Application.Services
{
    public class ApplicationOperacao : IApplicationOperacao
    {
        private IServiceLancamento serviceLancamento;
        private IMapper mapper;
        public ApplicationOperacao(IMapper mapper, IServiceLancamento serviceLancamento)
        {
            this.mapper = mapper;
            this.serviceLancamento = serviceLancamento;
        }

        public async Task<HttpResponseMessage> RealizarTransacao(LancamentoCommand lancamento)
        {
            try
            {
                var ContaOrigem = mapper.Map<ContaCorrente>(lancamento.contaOrigem);
                var ContaDestino = mapper.Map<ContaCorrente>(lancamento.contaDestino);
                var operacao = await serviceLancamento.RealizarTransacao(ContaOrigem, ContaDestino, lancamento.valor);

                if (operacao.IsSuccessStatusCode)
                    return new HttpResponseMessage(System.Net.HttpStatusCode.OK);
                else
                    return new HttpResponseMessage(System.Net.HttpStatusCode.BadRequest);
            }
            catch (Exception)
            {
                return new HttpResponseMessage(System.Net.HttpStatusCode.BadRequest);
            }

        }
    }
}
