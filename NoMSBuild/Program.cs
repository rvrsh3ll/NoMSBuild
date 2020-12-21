using Microsoft.Build.Evaluation;

namespace NoMSBuild
{

    public class BuildIt
    {
        private static bool BuildProject(string projectPath)
        {
            var engine = new ProjectCollection();
            bool success = engine.LoadProject(projectPath).Build();
            return success;
        }
        static void Main(string[] args)
        {
            string projectPath = "buildit.csproj";
            BuildProject(projectPath);
        }
    }
}
