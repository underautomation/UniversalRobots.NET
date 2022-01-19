import typing
import clr
import os
clr.AddReference(os.path.realpath(os.path.join(os.path.dirname(__file__), "..", "..", "..", "..", "..", 'lib', 'UnderAutomation.UniversalRobots.dll')))
from UnderAutomation.UniversalRobots.Utils.Security.Cryptography import HMAC as hmac

class HMAC:
	def __init__(self, _internal = 0):
		if(_internal == 0):
			self._instance = hmac()
		else:
			self._instance = _internal
	def initialize(self) -> None:
		self._instance.Initialize()
	@property
	def hash_size(self) -> int:
		return self._instance.HashSize
	@property
	def key(self) -> typing.List[int]:
		return self._instance.Key
	@key.setter
	def key(self, value: typing.List[int]):
		self._instance.Key = value
