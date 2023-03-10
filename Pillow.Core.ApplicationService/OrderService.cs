using Pillow.Core.Contracts;
using Pillow.Core.Entites;

namespace Pillow.Core.ApplicationService
{
    public class OrderService:IOrderService
    {
        private readonly IOrderRepository orderRepository;

        public OrderService(IOrderRepository orderRepository)
        {
            this.orderRepository = orderRepository;
        }

        public void PaymentDone(string token, int tId)
        {
            orderRepository.PaymentDone(token, tId);
        }

        public void SaveOrder(Order order)
        {
            orderRepository.Save(order);
        }

        public void SetTransactionId(int orderId, string token)
        {
            orderRepository.SetOrderToken(orderId, token);
        }
    }
}
