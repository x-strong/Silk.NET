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

namespace Silk.NET.OpenGL.Legacy.Extensions.ARB
{
    [Extension("ARB_transform_feedback3")]
    public unsafe partial class ArbTransformFeedback3 : NativeExtension<GL>
    {
        public const string ExtensionName = "ARB_transform_feedback3";
        [NativeApi(EntryPoint = "glBeginQueryIndexed")]
        public partial void BeginQueryIndexed([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint id);

        [NativeApi(EntryPoint = "glBeginQueryIndexed")]
        public partial void BeginQueryIndexed([Flow(FlowDirection.In)] QueryTarget target, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint id);

        [NativeApi(EntryPoint = "glDrawTransformFeedbackStream")]
        public partial void DrawTransformFeedbackStream([Flow(FlowDirection.In)] ARB mode, [Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] uint stream);

        [NativeApi(EntryPoint = "glDrawTransformFeedbackStream")]
        public partial void DrawTransformFeedbackStream([Flow(FlowDirection.In)] PrimitiveType mode, [Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] uint stream);

        [NativeApi(EntryPoint = "glEndQueryIndexed")]
        public partial void EndQueryIndexed([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] uint index);

        [NativeApi(EntryPoint = "glEndQueryIndexed")]
        public partial void EndQueryIndexed([Flow(FlowDirection.In)] QueryTarget target, [Flow(FlowDirection.In)] uint index);

        [NativeApi(EntryPoint = "glGetQueryIndexediv")]
        public unsafe partial void GetQueryIndexed([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] ARB pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetQueryIndexediv")]
        public partial void GetQueryIndexed([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] ARB pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out int @params);

        [NativeApi(EntryPoint = "glGetQueryIndexediv")]
        public unsafe partial void GetQueryIndexed([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] QueryParameterName pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetQueryIndexediv")]
        public partial void GetQueryIndexed([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] QueryParameterName pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out int @params);

        [NativeApi(EntryPoint = "glGetQueryIndexediv")]
        public unsafe partial void GetQueryIndexed([Flow(FlowDirection.In)] QueryTarget target, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] ARB pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetQueryIndexediv")]
        public partial void GetQueryIndexed([Flow(FlowDirection.In)] QueryTarget target, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] ARB pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out int @params);

        [NativeApi(EntryPoint = "glGetQueryIndexediv")]
        public unsafe partial void GetQueryIndexed([Flow(FlowDirection.In)] QueryTarget target, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] QueryParameterName pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetQueryIndexediv")]
        public partial void GetQueryIndexed([Flow(FlowDirection.In)] QueryTarget target, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] QueryParameterName pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out int @params);

        public ArbTransformFeedback3(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

