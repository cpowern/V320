namespace StrategyPattern {
    internal class ImageStorage {
        public void Store(string fileName, ICompressor compressor, IFilter filter) {
            compressor.compress(fileName);
            filter.apply(fileName);
            Console.WriteLine($"File {fileName} stored successfully!");
        }
    }
}
