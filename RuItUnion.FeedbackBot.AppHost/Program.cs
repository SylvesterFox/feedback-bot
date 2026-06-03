using Projects;

IDistributedApplicationBuilder builder = DistributedApplication.CreateBuilder(args);

IResourceBuilder<IResourceWithConnectionString> tg = builder.AddConnectionString("Telegram");
IResourceBuilder<IResourceWithConnectionString> db = builder.AddConnectionString("RuItUnion-FeedbackBot-Database");

builder.AddProject<RuItUnion_FeedbackBot>("RuItUnion-FeedbackBot")
    .WithReference(db).WithReference(tg)
    .WithHttpHealthCheck("/health");

await builder.Build().RunAsync();
