import typing
import clr
import os
clr.AddReference(os.path.realpath(os.path.join(os.path.dirname(__file__), "..",  'lib', 'UnderAutomation.UniversalRobots.dll')))
from UnderAutomation.UniversalRobots.Common import CartesianCoordinates as cartesian_coordinates

class CartesianCoordinates:
	def __init__(self, x: float, y: float, z: float, rx: float, ry: float, rz: float, _internal = 0):
		if(_internal == 0):
			self._instance = cartesian_coordinates(x, y, z, rx, ry, rz)
		else:
			self._instance = _internal
	def __repr__(self):
		return self._instance.ToString()
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
	def values(self) -> typing.List[float]:
		return self._instance.Values
