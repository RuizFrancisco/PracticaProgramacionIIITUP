using ExploreOOP.BusinessLayer.Services;
using ExploreOOP.BusinessLayer.Entities;
using Microsoft.AspNetCore.Mvc;

namespace ExploreOOPWebApi.Controllers;

[ApiController]
[Route("[controller]")]
public class LineOfCreditAccountController : ControllerBase
{
    private readonly ILogger<LineOfCreditAccountController> _logger;
    private readonly ILineOfCreditAccountService _lineOfCreditAccountService;

    public LineOfCreditAccountController(ILogger<LineOfCreditAccountController> logger, ILineOfCreditAccountService lineOfCreditAccountService)
    {
        _logger = logger;
        _lineOfCreditAccountService = lineOfCreditAccountService;
    }

    [HttpGet]
    public IEnumerable<LineOfCreditAccount> GetAll()
    {
        return _lineOfCreditAccountService.GetAll();
    }

    [HttpGet("{id}")]
    public LineOfCreditAccount Get(int id)
    {
        return _lineOfCreditAccountService.Get(id);
    }

    [HttpPost]
    public void Add([FromBody] CreateLineOfCreditAccount createLineOfCreditAccount)
    {
        _lineOfCreditAccountService.Create(createLineOfCreditAccount);
    }

    [HttpDelete("{id}")]
    public IActionResult Delete(int id)
    {
        try 
        { 
            _lineOfCreditAccountService.Delete(id);
            return Ok();
        }
        catch
        {
            return NotFound();
        }
    }

}
