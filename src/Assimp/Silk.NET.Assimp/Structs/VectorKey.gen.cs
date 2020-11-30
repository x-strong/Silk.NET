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

namespace Silk.NET.Assimp
{
    [NativeName("Name", "aiVectorKey")]
    public unsafe partial struct VectorKey
    {
        public VectorKey
        (
            double? mTime = null,
            System.Numerics.Vector3? mValue = null
        ) : this()
        {
            if (mTime is not null)
            {
                MTime = mTime.Value;
            }

            if (mValue is not null)
            {
                MValue = mValue.Value;
            }
        }


        [NativeName("Type", "double")]
        [NativeName("Type.Name", "double")]
        [NativeName("Name", "mTime")]
        public double MTime;

        [NativeName("Type", "aiVector3D")]
        [NativeName("Type.Name", "aiVector3D")]
        [NativeName("Name", "mValue")]
        public System.Numerics.Vector3 MValue;
    }
}
