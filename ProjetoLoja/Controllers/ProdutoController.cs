using Microsoft.AspNetCore.Mvc;
using ProjetoLoja.Repositories;
using ProjetoLoja.Repositories.Interfaces;
using ProjetoLoja.ViewModel;

namespace ProjetoLoja.Controllers
{
    public class ProdutoController : Controller
    {
        private readonly IProdutoRepository _produtos;

        public ProdutoController(IProdutoRepository produtos)
        {
            _produtos = produtos;
        }

        public IActionResult List()
        {
            var produtoListViewModel = new ProdutoListViewModel();
            produtoListViewModel.Produtos = _produtos.Produtos;
            produtoListViewModel.CategoriaAtual = "Categoria atual";
            return View(produtoListViewModel);
        }
    }
}
