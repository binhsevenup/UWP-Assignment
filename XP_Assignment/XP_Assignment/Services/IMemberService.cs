using XP_Assignment.Entities;

namespace XP_Assignment.Views
{
    public interface IMemberService
    {
        Member Register(Member member);

        MemberCredential Login(MemberLogin memberLogin);

        Member GetInformation(string token);
    }
}