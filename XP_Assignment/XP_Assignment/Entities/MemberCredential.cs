﻿namespace XP_Assignment.Entities
{
    public class MemberCredential
    {
        public string token { get; set; }
        public string secretToken { get; set; }
        public long userId { get; set; }
        public long createdTimeMLS { get; set; }
        public long expiredTimeMLS { get; set; }
        public int status { get; set; }
    }
}