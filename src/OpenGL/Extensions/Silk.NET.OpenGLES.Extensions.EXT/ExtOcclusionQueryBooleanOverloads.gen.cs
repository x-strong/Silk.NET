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

#pragma warning disable 1591

namespace Silk.NET.OpenGLES.Extensions.EXT
{
    public static class ExtOcclusionQueryBooleanOverloads
    {
        public static unsafe void DeleteQueries(this ExtOcclusionQueryBoolean thisApi, [Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.In)] ReadOnlySpan<uint> ids)
        {
            // SpanOverloader
            thisApi.DeleteQueries(n, in ids.GetPinnableReference());
        }

        public static unsafe void GenQueries(this ExtOcclusionQueryBoolean thisApi, [Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.Out)] Span<uint> ids)
        {
            // SpanOverloader
            thisApi.GenQueries(n, out ids.GetPinnableReference());
        }

        public static unsafe void GetQuery(this ExtOcclusionQueryBoolean thisApi, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] EXT pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] Span<int> @params)
        {
            // SpanOverloader
            thisApi.GetQuery(target, pname, out @params.GetPinnableReference());
        }

        public static unsafe void GetQuery(this ExtOcclusionQueryBoolean thisApi, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] QueryParameterName pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] Span<int> @params)
        {
            // SpanOverloader
            thisApi.GetQuery(target, pname, out @params.GetPinnableReference());
        }

        public static unsafe void GetQuery(this ExtOcclusionQueryBoolean thisApi, [Flow(FlowDirection.In)] QueryTarget target, [Flow(FlowDirection.In)] EXT pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] Span<int> @params)
        {
            // SpanOverloader
            thisApi.GetQuery(target, pname, out @params.GetPinnableReference());
        }

        public static unsafe void GetQuery(this ExtOcclusionQueryBoolean thisApi, [Flow(FlowDirection.In)] QueryTarget target, [Flow(FlowDirection.In)] QueryParameterName pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] Span<int> @params)
        {
            // SpanOverloader
            thisApi.GetQuery(target, pname, out @params.GetPinnableReference());
        }

        public static unsafe void GetQueryObject(this ExtOcclusionQueryBoolean thisApi, [Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] EXT pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] Span<uint> @params)
        {
            // SpanOverloader
            thisApi.GetQueryObject(id, pname, out @params.GetPinnableReference());
        }

        public static unsafe void GetQueryObject(this ExtOcclusionQueryBoolean thisApi, [Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] QueryObjectParameterName pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] Span<uint> @params)
        {
            // SpanOverloader
            thisApi.GetQueryObject(id, pname, out @params.GetPinnableReference());
        }

    }
}

