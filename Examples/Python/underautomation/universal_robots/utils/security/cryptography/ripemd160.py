import typing
import clr
import os
clr.AddReference(os.path.realpath(os.path.join(os.path.dirname(__file__), "..", "..", "..", "..", "..", 'lib', 'UnderAutomation.UniversalRobots.dll')))
from UnderAutomation.UniversalRobots.Utils.Security.Cryptography import RIPEMD160 as ripemd160

class RIPEMD160:
	def __init__(self, _internal = 0):
		if(_internal == 0):
			self._instance = ripemd160()
		else:
			self._instance = _internal
	def initialize(self) -> None:
		self._instance.Initialize()
	@property
	def hash_size(self) -> int:
		return self._instance.HashSize
