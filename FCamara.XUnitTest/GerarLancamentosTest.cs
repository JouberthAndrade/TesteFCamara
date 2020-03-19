using AutoMapper;
using FCamara.Application.Command;
using FCamara.Application.Interfaces;
using FCamara.Application.Services;
using FCamara.Domain.Core.Interfaces.Repositorys;
using FCamara.Domain.Core.Interfaces.Services;
using FCamara.Domain.Entities;
using FCamara.Domain.Service.Services;
using FCamara.Infra;
using FCamara.Infra.Repositorys;
using FCamara.Shared.Dto;
using FCamara.Shared.Enum;
using Microsoft.EntityFrameworkCore;
using Moq;
using System;
using System.Net.Http;
using System.Threading.Tasks;
using Xunit;

namespace FCamara.XUnitTest
{
    public class GerarLancamentosTest
    {
        private readonly Mock<IApplicationServiceContaCorrente> applicationServiceContaCorrente;
        private readonly Mock<IApplicationServiceLancamentos> applicationServiceLancamentos;
        private readonly Mock<IApplicationOperacao> applicationOperacao;
        private readonly Mock<IMapper> mapper = new Mock<IMapper>();

        private ContaDto contaOrigem;
        private ContaDto contaDestino;
        private LancamentoDto lancamentoDto;

        private LancamentoCommand lancamentoCommand;
        private HttpResponseMessage httpResponseMessage;


        public GerarLancamentosTest()
        {
            applicationServiceContaCorrente = new Mock<IApplicationServiceContaCorrente>();
            applicationServiceLancamentos = new Mock<IApplicationServiceLancamentos>();
            applicationOperacao = new Mock<IApplicationOperacao>();

            contaOrigem = CriaConta(33, 043, 65201, 1, TipoConta.Corrente, 1000);
            contaDestino = CriaConta(341, 6585, 45789, 9, TipoConta.Corrente, 1000);
            lancamentoDto = CriarLancamento(contaOrigem, contaDestino);
            lancamentoCommand = new LancamentoCommand();
            lancamentoCommand.contaOrigem = contaOrigem;
            lancamentoCommand.contaDestino = contaDestino;
            lancamentoCommand.valor = 500;
        }

        
        [Fact]
        public async Task Index_Credito()
        {
            
            applicationServiceContaCorrente
                .Setup(x => x.Add(contaOrigem));
            applicationServiceContaCorrente
                .Setup(x => x.Add(contaDestino));

            applicationServiceLancamentos
                .Setup(x => x.Add(lancamentoDto));

            applicationOperacao
                .Setup(x => x.RealizarTransacao(lancamentoCommand))
                .Returns(Task.FromResult(httpResponseMessage));
            
        }

        private async Task<MyDBContext> GetContext()
        {
            var options = new DbContextOptionsBuilder<MyDBContext>()
                        .UseInMemoryDatabase(Guid.NewGuid().ToString())
                        .Options;

            var context = new MyDBContext(options);
            var contaCredito = new ContaCorrente(33, 6590, 141455, 9, TipoConta.Corrente);
            var contaDebito = new ContaCorrente(341, 4876, 16075, 7, TipoConta.Corrente);

            contaCredito.SetarSaldoInicial(1000);
            contaDebito.SetarSaldoInicial(1000);

            contaCredito.SetarId(new Guid("86ACFFC8-CC0B-422A-987B-3B49791E4821"));
            contaDebito.SetarId(new Guid("56BCFFC8-CC0B-422A-987B-3B49791E4921"));

            context.ContaCorrentes.Add(contaCredito);
            context.ContaCorrentes.Add(contaDebito);
            await context.SaveChangesAsync();
            return  context;
        }

        private LancamentoDto CriarLancamento(ContaDto contaOrigem, ContaDto contaDestino)
        {
            return new LancamentoDto
            {
                ContaOrigem = contaOrigem,
                ContaDestino = contaDestino,
                DataOperacao = DateTime.Now,
                Tipo = Operacao.Credito
            };
        }

        private ContaDto CriaConta(int banco, int agencia, int contaNumero, int digito, TipoConta tipo, decimal saldo)
        {
            return new ContaDto
            {
                Banco = banco,
                Agencia = agencia,
                Conta = contaNumero,
                Digito = digito,
                Tipo = tipo,
                Saldo = saldo
            };
        }
    }
}
