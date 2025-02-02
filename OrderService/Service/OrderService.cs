
public class OrderService : IOrderService {
    private readonly IOrderRepository _orderRepository;

    public OrderService(IOrderRepository orderRepository) {
        _orderRepository = orderRepository;
    }

    public OrderDto GetOrderById(int id) {
        var order = _orderRepository.GetOrderById(id);
        return order != null ? new OrderDto { Id = order.Id, TotalAmount = order.TotalAmount } : null;
    }
}
