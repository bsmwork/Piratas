using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LiteDB;
using Model;

namespace Data
{
    public class FichaRepository: RepositorioPiratas
    {
        public List<Ficha>ListarFichas()
        {
            using (var db = new LiteDatabase(pathDbLite))
            {
                var col = db.GetCollection<Ficha>("Fichas");
                var results = col.Query()
                    //.Where(x => x.Name.StartsWith("J"))
                    //.OrderBy(x => x.)
                    .Select(x => new Model.Ficha {titulo= x.titulo, texto = x.texto, autor=x.autor })
                    //.Limit(10)
                    .ToList();
                return results;
            }
            
            }
        public int Insert(Model.Ficha newFicha)
        {
            
            using (var db = new LiteDatabase(pathDbLite))
            {
                // Get a collection (or create, if doesn't exist)
                var col = db.GetCollection<Ficha>("Fichas");

                // Create your new customer instance
                //var newFicha = new Ficha
                //{
                   
                //};

                // Insert new customer document (Id will be auto-incremented)
                col.Insert(newFicha);

                // Update a document inside a collection
                //customer.Name = "Jane Doe";

                //col.Update(customer);

                //// Index document using document Name property
                //col.EnsureIndex(x => x.Name);

                //// Use LINQ to query documents (filter, sort, transform)
                //var results = col.Query()
                //    .Where(x => x.Name.StartsWith("J"))
                //    .OrderBy(x => x.Name)
                //    .Select(x => new { x.Name, NameUpper = x.Name.ToUpper() })
                //    .Limit(10)
                //    .ToList();

                //// Let's create an index in phone numbers (using expression). It's a multikey index
                //col.EnsureIndex(x => x.Phones);

                //// and now we can query phones
                //var r = col.FindOne(x => x.Phones.Contains("8888-5555"));
            }
            return 0; 
        }
    }
}
