import typing
import clr
import os
clr.AddReference(os.path.realpath(os.path.join(os.path.dirname(__file__), "..", "..", "..", 'lib', 'UnderAutomation.UniversalRobots.dll')))
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
	def dhtheta(self) -> float:
		return self._instance.DHtheta
	@dhtheta.setter
	def dhtheta(self, value: float):
		self._instance.DHtheta = value
	@property
	def dha(self) -> float:
		return self._instance.DHa
	@dha.setter
	def dha(self, value: float):
		self._instance.DHa = value
	@property
	def dhd(self) -> float:
		return self._instance.DHd
	@dhd.setter
	def dhd(self, value: float):
		self._instance.DHd = value
	@property
	def dhalpha(self) -> float:
		return self._instance.Dhalpha
	@dhalpha.setter
	def dhalpha(self, value: float):
		self._instance.Dhalpha = value
