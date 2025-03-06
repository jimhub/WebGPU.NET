using System;
using System.Diagnostics;
using System.Text;
using Evergine.Bindings.WebGPU;

namespace HelloTriangle
{
    public unsafe static class Helpers
    {
        public static char* ToPointer(this string text)
        {
            return (char*)System.Runtime.InteropServices.Marshal.StringToHGlobalAnsi(text);
        }

        public static WGPUStringView ToStringView(this string text)
        {
            return new WGPUStringView
            {
                data = (char*)System.Runtime.InteropServices.Marshal.StringToHGlobalAnsi(text),
                length = (nuint)text.Length,
            };
        }

        public static unsafe string GetString(char* stringStart)
        {
            int characters = 0;
            while (stringStart[characters] != 0)
            {
                characters++;
            }

            return System.Text.Encoding.UTF8.GetString((byte*)stringStart, characters * 2);
        }
        
        public static unsafe string GetString(WGPUStringView stringView)
        {
            return System.Text.Encoding.UTF8.GetString((byte*)stringView.data, (int)stringView.length * 2);
        }
    }
}
