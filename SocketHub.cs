using Microsoft.AspNetCore.SignalR;
using Microsoft.OpenApi.Any;
using System.Threading.Tasks;

namespace SocketSignalR
{
    public class SocketHub : Hub
    {
        public override async Task OnConnectedAsync()
        {
            // Aquí puedes realizar cualquier acción necesaria cuando un cliente se conecta.
            Console.WriteLine("Usuario conectado");
            await base.OnConnectedAsync();
        }

        public override async Task OnDisconnectedAsync(Exception exception)
        {
            // Aquí puedes realizar cualquier acción necesaria cuando un cliente se desconecta.
            Console.WriteLine("Usuario desconectado");
            await base.OnDisconnectedAsync(exception);
        }

        public async Task SendPosition(object position)
        {
            // Este método se llama desde el cliente
            // Envía el mensaje a todos los clientes conectados
            Console.WriteLine("Mensaje recibido desde el cliente Node.js: " + position);
            await Clients.All.SendAsync("SendPosition", position);
        }

        public async Task FinalClassification(object option)
        {
            // Este método se llama desde el cliente
            // Envía el mensaje a todos los clientes conectados
            Console.WriteLine("Mensaje recibido FinalClassification: " + option);
            await Clients.All.SendAsync("FinalClassification", option);
        }

        public async Task Participants(object option)
        {
            // Este método se llama desde el cliente
            // Envía el mensaje a todos los clientes conectados
            Console.WriteLine("Mensaje recibido desde el cliente Node.js: " + option);
            await Clients.All.SendAsync("Participants", option);
        }

        public async Task EventProject(object option)
        {
            // Este método se llama desde el cliente
            // Envía el mensaje a todos los clientes conectados
            Console.WriteLine("Mensaje recibido desde el cliente Node.js: " + option);
            await Clients.All.SendAsync("EventProject", option);
        }

        public async Task PilotsPoints(object option)
        {
            // Este método se llama desde el cliente
            // Envía el mensaje a todos los clientes conectados
            Console.WriteLine("Mensaje recibido desde el cliente Node.js: " + option);
            await Clients.All.SendAsync("PilotsPoints", option);
        }
    }
}
