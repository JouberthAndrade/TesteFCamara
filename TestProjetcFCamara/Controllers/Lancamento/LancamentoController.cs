using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using AutoMapper;
using FCamara.Application.Command;
using FCamara.Application.Interfaces;
using FCamara.Infra;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FCamara.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LancamentoController : BaseController
    {
        private readonly IApplicationOperacao applicationOperacao;
        private readonly IMapper mapper;
        public LancamentoController(IMapper mapper,
            IApplicationOperacao applicationOperacao)
        {
            this.mapper = mapper;
            this.applicationOperacao = applicationOperacao;
        }

        [HttpPost("EfetuaLancamento")]
        public async Task<HttpResponseMessage> EfetuaLancamento([FromBody] LancamentoCommand operacao)
        {
            return await applicationOperacao.RealizarTransacao(operacao);
        }
    }
}