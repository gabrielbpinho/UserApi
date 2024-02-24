using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using UserApi.Data;
using UserApi.Data.DTO.Usuario;
using UserApi.Models;

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

        [HttpGet("ListaUsuario")]
        public IEnumerable<LeituraUsuarioDTO> ListaUsuarios()
        {
            return _mapper.Map<List<LeituraUsuarioDTO>>(_context.Usuarios.ToList());
        }

        [HttpGet("ListaUsuario{id}")]
        public IActionResult ListaUsuarioPorId(int id)
        {
            Usuario usuario = _context.Usuarios.FirstOrDefault(x => x.Id == id);

            if (usuario != null)
            {
                LeituraUsuarioDTO usuarioDTO = _mapper.Map<LeituraUsuarioDTO>(usuario);

                return Ok(usuarioDTO);
            }

            return NotFound();
        }

        [HttpPost("CriaUsuario")]
        public IActionResult CadastrarUsuario([FromBody] CriaUsuarioDTO usuarioDTO)
        {
            Usuario usuario = _mapper.Map<Usuario>(usuarioDTO);

            var usuarioExiste = _context.Usuarios.Where(x => x.CPF == usuarioDTO.CPF).Count();

            if(usuarioExiste == 0)
            {
                usuario.enumStatusContrato = Usuario.EnumStatusContrato.Ativo;
                _context.Usuarios.Add(usuario);
                _context.SaveChanges();

                return CreatedAtAction(nameof(ListaUsuarioPorId), new { Id = usuario.Id }, usuario);
            }
            else
            {
                return BadRequest($"Usuário já cadastrado");
            }
            
        }

        [HttpPut("AtualizaUsuario{id}")]
        public IActionResult AtualizaUsuario(int id, [FromBody] AtualizaUsuarioDTO UsuarioDTO)
        {
            Usuario Usuario = _context.Usuarios.FirstOrDefault(Usuario => Usuario.Id == id);

            if (Usuario == null)
            {
                return NotFound();
            }

            _mapper.Map(UsuarioDTO, Usuario);

            _context.SaveChanges();

            return NoContent();
        }


        [HttpDelete("DeletaUsuario{id}")]
        public IActionResult DeletaUsuario(int id)
        {
            Usuario Usuario = _context.Usuarios.FirstOrDefault(Usuario => Usuario.Id == id);

            if (Usuario == null)
            {
                return NotFound();
            }

            _context.Remove(Usuario);
            _context.SaveChanges();

            return NoContent();
        }

    }
}
