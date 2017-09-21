﻿// Copyright (c) Six Labors and contributors.
// Licensed under the Apache License, Version 2.0.

using System.Collections.Generic;

namespace SixLabors.ImageSharp.Formats.Jpeg.GolangPort
{
    /// <summary>
    /// Defines jpeg constants defined in the specification.
    /// </summary>
    internal static class OrigJpegConstants
    {
        /// <summary>
        /// The maximum allowable length in each dimension of a jpeg image.
        /// </summary>
        public const ushort MaxLength = 65535;

        /// <summary>
        /// The list of mimetypes that equate to a jpeg.
        /// </summary>
        public static readonly IEnumerable<string> MimeTypes = new[] { "image/jpeg", "image/pjpeg" };

        /// <summary>
        /// The list of file extensions that equate to a jpeg.
        /// </summary>
        public static readonly IEnumerable<string> FileExtensions = new[] { "jpg", "jpeg", "jfif" };

        /// <summary>
        /// Describes common Jpeg markers
        /// </summary>
        internal static class Markers
        {
            /// <summary>
            /// Marker prefix. Next byte is a marker.
            /// </summary>
            public const byte XFF = 0xff;

            /// <summary>
            /// Same as <see cref="XFF"/> but of type <see cref="int"/>
            /// </summary>
            public const int XFFInt = XFF;

            /// <summary>
            /// Start of Image
            /// </summary>
            public const byte SOI = 0xd8;

            /// <summary>
            /// Start of Frame (baseline DCT)
            /// <remarks>
            /// Indicates that this is a baseline DCT-based JPEG, and specifies the width, height, number of components,
            /// and component subsampling (e.g., 4:2:0).
            /// </remarks>
            /// </summary>
            public const byte SOF0 = 0xc0;

            /// <summary>
            /// Start Of Frame (Extended Sequential DCT)
            /// <remarks>
            /// Indicates that this is a progressive DCT-based JPEG, and specifies the width, height, number of components,
            /// and component subsampling (e.g., 4:2:0).
            /// </remarks>
            /// </summary>
            public const byte SOF1 = 0xc1;

            /// <summary>
            /// Start Of Frame (progressive DCT)
            /// <remarks>
            /// Indicates that this is a progressive DCT-based JPEG, and specifies the width, height, number of components,
            /// and component subsampling (e.g., 4:2:0).
            /// </remarks>
            /// </summary>
            public const byte SOF2 = 0xc2;

            /// <summary>
            /// Define Huffman Table(s)
            /// <remarks>
            /// Specifies one or more Huffman tables.
            /// </remarks>
            /// </summary>
            public const byte DHT = 0xc4;

            /// <summary>
            /// Define Quantization Table(s)
            /// <remarks>
            /// Specifies one or more quantization tables.
            /// </remarks>
            /// </summary>
            public const byte DQT = 0xdb;

            /// <summary>
            /// Define Restart Interval
            /// <remarks>
            /// Specifies the interval between RSTn markers, in macroblocks. This marker is followed by two bytes
            /// indicating the fixed size so it can be treated like any other variable size segment.
            /// </remarks>
            /// </summary>
            public const byte DRI = 0xdd;

            /// <summary>
            /// Define First Restart
            /// <remarks>
            /// Inserted every r macroblocks, where r is the restart interval set by a DRI marker.
            /// Not used if there was no DRI marker. The low three bits of the marker code cycle in value from 0 to 7.
            /// </remarks>
            /// </summary>
            public const byte RST0 = 0xd0;

            /// <summary>
            /// Define Eigth Restart
            /// <remarks>
            /// Inserted every r macroblocks, where r is the restart interval set by a DRI marker.
            /// Not used if there was no DRI marker. The low three bits of the marker code cycle in value from 0 to 7.
            /// </remarks>
            /// </summary>
            public const byte RST7 = 0xd7;

            /// <summary>
            /// Start of Scan
            /// <remarks>
            /// Begins a top-to-bottom scan of the image. In baseline DCT JPEG images, there is generally a single scan.
            /// Progressive DCT JPEG images usually contain multiple scans. This marker specifies which slice of data it
            /// will contain, and is immediately followed by entropy-coded data.
            /// </remarks>
            /// </summary>
            public const byte SOS = 0xda;

