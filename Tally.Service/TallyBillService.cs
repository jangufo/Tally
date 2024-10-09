using Tally.IRepository;
using Tally.Models;

namespace Tally.Service;

public class TallyBillService(ITallyBillRepository repository)
    : BaseService<TallyBill>(repository), ITallyBillRepository
{
    private readonly ITallyBillRepository _repository = repository;
}