// <copyright file="MitchellNetravaliResampler.cs" company="James Jackson-South">
// Copyright (c) James Jackson-South and contributors.
// Licensed under the Apache License, Version 2.0.
// </copyright>

using ImageProcessorCore.Common.Helpers;

namespace ImageProcessorCore.Samplers
{
    /// <summary>
    /// The function implements the mitchell algorithm as described on
    /// <see href="https://de.wikipedia.org/wiki/Mitchell-Netravali-Filter">Wikipedia</see>
    /// </summary>
    public class MitchellNetravaliResampler : IResampler
    {
        /// <inheritdoc/>
        public float Radius => 2;
        
        private const float _third = 1 / 3f;
        private static BcPrecomputed pre = new BcPrecomputed(_third, _third);

        /// <inheritdoc/>
        public float GetValue(float x)
        {
            return ImageMaths.GetBcValue(x, x * x, pre);
        }
    }
}
