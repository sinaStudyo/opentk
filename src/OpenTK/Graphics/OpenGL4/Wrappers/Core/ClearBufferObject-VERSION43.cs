//
// The Open Toolkit Library License
//
// Copyright (c) 2006 - 2015 Stefanos Apostolopoulos for the Open Toolkit Library
//
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to deal
// in the Software without restriction, including without limitation the rights to
// use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of
// the Software, and to permit persons to whom the Software is furnished to do
// so, subject to the following conditions:
//
// The above copyright notice and this permission notice shall be included in all
// copies or substantial portions of the Software.
//
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND,
// EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES
// OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND
// NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT
// HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY,
// WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING
// FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR
// OTHER DEALINGS IN THE SOFTWARE.
//

using System;
using System.Runtime.InteropServices;
using System.Text;

namespace OpenTK.Graphics.OpenGL4
{
    public sealed partial class GL
    {
        /// <summary>
        /// [requires: v4.3 or ARB_clear_buffer_object|VERSION_4_3]
        /// Fill a buffer object's data store with a fixed value.
        /// </summary>
        /// <param name="target">
        /// Specify the target of the operation. target must be one of the global buffer binding targets.
        /// </param>
        /// <param name="internalformat">
        /// The internal format with which the data will be stored in the buffer object.
        /// </param>
        /// <param name="format">
        /// The format of the data in memory addressed by data.
        /// </param>
        /// <param name="type">
        /// The type of the data in memory addressed by data.
        /// </param>
        /// <param name="data">
        /// [length: COMPSIZE(format,type)]
        /// The address of a memory location storing the data to be replicated into the buffer's data store.
        /// </param>
        [AutoGenerated(Category = "ARB_clear_buffer_object|VERSION_4_3", Version = "4.3", EntryPoint = "glClearBufferData")]
        public static void ClearBufferData(OpenTK.Graphics.OpenGL4.BufferTarget target, OpenTK.Graphics.OpenGL4.PixelInternalFormat internalformat, OpenTK.Graphics.OpenGL4.PixelFormat format, OpenTK.Graphics.OpenGL4.PixelType type, [CountAttribute(Computed = "format,type")] IntPtr data)
        {
            throw new BindingsNotRewrittenException();
        }

        /// <summary>
        /// [requires: v4.3 or ARB_clear_buffer_object|VERSION_4_3]
        /// Fill a buffer object's data store with a fixed value.
        /// </summary>
        /// <param name="target">
        /// Specify the target of the operation. target must be one of the global buffer binding targets.
        /// </param>
        /// <param name="internalformat">
        /// The internal format with which the data will be stored in the buffer object.
        /// </param>
        /// <param name="format">
        /// The format of the data in memory addressed by data.
        /// </param>
        /// <param name="type">
        /// The type of the data in memory addressed by data.
        /// </param>
        /// <param name="data">
        /// [length: COMPSIZE(format,type)]
        /// The address of a memory location storing the data to be replicated into the buffer's data store.
        /// </param>
        /// <typeparam name="T4"></typeparam>
        [AutoGenerated(Category = "ARB_clear_buffer_object|VERSION_4_3", Version = "4.3", EntryPoint = "glClearBufferData")]
        public static void ClearBufferData<T4>(OpenTK.Graphics.OpenGL4.BufferTarget target, OpenTK.Graphics.OpenGL4.PixelInternalFormat internalformat, OpenTK.Graphics.OpenGL4.PixelFormat format, OpenTK.Graphics.OpenGL4.PixelType type, [InAttribute, OutAttribute, CountAttribute(Computed = "format,type")] T4[] data)
            where T4 : struct
        {
            throw new BindingsNotRewrittenException();
        }

