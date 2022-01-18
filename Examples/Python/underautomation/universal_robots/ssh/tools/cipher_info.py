import typing
import clr
import os
clr.AddReference(os.path.realpath(os.path.join(os.path.dirname(__file__), "..", "..", "..", "..", 'lib', 'UnderAutomation.UniversalRobots.dll')))
from UnderAutomation.UniversalRobots.Ssh.Tools import CipherInfo as cipher_info

class CipherInfo:
	def __init__(self, keySize: int, cipher: typing.Any, _internal = 0):
		if(_internal == 0):
			self._instance = cipher_info(keySize, cipher)
		else:
			self._instance = _internal
	@property
	def key_size(self) -> int:
		return self._instance.KeySize
	@property
	def cipher(self) -> typing.Any:
		return self._instance.Cipher
