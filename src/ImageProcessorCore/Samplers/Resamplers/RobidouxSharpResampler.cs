// <copyright file="RobidouxSharpResampler.cs" company="James Jackson-South">
// Copyright (c) James Jackson-South and contributors.
// Licensed under the Apache License, Version 2.0.
// </copyright>

using ImageProcessorCore.Common.Helpers;

namespace ImageProcessorCore.Samplers
{
    /// <summary>
    /// The function implements the Robidoux Sharp algorithm.
    /// <see href="http://www.imagemagick.org/Usage/filter/#robidoux"/>
    /// </summary>
    public class RobidouxSharpResampler : IResampler
    {
        /// <inheritdoc/>
        public float Radius => 2;
        
        private static BcPrecomputed pre = new BcPrecomputed(0.26201451F, 0.36899274F);

        /// <inheritdoc/>
        public float GetValue(float x)
        {
            return ImageMaths.GetBcValue(x, x * x, pre);
        }
    }
}
