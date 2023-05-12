using MediatorAkademiPlusPostgre.MediatorDesignPattern.Commands;
using MediatorAkademiPlusPostgre.MediatorDesignPattern.Queries;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace MediatorAkademiPlusPostgre.Controllers
{
    public class ProductController : Controller
    {
        private readonly IMediator _mediator;

        public ProductController(IMediator mediator)
        {
            _mediator = mediator;
        }

        public async Task< IActionResult> Index()
        {
            var values =await _mediator.Send(new GetAllProductQuery());
            return View(values);
        }
        [HttpGet]
        public IActionResult AddProduct()
        {
            
            return View();
        }
        [HttpPost]
        public async Task< IActionResult> AddProduct(CreateProductCommand command)
        {
            await _mediator.Send(command);
            return RedirectToAction("Index");
        }
        public async Task< IActionResult> DeleteProduct(int id)
        {
            await _mediator.Send(new RemoveProductCommand(id));
            return RedirectToAction("Index");
        }
        [HttpGet]
        public async Task< IActionResult> UpdateProduct(int id)
        {
            var values = await _mediator.Send(new GetProductByIDQuery(id));
            return View(values);
        }
    }
}
