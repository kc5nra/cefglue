//
// DO NOT MODIFY! THIS IS AUTOGENERATED FILE!
//
namespace Xilium.CefGlue
{
    using System;
    using System.Collections.Generic;
    using System.Diagnostics;
    using System.Runtime.InteropServices;
    using Xilium.CefGlue.Interop;
    
    // Role: PROXY
    public sealed unsafe partial class CefPrintDialogCallback : IDisposable
    {
        internal static CefPrintDialogCallback FromNative(cef_print_dialog_callback_t* ptr)
        {
            return new CefPrintDialogCallback(ptr);
        }
        
        internal static CefPrintDialogCallback FromNativeOrNull(cef_print_dialog_callback_t* ptr)
        {
            if (ptr == null) return null;
            return new CefPrintDialogCallback(ptr);
        }
        
        private cef_print_dialog_callback_t* _self;
        
        private CefPrintDialogCallback(cef_print_dialog_callback_t* ptr)
        {
            if (ptr == null) throw new ArgumentNullException("ptr");
            _self = ptr;
        }
        
        ~CefPrintDialogCallback()
        {
            if (_self != null)
            {
                Release();
                _self = null;
            }
        }
        
        public void Dispose()
        {
            if (_self != null)
            {
                Release();
                _self = null;
            }
            GC.SuppressFinalize(this);
        }
        
        internal int AddRef()
        {
            return cef_print_dialog_callback_t.add_ref(_self);
        }
        
        internal int Release()
        {
            return cef_print_dialog_callback_t.release(_self);
        }
        
        internal int RefCt
        {
            get { return cef_print_dialog_callback_t.get_refct(_self); }
        }
        
        internal cef_print_dialog_callback_t* ToNative()
        {
            AddRef();
            return _self;
        }
    }
}
