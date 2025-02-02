using System.ControllerBase;

[ApiController]
[Route("api/orders")]
public class OrderController : ControllerBase {
    private readonly IOrderService _orderService;

    public OrderController(IOrderService orderService) {
        _orderService = orderService;
    }

    [HttpGet("{id}")]
    public IActionResult GetOrder(int id) {
        var order = _orderService.GetOrderById(id);
        return order != null ? Ok(order) : NotFound();
    }
}
