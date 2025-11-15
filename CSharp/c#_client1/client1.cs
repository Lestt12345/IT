using System.Net;
using System.Net.Sockets;
using System.Text;

namespace Client
{
    class client1
    {
        static int local_port = 8002, remote_port = 7777;
        static IPAddress remote_ip_address = IPAddress.Parse("127.0.0.1");
        static UdpClient udp_client = new UdpClient(local_port);

        static async Task Main(string[] args)
        {
            try
            {
                Console.WriteLine($"Sending local port: {local_port}");
                await SendAsync(local_port.ToString());
                if (await ReceiveAsync() == "start")
                {
                    while (true)
                    {
                        string response = await ReceiveAsync();
                        if (response == "q") break;
                        string[] response_parts = response.Split('/');
                        Console.Clear();
                        Console.Write(response_parts[1]);
                        if (response_parts[0] == "true") await SendAsync(Console.ReadLine());
                    }
                }
                else
                {
                    Console.WriteLine("Unexpected server response");
                }
            }
            catch (SocketException ex)
            {
                Console.WriteLine("Socket error: " + ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Main error: " + ex.Message);
            }
            finally
            {
                udp_client.Close();
                udp_client.Dispose();
                Console.WriteLine("\nClient closed");
            }
        }

        static async Task<string> ReceiveAsync()
        {
            try
            {
                UdpReceiveResult result = await udp_client.ReceiveAsync();
                string message = Encoding.Unicode.GetString(result.Buffer);
                return message;
            }
            catch (SocketException ex)
            {
                Console.WriteLine("Socket error: " + ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Receive error: " + ex.Message);
            }
            return "";
        }

        static async Task SendAsync(string message)
        {
            try
            {
                byte[] bytes = Encoding.Unicode.GetBytes(message);
                IPEndPoint remote_endpoint = new IPEndPoint(remote_ip_address, remote_port);
                await udp_client.SendAsync(bytes, bytes.Length, remote_endpoint);
            }
            catch (SocketException ex)
            {
                Console.WriteLine("Socket error: " + ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Send error: " + ex.Message);
            }
        }
    }
}
