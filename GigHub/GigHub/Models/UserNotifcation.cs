using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GigHub.Models
{
    public class UserNotifcation
    {
        [Key]
        [Column(Order = 1)]
        public string UserId { get; set; }

        [Key]
        [Column(Order = 2)]
        public int NotificationId { get; set; }

        public ApplicationUser User { get; }

        public Notification Notification { get; }

        public bool IsRead { get; set; }

        public UserNotifcation()
        {
            
        }

        public UserNotifcation(ApplicationUser user, Notification notification)
        {
            if (user == null) 
                throw new ArgumentNullException(nameof(user));

            if (notification == null)
                throw new ArgumentNullException(nameof(notification));

            User = user;
            Notification = notification;
        }
    }
}