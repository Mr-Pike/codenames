﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations.Schema;

namespace CodeNames.Models
{
    [ModelMetadataType(typeof(GamesMetadata))]
    public partial class Games
    {
    }
}
