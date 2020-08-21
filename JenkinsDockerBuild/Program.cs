using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace JenkinsDockerBuild
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("JENKINS DOCKER BUILD TEST APP " + FileVersionInfo.GetVersionInfo(Assembly.GetExecutingAssembly().Location).ProductVersion);
        }
    }
}
