using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Catalog.Domain.Entities;
using Catalog.Domain.Repositories;
using Microsoft.EntityFrameworkCore;

namespace Catalog.Infrastructure.Repositories
{
    public class ArtistRepository : IArtistRepository
    {
        private readonly CatalogContext _catalogContext;
        public IUnitOfWork UnitOfWork => _catalogContext;

        public ArtistRepository(CatalogContext catalogContext)
        {
            _catalogContext = catalogContext;
        }

        public async Task<IEnumerable<Artist>> GetAsync()
        {
            return await _catalogContext.Artist
                .AsNoTracking()
                .ToListAsync();
        }

        public async Task<Artist> GetAsync(Guid id)
        {
            var item = await _catalogContext.Artist
                .FindAsync(id);

            if (item == null) return null;

            _catalogContext.Entry(item).State = EntityState.Detached;
            return item;
        }

        public Artist Add(Artist item)
        {
            return _catalogContext.Artist.Add(item).Entity;
        }
    }
}