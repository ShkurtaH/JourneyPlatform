using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using JourneyPlatform.Data;
using JourneyPlatform.Models;

namespace JourneyPlatform.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class RolesController : ControllerBase
    {
        private readonly DataContext _context;


        public RolesController(DataContext context)
        {
            _context = context;
        }

        [HttpGet]

        public async Task<ActionResult<List<Roles>>> Get()
        {
            var roles = await _context.Roles.ToListAsync();
            return Ok(roles);
        }

        [HttpGet("{RoleId}")]
        public async Task<ActionResult<List<Roles>>> GetByRoleId(int RoleId)
        {
            var roles = await _context.Roles.FirstOrDefaultAsync(c => c.RoleId == RoleId);
            return Ok(roles);
        }


        [HttpPost]
        public async Task<ActionResult<List<Roles>>> AddRole(Roles role)
        {
            var addRole = _context.Roles.Add(role);
            await _context.SaveChangesAsync();
            if (addRole == null)
                return Ok("Failed");
            return Ok("Added succesfuly");
        }


        [HttpPut("{RoleId}")]
        public async Task<ActionResult<List<Roles>>> UpdateRole(int RoleId, Roles role)
        {
            var roleUpdate = await _context.Roles.FirstOrDefaultAsync(c => c.RoleId == RoleId);
            if (roleUpdate == null)
                return BadRequest("Role not found.");

            roleUpdate.RoleName = role.RoleName;


            await _context.SaveChangesAsync();

            return Ok("Updated successfuly");
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<List<Roles>>> DeleteRole(int id)
        {
            var roleDelete = await _context.Roles.FindAsync(id);
            if (roleDelete == null)
                return BadRequest("Role not found.");

            _context.Roles.Remove(roleDelete);
            await _context.SaveChangesAsync();

            return Ok("Deleted successfuly");
        }
    }
}