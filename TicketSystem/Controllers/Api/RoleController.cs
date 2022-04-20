using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DataAccess.Repositories.Roles;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace TicketSystem.Controllers.Api
{
    [Route("api/[controller]")]
    [ApiController]
    public class RoleController : ControllerBase
    {
        private readonly IRoleRepository _roleRepository;

        public RoleController(
            IRoleRepository roleRepository)
        {
            this._roleRepository = roleRepository;
        }

        [Route("GetRoleById")]
        public object GetRoleById(int roleId)
        {
            return this._roleRepository.GetRoleById(roleId);
        }
    }
}
