using NexumCase.Domain.Models;
using NexumCase.Domain.ValueObjects;

namespace nexum_case_ismail_aydogdu.Models
{
    public class ResultVM
    {

        public List<Robot> Robots { get; set; }
        public Cordinate tableCordinate { get; set; } = null!;
    }
}