        /// <summary>
        /// [requires: v4.3 or ARB_clear_buffer_object|VERSION_4_3]
        /// Fill a buffer object's data store with a fixed value.
        /// </summary>
        /// <param name="target">
        /// Specify the target of the operation. target must be one of the global buffer binding targets.
        /// </param>
        /// <param name="internalformat">
        /// The internal format with which the data will be stored in the buffer object.
        /// </param>
        /// <param name="format">
        /// The format of the data in memory addressed by data.
        /// </param>
        /// <param name="type">
        /// The type of the data in memory addressed by data.
        /// </param>
        /// <param name="data">
        /// [length: COMPSIZE(format,type)]
        /// The address of a memory location storing the data to be replicated into the buffer's data store.
        /// </param>
        /// <typeparam name="T4"></typeparam>
        [AutoGenerated(Category = "ARB_clear_buffer_object|VERSION_4_3", Version = "4.3", EntryPoint = "glClearBufferData")]
        public static void ClearBufferData<T4>(OpenTK.Graphics.OpenGL4.BufferTarget target, OpenTK.Graphics.OpenGL4.PixelInternalFormat internalformat, OpenTK.Graphics.OpenGL4.PixelFormat format, OpenTK.Graphics.OpenGL4.PixelType type, [InAttribute, OutAttribute, CountAttribute(Computed = "format,type")] T4[,] data)
            where T4 : struct
        {
            throw new BindingsNotRewrittenException();
        }

        /// <summary>
        /// [requires: v4.3 or ARB_clear_buffer_object|VERSION_4_3]
        /// Fill a buffer object's data store with a fixed value.
        /// </summary>
        /// <param name="target">
        /// Specify the target of the operation. target must be one of the global buffer binding targets.
        /// </param>
        /// <param name="internalformat">
        /// The internal format with which the data will be stored in the buffer object.
        /// </param>
        /// <param name="format">
        /// The format of the data in memory addressed by data.
        /// </param>
        /// <param name="type">
        /// The type of the data in memory addressed by data.
        /// </param>
        /// <param name="data">
        /// [length: COMPSIZE(format,type)]
        /// The address of a memory location storing the data to be replicated into the buffer's data store.
        /// </param>
        /// <typeparam name="T4"></typeparam>
        [AutoGenerated(Category = "ARB_clear_buffer_object|VERSION_4_3", Version = "4.3", EntryPoint = "glClearBufferData")]
        public static void ClearBufferData<T4>(OpenTK.Graphics.OpenGL4.BufferTarget target, OpenTK.Graphics.OpenGL4.PixelInternalFormat internalformat, OpenTK.Graphics.OpenGL4.PixelFormat format, OpenTK.Graphics.OpenGL4.PixelType type, [InAttribute, OutAttribute, CountAttribute(Computed = "format,type")] T4[,,] data)
            where T4 : struct
        {
            throw new BindingsNotRewrittenException();
        }

        /// <summary>
        /// [requires: v4.3 or ARB_clear_buffer_object|VERSION_4_3]
        /// Fill a buffer object's data store with a fixed value.
        /// </summary>
        /// <param name="target">
        /// Specify the target of the operation. target must be one of the global buffer binding targets.
        /// </param>
        /// <param name="internalformat">
        /// The internal format with which the data will be stored in the buffer object.
        /// </param>
        /// <param name="format">
        /// The format of the data in memory addressed by data.
        /// </param>
        /// <param name="type">
        /// The type of the data in memory addressed by data.
        /// </param>
        /// <param name="data">
        /// [length: COMPSIZE(format,type)]
        /// The address of a memory location storing the data to be replicated into the buffer's data store.
        /// </param>
        /// <typeparam name="T4"></typeparam>
        [AutoGenerated(Category = "ARB_clear_buffer_object|VERSION_4_3", Version = "4.3", EntryPoint = "glClearBufferData")]
        public static void ClearBufferData<T4>(OpenTK.Graphics.OpenGL4.BufferTarget target, OpenTK.Graphics.OpenGL4.PixelInternalFormat internalformat, OpenTK.Graphics.OpenGL4.PixelFormat format, OpenTK.Graphics.OpenGL4.PixelType type, [InAttribute, OutAttribute, CountAttribute(Computed = "format,type")] ref T4 data)
            where T4 : struct
        {
            throw new BindingsNotRewrittenException();
        }

