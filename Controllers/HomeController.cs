using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using LHPet.Models;

namespace LHPet.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {   
        Cliente cliente1=new Cliente(01, "Arthur A. Ferreira", "123.456.-22","arthuraf@email.com", "Doguinho");
        Cliente cliente2=new Cliente(02, "Alice Silva", "123.456.-54","alices@email.com", "Cabrito");
        Cliente cliente3=new Cliente(03, "João Carlos", "123.456.-68","joaoc@email.com", "Gatinho");
        Cliente cliente4=new Cliente(04, "Pedro Paulo", "123.456.-98","pedrop@email.com", "Panda");
        Cliente cliente5=new Cliente(05, "Wesley Safadão", "123.456.-64","wesleyf@email.com", "Unicornio");

        List<Cliente> listaClientes=new List<Cliente>();
        listaClientes.Add(cliente1);
        listaClientes.Add(cliente2);
        listaClientes.Add(cliente3);
        listaClientes.Add(cliente4);
        listaClientes.Add(cliente5);

        ViewBag.listaClientes = listaClientes;

        Fornecedor fornecedor1=new Fornecedor(01,"Flavinho do Pneu","12.123.456/0001-55","flavinho@ltda.com");
        Fornecedor fornecedor2=new Fornecedor(02,"Jorge do Café","78.986.655/0001-66","Jorge@ltda.com");
        Fornecedor fornecedor3=new Fornecedor(03,"AneFeste","74.123.369/0001-98","Ane@ltda.com");
        Fornecedor fornecedor4=new Fornecedor(04,"Corte Facil","23.699.874/0001-63","corte@ltda.com");
        Fornecedor fornecedor5=new Fornecedor(05,"JJ Locações","55.698.135/0001-44","jj@ltda.com");
        
        List<Fornecedor> listaFornecedor=new List<Fornecedor>();
        listaFornecedor.Add(fornecedor1);
        listaFornecedor.Add(fornecedor2);
        listaFornecedor.Add(fornecedor3);
        listaFornecedor.Add(fornecedor4);
        listaFornecedor.Add(fornecedor5);

        ViewBag.listaFornecedor = listaFornecedor;
     
        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
