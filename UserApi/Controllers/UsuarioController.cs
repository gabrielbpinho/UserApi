using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using UserApi.Data;
using UserApi.Data.DTO.Usuario;

namespace UserApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuarioController : ControllerBase
    {
        private AppDbContext _context;
        private IMapper _mapper;

        public UsuarioController(AppDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        [HttpGet("ListaCliente")]
        public IEnumerable<LeituraUsuarioDTO> ListaUsuarios()
        {
            return _mapper.Map<List<LeituraUsuarioDTO>>(_context.Usuarios.ToList());
        }

    }
}
