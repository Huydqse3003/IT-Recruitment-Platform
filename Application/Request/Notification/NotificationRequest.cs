using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Request.Notification
{
    public class NotificationRequest
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public bool IsRead { get; set; } = false;
    }
}
