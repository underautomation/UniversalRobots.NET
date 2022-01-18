from underautomation.universal_robots.ur import UR
from underautomation.universal_robots.urprogram import URProgram
from underautomation.universal_robots.urinstallation import URInstallation
from underautomation.universal_robots.pose import Pose
from underautomation.universal_robots.connect_parameters import ConnectParameters
from underautomation.universal_robots.rtde.rtde_input_data import RtdeInputData
from underautomation.universal_robots.rtde.rtde_output_data import RtdeOutputData
from underautomation.universal_robots.rtde.rtde_input_values import RtdeInputValues

robot = UR()

parameters = ConnectParameters("192.168.0.1")

# Enable Primary Interface
parameters.primary_interface.enable = True

# Select exchanged data
parameters.rtde.enable = True
parameters.rtde.frequency = 500 # Hz
parameters.rtde.input_setup.add(RtdeInputData.InputDoubleRegisters, 42)
parameters.rtde.input_setup.add(RtdeInputData.StandardAnalogOutput0)
parameters.rtde.input_setup.add(RtdeOutputData.ActualTcpPose)
parameters.rtde.input_setup.add(RtdeOutputData.ActualTcpSpeed)
parameters.rtde.input_setup.add(RtdeOutputData.ActualTcpForce)
parameters.rtde.input_setup.add(RtdeOutputData.ActualCurrent)
parameters.rtde.input_setup.add(RtdeOutputData.InputIntRegisters, 0)

# Enable Dashboard commands
parameters.dashboard.enable = True

# XML-RPC server on port 50000
parameters.xml_rpc.enable = True
parameters.xml_rpc.port = 50000

# Socket server on port 50001
parameters.socket_communication.enable = True
parameters.socket_communication.port = 50001

# Enable SSH commands and files
parameters.ssh.enable_ssh = True
parameters.ssh.enable_sftp = True
parameters.ssh.username = "ur"
parameters.ssh.password = "easybot"

# Connect to the robot
robot.connect(parameters)

#######################
#   PRIMARY INTERFACE
#######################
# Get all program and installation variables
variables = robot.primary_interface.global_variables.get_all()
# Send and execute script on the robot
robot.primary_interface.send("movej([-1.5,-1.5,-2,-0.5,1.8,0],a=1.4, v=1.05, t=0, r=0)")
# robot.primary_interface.program_threads...
# robot.primary_interface.popup_message...
# robot.primary_interface.joint_data.elbow...
# robot.primary_interface.singularity_info


########################
# RTDE
#######################
# Real frequency of received data
frequency = robot.rtde.measured_frequency
# Access received data
actualTcpPoseZ = robot.rtde.output_data_values.actual_tcp_pose.z
actualTcpPoseX = robot.rtde.output_data_values.input_int_registers.x0

# Prepare input values
inputs = RtdeInputValues()
inputs.input_double_registers.x42 = -42.1
inputs.standard_analog_output0 = 0.5
# Write values to robot
robot.rtde.write_inputs(inputs)


########################
#      DASHBOARD
#######################
# Power on the robot arm and release brakes
robot.dashboard.power_on()
robot.dashboard.release_brake()
# Load program file to polyscope
robot.dashboard.load_program("fast_bin_picking.urp")
# Start the program
robot.dashboard.play()
# Display a popup on the pendant
robot.dashboard.show_popup("I just remote-controlled my robot!")


########################
# SOCKET COMMUNICATION
#######################
# Get all client connected with URScript socket_open()
clients = robot.socket_communication.connected_clients
# Send message to all clients and reply "ok" when a message is received
robot.socket_communication.socket_write("Hello :) !")


########################
#       SSH
#######################
# Ask robot linux controller to execute a shell command
command = robot.ssh.run_command("ping 192.168.0.2")
result = command.result
exitStatus = command.exit_status


########################
#         SFTP
#######################
# List all files and directories in "programs" directory
items = robot.sftp.list_directory("/home/ur/ursim-current/programs/")

# Manipulates files and directories
# robot.Sftp.DownloadFile()
# robot.Sftp.UploadFile()
# robot.Sftp.CreateDirectory()


########################
#  EDIT NATIVE FILES
#######################
# Manipulate and edit program and installation files
program = URProgram.load(r"C:\path\to\program.urp")
installation = URInstallation.load(r"C:\path\to\default.installation")


########################
#     CONVERT POSE
#######################
# Convert pose types
pose = Pose(0.1, 0.2, -0.1, 0.01, 0, 1.1)
rpy = pose.from_rotation_vector_to_rpy()
rotationVector = pose.from_rotation_vector_to_rpy()





