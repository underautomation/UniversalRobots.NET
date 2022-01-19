import typing
from underautomation.universal_robots.ssh.tools.session import Session
from underautomation.universal_robots.ssh.tools.messages.transport.key_exchange_init_message import KeyExchangeInitMessage
from underautomation.universal_robots.ssh.tools.security.cryptography.cipher import Cipher
from underautomation.universal_robots.ssh.tools.compression.compressor import Compressor
from underautomation.universal_robots.ssh.tools.common.host_key_event_args import HostKeyEventArgs
from underautomation.universal_robots.ssh.tools.security.algorithm import Algorithm
import clr
import os
clr.AddReference(os.path.realpath(os.path.join(os.path.dirname(__file__), "..", "..", "..", "..", "..", 'lib', 'UnderAutomation.UniversalRobots.dll')))
from UnderAutomation.UniversalRobots.Ssh.Tools.Security import KeyExchange as key_exchange

class KeyExchange(Algorithm):
	def __init__(self, _internal = 0):
		if(_internal == 0):
			self._instance = key_exchange()
		else:
			self._instance = _internal
	def host_key_received(self, handler):
		self._instance.HostKeyReceived+= lambda sender, e : handler(sender, HostKeyEventArgs(None, e))
	def add__host_key_received(self, value: typing.Any) -> None:
		self._instance.add_HostKeyReceived(value)
	def remove__host_key_received(self, value: typing.Any) -> None:
		self._instance.remove_HostKeyReceived(value)
	def start(self, session: Session, message: KeyExchangeInitMessage) -> None:
		self._instance.Start(session._instance, message._instance)
	def finish(self) -> None:
		self._instance.Finish()
	def create_server_cipher(self) -> Cipher:
		return Cipher(self._instance.CreateServerCipher())
	def create_client_cipher(self) -> Cipher:
		return Cipher(self._instance.CreateClientCipher())
	def create_server_hash(self) -> typing.Any:
		return self._instance.CreateServerHash()
	def create_client_hash(self) -> typing.Any:
		return self._instance.CreateClientHash()
	def create_compressor(self) -> Compressor:
		return Compressor(self._instance.CreateCompressor())
	def create_decompressor(self) -> Compressor:
		return Compressor(self._instance.CreateDecompressor())
	def dispose(self) -> None:
		self._instance.Dispose()
	@property
	def shared_key(self) -> typing.List[int]:
		return self._instance.SharedKey
	@property
	def exchange_hash(self) -> typing.List[int]:
		return self._instance.ExchangeHash
