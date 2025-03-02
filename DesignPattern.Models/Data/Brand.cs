using System;
using System.Collections.Generic;

namespace DesignPattern.Models.Data;

public partial class Brand
{
    public Guid BrandId { get; set; }

    public string? Name { get; set; }

    public virtual ICollection<Beer> Beers { get; set; } = new List<Beer>();
}
