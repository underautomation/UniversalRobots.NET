import typing
import clr
import os
clr.AddReference(os.path.realpath(os.path.join(os.path.dirname(__file__), "..", "..", "..", "..", "..", "..", 'lib', 'UnderAutomation.UniversalRobots.dll')))
from UnderAutomation.UniversalRobots.Ssh.Tools.Security.Cryptography import HMACMD5 as hmacmd5

class HMACMD5:
	def __init__(self, key: typing.List[int], hashSize: int, _internal = 0):
		if(_internal == 0):
			self._instance = hmacmd5(key, hashSize)
		else:
			self._instance = _internal
	@property
	def hash_size(self) -> int:
		return self._instance.HashSize
