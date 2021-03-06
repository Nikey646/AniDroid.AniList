﻿using System.Collections.Generic;

namespace AniDroid.AniList.Models
{
    public class User : AniListObject
    {
        public string Name { get; set; }
        public string About { get; set; }
        public AniListImage Avatar { get; set; }
        public string BannerImage { get; set; }
        public bool IsFollowing { get; set; }
        public UserOptions Options { get; set; }
        public UserMediaListOptions MediaListOptions { get; set; }
        public UserFavourites Favourites { get; set; }
        public UserStats Stats { get; set; }
        public int UnreadNotificationCount { get; set; }
        public string SiteUrl { get; set; }
        public int DonatorTier { get; set; }
        public int UpdatedAt { get; set; }

        #region Internal Classes

        public class UserOptions
        {
            public AniListTitleLanguage TitleLanguage { get; set; }
            public bool DisplayAdultContent { get; set; }
        }

        public class UserMediaListOptions
        {
            public ScoreFormat ScoreFormat { get; set; }
            public string RowOrder { get; set; }
            public bool UseLegacyLists { get; set; }
            public MediaListTypeOptions AnimeList { get; set; }
            public MediaListTypeOptions MangaList { get; set; }
        }

        public class MediaListTypeOptions
        {
            public List<string> SectionOrder { get; set; }
            public bool SplitCompletedSectionByFormat { get; set; }
            public List<string> CustomLists { get; set; }
            public List<string> AdvancedScoring { get; set; }
            public bool AdvancedScoringEnabled { get; set; }
        }

        public class UserFavourites
        {
            public Connection<Media.Edge, Media> Anime { get; set; }
            public Connection<Media.Edge, Media> Manga { get; set; }
            public Connection<Character.Edge, Character> Characters { get; set; }
            public Connection<Staff.Edge, Staff> Staff { get; set; }
            public Connection<Studio.Edge, Studio> Studios { get; set; }
        }

        public class UserStats
        {
            public int WatchedTime { get; set; }
            public int ChaptersRead { get; set; }
            public List<UserActivityHistory> ActivityHistory { get; set; }
            public List<AniListStatusDistribution> AnimeStatusDistribution { get; set; }
            public List<AniListStatusDistribution> MangaStatusDistribution { get; set; }
            public List<AniListScoreDistribution> AnimeScoreDistribution { get; set; }
            public List<AniListScoreDistribution> MangaScoreDistribution { get; set; }
        }

        public class UserActivityHistory
        {
            public int Date { get; set; }
            public int Amount { get; set; }
            public int Level { get; set; }
        }



        #endregion

        #region Enum Classes

        public sealed class ScoreFormat : AniListEnum
        {
            private ScoreFormat(string val, string displayVal, int index) : base(val, displayVal, index) { }

            public static ScoreFormat Hundred { get; } = new ScoreFormat("POINT_100", "100", 0);
            public static ScoreFormat TenDecimal { get; } = new ScoreFormat("POINT_10_DECIMAL", "10.0", 1);
            public static ScoreFormat Ten { get; } = new ScoreFormat("POINT_10", "10", 2);
            public static ScoreFormat FiveStars { get; } = new ScoreFormat("POINT_5", "Five Stars", 3);
            public static ScoreFormat ThreeSmileys { get; } = new ScoreFormat("POINT_3", "Three Smileys", 4);
        }

        public sealed class FavoriteType : AniListEnum
        {
            private FavoriteType(string val, string displayVal, int index) : base(val, displayVal, index) { }

            public static FavoriteType Anime { get; } = new FavoriteType("ANIME", "Anime", 0);
            public static FavoriteType Manga { get; } = new FavoriteType("MANGA", "Manga", 1);
            public static FavoriteType Character { get; } = new FavoriteType("CHARACTER", "Character", 2);
            public static FavoriteType Staff { get; } = new FavoriteType("STAFF", "Staff", 3);
            public static FavoriteType Studio { get; } = new FavoriteType("STUDIO", "Studio", 4);
        }

        public sealed class UserSort : AniListEnum
        {
            private UserSort(string val, string displayVal, int index) : base(val, displayVal, index) { }

            public static UserSort Id { get; } = new UserSort("ID", "Id", 0);
            public static UserSort IdDesc { get; } = new UserSort("ID_DESC", "Id (Desc)", 1);
            public static UserSort Username { get; } = new UserSort("USERNAME", "Username", 2);
            public static UserSort UsernameDesc { get; } = new UserSort("USERNAME_DESC", "Username (Desc)", 3);
            public static UserSort WatchedTime { get; } = new UserSort("WATCHED_TIME", "Watched Time", 4);
            public static UserSort WatchedTimeDesc { get; } = new UserSort("WATCHED_TIME_DESC", "Watched Time (Desc)", 5);
            public static UserSort ChaptersRead { get; } = new UserSort("CHAPTERS_READ", "Chapters Read", 6);
            public static UserSort ChaptersReadDesc { get; } = new UserSort("CHAPTERS_READ_DESC", "Chapters Read (Desc)", 7);
            public static UserSort SearchMatch { get; } = new UserSort("SEARCH_MATCH", "Search Match", 8);
        }

        #endregion
    }
}
