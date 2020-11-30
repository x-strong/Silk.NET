// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.
using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.Text;
using Silk.NET.Core;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Loader;
using Silk.NET.OpenGL.Legacy;
using Extension = Silk.NET.Core.Attributes.ExtensionAttribute;

#pragma warning disable 1591

namespace Silk.NET.OpenGL.Legacy.Extensions.SGIX
{
    [Extension("SGIX_reference_plane")]
    public unsafe partial class SgixReferencePlane : NativeExtension<GL>
    {
        public const string ExtensionName = "SGIX_reference_plane";
        [NativeApi(EntryPoint = "glReferencePlaneSGIX")]
        public unsafe partial void ReferencePlane([Count(Count = 4), Flow(FlowDirection.In)] double* equation);

        [NativeApi(EntryPoint = "glReferencePlaneSGIX")]
        public partial void ReferencePlane([Count(Count = 4), Flow(FlowDirection.In)] in double equation);

        public SgixReferencePlane(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

