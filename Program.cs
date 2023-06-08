using Config;

var app = BuilderConfig.Build(args);
AppConfig.Run(app);
RouterConfig.Run(app);

app.Run();
