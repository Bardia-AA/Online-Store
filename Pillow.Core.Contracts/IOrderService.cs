using Pillow.Core.Entites;

namespace Pillow.Core.Contracts
{
    public interface IOrderService
    {
        void SaveOrder(Order order);

        void SetTransactionId(int orderId, string token);

        void PaymentDone(string token, int tId);
    }
}