        /// <summary>
        /// [requires: v4.3 or ARB_clear_buffer_object|VERSION_4_3]
        /// Fill all or part of buffer object's data store with a fixed value.
        /// </summary>
        /// <param name="target">
        /// Specify the target of the operation. target must be one of the global buffer binding targets.
        /// </param>
        /// <param name="internalformat">
        /// The internal format with which the data will be stored in the buffer object.
        /// </param>
        /// <param name="offset">
        /// The offset, in basic machine units into the buffer object's data store at which to start filling.
        /// </param>
        /// <param name="size">
        /// The size, in basic machine units of the range of the data store to fill.
        /// </param>
        /// <param name="format">
        /// The format of the data in memory addressed by data.
        /// </param>
        /// <param name="type">
        /// The type of the data in memory addressed by data.
        /// </param>
        /// <param name="data">
        /// [length: COMPSIZE(format,type)]
        /// The address of a memory location storing the data to be replicated into the buffer's data store.
        /// </param>
        [AutoGenerated(Category = "ARB_clear_buffer_object|VERSION_4_3", Version = "4.3", EntryPoint = "glClearBufferSubData")]
        public static void ClearBufferSubData(OpenTK.Graphics.OpenGL4.BufferTarget target, OpenTK.Graphics.OpenGL4.PixelInternalFormat internalformat, IntPtr offset, int size, OpenTK.Graphics.OpenGL4.PixelFormat format, OpenTK.Graphics.OpenGL4.PixelType type, [CountAttribute(Computed = "format,type")] IntPtr data)
        {
            throw new BindingsNotRewrittenException();
        }

        /// <summary>
        /// [requires: v4.3 or ARB_clear_buffer_object|VERSION_4_3]
        /// Fill all or part of buffer object's data store with a fixed value.
        /// </summary>
        /// <param name="target">
        /// Specify the target of the operation. target must be one of the global buffer binding targets.
        /// </param>
        /// <param name="internalformat">
        /// The internal format with which the data will be stored in the buffer object.
        /// </param>
        /// <param name="offset">
        /// The offset, in basic machine units into the buffer object's data store at which to start filling.
        /// </param>
        /// <param name="size">
        /// The size, in basic machine units of the range of the data store to fill.
        /// </param>
        /// <param name="format">
        /// The format of the data in memory addressed by data.
        /// </param>
        /// <param name="type">
        /// The type of the data in memory addressed by data.
        /// </param>
        /// <param name="data">
        /// [length: COMPSIZE(format,type)]
        /// The address of a memory location storing the data to be replicated into the buffer's data store.
        /// </param>
        /// <typeparam name="T6"></typeparam>
        [AutoGenerated(Category = "ARB_clear_buffer_object|VERSION_4_3", Version = "4.3", EntryPoint = "glClearBufferSubData")]
        public static void ClearBufferSubData<T6>(OpenTK.Graphics.OpenGL4.BufferTarget target, OpenTK.Graphics.OpenGL4.PixelInternalFormat internalformat, IntPtr offset, int size, OpenTK.Graphics.OpenGL4.PixelFormat format, OpenTK.Graphics.OpenGL4.PixelType type, [InAttribute, OutAttribute, CountAttribute(Computed = "format,type")] T6[] data)
            where T6 : struct
        {
            throw new BindingsNotRewrittenException();
        }

        /// <summary>
        /// [requires: v4.3 or ARB_clear_buffer_object|VERSION_4_3]
        /// Fill all or part of buffer object's data store with a fixed value.
        /// </summary>
        /// <param name="target">
        /// Specify the target of the operation. target must be one of the global buffer binding targets.
        /// </param>
        /// <param name="internalformat">
        /// The internal format with which the data will be stored in the buffer object.
        /// </param>
        /// <param name="offset">
        /// The offset, in basic machine units into the buffer object's data store at which to start filling.
        /// </param>
        /// <param name="size">
        /// The size, in basic machine units of the range of the data store to fill.
        /// </param>
        /// <param name="format">
        /// The format of the data in memory addressed by data.
        /// </param>
        /// <param name="type">
        /// The type of the data in memory addressed by data.
        /// </param>
        /// <param name="data">
        /// [length: COMPSIZE(format,type)]
        /// The address of a memory location storing the data to be replicated into the buffer's data store.
        /// </param>
        /// <typeparam name="T6"></typeparam>
        [AutoGenerated(Category = "ARB_clear_buffer_object|VERSION_4_3", Version = "4.3", EntryPoint = "glClearBufferSubData")]
        public static void ClearBufferSubData<T6>(OpenTK.Graphics.OpenGL4.BufferTarget target, OpenTK.Graphics.OpenGL4.PixelInternalFormat internalformat, IntPtr offset, int size, OpenTK.Graphics.OpenGL4.PixelFormat format, OpenTK.Graphics.OpenGL4.PixelType type, [InAttribute, OutAttribute, CountAttribute(Computed = "format,type")] T6[,] data)
            where T6 : struct
        {
            throw new BindingsNotRewrittenException();
        }

