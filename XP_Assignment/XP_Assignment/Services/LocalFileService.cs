using System;
using System.Diagnostics;
using System.Threading.Tasks;
using Windows.Storage;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using XP_Assignment.Entities;
using XP_Assignment.Views;

namespace XP_Assignment.Views
{
     class LocalFileService : IFileService
    {
        public async Task<bool> SaveMemberCredentialToFile(MemberCredential memberCredential)
        {
            try
            {
                var storageFolder = await ApplicationData.Current.LocalFolder.CreateFolderAsync("AccountFile",
                    CreationCollisionOption.OpenIfExists);
                var storageFile =
                    await storageFolder.CreateFileAsync("token.txt", CreationCollisionOption.ReplaceExisting);
                await FileIO.WriteTextAsync(storageFile, JsonConvert.SerializeObject(memberCredential));
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }

        public async Task<MemberCredential> ReadMemberCredentialFromFile()
        {
            var storageFolder = await ApplicationData.Current.LocalFolder.CreateFolderAsync("AccountFile",
                CreationCollisionOption.OpenIfExists);
            try
            {
                var storageFile =
                    await storageFolder.GetFileAsync("token.txt");
                if (storageFile != null)
                {
                    var jsonContent = await FileIO.ReadTextAsync(storageFile);
                    return JsonConvert.DeserializeObject<MemberCredential>(jsonContent);
                }
            }
            catch (Exception e)
            {
                // ignored
            }
            return null;
        }

        public async void SignOutByDeleteToken()
        {
            try
            {
                var storageFolder = await ApplicationData.Current.LocalFolder.CreateFolderAsync("AccountFile",
                    CreationCollisionOption.OpenIfExists);
                await storageFolder.DeleteAsync(StorageDeleteOption.Default);
            }
            catch (Exception e)
            {
                Debug.WriteLine(e.ToString());
            }
        }
    }
}