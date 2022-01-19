import typing
from underautomation.universal_robots.ssh.tools.messages.message import Message
import clr
import os
clr.AddReference(os.path.realpath(os.path.join(os.path.dirname(__file__), "..", "..", "..", "..", "..", "..", 'lib', 'UnderAutomation.UniversalRobots.dll')))
from UnderAutomation.UniversalRobots.Ssh.Tools.Messages.Transport import KeyExchangeInitMessage as key_exchange_init_message

class KeyExchangeInitMessage(Message):
	def __init__(self, _internal = 0):
		if(_internal == 0):
			self._instance = key_exchange_init_message()
		else:
			self._instance = _internal
	@property
	def cookie(self) -> typing.List[int]:
		return self._instance.Cookie
	@property
	def key_exchange_algorithms(self) -> typing.List[str]:
		return self._instance.KeyExchangeAlgorithms
	@key_exchange_algorithms.setter
	def key_exchange_algorithms(self, value: typing.List[str]):
		self._instance.KeyExchangeAlgorithms = value
	@property
	def server_host_key_algorithms(self) -> typing.List[str]:
		return self._instance.ServerHostKeyAlgorithms
	@server_host_key_algorithms.setter
	def server_host_key_algorithms(self, value: typing.List[str]):
		self._instance.ServerHostKeyAlgorithms = value
	@property
	def encryption_algorithms_client_to_server(self) -> typing.List[str]:
		return self._instance.EncryptionAlgorithmsClientToServer
	@encryption_algorithms_client_to_server.setter
	def encryption_algorithms_client_to_server(self, value: typing.List[str]):
		self._instance.EncryptionAlgorithmsClientToServer = value
	@property
	def encryption_algorithms_server_to_client(self) -> typing.List[str]:
		return self._instance.EncryptionAlgorithmsServerToClient
	@encryption_algorithms_server_to_client.setter
	def encryption_algorithms_server_to_client(self, value: typing.List[str]):
		self._instance.EncryptionAlgorithmsServerToClient = value
	@property
	def mac_algorithms_client_to_server(self) -> typing.List[str]:
		return self._instance.MacAlgorithmsClientToServer
	@mac_algorithms_client_to_server.setter
	def mac_algorithms_client_to_server(self, value: typing.List[str]):
		self._instance.MacAlgorithmsClientToServer = value
	@property
	def mac_algorithms_server_to_client(self) -> typing.List[str]:
		return self._instance.MacAlgorithmsServerToClient
	@mac_algorithms_server_to_client.setter
	def mac_algorithms_server_to_client(self, value: typing.List[str]):
		self._instance.MacAlgorithmsServerToClient = value
	@property
	def compression_algorithms_client_to_server(self) -> typing.List[str]:
		return self._instance.CompressionAlgorithmsClientToServer
	@compression_algorithms_client_to_server.setter
	def compression_algorithms_client_to_server(self, value: typing.List[str]):
		self._instance.CompressionAlgorithmsClientToServer = value
	@property
	def compression_algorithms_server_to_client(self) -> typing.List[str]:
		return self._instance.CompressionAlgorithmsServerToClient
	@compression_algorithms_server_to_client.setter
	def compression_algorithms_server_to_client(self, value: typing.List[str]):
		self._instance.CompressionAlgorithmsServerToClient = value
	@property
	def languages_client_to_server(self) -> typing.List[str]:
		return self._instance.LanguagesClientToServer
	@languages_client_to_server.setter
	def languages_client_to_server(self, value: typing.List[str]):
		self._instance.LanguagesClientToServer = value
	@property
	def languages_server_to_client(self) -> typing.List[str]:
		return self._instance.LanguagesServerToClient
	@languages_server_to_client.setter
	def languages_server_to_client(self, value: typing.List[str]):
		self._instance.LanguagesServerToClient = value
	@property
	def first_kex_packet_follows(self) -> bool:
		return self._instance.FirstKexPacketFollows
	@first_kex_packet_follows.setter
	def first_kex_packet_follows(self, value: bool):
		self._instance.FirstKexPacketFollows = value
	@property
	def reserved(self) -> int:
		return self._instance.Reserved
	@reserved.setter
	def reserved(self, value: int):
		self._instance.Reserved = value
