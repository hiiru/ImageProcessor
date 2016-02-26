// <copyright file="BicubicResampler.cs" company="James Jackson-South">
// Copyright (c) James Jackson-South and contributors.
// Licensed under the Apache License, Version 2.0.
// </copyright>

using System;

namespace ImageProcessorCore.Samplers
{
    /// <summary>
    /// The function implements the bicubic kernel algorithm W(x) as described on
    /// <see href="https://en.wikipedia.org/wiki/Bicubic_interpolation#Bicubic_convolution_algorithm">Wikipedia</see>
    /// A commonly used algorithm within imageprocessing that preserves sharpness better than triangle interpolation.
    /// </summary>
    public class BicubicResampler : IResampler
    {
        /// <inheritdoc/>
        public float Radius => 2;

        /// <inheritdoc/>
        public float GetValue(float input)
        {
            var x = Math.Abs(input);
            if (x <= 1)
            {
                return (((1.5f * x) - 2.5f) * x * x) + 1;
            }
            else if (x < 2)
            {
                return (((((-0.5f * x) + 2.5f) * x) - 4) * x) + 2;
            }
            return 0;
        }
    }
}
