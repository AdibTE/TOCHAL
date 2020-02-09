using AutoMapper.QueryableExtensions;
using Tochal.Core.DomainModels.DTO; 
using Tochal.Core.DomainModels.Entity; 
using Tochal.Infrastructure.Services.GenericService;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace Tochal.Infrastructure.Services.Test
{
    public class NotificationService : GenericService<Notification>
    {

        private readonly DataLayer.Context.IUnitOfWork _context;
        private DbSet<Notification> table = null;

        #region constructor
        public NotificationService(DataLayer.Context.IUnitOfWork context) : base(context)
        {
            _context = context;
            table = _context.Set<Notification>();
        }
        #endregion

    }

    public class NotificationUserService : GenericService<NotificationUser>
    {

        private readonly DataLayer.Context.IUnitOfWork _context;
        private DbSet<NotificationUser> table = null;

        #region constructor
        public NotificationUserService(DataLayer.Context.IUnitOfWork context) : base(context)
        {
            _context = context;
            table = _context.Set<NotificationUser>();
        }
        #endregion
  
        public List<NotificationUserSummaryDTO> GetAllNotificationforUser(int userId)
        {
            return table
                   .Where(p => p.UserId == userId&& p.IsRead==false)
                   .ProjectTo<NotificationUserSummaryDTO>()
                   .ToList();
        }

        public bool IsRead(int id)
        {
            var model = table.Find(id);
            model.IsRead = true;
            if (_context.SaveChanges()>0)
                return true;
            return false;
        }

    }

}
