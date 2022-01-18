import typing
import clr
import os
clr.AddReference(os.path.realpath(os.path.join(os.path.dirname(__file__), "..", "..", "..", "..", "..", "..", "..", 'lib', 'UnderAutomation.UniversalRobots.dll')))
from UnderAutomation.UniversalRobots.Ssh.Tools.Security.Cryptography.Ciphers import CipherPadding as cipher_padding

class CipherPadding:
	def __init__(self, _internal = 0):
		if(_internal == 0):
			self._instance = cipher_padding()
		else:
			self._instance = _internal
	def pad(self, blockSize: int, input: int) -> int:
		return self._instance.Pad(blockSize, input)
	def pad(self, blockSize: int, input: int, offset: int, length: int) -> int:
		return self._instance.Pad(blockSize, input, offset, length)
	def pad(self, input: int, paddinglength: int) -> int:
		return self._instance.Pad(input, paddinglength)
	def pad(self, input: int, offset: int, length: int, paddinglength: int) -> int:
		return self._instance.Pad(input, offset, length, paddinglength)
