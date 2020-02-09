using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using Tochal.Core.DomainModels.Entity.Blog;
using Tochal.Core.DomainModels.Entity.Content;
using Tochal.Infrastructure.DataLayer.Context;
using Tochal.Infrastructure.Services.GenericService;

namespace Tochal.Infrastructure.Services
{
    public class GalleryService : GenericService<Gallery>
    {
        private readonly ApplicationDbContext _context;
        private DbSet<Gallery> table = null;

        public GalleryService(ApplicationDbContext context) : base(context)
        {
            _context = context;
            table = _context.Set<Gallery>();

        }

        public void Create(List<string> Images, int entityId)
        {
            var list = new List<Gallery>();

            foreach (var item in Images)
            {
                list.Add(new Gallery {
                    EntityId=entityId,
                    Image=item
                });
            }
            _context.Gallery.AddRange(list);
            _context.SaveChanges();
        }

        public List<Gallery> GetGalleries(int Id)
        {
            var list = _context.Gallery.Where(p => p.EntityId == Id).ToList();
            return list;
        }
    }

}
