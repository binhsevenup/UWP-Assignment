using System.Threading.Tasks;
using XP_Assignment.Entities;

namespace XP_Assignment.Views
{
    public class GoogleDriveFileService : IFileService
    {
        public Task<bool> SaveMemberCredentialToFile(MemberCredential memberCredential)
        {
            throw new System.NotImplementedException();
        }

        public Task<MemberCredential> ReadMemberCredentialFromFile()
        {
            throw new System.NotImplementedException();
        }

        public void SignOutByDeleteToken()
        {
            throw new System.NotImplementedException();
        }
    }
}