using App.Domain.Core.Tickets.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Domain.Core.Tickets.Services
{
    public interface ITicketService
    {
        #region Ticket
        public Task<List<TicketDTO>> GetTickets(CancellationToken cancellationToken);
        public Task<List<TicketDTO>> GetTickets(int categoryId, CancellationToken cancellationToken);
        public Task<TicketDTO> GetTicket(int ticketId, CancellationToken cancellationToken);
        public Task<List<TicketDTO>> GetTicketsByStatus(int statusId, CancellationToken cancellationToken);
        public Task<int> AddTicket(TicketDTO ticketDto,CancellationToken cancellationToken);
        public Task UpdateTicket(TicketDTO ticketDto,CancellationToken cancellationToken);
        public Task DeleteTicket(int ticketId,CancellationToken cancellationToken);

        #endregion


        #region TicketHistory
        public Task AddTicketHistory(TicketHistoryDTO ticketHistoryDto, CancellationToken cancellationToken);

        #endregion


        #region Category
        public Task<List<CategoryDTO>> GetCategories(CancellationToken cancellationToken);
        public Task AddCategory(CategoryDTO categoryDto,CancellationToken cancellationToken);
        public Task UpdateCategory(CategoryDTO categoryDto,CancellationToken cancellationToken);
        public Task DeleteCategory(int categoryId,CancellationToken cancellationToken);

        #endregion


        #region Status
        public Task<List<StatusDTO>> GetStatuses(CancellationToken cancellationToken);
        public Task AddStatus(StatusDTO statusDto, CancellationToken cancellationToken);
        public Task UpdateStatus(StatusDTO statusDto, CancellationToken cancellationToken);
        public Task DeleteStatus(int statusId, CancellationToken cancellationToken);

        #endregion


        #region Priority
        public Task<List<PriorityDTO>> GetPriorities(CancellationToken cancellationToken);
        public Task AddPriority(PriorityDTO priorityDto, CancellationToken cancellationToken);
        public Task UpdatePriority(PriorityDTO priorityDto, CancellationToken cancellationToken);
        public Task DeletePriority(int priorityId, CancellationToken cancellationToken);

        #endregion
    }
}
