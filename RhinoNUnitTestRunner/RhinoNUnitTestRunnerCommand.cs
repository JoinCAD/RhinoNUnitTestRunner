using System;
using System.Collections.Generic;
using Rhino;
using Rhino.Commands;
using Rhino.Geometry;
using Rhino.Input;
using Rhino.Input.Custom;
using NUnitLite;
using System.Reflection;

namespace RhinoNUnitTestRunner
{
    [System.Runtime.InteropServices.Guid("96ad7749-f2c4-4be3-b692-1d3c2e2806e1")]
    public class RhinoNUnitTestRunnerCommand : Command
    {
        public RhinoNUnitTestRunnerCommand()
        {
            // Rhino only creates one instance of each command class defined in a
            // plug-in, so it is safe to store a refence in a static property.
            Instance = this;
        }

        ///<summary>The only instance of this command.</summary>
        public static RhinoNUnitTestRunnerCommand Instance
        {
            get; private set;
        }

        ///<returns>The command name as it appears on the Rhino command line.</returns>
        public override string EnglishName
        {
            get { return "RhinoNUnitTestRunnerCommand"; }
        }

        protected override Result RunCommand(RhinoDoc doc, RunMode mode)
        {
            try
            {
                // Go get the assembly through your preferred method.
                var assembly = typeof(TestsUsingRhinoAPI.RhinoCommonTest).Assembly;
                new AutoRun(assembly).Execute(new string[] { }, new RhinoConsoleTextWriter(), null);
            }
            catch (Exception e)
            {
                RhinoApp.Write(e.ToString());
                return Result.Failure;
            }
            
            return Result.Success;
        }
    }
}
