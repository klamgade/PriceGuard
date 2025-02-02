public class OrderRepository : IOrderRepository {
    private static readonly List<Order> orders = new() {
        new Order { Id = 1, TotalAmount = 100.00m },
        new Order { Id = 2, TotalAmount = 250.50m }
    };

    public Order GetOrderById(int id) {
        return orders.FirstOrDefault(o => o.Id == id);
    }
}
