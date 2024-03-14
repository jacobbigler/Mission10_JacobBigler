using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Mission10_JacobBigler.Models;

public partial class Team
{
    [Key]
    public int TeamId { get; set; }

    public string TeamName { get; set; } = null!;

    public int? CaptainId { get; set; }

    [JsonIgnore] //Ignore this so there isn't a loop
    public virtual ICollection<Bowler> Bowlers { get; set; } = new List<Bowler>();

    [JsonIgnore] //Ignore this because I don't need it
    public virtual ICollection<TourneyMatch> TourneyMatchEvenLaneTeams { get; set; } = new List<TourneyMatch>();
    [JsonIgnore] //Ignore this because I don't need it
    public virtual ICollection<TourneyMatch> TourneyMatchOddLaneTeams { get; set; } = new List<TourneyMatch>();
}
