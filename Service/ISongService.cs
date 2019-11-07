using ASM_UWP_NguyenThao.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASM_UWP_NguyenThao.Service
{
    interface ISongService
    {
        Song CreateSong(MemberCredential memberCredential, Song song);
        List<Song> GetAllSong(MemberCredential memberCredential);
        List<Song> GetMineSongs(MemberCredential memberCredential);
    }
}
