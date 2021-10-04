
# Use Pythonnet library
import clr

import time
import os

# Reference to DLL (ensure it is not locked : right click / Properties / Unlock / OK)
clr.AddReference(r'..\..\Libraries\net35\UnderAutomation.UniversalRobots')

from UnderAutomation.UniversalRobots import UR


_ur = UR()

_ur.Connect("192.168.0.56");

while 1:
	time.sleep(0.5)
	os.system('cls')
	print("Cartesian data :")
	print("  " + str(_ur.CartesianInfo.X) + " mm")
	print("  " + str(_ur.CartesianInfo.Y) + " mm")
	print("  " + str(_ur.CartesianInfo.Z) + " mm")
	print("  " + str(_ur.CartesianInfo.Rx) + " °")
	print("  " + str(_ur.CartesianInfo.Ry) + " °")
	print("  " + str(_ur.CartesianInfo.Rz) + " °")
	
	print("Press CTRL+C to stop...")