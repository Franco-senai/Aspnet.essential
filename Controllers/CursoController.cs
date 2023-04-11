
 
using AplicativoWeb.Models;     // camada models
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
    ViewData["desc"]    = c1.Descricao;
    ViewData["titInt"]  = c1.Titulointerno;
    ViewData["titMark"] = c1.TituloMarketing;
    

    return View();



    
} 


}