            /// <summary>
            /// Comment
            /// <remarks>
            /// Contains a text comment.
            /// </remarks>
            /// </summary>
            public const byte COM = 0xfe;

            /// <summary>
            /// End of Image
            /// </summary>
            public const byte EOI = 0xd9;

            /// <summary>
            /// Application specific marker for marking the jpeg format.
            /// <see href="http://www.sno.phy.queensu.ca/~phil/exiftool/TagNames/JPEG.html"/>
            /// </summary>
            public const byte APP0 = 0xe0;

            /// <summary>
            /// Application specific marker for marking where to store metadata.
            /// </summary>
            public const byte APP1 = 0xe1;

            /// <summary>
            /// Application specific marker for marking where to store ICC profile information.
            /// </summary>
            public const byte APP2 = 0xe2;

            /// <summary>
            /// Application specific marker used by Adobe for storing encoding information for DCT filters.
            /// </summary>
            public const byte APP14 = 0xee;

            /// <summary>
            /// Application specific marker used by GraphicConverter to store JPEG quality.
            /// </summary>
            public const byte APP15 = 0xef;
        }

        /// <summary>
        /// Describes Adobe specific markers <see href="http://www.sno.phy.queensu.ca/~phil/exiftool/TagNames/JPEG.html#Adobe"/>
        /// </summary>
        internal static class Adobe
        {
            /// <summary>
            /// Represents A in ASCII
            /// </summary>
            public const byte A = 0x41;

            /// <summary>
            /// Represents d in ASCII
            /// </summary>
            public const byte D = 0x64;

            /// <summary>
            /// Represents b in ASCII
            /// </summary>
            public const byte O = 0x6F;

            /// <summary>
            /// Represents b in ASCII
            /// </summary>
            public const byte B = 0x62;

            /// <summary>
            /// Represents e in ASCII
            /// </summary>
            public const byte E = 0x65;

            /// <summary>
            /// The color transform is unknown.(RGB or CMYK)
            /// </summary>
            public const int ColorTransformUnknown = 0;

            /// <summary>
            /// The color transform is YCbCr (luminance, red chroma, blue chroma)
            /// </summary>
            public const int ColorTransformYCbCr = 1;

            /// <summary>
            /// The color transform is YCCK (luminance, red chroma, blue chroma, keyline)
            /// </summary>
            public const int ColorTransformYcck = 2;
        }

        /// <summary>
        /// Contains EXIF specific markers
        /// </summary>
        internal static class Exif
        {
            /// <summary>
            /// Represents E in ASCII
            /// </summary>
            public const byte E = 0x45;

            /// <summary>
            /// Represents x in ASCII
            /// </summary>
            public const byte X = 0x78;

            /// <summary>
            /// Represents i in ASCII
            /// </summary>
            public const byte I = 0x69;

            /// <summary>
            /// Represents f in ASCII
            /// </summary>
            public const byte F = 0x66;

            /// <summary>
            /// Represents the null "0" marker
            /// </summary>
            public const byte Null = 0x0;
        }

        /// <summary>
        /// Contains ICC specific markers
        /// </summary>
        internal static class ICC
        {
            /// <summary>
            /// Represents I in ASCII
            /// </summary>
            public const byte I = 0x49;

            /// <summary>
            /// Represents C in ASCII
            /// </summary>
            public const byte C = 0x43;

            /// <summary>
            /// Represents _ in ASCII
            /// </summary>
            public const byte UnderScore = 0x5F;

            /// <summary>
            /// Represents P in ASCII
            /// </summary>
            public const byte P = 0x50;

            /// <summary>
            /// Represents R in ASCII
            /// </summary>
            public const byte R = 0x52;

            /// <summary>
            /// Represents O in ASCII
            /// </summary>
            public const byte O = 0x4F;

            /// <summary>
            /// Represents F in ASCII
            /// </summary>
            public const byte F = 0x46;

            /// <summary>
            /// Represents L in ASCII
            /// </summary>
            public const byte L = 0x4C;

            /// <summary>
            /// Represents E in ASCII
            /// </summary>
            public const byte E = 0x45;

            /// <summary>
            /// Represents the null "0" marker
            /// </summary>
            public const byte Null = 0x0;
        }
    }
}