﻿using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace RelationalGit.Data
{
    public class Period
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long Id { get; set; }

        public DateTime FromDateTime { get; set; }

        public DateTime ToDateTime { get; set; }

        public string FirstCommitSha { get; set; }

        public string LastCommitSha { get; set; }

        public string ModelParam { get; set; }
        
        public double dynLow { get; set; }

        public double dynHigh { get; set; }

        public double normLow { get; set; }

        public double normHigh { get; set; }
    }
}
