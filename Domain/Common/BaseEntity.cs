using System;

namespace Domain.Common;

public class BaseEntity : IBaseEntity
{
    public Guid Id { get; set; }
    public bool IsDeleted { set; get; }
}
