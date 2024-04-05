using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace IdentityApiEndpointsSampleDotnet8.Context
{
    public class MyApplicationDbContext: IdentityDbContext
    {
        public MyApplicationDbContext(DbContextOptions<MyApplicationDbContext> options): base(options)
        {
            
        }
    }
}
