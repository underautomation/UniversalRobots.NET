import typing
import clr
import os
clr.AddReference(os.path.realpath(os.path.join(os.path.dirname(__file__), "..", "..", "..", "..", "..", "..", 'lib', 'UnderAutomation.UniversalRobots.dll')))
from UnderAutomation.UniversalRobots.Ssh.Tools.Security.Cryptography import HMACSHA384 as hmacsha384

class HMACSHA384:
	def __init__(self, key: int, hashSize: int, _internal = 0):
		if(_internal == 0):
			self._instance = hmacsha384(key, hashSize)
		else:
			self._instance = _internal
	@property
	def hash_size(self) -> int:
		return self._instance.HashSize
