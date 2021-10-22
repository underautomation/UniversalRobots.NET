
# Use Pythonnet library (compatible with Python <= 3.8)
import clr

import time

# Reference to DLL (ensure it is not locked : right click / Properties / Unlock / OK)
clr.AddReference(r'..\..\Libraries\net35\UnderAutomation.UniversalRobots')

from UnderAutomation.UniversalRobots import UR

_ur = UR()

_ur.Connect("192.168.0.56")

# Called as soon as information is received
def version_received(sender, e):
	print("Firmware version : " + str(e.MajorVersion) + "." + str(e.MinorVersion) + "." + str(e.BugfixVersion))
	print("")

# subscribe to event
_ur.VersionReceived += version_received

# print cartesian info
while 1:
	time.sleep(1)
	print("")
	print("Cartesian data :")
	print("  " + str(_ur.CartesianInfo.X) + " mm")
	print("  " + str(_ur.CartesianInfo.Y) + " mm")
	print("  " + str(_ur.CartesianInfo.Z) + " mm")
	print("  " + str(_ur.CartesianInfo.Rx) + " °")
	print("  " + str(_ur.CartesianInfo.Ry) + " °")
	print("  " + str(_ur.CartesianInfo.Rz) + " °")
