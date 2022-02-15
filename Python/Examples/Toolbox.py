from underautomation.universal_robots.pose import Pose
from underautomation.universal_robots.ur_program import URProgram
from underautomation.universal_robots.ur_installation import URInstallation

##
# Create X, Y, Z, RX, RY, RZ pose
pose = Pose(0.1, 0.2, -0.1, 0, 0.05, 0.1)

# Convert cartesian pose type to RPY or rotation vector
rpy = pose.from_rotation_vector_to_rpy()
vectorPose = pose.from_rpy_to_rotation_vector()

# Decompile program and installation files and access inner XML
installation = URInstallation.load("C:\\temp\\default.installation")
prg = URProgram.load("C:\\temp\\prg.urp")
internalXml = prg.xml
##
