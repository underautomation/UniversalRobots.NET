import typing
from underautomation.universal_robots.ssh.tools.security.cryptography.symmetric_cipher import SymmetricCipher
import clr
import os
clr.AddReference(os.path.realpath(os.path.join(os.path.dirname(__file__), "..", "..", "..", "..", "..", "..", 'lib', 'UnderAutomation.UniversalRobots.dll')))
from UnderAutomation.UniversalRobots.Ssh.Tools.Security.Cryptography import BlockCipher as block_cipher

class BlockCipher(SymmetricCipher):
	def __init__(self, _internal = 0):
		if(_internal == 0):
			self._instance = block_cipher()
		else:
			self._instance = _internal
	def encrypt(self, data: int, offset: int, length: int) -> int:
		return self._instance.Encrypt(data, offset, length)
	def decrypt(self, data: int) -> int:
		return self._instance.Decrypt(data)
	def decrypt(self, data: int, offset: int, length: int) -> int:
		return self._instance.Decrypt(data, offset, length)
	@property
	def minimum_size(self) -> int:
		return self._instance.MinimumSize
	@property
	def block_size(self) -> int:
		return self._instance.BlockSize
