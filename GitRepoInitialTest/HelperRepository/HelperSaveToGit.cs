using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LibGit2Sharp;

namespace GitRepoInitialTest.HelperRepository
{
    public static class HelperSaveToGit
    {
         public static string GitRepo()
        {
            using (var repo = new Repository(@"C:\Realware\GitRepoInitialTestPhase"))
            {
                Commit commit = repo.Lookup<Commit>("73b48894238c3e9c37f9f3a696bbd4bffcf45ce5");
                Console.WriteLine("Author: {0}", commit.Author.Name);
                Console.WriteLine("Message: {0}", commit.MessageShort);
            }
            return "l";
        }
    }
}
