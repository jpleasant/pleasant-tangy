using Grpc.Core;
using PleasantAndTangyGrpc;

namespace PleasantAndTangyGrpc.Services;

public class CalendarService : Calendar.CalendarBase
{
    public override async Task GetCalendarItems(Empty request, IServerStreamWriter<CalendarEvent> responseStream, ServerCallContext context)
    {
        var items = new List<CalendarEvent>();
        items.Add(new CalendarEvent
        {
            Name = "Test",
            Details = ""
        });
        foreach (var i in items)
        {
            await responseStream.WriteAsync(i);
        }
    }
}