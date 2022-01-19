from underautomation.universal_robots.connect_parameters import ConnectParameters
from underautomation.universal_robots.ur import UR
from underautomation.universal_robots.primary_interface.joint_data_package_event_args import JointDataPackageEventArgs

import time 


robot = UR()

parameters = ConnectParameters("192.168.0.56")


vars = robot.primary_interface.global_variables.get_all()

v = vars.count

def f(a, b:JointDataPackageEventArgs):
    print(b.base.position)

robot.primary_interface.joint_data_received(f)

robot.xml_rpc.xml_rpc_server_request()


robot.connect(parameters)

while True:
    time.sleep(1)
#    print("")
#    print("  " + str(robot.primary_interface.cartesian_info.x) + " mm")

