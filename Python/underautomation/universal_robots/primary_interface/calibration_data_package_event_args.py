import typing
from underautomation.universal_robots.common.package_event_args import PackageEventArgs
import clr
import os
clr.AddReference(os.path.realpath(os.path.join(os.path.dirname(__file__), "..",  'lib', 'UnderAutomation.UniversalRobots.dll')))
from UnderAutomation.UniversalRobots.PrimaryInterface import CalibrationDataPackageEventArgs as calibration_data_package_event_args

class CalibrationDataPackageEventArgs(PackageEventArgs):
	def __init__(self, _internal = 0):
		if(_internal == 0):
			self._instance = calibration_data_package_event_args()
		else:
			self._instance = _internal
	@property
	def fx(self) -> float:
		return self._instance.Fx
	@fx.setter
	def fx(self, value: float):
		self._instance.Fx = value
	@property
	def fy(self) -> float:
		return self._instance.Fy
	@fy.setter
	def fy(self, value: float):
		self._instance.Fy = value
	@property
	def fz(self) -> float:
		return self._instance.Fz
	@fz.setter
	def fz(self, value: float):
		self._instance.Fz = value
	@property
	def frx(self) -> float:
		return self._instance.Frx
	@frx.setter
	def frx(self, value: float):
		self._instance.Frx = value
	@property
	def fry(self) -> float:
		return self._instance.Fry
	@fry.setter
	def fry(self, value: float):
		self._instance.Fry = value
	@property
	def frz(self) -> float:
		return self._instance.Frz
	@frz.setter
	def frz(self, value: float):
		self._instance.Frz = value
