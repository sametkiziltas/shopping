using System.Threading.Tasks;
using EventBus.Base.Events;

namespace EventBus.Base.Interfaces 
{
    public interface IIntegrationEventHandler<T>: IntegrationEventHandler where T : IntegrationEvent
    {
        Task Handle(T @event);
    }

    public interface IntegrationEventHandler 
    {
        
    }
}
