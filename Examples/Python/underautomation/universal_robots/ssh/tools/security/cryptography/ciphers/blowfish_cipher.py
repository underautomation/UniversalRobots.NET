import typing
from underautomation.universal_robots.ssh.tools.security.cryptography.ciphers.cipher_mode import CipherMode
from underautomation.universal_robots.ssh.tools.security.cryptography.ciphers.cipher_padding import CipherPadding
from underautomation.universal_robots.ssh.tools.security.cryptography.block_cipher import BlockCipher
import clr
import os
clr.AddReference(os.path.realpath(os.path.join(os.path.dirname(__file__), "..", "..", "..", "..", "..", "..", "..", 'lib', 'UnderAutomation.UniversalRobots.dll')))
from UnderAutomation.UniversalRobots.Ssh.Tools.Security.Cryptography.Ciphers import BlowfishCipher as blowfish_cipher

class BlowfishCipher(BlockCipher):
	def __init__(self, key: typing.List[int], mode: CipherMode, padding: CipherPadding, _internal = 0):
		if(_internal == 0):
			self._instance = blowfish_cipher(key, mode, padding)
		else:
			self._instance = _internal
	def encrypt_block(self, inputBuffer: typing.List[int], inputOffset: int, inputCount: int, outputBuffer: typing.List[int], outputOffset: int) -> int:
		return self._instance.EncryptBlock(inputBuffer, inputOffset, inputCount, outputBuffer, outputOffset)
	def decrypt_block(self, inputBuffer: typing.List[int], inputOffset: int, inputCount: int, outputBuffer: typing.List[int], outputOffset: int) -> int:
		return self._instance.DecryptBlock(inputBuffer, inputOffset, inputCount, outputBuffer, outputOffset)
