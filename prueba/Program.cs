using prueba;
using System.Collections.Generic;
//mostramos la lista de usuarios
//UserService.ShowData();
//asignamos los usuarios a una lista
var userList = UserService.GetUsers();

Console.WriteLine("");
//llamamos al objeto paginator y le pasamos los parametros de la paginaciòn
int currentPage = 1;
int pageSize = 10;
int maxPages = 10;

Paginator paginator = new Paginator(userList.usuario.Count(), currentPage, pageSize, maxPages);
Console.WriteLine($"StartPage: {paginator.StartPage}-EndPage: {paginator.EndPage} " +
    $"- StartIndex: {paginator.StartIndex}- EndIndex:{paginator.EndIndex}");

//pasamos a una lista
var result = GetPage.Page(userList, paginator.StartIndex, pageSize, "id", 0);

//imprimimos los valores en pantalla
Console.WriteLine("");
Console.WriteLine("Elementos paginados");
foreach (var it in result)
{
    Console.WriteLine($"{it.id}-{it.apellido} - {it.nombre}");
}

Console.WriteLine("");
Console.WriteLine("Elementos paginados descendentes por id");

var result2 = GetPage.Page(userList, paginator.StartIndex, pageSize, "id", 1);

foreach (var it in result2)
{
    Console.WriteLine($"{it.id}-{it.apellido} - {it.nombre}");
}
Console.ReadKey();