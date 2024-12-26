using System;
using System.Collections.Generic;

namespace LB4_AT.Models;

public partial class Genre
{
    public short Id { get; set; }

    public string GenreName { get; set; } = null!;

    public virtual ICollection<AnimeTittle> AnimeTittles { get; set; } = new List<AnimeTittle>();
}
