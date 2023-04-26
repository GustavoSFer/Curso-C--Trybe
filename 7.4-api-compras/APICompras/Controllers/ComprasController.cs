using APICompras.Models;
using APICompras.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;

namespace APICompras.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  public class ComprasController : ControllerBase
  {
    Private readonly IComprasService _service;
    public ComprasController(IComprasService service)
    {
      _service = service;
    }

    // Criando o método GET -> api/compras
    [HttpGet]
    public ActionResult<IEnumerable<CompraItem>> Get()
    {
      var items = _service.GetAllItems();
      return Ok(items);
    }

    // Criando o método GET com PARAMETRO -> api/compras/5
    [HttpGet("{id:int}")]
    public ActionResult<CompraItem> Get(int id)
    {
      var item = _service.GetById(id);
      if (item == null)
      {
        return NotFound();
      }
      return Ok(item);
    }
  }
}