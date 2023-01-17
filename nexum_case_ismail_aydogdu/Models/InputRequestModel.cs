using NexumCase.Domain.ValueObjects;

namespace nexum_case_ismail_aydogdu.Models
{
    public class InputRequestModel
    {
        public Cordinate UpCornerCordinate { get; set; }

        public Position PositionOne { get; set; } = new Position(new Cordinate(), new Direction());
        public Position PositionTwo { get; set; } = new Position(new Cordinate(), new Direction());

        public string DirectionCodeOne { get; set; }
        public string DirectionCodeTwo { get; set; }

        public string CommandKeysOne { get; set; }
        public string CommandKeysTwo { get; set; }
    }
}
