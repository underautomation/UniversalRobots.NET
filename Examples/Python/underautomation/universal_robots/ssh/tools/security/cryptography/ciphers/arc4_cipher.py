import typing
from underautomation.universal_robots.ssh.tools.security.cryptography.stream_cipher import StreamCipher
import clr
import os
clr.AddReference(os.path.realpath(os.path.join(os.path.dirname(__file__), "..", "..", "..", "..", "..", "..", "..", 'lib', 'UnderAutomation.UniversalRobots.dll')))
from UnderAutomation.UniversalRobots.Ssh.Tools.Security.Cryptography.Ciphers import Arc4Cipher as arc4_cipher

class Arc4Cipher(StreamCipher):
	def __init__(self, key: int, dischargeFirstBytes: bool, _internal = 0):
		if(_internal == 0):
			self._instance = arc4_cipher(key, dischargeFirstBytes)
		else:
			self._instance = _internal
	def encrypt_block(self, inputBuffer: int, inputOffset: int, inputCount: int, outputBuffer: int, outputOffset: int) -> int:
		return self._instance.EncryptBlock(inputBuffer, inputOffset, inputCount, outputBuffer, outputOffset)
	def decrypt_block(self, inputBuffer: int, inputOffset: int, inputCount: int, outputBuffer: int, outputOffset: int) -> int:
		return self._instance.DecryptBlock(inputBuffer, inputOffset, inputCount, outputBuffer, outputOffset)
	def encrypt(self, input: int, offset: int, length: int) -> int:
		return self._instance.Encrypt(input, offset, length)
	def decrypt(self, input: int) -> int:
		return self._instance.Decrypt(input)
	def decrypt(self, input: int, offset: int, length: int) -> int:
		return self._instance.Decrypt(input, offset, length)
	@property
	def minimum_size(self) -> int:
		return self._instance.MinimumSize
