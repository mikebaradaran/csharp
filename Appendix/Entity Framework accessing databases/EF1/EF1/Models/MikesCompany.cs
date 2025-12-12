using System;
using System.Collections.Generic;

namespace EF1.Models;

public partial class MikesCompany
{
    public int CompanyNo { get; set; }

    public string CompanyName { get; set; } = null!;

    public string? Tel { get; set; }

    public string? County { get; set; }

    public string? PostCode { get; set; }
}
