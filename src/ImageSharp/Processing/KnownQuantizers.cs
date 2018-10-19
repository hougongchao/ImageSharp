﻿// Copyright (c) Six Labors and contributors.
// Licensed under the Apache License, Version 2.0.

using SixLabors.ImageSharp.Processing.Processors.Quantization;

namespace SixLabors.ImageSharp.Processing
{
    /// <summary>
    /// Contains reusable static instances of known quantizing algorithms
    /// </summary>
    public static class KnownQuantizers
    {
        /// <summary>
        /// Gets the adaptive Octree quantizer. Fast with good quality.
        /// The quantizer only supports a single alpha value.
        /// </summary>
        public static IQuantizer Octree { get; } = new OctreeQuantizer();

        /// <summary>
        /// Gets the Xiaolin Wu's Color Quantizer which generates high quality output.
        /// The quantizer supports multiple alpha values.
        /// </summary>
        public static IQuantizer Wu { get; } = new WuQuantizer();

        /// <summary>
        /// Gets the palette based quantizer consisting of web safe colors as defined in the CSS Color Module Level 4.
        /// The quantizer supports a single alpha value.
        /// </summary>
        public static IQuantizer WebSafe { get; } = new WebSafePaletteQuantizer();

        /// <summary>
        /// Gets the palette based quantizer consisting of colors as defined in the original second edition of Werner’s Nomenclature of Colours 1821.
        /// The hex codes were collected and defined by Nicholas Rougeux <see href="https://www.c82.net/werner"/>
        /// The quantizer supports a single alpha value.
        /// </summary>
        public static IQuantizer Werner { get; } = new WernerPaletteQuantizer();
    }
}