using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using NetBanking.Banking.Application.Interfaces;
using NetBanking.Banking.Application.Models;
using NetBanking.Banking.Domain.Models;

namespace NetBanking.Banking.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BankingController : ControllerBase
    {

        private readonly IAccountService accountService;

        public BankingController(IAccountService @as)
        {
            accountService = @as;
        }
        // GET api/banking
        [HttpGet]
        public ActionResult<IEnumerable<Account>> Get()
        {
            return Ok(accountService.GetAccounts());
        }

        [HttpPost]
        public IActionResult Post([FromBody]AccountTransfer atm)
        {
            accountService.Transfer(atm);
            return Ok(atm);
        }
        
    }
}
