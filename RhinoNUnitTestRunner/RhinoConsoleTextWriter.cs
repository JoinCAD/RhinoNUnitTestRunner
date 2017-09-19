using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Common;

namespace RhinoNUnitTestRunner
{
    class RhinoConsoleTextWriter : NUnit.Common.ExtendedTextWriter
    {
        public override Encoding Encoding
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public override void Write(ColorStyle style, string value)
        {
            Rhino.RhinoApp.Write(value);
        }

        public override void WriteLabel(string label, object option)
        {
            Rhino.RhinoApp.Write(label + option?.ToString());
        }

        public override void WriteLabel(string label, object option, ColorStyle valueStyle)
        {
            Rhino.RhinoApp.Write(label + option?.ToString());
        }

        public override void WriteLabelLine(string label, object option)
        {
            Rhino.RhinoApp.WriteLine(label + option?.ToString());
        }

        public override void WriteLabelLine(string label, object option, ColorStyle valueStyle)
        {
            Rhino.RhinoApp.WriteLine(label + option?.ToString());
        }

        public override void WriteLine(ColorStyle style, string value)
        {
            Rhino.RhinoApp.WriteLine(value);
        }
    }
}
