using MediatR;

namespace Ordering.Application.Features.Orders.Commands.DeleteOrder
{
    internal class DeleteOrderCommand : IRequest
    {
        public int Id { get; set; }
    }
}
