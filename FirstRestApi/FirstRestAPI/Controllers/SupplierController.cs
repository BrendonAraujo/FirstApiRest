using FirstRestAPI.Models;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ApiExplorer;

namespace FirstRestAPI.Controllers;

[ApiController]
[Route("api/supplier")]
public class SupplierController : ControllerBase
{
    [HttpGet()]
    [ApiConventionMethod(typeof(DefaultApiConventions), nameof(DefaultApiConventions.Get))]
    public ActionResult<IEnumerable<Supplier>> GetAllSupplier()
    {
        return Ok();
    }

    [HttpGet("{id:int}")]
    [ApiConventionMethod(typeof(DefaultApiConventions), nameof(DefaultApiConventions.Get))]
    public ActionResult<Supplier> GetSupplier(int id)
    {
        if(id == 0)
        {
            return BadRequest();
        }

        return Ok();
    }

    [HttpPost()]
    [ApiConventionMethod(typeof(DefaultApiConventions), nameof(DefaultApiConventions.Post))]
    public ActionResult<Supplier> Create(Supplier supplier)
    {
        if (!ModelState.IsValid)
        {
            return BadRequest(ModelState);
        }

        return Created(nameof(GetSupplier),supplier);
    }

    [HttpPut("{id:Guid}")]
    [ApiConventionMethod(typeof(DefaultApiConventions), nameof(DefaultApiConventions.Put))]
    public ActionResult<IEnumerable<Supplier>> Update(Guid id, Supplier supplier)
    {
        if (!ModelState.IsValid)
        {
            return BadRequest(ModelState);
        }

        if(id != supplier.Id)
        {
            return BadRequest();
        }


        return Ok(supplier);
    }

    [HttpDelete("{id:int}")]
    [ApiConventionMethod(typeof(DefaultApiConventions), nameof(DefaultApiConventions.Delete))]
    public ActionResult Delete(Guid id) 
    {
        return NoContent();
    }
}
