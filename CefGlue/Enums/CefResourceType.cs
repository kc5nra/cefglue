using System;
using System.Collections.Generic;
using System.Text;

namespace Xilium.CefGlue
{
    /// <summary>
    /// Resource type for a request.
    /// </summary>
    public enum CefResourceType
    {
        /// <summary>
        /// Top level page.
        /// </summary>
        RT_MAIN_FRAME = 0,

        /// <summary>
        /// Frame or iframe.
        /// </summary>
        RT_SUB_FRAME,

        /// <summary>
        /// CSS stylesheet.
        /// </summary>
        RT_STYLESHEET,

        /// <summary>
        /// External script.
        /// </summary>
        RT_SCRIPT,

        /// <summary>
        /// Image (jpg/gif/png/etc).
        /// </summary>
        RT_IMAGE,

        /// <summary>
        /// Font.
        /// </summary>
        RT_FONT_RESOURCE,

        /// <summary>
        /// Some other subresource. This is the default type if the actual type is
        /// unknown.
        /// </summary>
        RT_SUB_RESOURCE,

        /// <summary>
        /// Object (or embed) tag for a plugin, or a resource that a plugin requested.
        /// </summary>
        RT_OBJECT,

        /// <summary>
        /// Media resource.
        /// </summary>
        RT_MEDIA,

        /// <summary>
        /// Main resource of a dedicated worker.
        /// </summary>
        RT_WORKER,

        /// <summary>
        /// Main resource of a shared worker.
        /// </summary>
        RT_SHARED_WORKER,

        /// <summary>
        /// Explicitly requested prefetch.
        /// </summary>
        RT_PREFETCH,

        /// <summary>
        /// Favicon.
        /// </summary>
        RT_FAVICON,

        /// <summary>
        /// XMLHttpRequest.
        /// </summary>
        RT_XHR,
    };
}
