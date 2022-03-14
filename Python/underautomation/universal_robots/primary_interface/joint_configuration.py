import typing
import clr
import os
clr.AddReference(os.path.realpath(os.path.join(os.path.dirname(__file__), "..",  'lib', 'UnderAutomation.UniversalRobots.dll')))
from UnderAutomation.UniversalRobots.PrimaryInterface import JointConfiguration as joint_configuration

class JointConfiguration:
	def __init__(self, _internal = 0):
		if(_internal == 0):
			self._instance = joint_configuration()
		else:
			self._instance = _internal
	@property
	def joint_min_limit(self) -> float:
		return self._instance.JointMinLimit
	@joint_min_limit.setter
	def joint_min_limit(self, value: float):
		self._instance.JointMinLimit = value
	@property
	def joint_max_limit(self) -> float:
		return self._instance.JointMaxLimit
	@joint_max_limit.setter
	def joint_max_limit(self, value: float):
		self._instance.JointMaxLimit = value
	@property
	def joint_max_speed(self) -> float:
		return self._instance.JointMaxSpeed
	@joint_max_speed.setter
	def joint_max_speed(self, value: float):
		self._instance.JointMaxSpeed = value
	@property
	def joint_max_acceleration(self) -> float:
		return self._instance.JointMaxAcceleration
	@joint_max_acceleration.setter
	def joint_max_acceleration(self, value: float):
		self._instance.JointMaxAcceleration = value
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
	def d_halpha(self) -> float:
		return self._instance.DHalpha
	@d_halpha.setter
	def d_halpha(self, value: float):
		self._instance.DHalpha = value
	@property
	def d_htheta(self) -> float:
		return self._instance.DHtheta
	@d_htheta.setter
	def d_htheta(self, value: float):
		self._instance.DHtheta = value
