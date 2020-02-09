using Tochal.Core.DomainModels.Entity.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Drawing.Printing;
using System.Text;

namespace Tochal.Core.DomainModels.Entity
{
    public class Notification
    {
        public int Id { get; set; }

        public string Text { get; set; }

        public DateTime? ShowDate { get; set; }
    }

    public class NotificationUser
    {
        public int Id { get; set; }

        public int NotificationId { get; set; }

        public int UserId { get; set; }

        public bool IsRead { get; set; }

        public DateTime? ShowDate { get; set; }

        [ForeignKey(nameof(UserId))]
        public User User { get; set; }

        [ForeignKey(nameof(NotificationId))]
        public Notification Notification { get; set; }
    }
}
