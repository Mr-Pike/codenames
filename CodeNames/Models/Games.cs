﻿using System;
using System.Collections.Generic;

namespace CodeNames.Models
{
    public partial class Games
    {
        public Games()
        {
            Gameswords = new HashSet<Gameswords>();
        }

        public int Id { get; set; }
        public short ScoreATeam { get; set; }
        public short ScoreBTeam { get; set; }
        public short RoundATeam { get; set; }
        public short RoundBTeam { get; set; }
        public short StartTeamId { get; set; }
        public short NextToPlayTeamId { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }

        public virtual ICollection<Gameswords> Gameswords { get; set; }
    }
}
