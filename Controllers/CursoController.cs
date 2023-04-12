

using AplicativoWeb.Models;
using Microsoft.AspNetCore.Mvc; // microsoft
//conjunto de Classes



namespace AplicativoWeb.Controllers; // definição

public class CursoController:Controller{


        /*

        ações ou actions
        objetivo:Resirecionar para as paginas (web)

        */


        /*
            Interface = interface grafica
            Orientadoa a objtetos Interface é um contrato
        */
public IActionResult Index(){
    // encapsular é esconder, estudar encapsulamento no youtube de orientação a objeto
    
    Curso c1 = new Curso();
    // define o componente da função SET
    c1.Descricao       = "Primeiros Passos no Asp.NET core";
    c1.Titulointerno   = "Desenvolvedor C#";
    c1.TituloMarketing = "Crie Aplicativos Dinamicos";

    // define o componente da função GET
    
    
    ViewData["curso"] = c1; // passa o objeto para dentro do ViewData (c1 o objeto)
     
     return View();
    
}

public IActionResult Create(){

    ViewData["titulo"]="Cadastro de Cursos";
    ViewBag.DataHora = DateTime.Now;

    return View();





}


}