using System.Linq;
using HelloGraphQL.Data;
using HelloGraphQL.Models;
using HotChocolate;
using HotChocolate.Data;

namespace HelloGraphQL.GraphQL
{
    public class Queries
    {
        // nativ verfügbarer DI ist Constructor Injection. Mit Hilfe von Hot Chocolate steht eine 
        // Method Injection zur Verfügung! 
        //public IQueryable<LinkGroup> GetLinkGroup([Service] AppDbContext context)
        //{
        //    return context.LinkGroups;
        //}

        [UseDbContext(typeof(AppDbContext))]
        [UseProjection]
        public IQueryable<LinkGroup> GetLinkGroup([ScopedService] AppDbContext context)
        {
            return context.LinkGroups;
        }

        [UseDbContext(typeof(AppDbContext))]
        [UseProjection]
        public IQueryable<Link> GetLink([ScopedService] AppDbContext context)
        {
            return context.Links;
        }
    }
}