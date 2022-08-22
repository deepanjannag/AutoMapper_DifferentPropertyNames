using AutoMapper;
using AutoMapperDemo.Dto;
using AutoMapperDemo.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace AutoMapperDemo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IMapper _mapper;

        public UserController(IMapper mapper)
        {
            _mapper = mapper;
        }


        [HttpGet]
        public async Task<UserForUI> ShowUser()
        {
            User u = new User { Id=1, FirstName="Jamsetji", LastName="Tata", Address="Jamshedpur", Email= "jtata@tata.com" };

            return _mapper.Map<UserForUI>(u);

        }
    }
}
