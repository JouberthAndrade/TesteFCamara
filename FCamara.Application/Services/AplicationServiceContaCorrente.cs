using AutoMapper;
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
    public class AplicationServiceContaCorrente : IApplicationServiceContaCorrente
    {
        private IServiceContaCorrente serviceContaCorrente;
        private IMapper mapper;
        public AplicationServiceContaCorrente(IServiceContaCorrente serviceContaCorrente, IMapper mapper)
        {
            this.serviceContaCorrente = serviceContaCorrente;
            this.mapper = mapper;
        }

        public void Add(ContaDto obj)
        {
            var objConta = mapper.Map<ContaCorrente>(obj);
            serviceContaCorrente.Add(objConta);
        }

        public void Dispose()
        {
            serviceContaCorrente.Dispose();
        }

        public IEnumerable<ContaDto> GetAll()
        {
            var lista = serviceContaCorrente.GetAll();
            return mapper.Map<IEnumerable<ContaDto>>(lista);
        }

        public ContaDto GetById(Guid id)
        {
            var pbjConta = serviceContaCorrente.GetById(id);
            return mapper.Map<ContaDto>(pbjConta);
        }

        public void Remove(ContaDto obj)
        {
            var objConta = mapper.Map<ContaCorrente>(obj);
            serviceContaCorrente.Remove(objConta);
        }

        public void Update(ContaDto obj)
        {
            var objConta = mapper.Map<ContaCorrente>(obj);
            serviceContaCorrente.Update(objConta);
        }
        
    }
}
