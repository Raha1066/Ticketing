using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Domain.Core.Tickets.Entities
{
    public class TicketHistory
    {
        public int Id { get; set; }
        public int TicketId { get; set; }
        public int StatusId { get; set; }
        public int UserId { get; set; }
        public string Comment { get; set; }
        public DateTime Date { get; set; }

    }
}
