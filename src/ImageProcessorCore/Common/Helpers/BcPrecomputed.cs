namespace ImageProcessorCore.Common.Helpers
{
    public class BcPrecomputed
    {
        public BcPrecomputed(float b, float c)
        {
            P1 = 12 - (9 * b) - (6 * c);
            P2 = -18 + (12 * b) + (6 * c);
            P3 = 6 - (2 * b);

            O1 = -b - (6 * c);
            O2 = (6 * b) + (30 * c);
            O3 = (-12 * b) - (48 * c);
            O4 = (8 * b) + (24 * c);
        }

        public float P1 { get; set; }
        public float P2 { get; set; }
        public float P3 { get; set; }

        public float O1 { get; set; }
        public float O2 { get; set; }
        public float O3 { get; set; }
        public float O4 { get; set; }
    }
}