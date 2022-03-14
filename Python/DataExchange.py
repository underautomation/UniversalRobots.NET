from underautomation.universal_robots.connect_parameters import ConnectParameters
from underautomation.universal_robots.rtde.rtde_input_data import RtdeInputData
from underautomation.universal_robots.rtde.rtde_input_values import RtdeInputValues
from underautomation.universal_robots.rtde.rtde_output_data import RtdeOutputData
from underautomation.universal_robots.ur import UR

# Create a robot instance
robot = UR()

# Setup connection to th robot
param = ConnectParameters()
param.ip = "192.168.0.1"

# Enable primary interface to get variable values
param.primary_interface.enable = True

# Enable rtde at 5Hz (500Hz possible)
param.rtde.enable = True
param.rtde.frequency = 5

# Ask the robot for permission to write these registers
param.rtde.input_setup.add(RtdeInputData.StandardAnalogOutput0)
param.rtde.input_setup.add(RtdeInputData.InputBitRegisters, 64)

# Ask the robot to send me this data
param.rtde.output_setup.add(RtdeOutputData.ActualTcpPose)
param.rtde.output_setup.add(RtdeOutputData.ActualTcpForce)

# Connect to the robot
robot.connect(param)

# Function called when new RTDE data is received
def on_output_data_received(o, e):
    ##
    # Display robot TCP pose
    pose = robot.rtde.output_data_values.actual_tcp_pose
    # pose.X, pose.Y, pose.Z, pose.Rx, ...

    # Display robot TCP force
    force = robot.rtde.output_data_values.actual_tcp_force

    # Write data in robot controler
    inputs = RtdeInputValues()
    inputs.standard_analog_output0 = 0.2
    inputs.input_bit_registers.x64 = True
    robot.rtde.write_inputs(inputs)
    ##

# Event raised when data is received
robot.rtde.output_data_received(on_output_data_received)

# Function called when any program or installation variable changes in the robot
def on_value_updated(p, e):
    ##
    # Display all program and installation variables
    variables = robot.primary_interface.global_variables.get_all()
    name = variables[0].name
    value = variables[0].to_pose()
    type = variables[0].type
    ##    

# Event raised when a program or installation variable change
robot.primary_interface.global_variables.values_updated(on_value_updated)


# Function called when masterboard data is received
def on_masterboard_data_received(p, e):
    ai0 = robot.primary_interface.masterboard_data.analog_input0
    di2 = robot.primary_interface.masterboard_data.digital_inputs.digital2

# Several other events are raised by primary interface
robot.primary_interface.masterboard_data_received(on_masterboard_data_received)

# Function called when cartesian data is received
def on_cartesian_info_received(p, e):
    x = e.X
    tcpOffsetX = e.TCPOffsetX

robot.primary_interface.cartesian_info_received(on_cartesian_info_received)

# Function called when joint data is received
def on_joint_data_received(o,e):
    shoulderAngle = e.Shoulder.Position
    elbowMode = e.Elbow.JointMode
    wrist3Speed = e.Wrist3.ActualSpeed

robot.primary_interface.joint_data_received(on_joint_data_received)
