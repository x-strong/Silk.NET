// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.Text;
using Silk.NET.Core
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Loader;

#pragma warning disable 1591

namespace Silk.NET.Vulkan
{
    [NativeName("Name", "VkImageMemoryBarrier")]
    public unsafe partial struct ImageMemoryBarrier
    {
        public ImageMemoryBarrier
        (
            StructureType? sType = StructureType.ImageMemoryBarrier,
            void* pNext = null,
            AccessFlags? srcAccessMask = null,
            AccessFlags? dstAccessMask = null,
            ImageLayout? oldLayout = null,
            ImageLayout? newLayout = null,
            uint? srcQueueFamilyIndex = null,
            uint? dstQueueFamilyIndex = null,
            Image? image = null,
            ImageSubresourceRange? subresourceRange = null
        ) : this()
        {
            if (sType is not null)
            {
                SType = sType.Value;
            }

            if (pNext is not null)
            {
                PNext = pNext;
            }

            if (srcAccessMask is not null)
            {
                SrcAccessMask = srcAccessMask.Value;
            }

            if (dstAccessMask is not null)
            {
                DstAccessMask = dstAccessMask.Value;
            }

            if (oldLayout is not null)
            {
                OldLayout = oldLayout.Value;
            }

            if (newLayout is not null)
            {
                NewLayout = newLayout.Value;
            }

            if (srcQueueFamilyIndex is not null)
            {
                SrcQueueFamilyIndex = srcQueueFamilyIndex.Value;
            }

            if (dstQueueFamilyIndex is not null)
            {
                DstQueueFamilyIndex = dstQueueFamilyIndex.Value;
            }

            if (image is not null)
            {
                Image = image.Value;
            }

            if (subresourceRange is not null)
            {
                SubresourceRange = subresourceRange.Value;
            }
        }

/// <summary></summary>
        [NativeName("Type", "VkStructureType")]
        [NativeName("Type.Name", "VkStructureType")]
        [NativeName("Name", "sType")]
        public StructureType SType;
/// <summary></summary>
        [NativeName("Type", "void*")]
        [NativeName("Type.Name", "void")]
        [NativeName("Name", "pNext")]
        public void* PNext;
/// <summary></summary>
        [NativeName("Type", "VkAccessFlags")]
        [NativeName("Type.Name", "VkAccessFlags")]
        [NativeName("Name", "srcAccessMask")]
        public AccessFlags SrcAccessMask;
/// <summary></summary>
        [NativeName("Type", "VkAccessFlags")]
        [NativeName("Type.Name", "VkAccessFlags")]
        [NativeName("Name", "dstAccessMask")]
        public AccessFlags DstAccessMask;
/// <summary></summary>
        [NativeName("Type", "VkImageLayout")]
        [NativeName("Type.Name", "VkImageLayout")]
        [NativeName("Name", "oldLayout")]
        public ImageLayout OldLayout;
/// <summary></summary>
        [NativeName("Type", "VkImageLayout")]
        [NativeName("Type.Name", "VkImageLayout")]
        [NativeName("Name", "newLayout")]
        public ImageLayout NewLayout;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "srcQueueFamilyIndex")]
        public uint SrcQueueFamilyIndex;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "dstQueueFamilyIndex")]
        public uint DstQueueFamilyIndex;
/// <summary></summary>
        [NativeName("Type", "VkImage")]
        [NativeName("Type.Name", "VkImage")]
        [NativeName("Name", "image")]
        public Image Image;
/// <summary></summary>
        [NativeName("Type", "VkImageSubresourceRange")]
        [NativeName("Type.Name", "VkImageSubresourceRange")]
        [NativeName("Name", "subresourceRange")]
        public ImageSubresourceRange SubresourceRange;
    }
}
