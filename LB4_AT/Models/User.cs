using System;
using System.Collections.Generic;

namespace LB4_AT.Models;

public partial class User
{
    public short Id { get; set; }

    public string FirstName { get; set; } = null!;

    public string LastName { get; set; } = null!;

    public DateOnly DateOfRegistration { get; set; }

    public virtual ICollection<AnimeTittle> AnimeTittles { get; set; } = new List<AnimeTittle>();
}
