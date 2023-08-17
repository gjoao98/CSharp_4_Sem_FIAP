// See https://aka.ms/new-console-template for more information
using Fiap.HelloWorld.UI.Models;

Console.WriteLine("Hello, World!");

// Instanciar um Aluno
Aluno aluno1 = new Aluno();

// Atribuir o nome ao aluno
aluno1.Nome = "Gabriel";
aluno1.Idade = 25;

// Exibir nome do aluno
Console.WriteLine(aluno1.Nome);
Console.WriteLine(aluno1.Idade);