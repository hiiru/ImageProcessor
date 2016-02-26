// <copyright file="BoxResampler.cs" company="James Jackson-South">
// Copyright (c) James Jackson-South and contributors.
// Licensed under the Apache License, Version 2.0.
// </copyright>

using System;

namespace ImageProcessorCore.Samplers
{
    /// <summary>
    /// The function implements the box algorithm. Similar to nearest neighbour when upscaling.
    /// When downscaling the pixels will average, merging together.
    /// </summary>
    public class BoxResampler : IResampler
    {
        /// <inheritdoc/>
        public float Radius => 0.5F;

        /// <inheritdoc/>
        public float GetValue(float input)
        {
            var x = Math.Abs(input);
            if (x <= 0.5)
                return 1;
            return 0;
        }
    }
}