        /// <summary>
        /// [requires: v4.3 or ARB_clear_buffer_object|VERSION_4_3]
        /// Fill all or part of buffer object's data store with a fixed value.
        /// </summary>
        /// <param name="target">
        /// Specify the target of the operation. target must be one of the global buffer binding targets.
        /// </param>
        /// <param name="internalformat">
        /// The internal format with which the data will be stored in the buffer object.
        /// </param>
        /// <param name="offset">
        /// The offset, in basic machine units into the buffer object's data store at which to start filling.
        /// </param>
        /// <param name="size">
        /// The size, in basic machine units of the range of the data store to fill.
        /// </param>
        /// <param name="format">
        /// The format of the data in memory addressed by data.
        /// </param>
        /// <param name="type">
        /// The type of the data in memory addressed by data.
        /// </param>
        /// <param name="data">
        /// [length: COMPSIZE(format,type)]
        /// The address of a memory location storing the data to be replicated into the buffer's data store.
        /// </param>
        /// <typeparam name="T6"></typeparam>
        [AutoGenerated(Category = "ARB_clear_buffer_object|VERSION_4_3", Version = "4.3", EntryPoint = "glClearBufferSubData")]
        public static void ClearBufferSubData<T6>(OpenTK.Graphics.OpenGL4.BufferTarget target, OpenTK.Graphics.OpenGL4.PixelInternalFormat internalformat, IntPtr offset, int size, OpenTK.Graphics.OpenGL4.PixelFormat format, OpenTK.Graphics.OpenGL4.PixelType type, [InAttribute, OutAttribute, CountAttribute(Computed = "format,type")] T6[,,] data)
            where T6 : struct
        {
            throw new BindingsNotRewrittenException();
        }

        /// <summary>
        /// [requires: v4.3 or ARB_clear_buffer_object|VERSION_4_3]
        /// Fill all or part of buffer object's data store with a fixed value.
        /// </summary>
        /// <param name="target">
        /// Specify the target of the operation. target must be one of the global buffer binding targets.
        /// </param>
        /// <param name="internalformat">
        /// The internal format with which the data will be stored in the buffer object.
        /// </param>
        /// <param name="offset">
        /// The offset, in basic machine units into the buffer object's data store at which to start filling.
        /// </param>
        /// <param name="size">
        /// The size, in basic machine units of the range of the data store to fill.
        /// </param>
        /// <param name="format">
        /// The format of the data in memory addressed by data.
        /// </param>
        /// <param name="type">
        /// The type of the data in memory addressed by data.
        /// </param>
        /// <param name="data">
        /// [length: COMPSIZE(format,type)]
        /// The address of a memory location storing the data to be replicated into the buffer's data store.
        /// </param>
        /// <typeparam name="T6"></typeparam>
        [AutoGenerated(Category = "ARB_clear_buffer_object|VERSION_4_3", Version = "4.3", EntryPoint = "glClearBufferSubData")]
        public static void ClearBufferSubData<T6>(OpenTK.Graphics.OpenGL4.BufferTarget target, OpenTK.Graphics.OpenGL4.PixelInternalFormat internalformat, IntPtr offset, int size, OpenTK.Graphics.OpenGL4.PixelFormat format, OpenTK.Graphics.OpenGL4.PixelType type, [InAttribute, OutAttribute, CountAttribute(Computed = "format,type")] ref T6 data)
            where T6 : struct
        {
            throw new BindingsNotRewrittenException();
        }

