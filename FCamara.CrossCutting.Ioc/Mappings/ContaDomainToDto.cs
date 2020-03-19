using AutoMapper;
using FCamara.Domain.Entities;
using FCamara.Shared.Dto;

namespace FCamara.CrossCutting.Ioc.Mappings
{
    public class ContaDomainToDto : Profile
    {
        public ContaDomainToDto()
        {
            CreateMap<ContaCorrente, ContaDto>();
            CreateMap<ContaDto, ContaCorrente>();

            CreateMap<Lancamentos, LancamentoDto>();
            CreateMap<LancamentoDto, Lancamentos>();
        }

    }
}
