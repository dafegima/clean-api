namespace User.Example.Domain.Interfaces
{
    public interface IDeleteUserUseCase
    {
        bool Execute(string identification);
    }
}
