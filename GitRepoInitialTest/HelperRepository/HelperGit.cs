using System;
using LibGit2Sharp;
using Microsoft.Alm.Authentication;

namespace GitRepoInitialTest.HelperRepository
{
    public static class HelperGit
    {
        public static void GitRepoInfo()
		{
			string repos;
			using (var repo = new Repository(@"C:\Users\mstojanovic\Desktop\GitTest\hello-world"))
			{
				var commit = repo.Head.Tip;
				Console.WriteLine("Author: {0}", commit.Author.Name);
				Console.WriteLine("Message: {0}", commit.MessageShort);
				repos = commit.Message;
				foreach (TreeEntry treeEntry in commit.Tree)
				{
					Console.WriteLine("Path:{0} - Type:{1}", treeEntry.Path, treeEntry.TargetType, treeEntry.Name);
				}
			}
        }

		public static void CopyRepositoryFromGit()
		{
			var secret = new SecretStore("git");
			var auth = new BasicAuthentication(secret);
			var cred = auth.GetCredentials(new TargetUri("https://g.real-ware.com/"));
			var option = new CloneOptions
			{
				CredentialsProvider = (_url, _user, _cred) => new
				UsernamePasswordCredentials
				{
					Username = cred.Username,
					Password = cred.Password
				},
			};
			Repository.Clone("https://g.real-ware.com/root/atomsngxmvc.git", @"C:\7\AtomsGit", option);
		}
    }
}
