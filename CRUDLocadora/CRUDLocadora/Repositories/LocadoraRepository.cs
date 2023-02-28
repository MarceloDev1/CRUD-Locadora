using System.Collections.Generic;
using System.Data;
using Dapper;
using CRUDLocadora.Models;
using CRUDLocadora.Data;
using CRUDLocadora.Repositories;
using System.Threading.Tasks;
using System.Linq;
using System.Text;
using System.Security.Cryptography;

namespace CRUDLocadora.Repositories
{
    public class LocadoraRepository : ILocadoraRepository
    {
        private readonly IDbConnection _db;

        public LocadoraRepository()
        {
            _db = ConnectionFactory.GetConnection();
        }
        public void CriarLocadora(LocadoraModel locadora)
        {
            _db.Execute("INSERT INTO Locadora(NomeFantasia, RazaoSocial, CNPJ, Email, Telefone, Endereco, CEP, Bairro, Estado, Cidade) VALUES (@NomeFantasia, @RazaoSocial, @CNPJ, @Email, @Telefone, @Endereco, @CEP, @Bairro, @Estado, @Cidade)", locadora);
        }

        public void CriarModelo(ModeloModel modelo)
        {
            _db.Execute("INSERT INTO Modelo(Modelo, IdMontadora) VALUES (@NomeModelo, @IdMontadora)", modelo);
        }

        public void CriarMontadora(MontadoraModel montadora)
        {
            _db.Execute("INSERT INTO Montadora(Montadora) VALUES (@NomeMontadora)", montadora);
        }

        public void CriarVeiculo(VeiculoModel veiculo)
        {
            _db.Execute("INSERT INTO Veiculos(Cor, Fabricante, AnoModelo, AnoFabricacao, Placa, Chassi, IdModelo) VALUES (@Cor, @Fabricante, @AnoModelo, @AnoFabricacao, @Placa, @Chassi, @IdModelo)", veiculo);
        }

        public async Task<List<ModeloModel>> BuscarModelos()
        {
            var retorno = await _db.QueryAsync<ModeloModel>("SELECT IdModelo, Modelo NomeModelo FROM Modelo");
            return retorno.ToList();
        }

        public async Task<List<MontadoraModel>> BuscarMontadoras()
        {
            var retorno = await _db.QueryAsync<MontadoraModel>("SELECT IdMontadora, Montadora NomeMontadora FROM Montadora");
            return retorno.ToList();
        }

        public async Task<List<VeiculoModel>> BuscarVeiculos()
        {
            var retorno = await _db.QueryAsync<VeiculoModel>("SELECT Veiculos.IdVeiculo, Modelo.Modelo NomeModelo FROM Veiculos LEFT JOIN Modelo ON Veiculos.IdModelo = Modelo.IdModelo ");
            return retorno.ToList();
        }

        public async Task<List<VeiculoModel>> BuscarVeiculosUtilizados(int idLocadora)
        {
            var retorno = await _db.QueryAsync<VeiculoModel>("SELECT Veiculos.IdLocadora, Veiculos.IdVeiculo, Modelo.Modelo NomeModelo, Veiculos.AnoFabricacao, Veiculos.Fabricante FROM Veiculos LEFT JOIN Modelo ON Veiculos.IdModelo = Modelo.IdModelo WHERE Veiculos.IdLocadora = @idLocadora", new { idLocadora });
            return retorno.ToList();
        }
        public async Task<List<VeiculoModel>> BuscarVeiculos(int idLocadora, bool trazerVeiculosDessaLocadora)
        {
            var clausulaWhere = new StringBuilder();
            clausulaWhere.Append("Veiculos.IdLocadora IS NULL");
            if (trazerVeiculosDessaLocadora) clausulaWhere.Append(" OR Veiculos.IdLocadora = @IdLocadora");
            var retorno = await _db.QueryAsync<VeiculoModel>($"SELECT Veiculos.IdVeiculo, Modelo.Modelo NomeModelo FROM Veiculos LEFT JOIN Modelo ON Veiculos.IdModelo = Modelo.IdModelo WHERE {clausulaWhere} ", new { @IdLocadora = idLocadora });
            return retorno.ToList();
        }
        public async Task<List<LocadoraModel>> BuscarLocadora(FiltroLocadoraModel filtro)
        {
            var retorno = await _db.QueryAsync<LocadoraModel>("SELECT * FROM Locadora WHERE NomeFantasia LIKE @NomeFantasia AND CNPJ LIKE @CNPJ ", new { NomeFantasia = $"%{filtro.NomeFantasia}%", CNPJ = $"%{filtro.CNPJ}%" });
            return retorno.ToList();
        }
        public async Task<LocadoraModel> BuscarLocadora(int idLocadora)
        {
           return await _db.QuerySingleOrDefaultAsync<LocadoraModel>("SELECT * FROM Locadora WHERE IdLocadora = @IdLocadora ", new { IdLocadora = idLocadora });            
        }

        public async Task<List<ModeloModel>> BuscarModelo(FiltroLocadoraModel filtro)
        {
            StringBuilder clausulaWhere = new StringBuilder();
            if (filtro.IdMontadora != null) clausulaWhere.Append(" AND Modelo.IdMontadora = @IdMontadora");
            var retorno = await _db.QueryAsync<ModeloModel>($"SELECT Modelo.IdModelo, Modelo.Modelo NomeModelo, Montadora.Montadora NomeMontadora  FROM Modelo LEFT JOIN Montadora ON Modelo.IdMontadora = Montadora.IdMontadora WHERE Modelo.Modelo LIKE @NomeModelo {clausulaWhere} ", new { NomeModelo = $"%{filtro.NomeModelo}%", filtro.IdMontadora });
            return retorno.ToList();
        }

