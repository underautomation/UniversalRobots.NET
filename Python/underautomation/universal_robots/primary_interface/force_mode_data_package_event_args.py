import typing
from underautomation.universal_robots.common.package_event_args import PackageEventArgs
import clr
import os
clr.AddReference(os.path.realpath(os.path.join(os.path.dirname(__file__), "..",  'lib', 'UnderAutomation.UniversalRobots.dll')))
from UnderAutomation.UniversalRobots.PrimaryInterface import ForceModeDataPackageEventArgs as force_mode_data_package_event_args

class ForceModeDataPackageEventArgs(PackageEventArgs):
	def __init__(self, _internal = 0):
		if(_internal == 0):
			self._instance = force_mode_data_package_event_args()
		else:
			self._instance = _internal
	@property
	def x(self) -> float:
		return self._instance.X
	@x.setter
	def x(self, value: float):
		self._instance.X = value
	@property
	def y(self) -> float:
		return self._instance.Y
	@y.setter
	def y(self, value: float):
		self._instance.Y = value
	@property
	def z(self) -> float:
		return self._instance.Z
	@z.setter
	def z(self, value: float):
		self._instance.Z = value
	@property
	def rx(self) -> float:
		return self._instance.Rx
	@rx.setter
	def rx(self, value: float):
		self._instance.Rx = value
	@property
	def ry(self) -> float:
		return self._instance.Ry
	@ry.setter
	def ry(self, value: float):
		self._instance.Ry = value
	@property
	def rz(self) -> float:
		return self._instance.Rz
	@rz.setter
	def rz(self, value: float):
		self._instance.Rz = value
	@property
	def robot_dexterity(self) -> float:
		return self._instance.RobotDexterity
	@robot_dexterity.setter
	def robot_dexterity(self, value: float):
		self._instance.RobotDexterity = value
