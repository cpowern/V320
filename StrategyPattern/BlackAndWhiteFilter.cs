namespace StrategyPattern {
    internal class BlackAndWhiteFilter : IFilter {
        public void apply(string fileName) {
            Console.WriteLine($"Applying black and white filter on {fileName}...");
        }
    }
}
