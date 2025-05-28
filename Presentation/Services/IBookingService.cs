using Presentation.Models;

namespace Presentation.Service;

public interface IBookingService
{
    Task<BookingResult> CreateBookingAsync(CreateBookingRequest request);
}