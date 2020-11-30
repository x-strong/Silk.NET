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

namespace Silk.NET.OpenGL.Legacy.Extensions.AMD
{
    public static class AmdGpuShaderInt64Overloads
    {
        public static unsafe void GetUniform(this AmdGpuShaderInt64 thisApi, [Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Count(Computed = "program, location"), Flow(FlowDirection.Out)] Span<long> @params)
        {
            // SpanOverloader
            thisApi.GetUniform(program, location, out @params.GetPinnableReference());
        }

        public static unsafe void GetUniform(this AmdGpuShaderInt64 thisApi, [Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Count(Computed = "program, location"), Flow(FlowDirection.Out)] Span<ulong> @params)
        {
            // SpanOverloader
            thisApi.GetUniform(program, location, out @params.GetPinnableReference());
        }

        public static unsafe void ProgramUniform1(this AmdGpuShaderInt64 thisApi, [Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] ReadOnlySpan<long> value)
        {
            // SpanOverloader
            thisApi.ProgramUniform1(program, location, count, in value.GetPinnableReference());
        }

        public static unsafe void ProgramUniform1(this AmdGpuShaderInt64 thisApi, [Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] ReadOnlySpan<ulong> value)
        {
            // SpanOverloader
            thisApi.ProgramUniform1(program, location, count, in value.GetPinnableReference());
        }

        public static unsafe void ProgramUniform2(this AmdGpuShaderInt64 thisApi, [Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] ReadOnlySpan<long> value)
        {
            // SpanOverloader
            thisApi.ProgramUniform2(program, location, count, in value.GetPinnableReference());
        }

        public static unsafe void ProgramUniform2(this AmdGpuShaderInt64 thisApi, [Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] ReadOnlySpan<ulong> value)
        {
            // SpanOverloader
            thisApi.ProgramUniform2(program, location, count, in value.GetPinnableReference());
        }

        public static unsafe void ProgramUniform3(this AmdGpuShaderInt64 thisApi, [Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] ReadOnlySpan<long> value)
        {
            // SpanOverloader
            thisApi.ProgramUniform3(program, location, count, in value.GetPinnableReference());
        }

        public static unsafe void ProgramUniform3(this AmdGpuShaderInt64 thisApi, [Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] ReadOnlySpan<ulong> value)
        {
            // SpanOverloader
            thisApi.ProgramUniform3(program, location, count, in value.GetPinnableReference());
        }

        public static unsafe void ProgramUniform4(this AmdGpuShaderInt64 thisApi, [Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] ReadOnlySpan<long> value)
        {
            // SpanOverloader
            thisApi.ProgramUniform4(program, location, count, in value.GetPinnableReference());
        }

        public static unsafe void ProgramUniform4(this AmdGpuShaderInt64 thisApi, [Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] ReadOnlySpan<ulong> value)
        {
            // SpanOverloader
            thisApi.ProgramUniform4(program, location, count, in value.GetPinnableReference());
        }

        public static unsafe void Uniform1(this AmdGpuShaderInt64 thisApi, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] ReadOnlySpan<long> value)
        {
            // SpanOverloader
            thisApi.Uniform1(location, count, in value.GetPinnableReference());
        }

        public static unsafe void Uniform1(this AmdGpuShaderInt64 thisApi, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] ReadOnlySpan<ulong> value)
        {
            // SpanOverloader
            thisApi.Uniform1(location, count, in value.GetPinnableReference());
        }

        public static unsafe void Uniform2(this AmdGpuShaderInt64 thisApi, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] ReadOnlySpan<long> value)
        {
            // SpanOverloader
            thisApi.Uniform2(location, count, in value.GetPinnableReference());
        }

        public static unsafe void Uniform2(this AmdGpuShaderInt64 thisApi, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] ReadOnlySpan<ulong> value)
        {
            // SpanOverloader
            thisApi.Uniform2(location, count, in value.GetPinnableReference());
        }

        public static unsafe void Uniform3(this AmdGpuShaderInt64 thisApi, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] ReadOnlySpan<long> value)
        {
            // SpanOverloader
            thisApi.Uniform3(location, count, in value.GetPinnableReference());
        }

        public static unsafe void Uniform3(this AmdGpuShaderInt64 thisApi, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] ReadOnlySpan<ulong> value)
        {
            // SpanOverloader
            thisApi.Uniform3(location, count, in value.GetPinnableReference());
        }

        public static unsafe void Uniform4(this AmdGpuShaderInt64 thisApi, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] ReadOnlySpan<long> value)
        {
            // SpanOverloader
            thisApi.Uniform4(location, count, in value.GetPinnableReference());
        }

        public static unsafe void Uniform4(this AmdGpuShaderInt64 thisApi, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] ReadOnlySpan<ulong> value)
        {
            // SpanOverloader
            thisApi.Uniform4(location, count, in value.GetPinnableReference());
        }

    }
}

