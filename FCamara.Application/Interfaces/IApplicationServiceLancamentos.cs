using FCamara.Shared.Dto;
using System;
using System.Collections.Generic;

namespace FCamara.Application.Interfaces
{
    public interface IApplicationServiceLancamentos
    {
        void Add(LancamentoDto obj);

        LancamentoDto GetById(Guid id);

        IEnumerable<LancamentoDto> GetAll();

        void Update(LancamentoDto obj);

        void Remove(LancamentoDto obj);

        void Dispose();

    }
}
