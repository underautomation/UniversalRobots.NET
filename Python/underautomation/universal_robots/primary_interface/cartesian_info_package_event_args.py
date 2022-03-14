import typing
from underautomation.universal_robots.common.package_event_args import PackageEventArgs
import clr
import os
clr.AddReference(os.path.realpath(os.path.join(os.path.dirname(__file__), "..",  'lib', 'UnderAutomation.UniversalRobots.dll')))
from UnderAutomation.UniversalRobots.PrimaryInterface import CartesianInfoPackageEventArgs as cartesian_info_package_event_args

class CartesianInfoPackageEventArgs(PackageEventArgs):
	def __init__(self, _internal = 0):
		if(_internal == 0):
			self._instance = cartesian_info_package_event_args()
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
	def tcp_offset_x(self) -> float:
		return self._instance.TCPOffsetX
	@tcp_offset_x.setter
	def tcp_offset_x(self, value: float):
		self._instance.TCPOffsetX = value
	@property
	def tcp_offset_y(self) -> float:
		return self._instance.TCPOffsetY
	@tcp_offset_y.setter
	def tcp_offset_y(self, value: float):
		self._instance.TCPOffsetY = value
	@property
	def tcp_offset_z(self) -> float:
		return self._instance.TCPOffsetZ
	@tcp_offset_z.setter
	def tcp_offset_z(self, value: float):
		self._instance.TCPOffsetZ = value
	@property
	def tcp_offset_rx(self) -> float:
		return self._instance.TCPOffsetRX
	@tcp_offset_rx.setter
	def tcp_offset_rx(self, value: float):
		self._instance.TCPOffsetRX = value
	@property
	def tcp_offset_ry(self) -> float:
		return self._instance.TCPOffsetRY
	@tcp_offset_ry.setter
	def tcp_offset_ry(self, value: float):
		self._instance.TCPOffsetRY = value
	@property
	def tcp_offset_rz(self) -> float:
		return self._instance.TCPOffsetRZ
	@tcp_offset_rz.setter
	def tcp_offset_rz(self, value: float):
		self._instance.TCPOffsetRZ = value
