namespace StrategyPattern {
    internal class HighContrastFilter : IFilter {
        public void apply(string fileName) {
            Console.WriteLine($"Applying high contrast filter on {fileName}...");
        }
    }
}
