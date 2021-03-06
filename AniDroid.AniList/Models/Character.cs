﻿using System.Collections.Generic;
using AniDroid.AniList.Interfaces;

namespace AniDroid.AniList.Models
{
    public class Character : AniListObject
    {
        public AniListName Name { get; set; }
        public AniListImage Image { get; set; }
        public string Description { get; set; }
        public bool IsFavourite { get; set; }
        public string SiteUrl { get; set; }
        public Connection<Media.Edge, Media> Media { get; set; }
        public IPagedData<Media.Edge> Anime { get; set; }
        public IPagedData<Media.Edge> Manga { get; set; }

        #region Internal Classes

        public class Edge : ConnectionEdge<Character>
        {
            public CharacterRole Role { get; set; }
            public List<Staff> VoiceActors { get; set; }
            public List<Media> Media { get; set; }
            public int FavouriteOrder { get; set; }
        }

        #endregion

        #region Enum Classes

        public sealed class CharacterRole : AniListEnum
        {
            private CharacterRole(string val, string displayVal, int index) : base(val, displayVal, index) { }

            public static CharacterRole Main { get; } = new CharacterRole("MAIN", "Main", 0);
            public static CharacterRole Supporting { get; } = new CharacterRole("SUPPORTING", "Supporting", 1);
            public static CharacterRole Background { get; } = new CharacterRole("BACKGROUND", "Background", 2);
        }

        #endregion
    }
}
