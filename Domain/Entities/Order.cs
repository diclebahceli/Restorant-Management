
using System;
using Domain.Common;

namespace Domain.Entities;

public class Order: BaseEntity
{
    public required int Tableno { get; set; }
    public List<MenuItem> Items { set; get; } = [];
}
