import typing
from underautomation.universal_robots.rtde.rtde_registers_value_1 import RtdeRegistersValue1
import clr
import os
clr.AddReference(os.path.realpath(os.path.join(os.path.dirname(__file__), "..",  'lib', 'UnderAutomation.UniversalRobots.dll')))
from UnderAutomation.UniversalRobots.Rtde import RtdeBitRegistersValue as rtde_bit_registers_value

class RtdeBitRegistersValue(RtdeRegistersValue1[bool]):
	def __init__(self, _internal = 0):
		if(_internal == 0):
			self._instance = rtde_bit_registers_value()
		else:
			self._instance = _internal
	@property
	def x64(self) -> bool:
		return self._instance.X64
	@x64.setter
	def x64(self, value: bool):
		self._instance.X64 = value
	@property
	def x65(self) -> bool:
		return self._instance.X65
	@x65.setter
	def x65(self, value: bool):
		self._instance.X65 = value
	@property
	def x66(self) -> bool:
		return self._instance.X66
	@x66.setter
	def x66(self, value: bool):
		self._instance.X66 = value
	@property
	def x67(self) -> bool:
		return self._instance.X67
	@x67.setter
	def x67(self, value: bool):
		self._instance.X67 = value
	@property
	def x68(self) -> bool:
		return self._instance.X68
	@x68.setter
	def x68(self, value: bool):
		self._instance.X68 = value
	@property
	def x69(self) -> bool:
		return self._instance.X69
	@x69.setter
	def x69(self, value: bool):
		self._instance.X69 = value
	@property
	def x70(self) -> bool:
		return self._instance.X70
	@x70.setter
	def x70(self, value: bool):
		self._instance.X70 = value
	@property
	def x71(self) -> bool:
		return self._instance.X71
	@x71.setter
	def x71(self, value: bool):
		self._instance.X71 = value
	@property
	def x72(self) -> bool:
		return self._instance.X72
	@x72.setter
	def x72(self, value: bool):
		self._instance.X72 = value
	@property
	def x73(self) -> bool:
		return self._instance.X73
	@x73.setter
	def x73(self, value: bool):
		self._instance.X73 = value
	@property
	def x74(self) -> bool:
		return self._instance.X74
	@x74.setter
	def x74(self, value: bool):
		self._instance.X74 = value
	@property
	def x75(self) -> bool:
		return self._instance.X75
	@x75.setter
	def x75(self, value: bool):
		self._instance.X75 = value
	@property
	def x76(self) -> bool:
		return self._instance.X76
	@x76.setter
	def x76(self, value: bool):
		self._instance.X76 = value
	@property
	def x77(self) -> bool:
		return self._instance.X77
	@x77.setter
	def x77(self, value: bool):
		self._instance.X77 = value
	@property
	def x78(self) -> bool:
		return self._instance.X78
	@x78.setter
	def x78(self, value: bool):
		self._instance.X78 = value
	@property
	def x79(self) -> bool:
		return self._instance.X79
	@x79.setter
	def x79(self, value: bool):
		self._instance.X79 = value
	@property
	def x80(self) -> bool:
		return self._instance.X80
	@x80.setter
	def x80(self, value: bool):
		self._instance.X80 = value
	@property
	def x81(self) -> bool:
		return self._instance.X81
	@x81.setter
	def x81(self, value: bool):
		self._instance.X81 = value
	@property
	def x82(self) -> bool:
		return self._instance.X82
	@x82.setter
	def x82(self, value: bool):
		self._instance.X82 = value
	@property
	def x83(self) -> bool:
		return self._instance.X83
	@x83.setter
	def x83(self, value: bool):
		self._instance.X83 = value
	@property
	def x84(self) -> bool:
		return self._instance.X84
	@x84.setter
	def x84(self, value: bool):
		self._instance.X84 = value
	@property
	def x85(self) -> bool:
		return self._instance.X85
	@x85.setter
	def x85(self, value: bool):
		self._instance.X85 = value
	@property
	def x86(self) -> bool:
		return self._instance.X86
	@x86.setter
	def x86(self, value: bool):
		self._instance.X86 = value
	@property
	def x87(self) -> bool:
		return self._instance.X87
	@x87.setter
	def x87(self, value: bool):
		self._instance.X87 = value
	@property
	def x88(self) -> bool:
		return self._instance.X88
	@x88.setter
	def x88(self, value: bool):
		self._instance.X88 = value
	@property
	def x89(self) -> bool:
		return self._instance.X89
	@x89.setter
	def x89(self, value: bool):
		self._instance.X89 = value
	@property
	def x90(self) -> bool:
		return self._instance.X90
	@x90.setter
	def x90(self, value: bool):
		self._instance.X90 = value
	@property
	def x91(self) -> bool:
		return self._instance.X91
	@x91.setter
	def x91(self, value: bool):
		self._instance.X91 = value
	@property
	def x92(self) -> bool:
		return self._instance.X92
	@x92.setter
	def x92(self, value: bool):
		self._instance.X92 = value
	@property
	def x93(self) -> bool:
		return self._instance.X93
	@x93.setter
	def x93(self, value: bool):
		self._instance.X93 = value
	@property
	def x94(self) -> bool:
		return self._instance.X94
	@x94.setter
	def x94(self, value: bool):
		self._instance.X94 = value
	@property
	def x95(self) -> bool:
		return self._instance.X95
	@x95.setter
	def x95(self, value: bool):
		self._instance.X95 = value
	@property
	def x96(self) -> bool:
		return self._instance.X96
	@x96.setter
	def x96(self, value: bool):
		self._instance.X96 = value
	@property
	def x97(self) -> bool:
		return self._instance.X97
	@x97.setter
	def x97(self, value: bool):
		self._instance.X97 = value
	@property
	def x98(self) -> bool:
		return self._instance.X98
	@x98.setter
	def x98(self, value: bool):
		self._instance.X98 = value
	@property
	def x99(self) -> bool:
		return self._instance.X99
	@x99.setter
	def x99(self, value: bool):
		self._instance.X99 = value
	@property
	def x100(self) -> bool:
		return self._instance.X100
	@x100.setter
	def x100(self, value: bool):
		self._instance.X100 = value
	@property
	def x101(self) -> bool:
		return self._instance.X101
	@x101.setter
	def x101(self, value: bool):
		self._instance.X101 = value
	@property
	def x102(self) -> bool:
		return self._instance.X102
	@x102.setter
	def x102(self, value: bool):
		self._instance.X102 = value
	@property
	def x103(self) -> bool:
		return self._instance.X103
	@x103.setter
	def x103(self, value: bool):
		self._instance.X103 = value
	@property
	def x104(self) -> bool:
		return self._instance.X104
	@x104.setter
	def x104(self, value: bool):
		self._instance.X104 = value
	@property
	def x105(self) -> bool:
		return self._instance.X105
	@x105.setter
	def x105(self, value: bool):
		self._instance.X105 = value
	@property
	def x106(self) -> bool:
		return self._instance.X106
	@x106.setter
	def x106(self, value: bool):
		self._instance.X106 = value
	@property
	def x107(self) -> bool:
		return self._instance.X107
	@x107.setter
	def x107(self, value: bool):
		self._instance.X107 = value
	@property
	def x108(self) -> bool:
		return self._instance.X108
	@x108.setter
	def x108(self, value: bool):
		self._instance.X108 = value
	@property
	def x109(self) -> bool:
		return self._instance.X109
	@x109.setter
	def x109(self, value: bool):
		self._instance.X109 = value
	@property
	def x110(self) -> bool:
		return self._instance.X110
	@x110.setter
	def x110(self, value: bool):
		self._instance.X110 = value
	@property
	def x111(self) -> bool:
		return self._instance.X111
	@x111.setter
	def x111(self, value: bool):
		self._instance.X111 = value
	@property
	def x112(self) -> bool:
		return self._instance.X112
	@x112.setter
	def x112(self, value: bool):
		self._instance.X112 = value
	@property
	def x113(self) -> bool:
		return self._instance.X113
	@x113.setter
	def x113(self, value: bool):
		self._instance.X113 = value
	@property
	def x114(self) -> bool:
		return self._instance.X114
	@x114.setter
	def x114(self, value: bool):
		self._instance.X114 = value
	@property
	def x115(self) -> bool:
		return self._instance.X115
	@x115.setter
	def x115(self, value: bool):
		self._instance.X115 = value
	@property
	def x116(self) -> bool:
		return self._instance.X116
	@x116.setter
	def x116(self, value: bool):
		self._instance.X116 = value
	@property
	def x117(self) -> bool:
		return self._instance.X117
	@x117.setter
	def x117(self, value: bool):
		self._instance.X117 = value
	@property
	def x118(self) -> bool:
		return self._instance.X118
	@x118.setter
	def x118(self, value: bool):
		self._instance.X118 = value
	@property
	def x119(self) -> bool:
		return self._instance.X119
	@x119.setter
	def x119(self, value: bool):
		self._instance.X119 = value
	@property
	def x120(self) -> bool:
		return self._instance.X120
	@x120.setter
	def x120(self, value: bool):
		self._instance.X120 = value
	@property
	def x121(self) -> bool:
		return self._instance.X121
	@x121.setter
	def x121(self, value: bool):
		self._instance.X121 = value
	@property
	def x122(self) -> bool:
		return self._instance.X122
	@x122.setter
	def x122(self, value: bool):
		self._instance.X122 = value
	@property
	def x123(self) -> bool:
		return self._instance.X123
	@x123.setter
	def x123(self, value: bool):
		self._instance.X123 = value
	@property
	def x124(self) -> bool:
		return self._instance.X124
	@x124.setter
	def x124(self, value: bool):
		self._instance.X124 = value
	@property
	def x125(self) -> bool:
		return self._instance.X125
	@x125.setter
	def x125(self, value: bool):
		self._instance.X125 = value
	@property
	def x126(self) -> bool:
		return self._instance.X126
	@x126.setter
	def x126(self, value: bool):
		self._instance.X126 = value
	@property
	def x127(self) -> bool:
		return self._instance.X127
	@x127.setter
	def x127(self, value: bool):
		self._instance.X127 = value
	@property
	def lower_range_index(self) -> int:
		return self._instance.LowerRangeIndex
