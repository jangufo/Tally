using Tally.IRepository;
using Tally.IService;
using Tally.Models;

namespace Tally.Service;

public class TallyUserService(ITallyUserRepository repository) : BaseService<TallyUser>(repository), ITallyUserService
{
    private readonly ITallyUserRepository _repository = repository;
}