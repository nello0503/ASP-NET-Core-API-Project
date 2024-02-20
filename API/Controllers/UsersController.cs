using API.DTOs;
using API.Interfaces;
using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers;

[Authorize]
public class UsersController : BaseApiController
{
    private readonly IUserRepository _iuserRepository;
    private readonly IMapper _mapper;

    public UsersController(IUserRepository iuserRepository, IMapper mapper)
    {
        _iuserRepository = iuserRepository;
        _mapper = mapper;
    }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<MemberDto>>> GetUsers()
    {
        var users = await _iuserRepository.GetMembersAsync();
        
         return Ok(users);
    }

    
    [HttpGet("{username}")] // /api/username
    public async Task<ActionResult<MemberDto>> GetUser(string username)
    {
        return await _iuserRepository.GetMemberAsync(username);
    }

 
}
