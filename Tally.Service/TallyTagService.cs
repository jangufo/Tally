using Tally.IRepository;
using Tally.Models;

namespace Tally.Service;

public class TallyTagService(ITallyTagRepository repository) : BaseService<TallyTag>(repository), ITallyTagRepository
{
    private readonly ITallyTagRepository _repository = repository;
}