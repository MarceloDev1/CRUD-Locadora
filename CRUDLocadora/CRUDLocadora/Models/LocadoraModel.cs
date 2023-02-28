using System;
using System.Collections.Generic;

namespace CRUDLocadora.Models
{
    public class LocadoraModel
    {
        public LocadoraModel()
        {
            ListaVeiculo = new List<VeiculoModel>();
            ListaVeiculosUtilizados = new List<VeiculoModel>();
        }
        public int IdLocadora { get; set; }
        public int IdVeiculo { get; set; }
        public string NomeFantasia { get; set; }
        public string RazaoSocial { get; set; }
        public string CNPJ { get; set; }
        public string Email { get; set; }
        public string Telefone { get; set; }
        public string Endereco { get; set; }
        public string CEP { get; set; }
        public string Bairro { get; set; }
        public string Estado { get; set; }
        public string Cidade { get; set; }
        public List<VeiculoModel> ListaVeiculo { get; set; }
        public List<VeiculoModel> ListaVeiculosUtilizados { get; set; }
    }
}
