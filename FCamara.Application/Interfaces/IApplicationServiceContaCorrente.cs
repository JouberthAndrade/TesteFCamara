using FCamara.Shared.Dto;
using System;
using System.Collections.Generic;

namespace FCamara.Application.Interfaces
{
    public interface IApplicationServiceContaCorrente 
    {
        void Add(ContaDto obj);

        ContaDto GetById(Guid id);

        IEnumerable<ContaDto> GetAll();

        void Update(ContaDto obj);

        void Remove(ContaDto obj);

        void Dispose();
        
    }
}
