

using AutoMapper;
using ticketsservice.Dtos;
using ticketsservice.Models;

namespace ticketsservice.Profiles;
public class MappingProfile : Profile
{
    public MappingProfile()
    {
        CreateMap<CreateTicketDto,Ticket>();
        CreateMap<TicketResponseDto,Ticket>().ReverseMap();
    }
}