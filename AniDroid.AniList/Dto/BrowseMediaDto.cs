﻿using System;
using System.Collections.Generic;
using System.Text;
using AniDroid.AniList.Models;

namespace AniDroid.AniList.Dto
{
    public class BrowseMediaDto
    {
        // TODO: add rest of properties from query

        public ICollection<Media.MediaSort> Sort { get; set; }
        public Media.MediaType Type { get; set; }
        public Media.MediaSeason Season { get; set; }
        public int? SeasonYear { get; set; }
        public Media.MediaFormat Format { get; set; }
        public int? Year { get; set; }
        public string YearLike => Year.HasValue ? $"{Year}%" : null;


        public ICollection<string> IncludedGenres { get; set; }
        public ICollection<string> ExcludedGenres { get; set; }
        public ICollection<string> IncludedTags { get; set; }
        public ICollection<string> ExcludedTags { get; set; }
    }
}
