import typing
import clr
import os
clr.AddReference(os.path.realpath(os.path.join(os.path.dirname(__file__), "..", "..", "..",  'lib', 'UnderAutomation.UniversalRobots.dll')))
from UnderAutomation.UniversalRobots.Ssh.Tools.Sftp import SftpFileSytemInformation as sftp_file_sytem_information

class SftpFileSytemInformation:
	def __init__(self, _internal = 0):
		if(_internal == 0):
			self._instance = sftp_file_sytem_information()
		else:
			self._instance = _internal
	@property
	def file_system_block_size(self) -> int:
		return self._instance.FileSystemBlockSize
	@property
	def block_size(self) -> int:
		return self._instance.BlockSize
	@property
	def total_blocks(self) -> int:
		return self._instance.TotalBlocks
	@property
	def free_blocks(self) -> int:
		return self._instance.FreeBlocks
	@property
	def available_blocks(self) -> int:
		return self._instance.AvailableBlocks
	@property
	def total_nodes(self) -> int:
		return self._instance.TotalNodes
	@property
	def free_nodes(self) -> int:
		return self._instance.FreeNodes
	@property
	def available_nodes(self) -> int:
		return self._instance.AvailableNodes
	@property
	def sid(self) -> int:
		return self._instance.Sid
	@property
	def is_read_only(self) -> bool:
		return self._instance.IsReadOnly
	@property
	def supports_set_uid(self) -> bool:
		return self._instance.SupportsSetUid
	@property
	def max_name_lenght(self) -> int:
		return self._instance.MaxNameLenght
