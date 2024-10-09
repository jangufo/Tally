using Tally.IRepository;
using Tally.Models;

namespace Tally.Service;

public class TallyAccountService(ITallyAccountRepository repository)
    : BaseService<TallyAccount>(repository), ITallyAccountRepository
{
    private readonly ITallyAccountRepository _repository = repository;
}