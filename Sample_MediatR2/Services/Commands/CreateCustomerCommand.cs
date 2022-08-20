using MediatR;

namespace Sample_MediatR2.Services.Commands;

public record CreateCustomerCommand : IRequest<object>
{
    public string? CustomerName { get; set; }
    public string? PhoneNumber { get; set; }

    public CreateCustomerCommand(string? name, string? phone)
    {
        CustomerName = name;
        PhoneNumber = phone;
    }
}

public class CreateCustomerCommandHandler : IRequestHandler<CreateCustomerCommand, object>
{
    public async Task<object> Handle(CreateCustomerCommand request, CancellationToken cancellationToken)
    {
        await Task.CompletedTask;
        return new
        {
            IsSuccess = true,
            Message = "Operation succeded!"
        };
    }
}