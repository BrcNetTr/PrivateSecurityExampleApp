
namespace Entities.Models.Common;

public abstract class BaseEntity:IBaseEntity
{
    public int Id { get; set; }
    public DateTime CreateDate { get; set; }
    public DateTime? UpdatedDate { get; set; }

}
