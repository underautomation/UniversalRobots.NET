import typing
from underautomation.universal_robots.rtde.rtde_registers_value_1 import RtdeRegistersValue1
import clr
import os
clr.AddReference(os.path.realpath(os.path.join(os.path.dirname(__file__), "..",  'lib', 'UnderAutomation.UniversalRobots.dll')))
from UnderAutomation.UniversalRobots.Rtde import RtdeIntRegistersValue as rtde_int_registers_value

class RtdeIntRegistersValue(RtdeRegistersValue1[int]):
	def __init__(self, _internal = 0):
		if(_internal == 0):
			self._instance = rtde_int_registers_value()
		else:
			self._instance = _internal
	@property
	def x0(self) -> int:
		return self._instance.X0
	@x0.setter
	def x0(self, value: int):
		self._instance.X0 = value
	@property
	def x1(self) -> int:
		return self._instance.X1
	@x1.setter
	def x1(self, value: int):
		self._instance.X1 = value
	@property
	def x2(self) -> int:
		return self._instance.X2
	@x2.setter
	def x2(self, value: int):
		self._instance.X2 = value
	@property
	def x3(self) -> int:
		return self._instance.X3
	@x3.setter
	def x3(self, value: int):
		self._instance.X3 = value
	@property
	def x4(self) -> int:
		return self._instance.X4
	@x4.setter
	def x4(self, value: int):
		self._instance.X4 = value
	@property
	def x5(self) -> int:
		return self._instance.X5
	@x5.setter
	def x5(self, value: int):
		self._instance.X5 = value
	@property
	def x6(self) -> int:
		return self._instance.X6
	@x6.setter
	def x6(self, value: int):
		self._instance.X6 = value
	@property
	def x7(self) -> int:
		return self._instance.X7
	@x7.setter
	def x7(self, value: int):
		self._instance.X7 = value
	@property
	def x8(self) -> int:
		return self._instance.X8
	@x8.setter
	def x8(self, value: int):
		self._instance.X8 = value
	@property
	def x9(self) -> int:
		return self._instance.X9
	@x9.setter
	def x9(self, value: int):
		self._instance.X9 = value
	@property
	def x10(self) -> int:
		return self._instance.X10
	@x10.setter
	def x10(self, value: int):
		self._instance.X10 = value
	@property
	def x11(self) -> int:
		return self._instance.X11
	@x11.setter
	def x11(self, value: int):
		self._instance.X11 = value
	@property
	def x12(self) -> int:
		return self._instance.X12
	@x12.setter
	def x12(self, value: int):
		self._instance.X12 = value
	@property
	def x13(self) -> int:
		return self._instance.X13
	@x13.setter
	def x13(self, value: int):
		self._instance.X13 = value
	@property
	def x14(self) -> int:
		return self._instance.X14
	@x14.setter
	def x14(self, value: int):
		self._instance.X14 = value
	@property
	def x15(self) -> int:
		return self._instance.X15
	@x15.setter
	def x15(self, value: int):
		self._instance.X15 = value
	@property
	def x16(self) -> int:
		return self._instance.X16
	@x16.setter
	def x16(self, value: int):
		self._instance.X16 = value
	@property
	def x17(self) -> int:
		return self._instance.X17
	@x17.setter
	def x17(self, value: int):
		self._instance.X17 = value
	@property
	def x18(self) -> int:
		return self._instance.X18
	@x18.setter
	def x18(self, value: int):
		self._instance.X18 = value
	@property
	def x19(self) -> int:
		return self._instance.X19
	@x19.setter
	def x19(self, value: int):
		self._instance.X19 = value
	@property
	def x20(self) -> int:
		return self._instance.X20
	@x20.setter
	def x20(self, value: int):
		self._instance.X20 = value
	@property
	def x21(self) -> int:
		return self._instance.X21
	@x21.setter
	def x21(self, value: int):
		self._instance.X21 = value
	@property
	def x22(self) -> int:
		return self._instance.X22
	@x22.setter
	def x22(self, value: int):
		self._instance.X22 = value
	@property
	def x23(self) -> int:
		return self._instance.X23
	@x23.setter
	def x23(self, value: int):
		self._instance.X23 = value
	@property
	def x24(self) -> int:
		return self._instance.X24
	@x24.setter
	def x24(self, value: int):
		self._instance.X24 = value
	@property
	def x25(self) -> int:
		return self._instance.X25
	@x25.setter
	def x25(self, value: int):
		self._instance.X25 = value
	@property
	def x26(self) -> int:
		return self._instance.X26
	@x26.setter
	def x26(self, value: int):
		self._instance.X26 = value
	@property
	def x27(self) -> int:
		return self._instance.X27
	@x27.setter
	def x27(self, value: int):
		self._instance.X27 = value
	@property
	def x28(self) -> int:
		return self._instance.X28
	@x28.setter
	def x28(self, value: int):
		self._instance.X28 = value
	@property
	def x29(self) -> int:
		return self._instance.X29
	@x29.setter
	def x29(self, value: int):
		self._instance.X29 = value
	@property
	def x30(self) -> int:
		return self._instance.X30
	@x30.setter
	def x30(self, value: int):
		self._instance.X30 = value
	@property
	def x31(self) -> int:
		return self._instance.X31
	@x31.setter
	def x31(self, value: int):
		self._instance.X31 = value
	@property
	def x32(self) -> int:
		return self._instance.X32
	@x32.setter
	def x32(self, value: int):
		self._instance.X32 = value
	@property
	def x33(self) -> int:
		return self._instance.X33
	@x33.setter
	def x33(self, value: int):
		self._instance.X33 = value
	@property
	def x34(self) -> int:
		return self._instance.X34
	@x34.setter
	def x34(self, value: int):
		self._instance.X34 = value
	@property
	def x35(self) -> int:
		return self._instance.X35
	@x35.setter
	def x35(self, value: int):
		self._instance.X35 = value
	@property
	def x36(self) -> int:
		return self._instance.X36
	@x36.setter
	def x36(self, value: int):
		self._instance.X36 = value
	@property
	def x37(self) -> int:
		return self._instance.X37
	@x37.setter
	def x37(self, value: int):
		self._instance.X37 = value
	@property
	def x38(self) -> int:
		return self._instance.X38
	@x38.setter
	def x38(self, value: int):
		self._instance.X38 = value
	@property
	def x39(self) -> int:
		return self._instance.X39
	@x39.setter
	def x39(self, value: int):
		self._instance.X39 = value
	@property
	def x40(self) -> int:
		return self._instance.X40
	@x40.setter
	def x40(self, value: int):
		self._instance.X40 = value
	@property
	def x41(self) -> int:
		return self._instance.X41
	@x41.setter
	def x41(self, value: int):
		self._instance.X41 = value
	@property
	def x42(self) -> int:
		return self._instance.X42
	@x42.setter
	def x42(self, value: int):
		self._instance.X42 = value
	@property
	def x43(self) -> int:
		return self._instance.X43
	@x43.setter
	def x43(self, value: int):
		self._instance.X43 = value
	@property
	def x44(self) -> int:
		return self._instance.X44
	@x44.setter
	def x44(self, value: int):
		self._instance.X44 = value
	@property
	def x45(self) -> int:
		return self._instance.X45
	@x45.setter
	def x45(self, value: int):
		self._instance.X45 = value
	@property
	def x46(self) -> int:
		return self._instance.X46
	@x46.setter
	def x46(self, value: int):
		self._instance.X46 = value
	@property
	def x47(self) -> int:
		return self._instance.X47
	@x47.setter
	def x47(self, value: int):
		self._instance.X47 = value
	@property
	def lower_range_index(self) -> int:
		return self._instance.LowerRangeIndex