        public async Task<List<MontadoraModel>> BuscarMontadora(FiltroLocadoraModel filtro)
        {
            var retorno = await _db.QueryAsync<MontadoraModel>("SELECT Montadora.IdMontadora, Montadora.Montadora NomeMontadora FROM Montadora WHERE Montadora LIKE @NomeMontadora", new { NomeMontadora = $"%{filtro.NomeMontadora}%"});
            return retorno.ToList();
        }

        public async Task<List<VeiculoModel>> BuscarVeiculo(FiltroLocadoraModel filtro)
        {
            var retorno = await _db.QueryAsync<VeiculoModel>("SELECT Veiculos.*, Modelo.Modelo NomeModelo, Modelo.IdModelo FROM Veiculos LEFT JOIN Modelo ON Veiculos.IdModelo = Modelo.IdModelo WHERE Fabricante LIKE Fabricante", new { Fabricante = $"%{filtro.NomeFabricante}%" });
            return retorno.ToList();
        }

        public async Task ExcluirLocadora(int idLocadora)
        {
            await _db.ExecuteAsync("DELETE FROM Locadora WHERE IdLocadora = @idLocadora", new { idLocadora });
        }

        public async Task ExcluirModelo(int idModelo)
        {
            await _db.ExecuteAsync("DELETE FROM Modelo WHERE IdModelo = @idModelo", new { idModelo });
        }

        public async Task SalvarCarroNaLocadora(int idLocadora, int idVeiculo)
        {
            await _db.ExecuteAsync("UPDATE Veiculos SET IdLocadora = @idLocadora WHERE IdVeiculo = @idVeiculo", new { idLocadora, idVeiculo });
            await _db.ExecuteAsync("INSERT INTO LogUtilizacao (IdVeiculo, IdLocadora, EmUtilizacao) VALUES (@idVeiculo, @idLocadora, 1)", new { idLocadora, idVeiculo });
        }

        public async Task RemoverCarroNaLocadora(int idLocadora, int idVeiculo)
        {
            await _db.ExecuteAsync("UPDATE Veiculos SET IdLocadora = NULL WHERE IdVeiculo = @idVeiculo", new { idVeiculo });
            await _db.ExecuteAsync("INSERT INTO LogUtilizacao (IdVeiculo, IdLocadora, EmUtilizacao) VALUES (@idVeiculo, @idLocadora, 0)", new { idLocadora, idVeiculo });
        }

        public async Task<ModeloModel> BuscarModelo(int idModelo)
        {
            return await _db.QuerySingleOrDefaultAsync<ModeloModel>("SELECT IdModelo, Modelo NomeModelo, IdMontadora FROM Modelo WHERE IdModelo = @IdModelo ", new { IdModelo = idModelo });
        }

        public async Task SalvarModelo(ModeloModel modelo)
        {
            await _db.ExecuteAsync("UPDATE Modelo SET Modelo = @Modelo, IdMontadora = @IdMontadora WHERE IdModelo = @IdModelo", new { @IdModelo = modelo.IdModelo, @Modelo = modelo.NomeModelo, @IdMontadora = modelo.IdMontadora });
        }
        public async Task SalvarMontadora(MontadoraModel montadora)
        {
            await _db.ExecuteAsync("UPDATE Montadora SET Montadora = @Montadora WHERE IdMontadora = @IdMontadora", new { @Montadora = montadora.NomeMontadora, @IdMontadora = montadora.IdMontadora });
        }        
        public async Task<MontadoraModel> BuscarMontadora(int idMontadora)
        {
            return await _db.QuerySingleOrDefaultAsync<MontadoraModel>("SELECT Montadora NomeMontadora, IdMontadora FROM Montadora WHERE IdMontadora = @IdMontadora ", new { IdMontadora = idMontadora });
        }
        public async Task ExcluirMontadora(int idMontadora)
        {
            await _db.ExecuteAsync("DELETE FROM Montadora WHERE IdMontadora = @idMontadora", new { idMontadora });
        }
        public async Task<VeiculoModel> BuscarVeiculo(int idVeiculo)
        {
            return await _db.QuerySingleOrDefaultAsync<VeiculoModel>("SELECT Veiculos.*, Modelo.Modelo NomeModelo, Modelo.IdModelo FROM Veiculos LEFT JOIN Modelo ON Veiculos.IdModelo = Modelo.IdModelo WHERE IdVeiculo = @IdVeiculo ", new { @IdVeiculo = idVeiculo });
        }
        public async Task SalvarVeiculo(VeiculoModel veiculo)
        {
            await _db.ExecuteAsync("UPDATE Veiculo SET IdModelo = @IdModelo, Cor = @Cor, Fabricante = @Fabricante, AnoModelo = @AnoModelo, Placa = @Placa, Chassi = @Chassi, AnoFabricacao = @AnoFabricacao WHERE IdVeiculo = @IdVeiculo", veiculo);
        }
        public async Task ExcluirVeiculo(int idVeiculo)
        {
            await _db.ExecuteAsync("DELETE FROM Veiculos WHERE IdVeiculo = @idVeiculo", new { idVeiculo });
        }
    }
}