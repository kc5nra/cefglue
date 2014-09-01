﻿using System;
using System.Collections.Generic;
using System.Text;

//
// This file manually written from cef/include/internal/cef_types.h.
//
namespace Xilium.CefGlue.Interop
{
    using System;
    using System.Runtime.InteropServices;

    [StructLayout(LayoutKind.Sequential, Pack = libcef.ALIGN)]
    internal unsafe struct cef_page_range_t
    {
        public int from;
        public int to;

        public cef_page_range_t(int width, int height)
        {
            this.from = width;
            this.to = height;
        }
    }
}