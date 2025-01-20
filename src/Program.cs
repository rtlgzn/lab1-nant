static void Main(string[] args) {
    CommandLineBuilder builder = new CommandLineBuilder(args);
    builder.Parse(); // Existing code for parsing

    // Custom flag logic
    if (args.Contains("--ari")) {
        Console.WriteLine("BTP605 - Ari");
    }
}

