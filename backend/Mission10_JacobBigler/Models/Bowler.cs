﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Mission10_JacobBigler.Models;

public partial class Bowler
{
    [Key]
    public int BowlerId { get; set; }

    public string? BowlerLastName { get; set; }

    public string? BowlerFirstName { get; set; }

    public string? BowlerMiddleInit { get; set; }

    public string? BowlerAddress { get; set; }

    public string? BowlerCity { get; set; }

    public string? BowlerState { get; set; }

    public string? BowlerZip { get; set; }

    public string? BowlerPhoneNumber { get; set; }

    public int? TeamId { get; set; }

    [JsonIgnore]//I add these JsonIgnores so that it only grabs information that I need.
    public virtual ICollection<BowlerScore> BowlerScores { get; set; } = new List<BowlerScore>();

    //This grabs an instance of the team
    public virtual Team? Team { get; set; }
}
