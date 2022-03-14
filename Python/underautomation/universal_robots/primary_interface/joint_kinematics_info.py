import typing
import clr
import os
clr.AddReference(os.path.realpath(os.path.join(os.path.dirname(__file__), "..",  'lib', 'UnderAutomation.UniversalRobots.dll')))
from UnderAutomation.UniversalRobots.PrimaryInterface import JointKinematicsInfo as joint_kinematics_info

class JointKinematicsInfo:
	def __init__(self, _internal = 0):
		if(_internal == 0):
			self._instance = joint_kinematics_info()
		else:
			self._instance = _internal
	@property
	def checksum(self) -> int:
		return self._instance.Checksum
	@checksum.setter
	def checksum(self, value: int):
		self._instance.Checksum = value
	@property
	def d_htheta(self) -> float:
		return self._instance.DHtheta
	@d_htheta.setter
	def d_htheta(self, value: float):
		self._instance.DHtheta = value
	@property
	def d_ha(self) -> float:
		return self._instance.DHa
	@d_ha.setter
	def d_ha(self, value: float):
		self._instance.DHa = value
	@property
	def d_hd(self) -> float:
		return self._instance.DHd
	@d_hd.setter
	def d_hd(self, value: float):
		self._instance.DHd = value
	@property
	def dhalpha(self) -> float:
		return self._instance.Dhalpha
	@dhalpha.setter
	def dhalpha(self, value: float):
		self._instance.Dhalpha = value
