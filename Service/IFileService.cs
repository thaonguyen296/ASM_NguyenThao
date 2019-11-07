using ASM_UWP_NguyenThao.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASM_UWP_NguyenThao.Service
{
    interface IFileService
    {
        Task<bool> SaveMemberCredentialToFile(MemberCredential memberCredential);

        Task<MemberCredential> ReadMemberCredentialFromFile();

        void SignOutByDeleteToken();
    }
}
