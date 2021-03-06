﻿using System;
using System.Collections.Generic;

namespace CodeNames.Models
{
    public partial class Words
    {
        public Words()
        {
            Gameswords = new HashSet<Gameswords>();
            Themeswords = new HashSet<Themeswords>();
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Gameswords> Gameswords { get; set; }
        public virtual ICollection<Themeswords> Themeswords { get; set; }
    }
}
