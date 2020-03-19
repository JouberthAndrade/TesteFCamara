using AutoMapper;
using FCamara.Application.Interfaces;
using FCamara.Domain.Core.Interfaces.Services;
using FCamara.Domain.Entities;
using FCamara.Shared.Dto;
using System;
using System.Collections.Generic;

namespace FCamara.Application.Services
{
    public class ApplicationServiceLancamentos : IApplicationServiceLancamentos
    {
        private IServiceLancamento serviceLancamento;
        private IMapper mapper;
        public ApplicationServiceLancamentos(IServiceLancamento serviceLancamento, IMapper mapper)
        {
            this.serviceLancamento = serviceLancamento;
            this.mapper = mapper;
        }

        public void Add(LancamentoDto obj)
        {
            var objLancamento = mapper.Map<Lancamentos>(obj);
            serviceLancamento.Add(objLancamento);
        }

        public void Dispose()
        {
            serviceLancamento.Dispose();
        }

        public IEnumerable<LancamentoDto> GetAll()
        {
            var lista = serviceLancamento.GetAll();
            return mapper.Map<IEnumerable<LancamentoDto>>(lista);
        }

        public LancamentoDto GetById(Guid id)
        {
            var pbjLancamento = serviceLancamento.GetById(id);
            return mapper.Map<LancamentoDto>(pbjLancamento);
        }

        public void Remove(LancamentoDto obj)
        {
            var objLancamento = mapper.Map<Lancamentos>(obj);
            serviceLancamento.Remove(objLancamento);
        }

        public void Update(LancamentoDto obj)
        {
            var objLancamento = mapper.Map<Lancamentos>(obj);
            serviceLancamento.Update(objLancamento);
        }

        
    }
}
