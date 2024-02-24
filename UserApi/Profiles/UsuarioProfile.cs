using AutoMapper;
using UserApi.Data.DTO.Usuario;
using UserApi.Models;

namespace UserApi.Profiles
{
    public class UsuarioProfile : Profile
    {
       public UsuarioProfile()
        {
            CreateMap<CriaUsuarioDTO, Usuario>();
            CreateMap<Usuario, LeituraUsuarioDTO>();
            CreateMap<AtualizaUsuarioDTO, Usuario>();
        }
    }
}
