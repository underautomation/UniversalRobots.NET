from underautomation.universal_robots.connect_parameters import ConnectParameters
from underautomation.universal_robots.ur import UR

import time 


robot = UR()

parameters = ConnectParameters("192.168.0.56")


robot.connect(parameters)


while True:
    time.sleep(1)
    print("")
    print("  " + str(robot.primary_interface.cartesian_info.x) + " mm")

