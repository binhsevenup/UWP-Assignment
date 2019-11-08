using System.Threading.Tasks;
using XP_Assignment.Entities;

namespace XP_Assignment.Views
{
    public interface IFileService
    {
        Task<bool> SaveMemberCredentialToFile(MemberCredential memberCredential);

        Task<MemberCredential> ReadMemberCredentialFromFile();

        void SignOutByDeleteToken();

    }
}