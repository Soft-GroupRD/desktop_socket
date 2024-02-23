module.exports = {
  apps: [
    {
      name: "desktop_socket",
      script: "dotnet",
      args: "SocketSignalR.dll",
      cwd: "/Proyectos/mvc/desktop_socket/bin/Release/net6.0/ubuntu.16.04-x64/publish"
    }
  ]
};
