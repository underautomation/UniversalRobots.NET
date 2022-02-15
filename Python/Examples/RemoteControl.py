from underautomation.universal_robots.ur import UR

##
# Create a new robot instance
robot = UR()

# Connect to the robot
robot.connect("192.168.0.1")

# Power on the robot arm and release brakes
robot.dashboard.power_on()
robot.dashboard.release_brake()

# Load program file to polyscope
robot.dashboard.load_program("fast_bin_picking.urp")

# Start the program
robot.dashboard.play()

# Get program name and state
state = robot.dashboard.get_program_state()

# Display a popup on the pendant
robot.dashboard.show_popup("I just remote-controlled my robot!")
##