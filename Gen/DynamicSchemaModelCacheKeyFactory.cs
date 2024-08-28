using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;

namespace Base_Backend.Gen;

public class DynamicSchemaModelCacheKeyFactory: IModelCacheKeyFactory
{

    public object Create(DbContext context, bool designTime)
    {
        if (context is CustomDbContext dynamicSchemaContext)
        {
            return (context.GetType(), CustomDbContext._asyncThread.Value);
        }

        return context.GetType();
    }
}