using System.Reflection;
using Sora.Command.Manager;
using Sora.Server;
using YukariToolBox.FormatLog;


Log.SetLogLevel(LogLevel.Debug);

SoraWSServer   server     = new SoraWSServer(new ServerConfig {Port = 8080});
CommandManager commandMgr = new CommandManager(server);
commandMgr.MappingCommands(Assembly.GetEntryAssembly());
await server.StartServer();
