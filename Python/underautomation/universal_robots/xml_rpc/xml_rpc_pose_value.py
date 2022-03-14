import typing
from underautomation.universal_robots.common.pose import Pose
from underautomation.universal_robots.xml_rpc.xml_rpc_type import XmlRpcType
from underautomation.universal_robots.xml_rpc.xml_rpc_struct_value import XmlRpcStructValue
import clr
import os
clr.AddReference(os.path.realpath(os.path.join(os.path.dirname(__file__), "..",  'lib', 'UnderAutomation.UniversalRobots.dll')))
from UnderAutomation.UniversalRobots.XmlRpc import XmlRpcPoseValue as xml_rpc_pose_value

class XmlRpcPoseValue(XmlRpcStructValue):
	def __init__(self, pose: Pose, _internal = 0):
		if(_internal == 0):
			self._instance = xml_rpc_pose_value(pose)
		else:
			self._instance = _internal
	def __repr__(self):
		return self._instance.ToString()
	@property
	def value(self) -> Pose:
		return Pose(None, None, None, None, None, None, self._instance.Value)
	@property
	def type(self) -> XmlRpcType:
		return XmlRpcType(self._instance.Type)
