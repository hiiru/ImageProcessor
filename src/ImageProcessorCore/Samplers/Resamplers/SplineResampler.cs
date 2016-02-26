// <copyright file="SplineResampler.cs" company="James Jackson-South">
// Copyright (c) James Jackson-South and contributors.
// Licensed under the Apache License, Version 2.0.
// </copyright>

using ImageProcessorCore.Common.Helpers;

namespace ImageProcessorCore.Samplers
{
    /// <summary>
    /// The function implements the spline algorithm.
    /// <see href="http://www.imagemagick.org/Usage/filter/#cubic_bc"/>
    /// </summary>
    public class SplineResampler : IResampler
    {
        /// <inheritdoc/>
        public float Radius => 2;
        
        private static BcPrecomputed pre = new BcPrecomputed(1, 0);

        /// <inheritdoc/>
        public float GetValue(float x)
        {
            return ImageMaths.GetBcValue(x, x * x, pre);
        }
    }
}
