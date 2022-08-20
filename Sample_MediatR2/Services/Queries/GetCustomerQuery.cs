using MediatR;
using Sample_MediatR2.Entities;

namespace Sample_MediatR2.Services.Queries
{
    public class GetCustomerQuery : IRequest<Customer>
    {
        public int CustomerId { get; set; }
    }

    public class GetCustomerQueryHandler : IRequestHandler<GetCustomerQuery, Customer>
    {
        public Task<Customer> Handle(GetCustomerQuery request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}