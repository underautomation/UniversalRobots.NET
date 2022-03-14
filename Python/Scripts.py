
# Create a robot instance
from underautomation.universal_robots.connect_parameters import ConnectParameters
from underautomation.universal_robots.ur import UR


robot = UR()

# Setup connection to th robot
param = ConnectParameters("192.168.0.1")

# Enable primary interface to get variable values
param.primary_interface.enable = True

# Enable SFTP file access
param.ssh.enable_sftp = True

# Connect to the robot
robot.connect(param)

##
# Ask robot to execute a movej
robot.primary_interface.script.send("movej([-1.5,-1.5,-2,-0.5,1.8,0], a=1.4, v=1.05, t=0, r=0)")

# Enumerates files and folder
items = robot.sftp.list_directory("/home/ur/ursim-current/programs/")

# Download program file prg.urp to your local disk
robot.sftp.download_file("/home/ur/ursim-current/programs/prg.urp", "C:\\temp\\prg.urp")

# Send a local file to the robot
robot.sftp.upload_file("C:\\temp\\prg.urp", "/home/ur/ursim-current/programs/prg.urp")

# Manipulate files and directories
robot.sftp.rename_file("/home/ur/prg.urp", "/home/ur/prg2.urp")
robot.sftp.delete("/home/ur/prg.urp")
exists = robot.sftp.exists("/home/ur/prg.urp")
robot.sftp.write_all_text("/home/ur/file.txt", "Hello robot !")
# ...
##