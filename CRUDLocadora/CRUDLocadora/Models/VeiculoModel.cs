using System;
using System.Collections.Generic;
using System.Numerics;
using System.Runtime.ConstrainedExecution;

namespace CRUDLocadora.Models
{
    public class VeiculoModel
    {
        public VeiculoModel()
        {
            ListaModelo = new List<ModeloModel>();
        }
        public int IdVeiculo { get; set; }
        public int IdModelo { get; set; }
        public string Cor { get; set; }
        public string Fabricante { get; set; }        
        public string AnoModelo { get; set; }
        public string NomeModelo { get; set; }
        public string AnoFabricacao { get; set; }
        public string Placa { get; set; }
        public string Chassi { get; set; }
        public DateTime DataCriacao { get; set; }
        public List<ModeloModel> ListaModelo { get; set; }
        public int IdLocadora { get; set; }
    }
}
