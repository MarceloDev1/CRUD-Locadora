using System.Collections.Generic;

namespace CRUDLocadora.Models
{
    public class ModeloModel
    {
        public ModeloModel()
        {
            ListaMontadora = new List<MontadoraModel>();
        }
        public int IdModelo { get; set; }
        public int IdMontadora { get; set;}
        public string NomeModelo { get; set; }
        public string NomeMontadora { get; set; }
        public List<MontadoraModel> ListaMontadora { get; set; }
    }
}
