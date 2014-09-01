using System;
using System.Collections.Generic;
using System.Text;

//
// This file manually written from cef/include/internal/cef_types.h.
// C API name: cef_color_model_t.
//
namespace Xilium.CefGlue
{
    using System;

    /// <summary>
    /// Supported context menu media types.
    /// </summary>
    public enum CefColorModel
    {
        COLOR_MODEL_UNKNOWN,
        COLOR_MODEL_GRAY,
        COLOR_MODEL_COLOR,
        COLOR_MODEL_CMYK,
        COLOR_MODEL_CMY,
        COLOR_MODEL_KCMY,

        /// <summary>
        /// CMY_K represents CMY+K.
        /// </summary>
        COLOR_MODEL_CMY_K,

        COLOR_MODEL_BLACK,
        COLOR_MODEL_GRAYSCALE,
        COLOR_MODEL_RGB,
        COLOR_MODEL_RGB16,
        COLOR_MODEL_RGBA,

        /// <summary>
        /// Used in samsung printer ppds.
        /// </summary>
        COLOR_MODEL_COLORMODE_COLOR,

        /// <summary>
        /// Used in samsung printer ppds.
        /// </summary>
        COLOR_MODEL_COLORMODE_MONOCHROME,

        /// <summary>
        /// Used in HP color printer ppds.
        /// </summary>
        COLOR_MODEL_HP_COLOR_COLOR,

        /// <summary>
        /// Used in HP color printer ppds.
        /// </summary>
        COLOR_MODEL_HP_COLOR_BLACK,

        /// <summary>
        /// Used in foomatic ppds.
        /// </summary>
        COLOR_MODEL_PRINTOUTMODE_NORMAL,

        /// <summary>
        /// Used in foomatic ppds.
        /// </summary>
        COLOR_MODEL_PRINTOUTMODE_NORMAL_GRAY,

        /// <summary>
        ///  Used in canon printer ppds.
        /// </summary>
        COLOR_MODEL_PROCESSCOLORMODEL_CMYK,

        /// <summary>
        /// Used in canon printer ppds.
        /// </summary>
        COLOR_MODEL_PROCESSCOLORMODEL_GREYSCALE,

        /// <summary>
        /// Used in canon printer ppds
        /// </summary>
        COLOR_MODEL_PROCESSCOLORMODEL_RGB,
    }
}