using System;
using System.Collections.Generic;

namespace DesignPattern.Models.Data;

public partial class Beer
{
    public int BeerId { get; set; }

    public string? Name { get; set; }

    public Guid? BrandId { get; set; }

    public virtual Brand? Brand { get; set; }
}
