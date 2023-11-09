﻿using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Entities.Models;

public partial class Order
{
    public int Id { get; set; }

    public DateTime OrderDate { get; set; }

    public int OrderSum { get; set; }

    public int UserId { get; set; }

    [JsonIgnore]
    public virtual ICollection<OrderItem> OrderItems { get; set; } = new List<OrderItem>();

    public virtual User? User { get; set; } = null!;
}
