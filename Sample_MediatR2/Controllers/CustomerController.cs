﻿using MediatR;
using Microsoft.AspNetCore.Mvc;
using Sample_MediatR2.Dtos;
using Sample_MediatR2.Services.Commands;

namespace Sample_MediatR2.Controllers;

[Route("api/[controller]")]
[ApiController]
public class CustomerController : ControllerBase
{
    private readonly IMediator _mediator;

    public CustomerController(IMediator mediator)
    {
        _mediator = mediator;
    }

    [HttpPost]
    public IActionResult Post([FromBody] AddCustomerDto model)
    {
        var result = _mediator.Send(new CreateCustomerCommand(model.CustomerName, model.CustomerPhoneNumber));
        return Ok(result.Result);
    }
}