        /// <summary>
        /// [requires: v4.3 or ARB_clear_buffer_object|VERSION_4_3]
        /// Fill all or part of buffer object's data store with a fixed value.
        /// </summary>
        /// <param name="target">
        /// Specify the target of the operation. target must be one of the global buffer binding targets.
        /// </param>
        /// <param name="internalformat">
        /// The internal format with which the data will be stored in the buffer object.
        /// </param>
        /// <param name="offset">
        /// The offset, in basic machine units into the buffer object's data store at which to start filling.
        /// </param>
        /// <param name="size">
        /// The size, in basic machine units of the range of the data store to fill.
        /// </param>
        /// <param name="format">
        /// The format of the data in memory addressed by data.
        /// </param>
        /// <param name="type">
        /// The type of the data in memory addressed by data.
        /// </param>
        /// <param name="data">
        /// [length: COMPSIZE(format,type)]
        /// The address of a memory location storing the data to be replicated into the buffer's data store.
        /// </param>
        [AutoGenerated(Category = "ARB_clear_buffer_object|VERSION_4_3", Version = "4.3", EntryPoint = "glClearBufferSubData")]
        public static void ClearBufferSubData(OpenTK.Graphics.OpenGL4.BufferTarget target, OpenTK.Graphics.OpenGL4.PixelInternalFormat internalformat, IntPtr offset, UIntPtr size, OpenTK.Graphics.OpenGL4.PixelFormat format, OpenTK.Graphics.OpenGL4.PixelType type, [CountAttribute(Computed = "format,type")] IntPtr data)
        {
            throw new BindingsNotRewrittenException();
        }

        /// <summary>
        /// [requires: v4.3 or ARB_clear_buffer_object|VERSION_4_3]
        /// Fill all or part of buffer object's data store with a fixed value.
        /// </summary>
        /// <param name="target">
        /// Specify the target of the operation. target must be one of the global buffer binding targets.
        /// </param>
        /// <param name="internalformat">
        /// The internal format with which the data will be stored in the buffer object.
        /// </param>
        /// <param name="offset">
        /// The offset, in basic machine units into the buffer object's data store at which to start filling.
        /// </param>
        /// <param name="size">
        /// The size, in basic machine units of the range of the data store to fill.
        /// </param>
        /// <param name="format">
        /// The format of the data in memory addressed by data.
        /// </param>
        /// <param name="type">
        /// The type of the data in memory addressed by data.
        /// </param>
        /// <param name="data">
        /// [length: COMPSIZE(format,type)]
        /// The address of a memory location storing the data to be replicated into the buffer's data store.
        /// </param>
        /// <typeparam name="T6"></typeparam>
        [AutoGenerated(Category = "ARB_clear_buffer_object|VERSION_4_3", Version = "4.3", EntryPoint = "glClearBufferSubData")]
        public static void ClearBufferSubData<T6>(OpenTK.Graphics.OpenGL4.BufferTarget target, OpenTK.Graphics.OpenGL4.PixelInternalFormat internalformat, IntPtr offset, UIntPtr size, OpenTK.Graphics.OpenGL4.PixelFormat format, OpenTK.Graphics.OpenGL4.PixelType type, [InAttribute, OutAttribute, CountAttribute(Computed = "format,type")] T6[] data)
            where T6 : struct
        {
            throw new BindingsNotRewrittenException();
        }

        /// <summary>
        /// [requires: v4.3 or ARB_clear_buffer_object|VERSION_4_3]
        /// Fill all or part of buffer object's data store with a fixed value.
        /// </summary>
        /// <param name="target">
        /// Specify the target of the operation. target must be one of the global buffer binding targets.
        /// </param>
        /// <param name="internalformat">
        /// The internal format with which the data will be stored in the buffer object.
        /// </param>
        /// <param name="offset">
        /// The offset, in basic machine units into the buffer object's data store at which to start filling.
        /// </param>
        /// <param name="size">
        /// The size, in basic machine units of the range of the data store to fill.
        /// </param>
        /// <param name="format">
        /// The format of the data in memory addressed by data.
        /// </param>
        /// <param name="type">
        /// The type of the data in memory addressed by data.
        /// </param>
        /// <param name="data">
        /// [length: COMPSIZE(format,type)]
        /// The address of a memory location storing the data to be replicated into the buffer's data store.
        /// </param>
        /// <typeparam name="T6"></typeparam>
        [AutoGenerated(Category = "ARB_clear_buffer_object|VERSION_4_3", Version = "4.3", EntryPoint = "glClearBufferSubData")]
        public static void ClearBufferSubData<T6>(OpenTK.Graphics.OpenGL4.BufferTarget target, OpenTK.Graphics.OpenGL4.PixelInternalFormat internalformat, IntPtr offset, UIntPtr size, OpenTK.Graphics.OpenGL4.PixelFormat format, OpenTK.Graphics.OpenGL4.PixelType type, [InAttribute, OutAttribute, CountAttribute(Computed = "format,type")] T6[,] data)
            where T6 : struct
        {
            throw new BindingsNotRewrittenException();
        }

