namespace PackIT.Shared.Abstractions.Commands;

public interface ICommandDispatcher
{
    Task DispatchAsync<TCommand>(ICommand command) where TCommand : class, ICommand;
}