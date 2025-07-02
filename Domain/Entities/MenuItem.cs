using System;
using Domain.Common;

namespace Domain.Entities;

public class MenuItem : BaseEntity
{
    public required string Name { get; set; }
    public required Category Category { get; set; }
    public required double Price { set; get; }
}
