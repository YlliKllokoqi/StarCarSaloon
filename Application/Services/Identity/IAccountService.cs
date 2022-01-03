using Application.DTOs.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services.Identity
{
    public interface IAccountService
    {
        Task<object> Login(LoginDTO loginDTO);
        Task<string> Register(RegisterDTO registerDTO);
    }
}
