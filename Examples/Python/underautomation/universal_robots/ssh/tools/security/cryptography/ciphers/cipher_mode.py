import typing
import clr
import os
clr.AddReference(os.path.realpath(os.path.join(os.path.dirname(__file__), "..", "..", "..", "..", "..", "..", "..", 'lib', 'UnderAutomation.UniversalRobots.dll')))
from UnderAutomation.UniversalRobots.Ssh.Tools.Security.Cryptography.Ciphers import CipherMode as cipher_mode

class CipherMode:
	def __init__(self, _internal = 0):
		if(_internal == 0):
			self._instance = cipher_mode()
		else:
			self._instance = _internal
	def encrypt_block(self, inputBuffer: typing.List[int], inputOffset: int, inputCount: int, outputBuffer: typing.List[int], outputOffset: int) -> int:
		return self._instance.EncryptBlock(inputBuffer, inputOffset, inputCount, outputBuffer, outputOffset)
	def decrypt_block(self, inputBuffer: typing.List[int], inputOffset: int, inputCount: int, outputBuffer: typing.List[int], outputOffset: int) -> int:
		return self._instance.DecryptBlock(inputBuffer, inputOffset, inputCount, outputBuffer, outputOffset)
