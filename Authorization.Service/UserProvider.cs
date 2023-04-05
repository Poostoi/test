using Authorization.Entities;
using Authorization.Infrastructure;
using Microsoft.EntityFrameworkCore;

namespace Authorization.Service;

public class UserProvider
{
    private readonly ApplicationDbContext _dbContext;

    public UserProvider(ApplicationDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public async Task<User?> FindUser(Guid id, CancellationToken cancellationToken)
    {
        return await _dbContext.Users.SingleOrDefaultAsync(user => user.Id == id, cancellationToken)
            .ConfigureAwait(false);
    }
    public async Task AddUser(User user, CancellationToken cancellationToken)
    {
        await _dbContext.Users.AddAsync(user, cancellationToken).ConfigureAwait(false);
    }
}