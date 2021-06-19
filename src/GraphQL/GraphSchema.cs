using System;
using GraphQL.Types;
using Microsoft.Extensions.DependencyInjection;

namespace AspNetCoreGraphQL.GraphQL
{
    public class GraphSchema : Schema
    {
        public GraphSchema(IServiceProvider provider) : base(provider)
        {
            Query = provider.GetRequiredService<RootQuery>();
        }
    }
}
