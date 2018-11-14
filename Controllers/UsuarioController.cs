using System;
using System.IO;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using todols.Web.Mvc.Models;

namespace todols.Web.Mvc.Controllers
{
    public class UsuarioController : Controller
    {
        [HttpGet]
        public ActionResult Cadastrar(){
            return View();
        }

        [HttpPost]
        public ActionResult Cadastrar(IFormCollection form){
            UsuarioModel usuario = new UsuarioModel();
            usuario.Id = form["Id"];
            usuario.Nome = form["nome"];
            usuario.Email = form["email"];
            usuario.Senha = form["senha"];
            usuario.tipo = form["Tipo"];
            usuario.DataNascimento = DateTime.Parse(form["dataNascimento"]);

            using(StreamWriter sw = new StreamWriter("usuarios.csv", true)){
                sw.WriteLine($"{usuario.Id};{usuario.Nome};{usuario.Email};{usuario.Senha};{usuario.tipo};{usuario.DataNascimento}");
            }

            ViewBag.Mensagem =  "Usuário Cadastrado";
            
            return RedirectToAction("Index", "Transacao");
        }

    }
}