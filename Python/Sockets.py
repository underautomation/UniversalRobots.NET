# Create a robot instance
from underautomation.universal_robots.connect_parameters import ConnectParameters
from underautomation.universal_robots.socket_communication.socket_client_connection_event_args import SocketClientConnectionEventArgs
from underautomation.universal_robots.socket_communication.socket_request_event_args import SocketRequestEventArgs
from underautomation.universal_robots.ur import UR


robot = UR()

# Setup connection to th robot
param = ConnectParameters("192.168.0.1")

# Enable spcket server on port 50001
param.socket_communication.enable = True
param.socket_communication.port = 50001

# Connect to the robot
robot.connect(param)

##
# Function called when robot connects with URScipt function socket_open()
def on_socket_client_connection(o, e : SocketClientConnectionEventArgs):
    e.client.socket_write("Hello cobot <3")

robot.socket_communication.socket_client_connection(on_socket_client_connection)

# Function called when the robot sends a message with socket_write()
def on_socket_request(o,e:SocketRequestEventArgs):
    # Get robot message
    robotMessage = e.Message

robot.socket_communication.socket_request(on_socket_request)

# Send a message to all connected clients
robot.socket_communication.socket_write("123456")
##

# List of all connected clients
connectedClients = robot.socket_communication.connected_clients

# IP address and remote port of a client
clientEndpoint = connectedClients[0].end_point

# Send a message to a specific connected robot
connectedClients[0].socket_write("Hello robot [0]")

  # Handle client disconnection
def on_socket_client_disconnection(o,e):
    pass

connectedClients[0].socket_client_disconnection(on_socket_client_disconnection)