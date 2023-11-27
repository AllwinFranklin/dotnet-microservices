namespace Ordering.Application.Exceptions
{
    public class NotFoundException : ApplicationException
    {
        public NotFoundException(string name, object key)
            : base($"Enitity \"{name}\" ({key}) was not found.") { }
    }
}
