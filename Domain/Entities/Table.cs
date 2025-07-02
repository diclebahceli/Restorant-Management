using System;
using Domain.Common;

namespace Domain.Entities;

public class Table: BaseEntity
{
    public int Number { set; get; }
    public Order? Orders { set; get; }
}
