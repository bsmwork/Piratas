// See https://aka.ms/new-console-template for more information
using Data;
using Model;
TestPiratas p= new TestPiratas();
var datos = p.Listar();

class TestPiratas { 




 public List<Ficha> Listar()
{
    FichaRepository repositorio = new FichaRepository();
    var lista = repositorio.ListarFichas();
        return lista;

}
 void Insertar() {
    FichaRepository repositorio = new FichaRepository();
    for (int n = 2; n <= 100; n++)
    {
        Model.Ficha newFicha = new Ficha

        {

            titulo = "Título" + n,
            texto = "texto" + n,
            autor = "autor" + n,
            obra = "obra" + n,
            // DESCRIPTORES
            nombre = "nombre" + n,
            tema = "tema" + n,
            tiempo = "tiempo" + n,
            espacio = "espacio" + n
        };

        repositorio.Insert(newFicha);
    }
}
}