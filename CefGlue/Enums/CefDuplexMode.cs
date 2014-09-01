using System;
using System.Collections.Generic;
using System.Text;

//
// This file manually written from cef/include/internal/cef_types.h.
// C API name: cef_duplex_mode_t.
//
namespace Xilium.CefGlue
{
    using System;

    /// <summary>
    /// Print job duplex mode values.
    /// </summary>
    public enum CefDuplexMode
    {
        DUPLEX_MODE_UNKNOWN = -1,
        DUPLEX_MODE_SIMPLEX,
        DUPLEX_MODE_LONG_EDGE,
        DUPLEX_MODE_SHORT_EDGE,
    }
}