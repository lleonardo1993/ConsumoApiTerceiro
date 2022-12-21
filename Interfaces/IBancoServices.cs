using IntegraBrasilApi.Dtos;

namespace IntegraBrasilApi.Interfaces
{
    public interface IBancoServices
    {
        Task<ResponseGenerico<List<BancoResponse>>> BuscarTodos();
        Task<ResponseGenerico<BancoResponse>> BuscarBanco(string codigoBanco);

    }
}
