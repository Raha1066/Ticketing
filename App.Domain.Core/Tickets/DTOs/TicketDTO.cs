using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Domain.Core.Tickets.DTOs
{
    public class TicketDTO
    {
        public int Id { get; set; }
        public string Subject { get; set; }
        public string Description { get; set; }
        public int CategoryId { get; set; }
        public int StatusId { get; set; }
        public int PriorityId { get; set; }
        public List<TicketHistoryDTO>? TicketHistories { get; set; }
        public string File { get; set; }



    }

}
