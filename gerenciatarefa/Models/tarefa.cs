//agrupar classes 
namespace GerenciaTarefa.Models;
//Conjunto de cLass
public class Tarefa{

//CLasse é um conjunto de objetos
//Propriedades
//propriedaddes Automáticas (prop + tab)
//Funcionalidade

public int Id { get;set; }//inteiro
public string? Cabecalho { get; set; }// cabecalho dos cards da views
public string? Titulo { get; set; } //titulo dos cards da views
public string? Descricao { get; set; }//Texto
public bool Tacomleta { get; set; }//estado da tarefa concluido/Não concluido
// Funcionalidades

}