using Microsoft.EntityFrameworkCore.Design;

namespace RuItUnion.FeedbackBot.Data;

public class FeedbackBotContextFactory : IDesignTimeDbContextFactory<FeedbackBotContext>
{
    public FeedbackBotContext CreateDbContext(string[] args)
    {
        DbContextOptionsBuilder<FeedbackBotContext> builder = new();
        string connectionString = args.Length != 0
            ? string.Join(' ', args)
            : @"Data Source=feedback_bot.db";
        Console.WriteLine(@"connectionString = " + connectionString);
        return new(builder
            .UseSqlite(connectionString)
            .Options);
    }
}
