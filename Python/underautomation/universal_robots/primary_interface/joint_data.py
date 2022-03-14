import typing
from underautomation.universal_robots.common.joint_modes import JointModes
import clr
import os
clr.AddReference(os.path.realpath(os.path.join(os.path.dirname(__file__), "..",  'lib', 'UnderAutomation.UniversalRobots.dll')))
from UnderAutomation.UniversalRobots.PrimaryInterface import JointData as joint_data

class JointData:
	def __init__(self, _internal = 0):
		if(_internal == 0):
			self._instance = joint_data()
		else:
			self._instance = _internal
	@property
	def position(self) -> float:
		return self._instance.Position
	@position.setter
	def position(self, value: float):
		self._instance.Position = value
	@property
	def target_position(self) -> float:
		return self._instance.TargetPosition
	@target_position.setter
	def target_position(self, value: float):
		self._instance.TargetPosition = value
	@property
	def actual_speed(self) -> float:
		return self._instance.ActualSpeed
	@actual_speed.setter
	def actual_speed(self, value: float):
		self._instance.ActualSpeed = value
	@property
	def current(self) -> float:
		return self._instance.Current
	@current.setter
	def current(self, value: float):
		self._instance.Current = value
	@property
	def voltage(self) -> float:
		return self._instance.Voltage
	@voltage.setter
	def voltage(self, value: float):
		self._instance.Voltage = value
	@property
	def temperature(self) -> float:
		return self._instance.Temperature
	@temperature.setter
	def temperature(self, value: float):
		self._instance.Temperature = value
	@property
	def joint_mode(self) -> JointModes:
		return JointModes(self._instance.JointMode)
	@joint_mode.setter
	def joint_mode(self, value: JointModes):
		self._instance.JointMode = value
