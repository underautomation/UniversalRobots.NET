import typing
import clr
import os
clr.AddReference(os.path.realpath(os.path.join(os.path.dirname(__file__), "..", "..", "..", "..", 'lib', 'UnderAutomation.UniversalRobots.dll')))
from UnderAutomation.UniversalRobots.Ssh.Tools import HashInfo as hash_info

class HashInfo:
	def __init__(self, keySize: int, hash: typing.Any, _internal = 0):
		if(_internal == 0):
			self._instance = hash_info(keySize, hash)
		else:
			self._instance = _internal
	@property
	def key_size(self) -> int:
		return self._instance.KeySize
	@property
	def hash_algorithm(self) -> typing.Any:
		return self._instance.HashAlgorithm
