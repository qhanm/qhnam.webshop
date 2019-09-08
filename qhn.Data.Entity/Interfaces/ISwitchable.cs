using qhn.Data.Entity.Enums;

namespace qhn.Data.Entity.Interfaces
{
    public interface ISwitchable
    {
        Status Status { set; get; }
    }
}
