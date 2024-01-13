using AutoMapper;
using Business.Interfaces;
using FirstRestAPI.Models;
using FirstRestAPI.ViewModels;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ApiExplorer;

namespace FirstRestAPI.Controllers;

[Route("api/[controller]")]
public class SupplierController : MainController
{
    private readonly ISupplierRepository _supplierRepository;
    private readonly IMapper _mapper;
    public SupplierController(ISupplierRepository supplierRepository, IMapper mapper)
    {
        _supplierRepository = supplierRepository;
        _mapper = mapper;
    }

    [HttpGet()]
    [ApiConventionMethod(typeof(DefaultApiConventions), nameof(DefaultApiConventions.Get))]
    public async Task<ActionResult<IEnumerable<SupplierViewModel>>> GetAllSupplier()
    {
        var suppliers = await _supplierRepository.Get();
        var supplierViewModel = _mapper.Map<IEnumerable<SupplierViewModel>>(suppliers);
        return Ok(supplierViewModel);
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
    public ActionResult<Supplier> CreateSupplier(Supplier supplier)
    {
        if (!ModelState.IsValid)
        {
            return BadRequest(ModelState);
        }

        return Created(nameof(GetSupplier),supplier);
    }

    [HttpPut("{id:Guid}")]
    [ApiConventionMethod(typeof(DefaultApiConventions), nameof(DefaultApiConventions.Put))]
    public ActionResult<IEnumerable<Supplier>> UpdateSupplier(Guid id, Supplier supplier)
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
    public ActionResult DeleteSupplier(Guid id) 
    {
        return NoContent();
    }
}