        /// <summary>
        /// [requires: v4.3 or ARB_clear_buffer_object|VERSION_4_3]
        /// Fill all or part of buffer object's data store with a fixed value.
        /// </summary>
        /// <param name="target">
        /// Specify the target of the operation. target must be one of the global buffer binding targets.
        /// </param>
        /// <param name="internalformat">
        /// The internal format with which the data will be stored in the buffer object.
        /// </param>
        /// <param name="offset">
        /// The offset, in basic machine units into the buffer object's data store at which to start filling.
        /// </param>
        /// <param name="size">
        /// The size, in basic machine units of the range of the data store to fill.
        /// </param>
        /// <param name="format">
        /// The format of the data in memory addressed by data.
        /// </param>
        /// <param name="type">
        /// The type of the data in memory addressed by data.
        /// </param>
        /// <param name="data">
        /// [length: COMPSIZE(format,type)]
        /// The address of a memory location storing the data to be replicated into the buffer's data store.
        /// </param>
        /// <typeparam name="T6"></typeparam>
        [AutoGenerated(Category = "ARB_clear_buffer_object|VERSION_4_3", Version = "4.3", EntryPoint = "glClearBufferSubData")]
        public static void ClearBufferSubData<T6>(OpenTK.Graphics.OpenGL4.BufferTarget target, OpenTK.Graphics.OpenGL4.PixelInternalFormat internalformat, IntPtr offset, UIntPtr size, OpenTK.Graphics.OpenGL4.PixelFormat format, OpenTK.Graphics.OpenGL4.PixelType type, [InAttribute, OutAttribute, CountAttribute(Computed = "format,type")] T6[,,] data)
            where T6 : struct
        {
            throw new BindingsNotRewrittenException();
        }

        /// <summary>
        /// [requires: v4.3 or ARB_clear_buffer_object|VERSION_4_3]
        /// Fill all or part of buffer object's data store with a fixed value.
        /// </summary>
        /// <param name="target">
        /// Specify the target of the operation. target must be one of the global buffer binding targets.
        /// </param>
        /// <param name="internalformat">
        /// The internal format with which the data will be stored in the buffer object.
        /// </param>
        /// <param name="offset">
        /// The offset, in basic machine units into the buffer object's data store at which to start filling.
        /// </param>
        /// <param name="size">
        /// The size, in basic machine units of the range of the data store to fill.
        /// </param>
        /// <param name="format">
        /// The format of the data in memory addressed by data.
        /// </param>
        /// <param name="type">
        /// The type of the data in memory addressed by data.
        /// </param>
        /// <param name="data">
        /// [length: COMPSIZE(format,type)]
        /// The address of a memory location storing the data to be replicated into the buffer's data store.
        /// </param>
        /// <typeparam name="T6"></typeparam>
        [AutoGenerated(Category = "ARB_clear_buffer_object|VERSION_4_3", Version = "4.3", EntryPoint = "glClearBufferSubData")]
        public static void ClearBufferSubData<T6>(OpenTK.Graphics.OpenGL4.BufferTarget target, OpenTK.Graphics.OpenGL4.PixelInternalFormat internalformat, IntPtr offset, UIntPtr size, OpenTK.Graphics.OpenGL4.PixelFormat format, OpenTK.Graphics.OpenGL4.PixelType type, [InAttribute, OutAttribute, CountAttribute(Computed = "format,type")] ref T6 data)
            where T6 : struct
        {
            throw new BindingsNotRewrittenException();
        }

        #pragma warning disable SA1300 // Element should begin with an upper-case letter

        [Slot(66)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        private static extern void glClearBufferData(OpenTK.Graphics.OpenGL4.BufferTarget target, OpenTK.Graphics.OpenGL4.PixelInternalFormat internalformat, OpenTK.Graphics.OpenGL4.PixelFormat format, OpenTK.Graphics.OpenGL4.PixelType type, [CountAttribute(Computed = "format,type")] IntPtr data);

        [Slot(70)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        private static extern void glClearBufferSubData(OpenTK.Graphics.OpenGL4.BufferTarget target, OpenTK.Graphics.OpenGL4.PixelInternalFormat internalformat, IntPtr offset, UIntPtr size, OpenTK.Graphics.OpenGL4.PixelFormat format, OpenTK.Graphics.OpenGL4.PixelType type, [CountAttribute(Computed = "format,type")] IntPtr data);
    }
}
