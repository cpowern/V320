namespace StrategyPattern {
    internal class PngCompressor : ICompressor {
        public void compress(string fileName) {
            Console.WriteLine($"Compressing {fileName} using Png...");
        }
    }
}
