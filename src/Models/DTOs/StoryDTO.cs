﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.DTOs
{
    public class StoryDTO
    {
        public string By { get; set; }
        public int Descendants { get; set; }
        public int Id { get; set; }
        public IEnumerable<int> Kids { get; set; }
        public int Score { get; set; }
        public long Time { get; set; }
        public string Title { get; set; }
        public string Type { get; set; }
        public string Url { get; set; }
    }
}