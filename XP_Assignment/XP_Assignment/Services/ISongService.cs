using System.Collections.Generic;
using XP_Assignment.Entities;

namespace XP_Assignment.Views
{
    public interface ISongService
    {
        Song CreateSong(MemberCredential memberCredential, Song song);
        List<Song> GetAllSong(MemberCredential memberCredential);
        List<Song> GetMineSongs(MemberCredential memberCredential);
    }
}