
using System.Collections.Generic;
using System.Threading.Tasks;
using CRUDLocadora.Models;

namespace CRUDLocadora.Repositories
{
    public interface ILocadoraRepository
    {
        void CriarLocadora(LocadoraModel locadora);
        void CriarModelo(ModeloModel veiculo);
        void CriarMontadora(MontadoraModel montadora);
        void CriarVeiculo(VeiculoModel veiculo);
        Task<List<ModeloModel>> BuscarModelos();
        Task<List<MontadoraModel>> BuscarMontadoras();
        Task<List<VeiculoModel>> BuscarVeiculos();
        Task<List<VeiculoModel>> BuscarVeiculos(int idLocadora, bool trazerVeiculosDessaLocadora);
        Task<List<VeiculoModel>> BuscarVeiculosUtilizados(int idLocadora);
        Task<List<LocadoraModel>> BuscarLocadora(FiltroLocadoraModel filtro);
        Task<LocadoraModel> BuscarLocadora(int idLocadora);
        Task<List<ModeloModel>> BuscarModelo(FiltroLocadoraModel filtro);
        Task<List<MontadoraModel>> BuscarMontadora(FiltroLocadoraModel filtro);
        Task<List<VeiculoModel>> BuscarVeiculo(FiltroLocadoraModel filtro);
        Task ExcluirLocadora(int idLocadora);
        Task SalvarCarroNaLocadora(int idLocadora, int idVeiculo);
        Task RemoverCarroNaLocadora(int idLocadora, int idVeiculo);
        Task<ModeloModel> BuscarModelo(int idModelo);
        Task ExcluirModelo(int idModelo);
        Task ExcluirMontadora(int idMontadora);
        Task<MontadoraModel> BuscarMontadora(int idMontadora);
        Task SalvarModelo(ModeloModel modelo);
        Task SalvarMontadora(MontadoraModel montadora);
        Task<VeiculoModel> BuscarVeiculo(int idVeiculo);
        Task SalvarVeiculo(VeiculoModel veiculo);
        Task ExcluirVeiculo(int idVeiculo);
    }
}