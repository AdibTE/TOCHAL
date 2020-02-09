using System;
using System.Collections.Generic;
using System.Text;

namespace Tochal.Core.DomainModels.ViewModel
{
    public class NotificationViewModel
    {

        public string Text { get; set; }

        public DateTime? ShowDate { get; set; }
    }

    public class NotificationSearchViewModel
    {
        public int NotificationId { get; set; }

        public int UserId { get; set; }

        public bool IsRead { get; set; }

        public DateTime? ShowDate { get; set; }
    }
}
