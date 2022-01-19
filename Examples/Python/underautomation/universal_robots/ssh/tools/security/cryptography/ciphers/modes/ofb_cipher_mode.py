import typing
from underautomation.universal_robots.ssh.tools.security.cryptography.ciphers.cipher_mode import CipherMode
import clr
import os
clr.AddReference(os.path.realpath(os.path.join(os.path.dirname(__file__), "..", "..", "..", "..", "..", "..", "..", "..", 'lib', 'UnderAutomation.UniversalRobots.dll')))
from UnderAutomation.UniversalRobots.Ssh.Tools.Security.Cryptography.Ciphers.Modes import OfbCipherMode as ofb_cipher_mode

class OfbCipherMode(CipherMode):
	def __init__(self, iv: typing.List[int], _internal = 0):
		if(_internal == 0):
			self._instance = ofb_cipher_mode(iv)
		else:
			self._instance = _internal
	def encrypt_block(self, inputBuffer: typing.List[int], inputOffset: int, inputCount: int, outputBuffer: typing.List[int], outputOffset: int) -> int:
		return self._instance.EncryptBlock(inputBuffer, inputOffset, inputCount, outputBuffer, outputOffset)
	def decrypt_block(self, inputBuffer: typing.List[int], inputOffset: int, inputCount: int, outputBuffer: typing.List[int], outputOffset: int) -> int:
		return self._instance.DecryptBlock(inputBuffer, inputOffset, inputCount, outputBuffer, outputOffset)
