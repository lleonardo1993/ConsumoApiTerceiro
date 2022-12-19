using AutoMapper;
using IntegraBrasilApi.Dtos;
using IntegraBrasilApi.Interfaces;

namespace IntegraBrasilApi.Services
{
    public class BancoService : IBancoServices
    {
        private readonly IMapper _mapper;
        private readonly IBrasilApi _brasilApi;

        public BancoService(IMapper mapper, IBrasilApi brasilApi)
        {
            _mapper = mapper;
            _brasilApi = brasilApi;
        }

        public async Task<ResponseGenerico<List<BancoResponse>>> BuscarTodos()
        {
            var bancos = await _brasilApi.BuscarTodosBanco();
            return _mapper.Map<ResponseGenerico<List<BancoResponse>>>(bancos);

        }

        public Task<ResponseGenerico<List<BancoResponse>>> BuscarBanco(string codigoBanco)
        {
            throw new NotImplementedException();
        }
               
    }
}
