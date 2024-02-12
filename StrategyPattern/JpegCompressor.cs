namespace StrategyPattern {
    internal class JpegCompressor : ICompressor {
        public void compress(string fileName) {
            Console.WriteLine($"Compressing {fileName} using JPEG...");
        }
    }
}
