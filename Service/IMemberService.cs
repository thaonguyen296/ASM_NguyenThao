using ASM_UWP_NguyenThao.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASM_UWP_NguyenThao.Service
{
    interface IMemberService
    {
        Member Register(Member member);

        MemberCredential Login(MemberLogin memberLogin);

        Member GetInformation(string token);
    }
}
