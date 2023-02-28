using CRUDLocadora.Models;
using System;
using System.Collections.Generic;

namespace CRUDLocadora.Models
{
    public class FiltroLocadoraModel
    {
        public FiltroLocadoraModel()
        {
            ListaModelo = new List<ModeloModel>();
            ListaMontadora = new List<MontadoraModel>();
            ListaVeiculo = new List<VeiculoModel>();
            ListaLocadora = new List<LocadoraModel>();
        }
        public DateTime DataCriacao { get; set; }
        public string Placa { get; set; }
        public string NomeFantasia { get; set; }
        public string CNPJ { get; set; }
        public string Telefone { get; set; }
        public string NomeFabricante { get; set; }
        public int IdModelo { get; set; }
        public int IdLocadora { get; set; }
        public string NomeModelo { get; set; }
        public int? IdMontadora { get; set; }
        public string NomeMontadora { get; set; }
        public string AnoModelo { get; set; }
        public string AnoFabricacao { get; set; }
        public string Chassi { get; set; }
        public List<ModeloModel> ListaModelo { get; set; }
        public List<MontadoraModel> ListaMontadora { get; set; }
        public List<VeiculoModel> ListaVeiculo { get; set; }
        public List<LocadoraModel> ListaLocadora { get; set; }
    }
}