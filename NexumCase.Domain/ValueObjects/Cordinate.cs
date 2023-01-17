using CSharpFunctionalExtensions;

namespace NexumCase.Domain.ValueObjects
{
    public class Cordinate : ValueObject
    {
        public int X { get; set; }
        public int Y { get; set; }

        protected override IEnumerable<object> GetEqualityComponents()
        {
            throw new NotImplementedException();
        }
    }
}
