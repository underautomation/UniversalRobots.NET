import typing
import clr
import os
clr.AddReference(os.path.realpath(os.path.join(os.path.dirname(__file__), "..", "..", "..", "..", "..", "..", 'lib', 'UnderAutomation.UniversalRobots.dll')))
from UnderAutomation.UniversalRobots.Ssh.Tools.Security.Cryptography import Cipher as cipher

class Cipher:
	def __init__(self, _internal = 0):
		if(_internal == 0):
			self._instance = cipher()
		else:
			self._instance = _internal
	def encrypt(self, input: int) -> int:
		return self._instance.Encrypt(input)
	def encrypt(self, input: int, offset: int, length: int) -> int:
		return self._instance.Encrypt(input, offset, length)
	def decrypt(self, input: int) -> int:
		return self._instance.Decrypt(input)
	def decrypt(self, input: int, offset: int, length: int) -> int:
		return self._instance.Decrypt(input, offset, length)
	@property
	def minimum_size(self) -> int:
		return self._instance.MinimumSize
