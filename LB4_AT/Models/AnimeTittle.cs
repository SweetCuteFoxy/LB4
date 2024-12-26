using System;
using System.Collections.Generic;

namespace LB4_AT.Models;

public partial class AnimeTittle
{
    public short Id { get; set; }

    public short IdOfGenre { get; set; }

    public short IdOfAnimeType { get; set; }

    public short IdOfUser { get; set; }

    public string OriginalName { get; set; } = null!;

    public string TittleName { get; set; } = null!;

    public DateOnly? YearOfRealese { get; set; }

    public short? Description { get; set; }

    public string? Poster { get; set; }

    public short? CountOfSeries { get; set; }

    public short? Duration { get; set; }

    public bool IsComplete { get; set; }

    public string Studio { get; set; } = null!;

    public virtual AnimeType IdOfAnimeTypeNavigation { get; set; } = null!;

    public virtual Genre IdOfGenreNavigation { get; set; } = null!;

    public virtual User IdOfUserNavigation { get; set; } = null!;
}
