using NexumCase.Domain.ValueObjects;

namespace NexumCase.Domain.Models
{
    public class Input
    {
        public Cordinate UpCornerCordinate { get; set; } = null!;
        public List<Command> Commands { get; set; } = null!;
    }
}
