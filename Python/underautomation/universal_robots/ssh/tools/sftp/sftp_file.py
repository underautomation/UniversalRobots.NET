import typing
from underautomation.universal_robots.ssh.tools.sftp.sftp_file_attributes import SftpFileAttributes
import clr
import os
clr.AddReference(os.path.realpath(os.path.join(os.path.dirname(__file__), "..", "..", "..",  'lib', 'UnderAutomation.UniversalRobots.dll')))
from UnderAutomation.UniversalRobots.Ssh.Tools.Sftp import SftpFile as sftp_file

class SftpFile:
	def __init__(self, _internal = 0):
		if(_internal == 0):
			self._instance = sftp_file()
		else:
			self._instance = _internal
	def set_permissions(self, mode: int) -> None:
		self._instance.SetPermissions(mode)
	def delete(self) -> None:
		self._instance.Delete()
	def move_to(self, destFileName: str) -> None:
		self._instance.MoveTo(destFileName)
	def update_status(self) -> None:
		self._instance.UpdateStatus()
	def __repr__(self):
		return self._instance.ToString()
	@property
	def attributes(self) -> SftpFileAttributes:
		return SftpFileAttributes(self._instance.Attributes)
	@property
	def full_name(self) -> str:
		return self._instance.FullName
	@property
	def name(self) -> str:
		return self._instance.Name
	@property
	def last_access_time(self) -> typing.Any:
		return self._instance.LastAccessTime
	@last_access_time.setter
	def last_access_time(self, value: typing.Any):
		self._instance.LastAccessTime = value
	@property
	def last_write_time(self) -> typing.Any:
		return self._instance.LastWriteTime
	@last_write_time.setter
	def last_write_time(self, value: typing.Any):
		self._instance.LastWriteTime = value
	@property
	def last_access_time_utc(self) -> typing.Any:
		return self._instance.LastAccessTimeUtc
	@last_access_time_utc.setter
	def last_access_time_utc(self, value: typing.Any):
		self._instance.LastAccessTimeUtc = value
	@property
	def last_write_time_utc(self) -> typing.Any:
		return self._instance.LastWriteTimeUtc
	@last_write_time_utc.setter
	def last_write_time_utc(self, value: typing.Any):
		self._instance.LastWriteTimeUtc = value
	@property
	def length(self) -> int:
		return self._instance.Length
	@property
	def user_id(self) -> int:
		return self._instance.UserId
	@user_id.setter
	def user_id(self, value: int):
		self._instance.UserId = value
	@property
	def group_id(self) -> int:
		return self._instance.GroupId
	@group_id.setter
	def group_id(self, value: int):
		self._instance.GroupId = value
	@property
	def is_socket(self) -> bool:
		return self._instance.IsSocket
	@property
	def is_symbolic_link(self) -> bool:
		return self._instance.IsSymbolicLink
	@property
	def is_regular_file(self) -> bool:
		return self._instance.IsRegularFile
	@property
	def is_block_device(self) -> bool:
		return self._instance.IsBlockDevice
	@property
	def is_directory(self) -> bool:
		return self._instance.IsDirectory
	@property
	def is_character_device(self) -> bool:
		return self._instance.IsCharacterDevice
	@property
	def is_named_pipe(self) -> bool:
		return self._instance.IsNamedPipe
	@property
	def owner_can_read(self) -> bool:
		return self._instance.OwnerCanRead
	@owner_can_read.setter
	def owner_can_read(self, value: bool):
		self._instance.OwnerCanRead = value
	@property
	def owner_can_write(self) -> bool:
		return self._instance.OwnerCanWrite
	@owner_can_write.setter
	def owner_can_write(self, value: bool):
		self._instance.OwnerCanWrite = value
	@property
	def owner_can_execute(self) -> bool:
		return self._instance.OwnerCanExecute
	@owner_can_execute.setter
	def owner_can_execute(self, value: bool):
		self._instance.OwnerCanExecute = value
	@property
	def group_can_read(self) -> bool:
		return self._instance.GroupCanRead
	@group_can_read.setter
	def group_can_read(self, value: bool):
		self._instance.GroupCanRead = value
	@property
	def group_can_write(self) -> bool:
		return self._instance.GroupCanWrite
	@group_can_write.setter
	def group_can_write(self, value: bool):
		self._instance.GroupCanWrite = value
	@property
	def group_can_execute(self) -> bool:
		return self._instance.GroupCanExecute
	@group_can_execute.setter
	def group_can_execute(self, value: bool):
		self._instance.GroupCanExecute = value
	@property
	def others_can_read(self) -> bool:
		return self._instance.OthersCanRead
	@others_can_read.setter
	def others_can_read(self, value: bool):
		self._instance.OthersCanRead = value
	@property
	def others_can_write(self) -> bool:
		return self._instance.OthersCanWrite
	@others_can_write.setter
	def others_can_write(self, value: bool):
		self._instance.OthersCanWrite = value
	@property
	def others_can_execute(self) -> bool:
		return self._instance.OthersCanExecute
	@others_can_execute.setter
	def others_can_execute(self, value: bool):
		self._instance.OthersCanExecute = value
